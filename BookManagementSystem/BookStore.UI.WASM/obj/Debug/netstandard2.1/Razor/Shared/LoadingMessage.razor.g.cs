#pragma checksum "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Shared\LoadingMessage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "697d9ffb6ee75d7d1bc5450b32315407c4baba69"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.UI.WASM.Shared
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
    public partial class LoadingMessage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-dismissible alert-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "h5");
            __builder.AddContent(4, 
#nullable restore
#line 3 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Shared\LoadingMessage.razor"
         Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Shared\LoadingMessage.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Message { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
