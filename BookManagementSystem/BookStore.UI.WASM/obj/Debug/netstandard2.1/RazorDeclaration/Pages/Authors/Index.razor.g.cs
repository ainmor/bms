#pragma checksum "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5c1b5143a5e44df64bd470c8ba1b062ffe4047a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookStore.UI.WASM.Pages.Authors
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Index.razor"
       
    private IList<Author> Model;

    protected async override Task OnInitializedAsync()
    {
        Model = await _repo.Get(EndPoints.AuthorsEndPoint);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorRepository _repo { get; set; }
    }
}
#pragma warning restore 1591
