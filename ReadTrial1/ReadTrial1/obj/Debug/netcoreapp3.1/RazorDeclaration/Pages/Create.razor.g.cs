#pragma checksum "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b2b73e249fb9e0ce45ff6ac94e5bcdac74f16f0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\Create.razor"
using ReadTrial1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\Create.razor"
using ReadTrial1.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/creat")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\arshb\Desktop\Reference material\ReadTrial1\ReadTrial1\Pages\Create.razor"
       
    public AdminCreate product = new AdminCreate();
    public async void HandleValidSubmit()
    {
        try
        {
            await ApparelService.PostAsJsonAsync("https://localhost:3001/api/CudProduct", product);
        }
        catch
        {

            base.StateHasChanged();
        }
        product = new AdminCreate();
        base.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenderApparelService ApparelService { get; set; }
    }
}
#pragma warning restore 1591