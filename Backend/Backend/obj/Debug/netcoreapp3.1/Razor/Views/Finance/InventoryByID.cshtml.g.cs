#pragma checksum "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/InventoryByID.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "497066f2c70b03f971fea425d43af7899434a7b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finance_InventoryByID), @"mvc.1.0.view", @"/Views/Finance/InventoryByID.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/_ViewImports.cshtml"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/_ViewImports.cshtml"
using Backend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"497066f2c70b03f971fea425d43af7899434a7b4", @"/Views/Finance/InventoryByID.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58f01d0c9c2dd0c1adc189b4df9db144da67c998", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Finance_InventoryByID : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/InventoryByID.cshtml"
  
    ViewData["Title"] = "Home Page";



#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497066f2c70b03f971fea425d43af7899434a7b44003", async() => {
                WriteLiteral("\n    <h2>Inventory search by id</h2>\n    <div>\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497066f2c70b03f971fea425d43af7899434a7b44313", async() => {
                    WriteLiteral("\n\n            <div>\n\n                <label for=\"CompanyName\">Input inventory transection number</label>\n                <input class=\"form-control me-sm-2\" type=\"text\" name=\"id\"");
                    BeginWriteAttribute("value", " value=\"", 306, "\"", 314, 0);
                    EndWriteAttribute();
                    WriteLiteral(" />\n                <button class=\"btn btn-secondary my-2 my-sm-0\" type=\"submit\">Search</button>\n            </div>\n\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>
    <div>

        <h2>Inventory</h2>
        <table class=""table"">
            <tr>
                <th>No</th>
                <th>debit/Cradit</th>
                <th>type</th>
                <th>volume</th>
                <th>date</th>


            </tr>
");
#nullable restore
#line 35 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/InventoryByID.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 38 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/InventoryByID.cshtml"
                   Write(item.inventory_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 39 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/InventoryByID.cshtml"
                   Write(item.side);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 40 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/InventoryByID.cshtml"
                   Write(item.type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 41 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/InventoryByID.cshtml"
                   Write(item.volume);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 42 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/InventoryByID.cshtml"
                   Write(item.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 43 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/InventoryByID.cshtml"
                   Write(item.date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n\n                </tr>\n");
#nullable restore
#line 46 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/InventoryByID.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
