#pragma checksum "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Users\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a7d28793a20ed30b96a39f434d4586a4c853f0a"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.UI.WASM.Pages.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using BookStore.UI.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using BookStore.UI.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using BookStore.UI.WASM.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using BookStore.UI.WASM.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using BookStore.UI.WASM.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Login</h3>\r\n<hr>\r\n<br>\r\n");
#nullable restore
#line 10 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Users\Login.razor"
 if (!response)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BookStore.UI.WASM.Shared.ErrorMessage>(2);
            __builder.AddAttribute(3, "Message", "Something went wrong with the login attempt");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 13 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Users\Login.razor"

}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Users\Login.razor"
                     Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Users\Login.razor"
                                           HandleLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.AddMarkupContent(20, "<label for=\"email\">Email Address</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "Id", "email");
                __builder2.AddAttribute(23, "type", "email");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Users\Login.razor"
                                                                                 Model.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.EmailAddress = __value, Model.EmailAddress))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __Blazor.BookStore.UI.WASM.Pages.Users.Login.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 23 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Users\Login.razor"
                                      () => Model.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.AddMarkupContent(36, "<label for=\"password\">Password</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "Id", "password");
                __builder2.AddAttribute(39, "type", "password");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Users\Login.razor"
                                                                                       Model.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Password = __value, Model.Password))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __Blazor.BookStore.UI.WASM.Pages.Users.Login.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 28 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Users\Login.razor"
                                      () => Model.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.AddMarkupContent(49, "<button class=\"btn btn-primary btn-block\" type=\"submit\">Login</button>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Users\Login.razor"
       
    private LoginModel Model = new LoginModel();
    private bool response = true;

    private async Task HandleLogin()
    {
        response = await _authRepo.Login(Model);

        if (response)
        {
            _navManager.NavigateTo("/");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationRepository _authRepo { get; set; }
    }
}
namespace __Blazor.BookStore.UI.WASM.Pages.Users.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
