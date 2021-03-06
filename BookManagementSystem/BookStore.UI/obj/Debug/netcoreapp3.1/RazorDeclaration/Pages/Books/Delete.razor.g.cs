#pragma checksum "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\Pages\Books\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21cb2641584b4cbacbb08860f1a90a2ce69f7b61"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookStore.UI.Pages.Books
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
#nullable restore
#line 13 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using BlazorFileUploader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\Pages\Books\Delete.razor"
           [Authorize(Roles = "Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books/delete/{Id}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI\Pages\Books\Delete.razor"
       
    [Parameter]
    public string Id { get; set; }
    private Book Model = new Book();
    private bool isSuccess = true;

    protected override async Task OnInitializedAsync()
    {
        int id = Convert.ToInt32(Id);
        Model = await _bookRepo.Get(EndPoints.BooksEndPoint, id);
    }

    private async Task DeleteBook()
    {
        _fileUpload.RemoveFile(Model.Image);
        isSuccess = await _bookRepo.Delete(EndPoints.BooksEndPoint, Model.Id);
        if (isSuccess)
        {
            _toastService.ShowError("Book Deleted Successfully", "");
            BackToList();
        }
    }

    private void BackToList()
    {
        _navManager.NavigateTo("/books/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload _fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookRepository _bookRepo { get; set; }
    }
}
#pragma warning restore 1591
