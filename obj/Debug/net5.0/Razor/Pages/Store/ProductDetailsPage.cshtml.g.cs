#pragma checksum "C:\Coding Directory\SimplyHorsePower\Pages\Store\ProductDetailsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88d76047c9b9ffeab77d1ec8cb5e7ebf90e1ce22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SimplyHorsePower.Pages.Store.Pages_Store_ProductDetailsPage), @"mvc.1.0.razor-page", @"/Pages/Store/ProductDetailsPage.cshtml")]
namespace SimplyHorsePower.Pages.Store
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d76047c9b9ffeab77d1ec8cb5e7ebf90e1ce22", @"/Pages/Store/ProductDetailsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e771dab9a721d5e3d4b8c17c363e61668010ff60", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Store_ProductDetailsPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AnonymousShoppingCart/ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div>\r\n\r\n    <div>\r\n        <h2 class=\"text-info\">Product details</h2>\r\n    </div>\r\n\r\n    <div>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 196, "\"", 254, 2);
            WriteAttributeValue("", 202, "data:image/gif;base64,", 202, 22, true);
#nullable restore
#line 14 "C:\Coding Directory\SimplyHorsePower\Pages\Store\ProductDetailsPage.cshtml"
WriteAttributeValue("", 224, Model.product.MainBase64Image, 224, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"Card image cap\">\r\n    </div>\r\n\r\n    <div>\r\n        <div class=\"carousel slide\" data-ride=\"carousel\" data-interval=\"2000\" style=\"width:auto;\">\r\n            <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 20 "C:\Coding Directory\SimplyHorsePower\Pages\Store\ProductDetailsPage.cshtml"
                 foreach (var photo in Model.ProductGalleryImages)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 575, "\"", 659, 2);
            WriteAttributeValue("", 583, "carousel-item", 583, 13, true);
#nullable restore
#line 22 "C:\Coding Directory\SimplyHorsePower\Pages\Store\ProductDetailsPage.cshtml"
WriteAttributeValue(" ", 596, photo == Model.ProductGalleryImages.First() ? "active" : "", 597, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 691, "\"", 751, 2);
            WriteAttributeValue("", 697, "data:image/gif;base64,", 697, 22, true);
#nullable restore
#line 23 "C:\Coding Directory\SimplyHorsePower\Pages\Store\ProductDetailsPage.cshtml"
WriteAttributeValue("", 719, photo.ProductGalleryBase64Image, 719, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    </div>\r\n");
#nullable restore
#line 26 "C:\Coding Directory\SimplyHorsePower\Pages\Store\ProductDetailsPage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n    <h3><a class=\"mt-2 text-danger\">");
#nullable restore
#line 31 "C:\Coding Directory\SimplyHorsePower\Pages\Store\ProductDetailsPage.cshtml"
                               Write(Model.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n    <p>");
#nullable restore
#line 32 "C:\Coding Directory\SimplyHorsePower\Pages\Store\ProductDetailsPage.cshtml"
  Write(Model.product.MakeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p class=\"text-secondary\">");
#nullable restore
#line 33 "C:\Coding Directory\SimplyHorsePower\Pages\Store\ProductDetailsPage.cshtml"
                         Write(Model.product.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88d76047c9b9ffeab77d1ec8cb5e7ebf90e1ce227332", async() => {
                WriteLiteral("Add to cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Coding Directory\SimplyHorsePower\Pages\Store\ProductDetailsPage.cshtml"
                                                        WriteLiteral(Model.product.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplyHorsePower.Pages.Store.ProductDetailsPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SimplyHorsePower.Pages.Store.ProductDetailsPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SimplyHorsePower.Pages.Store.ProductDetailsPageModel>)PageContext?.ViewData;
        public SimplyHorsePower.Pages.Store.ProductDetailsPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
