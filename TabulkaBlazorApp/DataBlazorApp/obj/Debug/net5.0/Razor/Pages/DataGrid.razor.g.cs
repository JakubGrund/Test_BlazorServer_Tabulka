#pragma checksum "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "320a7a666192a0cac9cbe8092f7b2d774036ab04"
// <auto-generated/>
#pragma warning disable 1591
namespace DataBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/_Imports.razor"
using DataBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/_Imports.razor"
using DataBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor"
using DataBlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid")]
    public partial class DataGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DataGrid</h3>");
#nullable restore
#line 7 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor"
 if(product == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p> Loading ...</p>");
#nullable restore
#line 10 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<Product>>(2);
            __builder.AddAttribute(3, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor"
                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor"
                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 13 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor"
                                                                            FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor"
                      4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor"
                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Product>>(
#nullable restore
#line 14 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor"
                                                    product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ColumnWidth", "150px");
            __builder.AddAttribute(10, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Product>>(11);
                __builder2.AddAttribute(12, "Property", "ProdID");
                __builder2.AddAttribute(13, "Title", "Product ID");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Product>>(15);
                __builder2.AddAttribute(16, "Property", "ProdName");
                __builder2.AddAttribute(17, "Title", "Product Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Product>>(19);
                __builder2.AddAttribute(20, "Property", "SellingPrice");
                __builder2.AddAttribute(21, "Title", "Selling Price");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Product>>(23);
                __builder2.AddAttribute(24, "Property", "PurchaseDate");
                __builder2.AddAttribute(25, "Title", "Purchase Date");
                __builder2.AddAttribute(26, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Product>)((data) => (__builder3) => {
                    __builder3.AddContent(27, 
#nullable restore
#line 21 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor"
                 String.Format("{0:s}", data.PurchaseDate)

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Product>>(29);
                __builder2.AddAttribute(30, "Property", "Price");
                __builder2.AddAttribute(31, "Title", "Price");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 27 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/Users/jakubgrund/Desktop/DataBlazorApp/DataBlazorApp/Pages/DataGrid.razor"
       
    IEnumerable<Product> product;

    protected override async Task OnInitializedAsync()
    {
        product = await Task.Run(() => productServis.ProductList());
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductServis productServis { get; set; }
    }
}
#pragma warning restore 1591