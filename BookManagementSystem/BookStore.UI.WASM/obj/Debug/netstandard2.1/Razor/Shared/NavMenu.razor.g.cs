#pragma checksum "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43fdf946822cbef3c35982b8b6a1fef7a2485753"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>BookStore-UI</a>\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\n        <span class=\"navbar-toggler-icon\"></span>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(17);
            __builder.AddAttribute(18, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "\n                ");
                __builder2.OpenElement(20, "li");
                __builder2.AddAttribute(21, "class", "nav-item px-3");
                __builder2.AddMarkupContent(22, "\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
                __builder2.AddAttribute(24, "class", "nav-link");
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "\n                        <span class=\"oi oi-person\" aria-hidden=\"true\"></span> ");
                    __builder3.AddContent(27, 
#nullable restore
#line 14 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Shared\NavMenu.razor"
                                                                               context.User.Identity.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(28, "\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n                ");
                __builder2.OpenElement(31, "li");
                __builder2.AddAttribute(32, "class", "nav-item px-3");
                __builder2.AddMarkupContent(33, "\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
                __builder2.AddAttribute(35, "class", "nav-link");
                __builder2.AddAttribute(36, "href", "logout");
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "\n                        <span class=\"oi oi-arrow-circle-left\" aria-hidden=\"true\"></span> Log Out\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n            ");
            }
            ));
            __builder.AddAttribute(41, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(42, "\n                ");
                __builder2.OpenElement(43, "li");
                __builder2.AddAttribute(44, "class", "nav-item px-3");
                __builder2.AddMarkupContent(45, "\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(46);
                __builder2.AddAttribute(47, "class", "nav-link");
                __builder2.AddAttribute(48, "href", "login");
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(50, "\n                        <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Login\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n                ");
                __builder2.OpenElement(53, "li");
                __builder2.AddAttribute(54, "class", "nav-item px-3");
                __builder2.AddMarkupContent(55, "\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(56);
                __builder2.AddAttribute(57, "class", "nav-link");
                __builder2.AddAttribute(58, "href", "register");
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(60, "\n                        <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Register\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\n        ");
            __builder.OpenElement(64, "li");
            __builder.AddAttribute(65, "class", "nav-item px-3");
            __builder.AddMarkupContent(66, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(67);
            __builder.AddAttribute(68, "class", "nav-link");
            __builder.AddAttribute(69, "href", "");
            __builder.AddAttribute(70, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 37 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(72, "\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n        ");
            __builder.OpenElement(75, "li");
            __builder.AddAttribute(76, "class", "nav-item px-3");
            __builder.AddMarkupContent(77, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(78);
            __builder.AddAttribute(79, "class", "nav-link");
            __builder.AddAttribute(80, "href", "authors/");
            __builder.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(82, "\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Authors\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\n        ");
            __builder.OpenElement(85, "li");
            __builder.AddAttribute(86, "class", "nav-item px-3");
            __builder.AddMarkupContent(87, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(88);
            __builder.AddAttribute(89, "class", "nav-link");
            __builder.AddAttribute(90, "href", "books/");
            __builder.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(92, "\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Books\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(95);
            __builder.AddAttribute(96, "Roles", "Administrator");
            __builder.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(98, "\n            ");
                __builder2.OpenElement(99, "li");
                __builder2.AddAttribute(100, "class", "nav-item px-3");
                __builder2.AddMarkupContent(101, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(102);
                __builder2.AddAttribute(103, "class", "nav-link");
                __builder2.AddAttribute(104, "href", "books");
                __builder2.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(106, "\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> ADMIN LINK\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(109, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(110);
            __builder.AddAttribute(111, "Roles", "Customer");
            __builder.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(113, "\n            ");
                __builder2.OpenElement(114, "li");
                __builder2.AddAttribute(115, "class", "nav-item px-3");
                __builder2.AddMarkupContent(116, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(117);
                __builder2.AddAttribute(118, "class", "nav-link");
                __builder2.AddAttribute(119, "href", "books");
                __builder2.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(121, "\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> CUSTOMER LINK\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(122, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(124, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Shared\NavMenu.razor"
        private bool collapseNavMenu = true;

            private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

            private void ToggleNavMenu()
            {
                collapseNavMenu = !collapseNavMenu;
            } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
