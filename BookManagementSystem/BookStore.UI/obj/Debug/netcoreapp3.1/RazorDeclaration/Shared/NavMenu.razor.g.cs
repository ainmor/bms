#pragma checksum "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34ac21568c74e1b5c6c92bfdd0575f1776bf0559"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookStore.UI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using BookStore.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using BookStore.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using BookStore.UI.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using BookStore.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using BookStore.UI.Contracts;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\Shared\NavMenu.razor"
       
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
