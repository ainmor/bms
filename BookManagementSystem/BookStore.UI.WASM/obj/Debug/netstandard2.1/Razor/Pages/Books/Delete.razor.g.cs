#pragma checksum "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21cb2641584b4cbacbb08860f1a90a2ce69f7b61"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.UI.WASM.Pages.Books
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
#nullable restore
#line 3 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
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
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Are You Sure You Want to Delete This Record?</h3>\r\n<hr>\r\n<br>\r\n");
#nullable restore
#line 13 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
 if (!isSuccess)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BookStore.UI.WASM.Shared.ErrorMessage>(2);
            __builder.AddAttribute(3, "Message", "Something went wrong with the Operation");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 16 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 18 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
 if (int.Parse(Id) < 1 || string.IsNullOrWhiteSpace(Id))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenComponent<BookStore.UI.WASM.Shared.ErrorMessage>(7);
            __builder.AddAttribute(8, "Message", "Invalid Selection. Please Try Again");
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 21 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
}
else if (Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "    ");
            __builder.OpenComponent<BookStore.UI.WASM.Shared.LoadingMessage>(11);
            __builder.AddAttribute(12, "Message", "Loading Book Details");
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 25 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-6");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table table-responsive");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.AddMarkupContent(26, "<td>\r\n                        <strong>Title</strong>\r\n                    </td>\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 35 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                         Model.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.AddMarkupContent(33, "<td>\r\n                        <strong>Author</strong>\r\n                    </td>\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 42 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                         if (Model.Author == null)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                            ");
            __builder.AddMarkupContent(37, "<span class=\"text-muted\">No Author Recorded</span>\r\n");
#nullable restore
#line 45 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                            ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "href", "/authors/view/" + (
#nullable restore
#line 48 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                                                    Model.AuthorId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, 
#nullable restore
#line 48 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                                                                     Model.Author.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(42, " ");
            __builder.AddContent(43, 
#nullable restore
#line 48 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                                                                                             Model.Author.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 49 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "tr");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.AddMarkupContent(50, "<td>\r\n                        <strong>Summary</strong>\r\n                    </td>\r\n                    ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 56 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                         Model.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "tr");
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.AddMarkupContent(57, "<td>\r\n                        <strong>Published Year</strong>\r\n                    </td>\r\n                    ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 62 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                         Model.Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "tr");
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.AddMarkupContent(64, "<td>\r\n                        <strong>ISBN</strong>\r\n                    </td>\r\n                    ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 68 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                         Model.Isbn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "col-4");
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "img");
            __builder.AddAttribute(75, "src", "/uploads/" + (
#nullable restore
#line 73 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                                Model.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "style", "height:300px; width:300px");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenElement(78, "h3");
            __builder.AddAttribute(79, "class", "text-center text-info");
            __builder.AddContent(80, 
#nullable restore
#line 74 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                                               string.Format("{0:C}", Model.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 77 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(84, "\r\n\r\n");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                  DeleteBook

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "class", "btn btn-danger");
            __builder.AddMarkupContent(88, "\r\n    <span class=\"oi oi-delete\"></span>\r\n    Delete Book\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
                  BackToList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "class", "btn btn-outline-secondary");
            __builder.AddMarkupContent(93, "\r\n    <span class=\"oi oi-media-skip-backward\"></span>\r\n    Back To List\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Books\Delete.razor"
       
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
