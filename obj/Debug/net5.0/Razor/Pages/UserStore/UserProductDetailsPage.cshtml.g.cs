#pragma checksum "C:\Coding Directory\SimplyHorsePower\Pages\UserStore\UserProductDetailsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deb2b29189548976dcd4440748c52afd89c87486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SimplyHorsePower.Pages.UserStore.Pages_UserStore_UserProductDetailsPage), @"mvc.1.0.razor-page", @"/Pages/UserStore/UserProductDetailsPage.cshtml")]
namespace SimplyHorsePower.Pages.UserStore
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
#line 1 "C:\Coding Directory\SimplyHorsePower\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Coding Directory\SimplyHorsePower\Pages\_ViewImports.cshtml"
using SimplyHorsePower;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Coding Directory\SimplyHorsePower\Pages\_ViewImports.cshtml"
using SimplyHorsePower.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deb2b29189548976dcd4440748c52afd89c87486", @"/Pages/UserStore/UserProductDetailsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e771dab9a721d5e3d4b8c17c363e61668010ff60", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserStore_UserProductDetailsPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/UserShoppingCart/UserShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n\r\n    <div>\r\n        <h2 class=\"text-info\">Product details</h2>\r\n    </div>\r\n\r\n    <div>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 228, "\"", 286, 2);
            WriteAttributeValue("", 234, "data:image/gif;base64,", 234, 22, true);
#nullable restore
#line 14 "C:\Coding Directory\SimplyHorsePower\Pages\UserStore\UserProductDetailsPage.cshtml"
WriteAttributeValue("", 256, Model.product.MainBase64Image, 256, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"Card image cap\">\r\n    </div>\r\n\r\n    <div>\r\n        <div class=\"carousel slide\" data-ride=\"carousel\" data-interval=\"2000\" style=\"width:auto;\">\r\n            <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 20 "C:\Coding Directory\SimplyHorsePower\Pages\UserStore\UserProductDetailsPage.cshtml"
                 foreach (var photo in Model.ProductGalleryImages)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 607, "\"", 691, 2);
            WriteAttributeValue("", 615, "carousel-item", 615, 13, true);
#nullable restore
#line 22 "C:\Coding Directory\SimplyHorsePower\Pages\UserStore\UserProductDetailsPage.cshtml"
WriteAttributeValue(" ", 628, photo == Model.ProductGalleryImages.First() ? "active" : "", 629, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 723, "\"", 783, 2);
            WriteAttributeValue("", 729, "data:image/gif;base64,", 729, 22, true);
#nullable restore
#line 23 "C:\Coding Directory\SimplyHorsePower\Pages\UserStore\UserProductDetailsPage.cshtml"
WriteAttributeValue("", 751, photo.ProductGalleryBase64Image, 751, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    </div>\r\n");
#nullable restore
#line 26 "C:\Coding Directory\SimplyHorsePower\Pages\UserStore\UserProductDetailsPage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
            WriteLiteral("    </div>\r\n    <h3><a class=\"mt-2 text-danger\">");
#nullable restore
#line 36 "C:\Coding Directory\SimplyHorsePower\Pages\UserStore\UserProductDetailsPage.cshtml"
                               Write(Model.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n    <p>");
#nullable restore
#line 37 "C:\Coding Directory\SimplyHorsePower\Pages\UserStore\UserProductDetailsPage.cshtml"
  Write(Model.product.MakeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p class=\"text-secondary\">");
#nullable restore
#line 38 "C:\Coding Directory\SimplyHorsePower\Pages\UserStore\UserProductDetailsPage.cshtml"
                         Write(Model.product.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb2b29189548976dcd4440748c52afd89c874867578", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1458, "\"", 1490, 1);
#nullable restore
#line 40 "C:\Coding Directory\SimplyHorsePower\Pages\UserStore\UserProductDetailsPage.cshtml"
WriteAttributeValue("", 1466, Model.product.ProductId, 1466, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"submit\" value=\"Add to cart\" class=\"btn btn-info\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplyHorsePower.Pages.UserStore.UserProductDetailsPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SimplyHorsePower.Pages.UserStore.UserProductDetailsPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SimplyHorsePower.Pages.UserStore.UserProductDetailsPageModel>)PageContext?.ViewData;
        public SimplyHorsePower.Pages.UserStore.UserProductDetailsPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
