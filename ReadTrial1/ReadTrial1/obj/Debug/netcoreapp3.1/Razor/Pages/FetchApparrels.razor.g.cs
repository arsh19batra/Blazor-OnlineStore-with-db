#pragma checksum "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbbc847f9ff84f0b1d5e0d41b0d0753359e3f971"
// <auto-generated/>
#pragma warning disable 1591
namespace ReadTrial1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\_Imports.razor"
using ReadTrial1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\_Imports.razor"
using ReadTrial1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
using ReadTrial1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchApparel/{id:int}")]
    public partial class FetchApparrels : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Men\'s Section</h3>\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>Product List</h1>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
 if (apparels == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 14 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Product Id</th>\r\n                <th>Product Name</th>\r\n                <th>Gender Id</th>\r\n                <th>List Price</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 27 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
             foreach (var apparel in apparels)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 30 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
                         apparel.product_id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 31 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
                         apparel.product_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 32 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
                         apparel.gender_id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 33 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
                         apparel.list_price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    \r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
                                            () => AddToCart(@apparel.product_id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Add To Cart");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 37 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 40 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
       

    private List<Product> apparels;

    [Parameter] public int id { get; set; }
    [Parameter] public int productId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        apparels = await ApparelService.GetProductByGenderId(id);
    }



#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
            
    public async Task Delete(int id)
    {
        await ApparelService.DeleteById(id);
    }
    public async Task AddToCart(int productId)
    {
        var product = await ApparelService.GetProductAsync("https://localhost:5001/api/ReadValues/product/" + productId);
        var checkStocks = await ApparelService.GetStockByIdAsync("https://localhost:5001/api/ReadValues/stock/" + productId);
        ProductUpdate prod = new ProductUpdate()
        {
            ProductId = product.product_id,
            ListPrice = product.list_price
        };
        if (checkStocks!=null)
        {
            if (checkStocks.Quantity != 0)
            {
                var qwe = await ApparelService.PostOrderByProductId("https://localhost:3001/api/CudApi/1", prod);
            }
            else
            {
                Console.WriteLine("Out of Stock");
            }
        }
        else
        {
            Console.WriteLine("Out of Stock");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenderApparelService ApparelService { get; set; }
    }
}
#pragma warning restore 1591
