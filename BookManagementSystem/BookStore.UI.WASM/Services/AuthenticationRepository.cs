using Blazored.LocalStorage;
using BookStore.UI.WASM.Contracts;
using BookStore.UI.WASM.Models;
using BookStore.UI.WASM.Providers;
using BookStore.UI.WASM.Static;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.UI.WASM.Services
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly HttpClient _client;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        public AuthenticationRepository(HttpClient client, 
                                        ILocalStorageService localStorage,
                                        AuthenticationStateProvider authenticationStateProvider)
        {
            _client = client;
            _localStorage = localStorage;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<bool> Login(LoginModel user)
        {
            var response = await _client.PostAsJsonAsync(EndPoints.LoginEndPoint, user);

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            var content = await response.Content.ReadAsStringAsync();
            var token = JsonConvert.DeserializeObject<TokenReponse>(content);
                        
            //Store token
            await _localStorage.SetItemAsync("authToken", token.Token);

            //Change tauth state of app
            await ((ApiAuthenticationStateProvider)_authenticationStateProvider)
                .LoggedIn();
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("bearer", token.Token);

            return true;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider)
                .LoggedOut();
        }

        public async Task<bool> Register(RegistrationModel user)
        {
            var response = await _client.PostAsJsonAsync(EndPoints.RegisterEndPoint, user);          

            return response.IsSuccessStatusCode;
        }
    }
}
