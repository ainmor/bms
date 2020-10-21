#pragma checksum "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5585c33ef767b95f11aa2d084736ca8258f2728b"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 2 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
           [Authorize(Roles = "Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/delete/{Id}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Are You Sure You Want to Delete This Record?</h3>\r\n<hr>\r\n<br>\r\n");
#nullable restore
#line 9 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
 if (isFailed)
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
#line 12 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 14 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenComponent<BookStore.UI.WASM.Shared.LoadingMessage>(7);
            __builder.AddAttribute(8, "Message", "Loading Authors Details...");
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 17 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-4");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, "<h4>View Author Details</h4>\r\n        ");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-responsive");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.AddMarkupContent(20, "<td>First Name</td>\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 25 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
                     Model.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.AddMarkupContent(27, "<td>Last Name</td>\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 29 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
                     Model.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.AddMarkupContent(34, "<td>Biography</td>\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 33 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
                     Model.Bio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        <br>\r\n\r\n");
#nullable restore
#line 38 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
         if (Model.Books == null || Model.Books.Count < 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "            ");
            __builder.AddMarkupContent(41, "<div class=\"alert alert-dismissible alert-dark\">\r\n                No Books for this Author!\r\n            </div>\r\n");
#nullable restore
#line 43 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "card");
            __builder.AddAttribute(45, "style", "width: 18rem;");
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.AddMarkupContent(47, "<h4>Author\'s Books</h4>\r\n                ");
            __builder.OpenElement(48, "ul");
            __builder.AddAttribute(49, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 49 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
                     foreach (var book in Model.Books)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                        ");
            __builder.OpenElement(52, "li");
            __builder.AddAttribute(53, "class", "list-group-item");
            __builder.AddContent(54, 
#nullable restore
#line 51 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
                                                     book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(55, " - ");
            __builder.AddContent(56, 
#nullable restore
#line 51 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
                                                                   book.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 52 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 55 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 57 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "<br>\r\n\r\n");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
                  DeleteAuthor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "class", "btn btn-danger");
            __builder.AddMarkupContent(68, "\r\n    <span class=\"oi oi-delete\"></span>\r\n    Delete Author\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
                  BackToList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "class", "btn btn-outline-secondary");
            __builder.AddMarkupContent(73, "\r\n    <span class=\"oi oi-media-skip-backward\"></span>\r\n    Back To List\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "D:\programming\aspnet\bmsaspnetblazor\BookManagementSystem\BookStore.UI.WASM\Pages\Authors\Delete.razor"
       
    [Parameter]
    public string Id { get; set; }

    private Author Model = new Author();
    private bool isFailed = false;

    protected override async Task OnInitializedAsync()
    {
        int id = Convert.ToInt32(Id);
        Model = await _repo.Get(EndPoints.AuthorsEndPoint, id);
    }

    private async Task DeleteAuthor()
    {
        bool isSuccess = await _repo.Delete(EndPoints.AuthorsEndPoint, Model.Id);
        if (isSuccess)
        {
            _toastService.ShowError("Author Deleted Successfully");
            BackToList();
        }
        else
        {
            isFailed = true;
        }
    }

    private void BackToList()
    {
        _navManager.NavigateTo("/Authors/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorRepository _repo { get; set; }
    }
}
#pragma warning restore 1591