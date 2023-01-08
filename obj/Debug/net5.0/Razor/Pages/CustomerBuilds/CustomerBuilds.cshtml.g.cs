#pragma checksum "C:\Coding Directory\SimplyHorsePower\Pages\CustomerBuilds\CustomerBuilds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ed6f46ca2428c944cf000c52adceb8352c09fcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SimplyHorsePower.Pages.CustomerBuilds.Pages_CustomerBuilds_CustomerBuilds), @"mvc.1.0.razor-page", @"/Pages/CustomerBuilds/CustomerBuilds.cshtml")]
namespace SimplyHorsePower.Pages.CustomerBuilds
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ed6f46ca2428c944cf000c52adceb8352c09fcf", @"/Pages/CustomerBuilds/CustomerBuilds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e771dab9a721d5e3d4b8c17c363e61668010ff60", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CustomerBuilds_CustomerBuilds : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/CustomerBuilds/CustomerBuildDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-default mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-abc", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Coding Directory\SimplyHorsePower\Pages\CustomerBuilds\CustomerBuilds.cshtml"
  
    ViewData["Title"] = "Customer Projects";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-info\">");
#nullable restore
#line 9 "C:\Coding Directory\SimplyHorsePower\Pages\CustomerBuilds\CustomerBuilds.cshtml"
                 Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div>\r\n    <div class=\"content\">\r\n        <div class=\"col-md-9\">\r\n            <div class=\"customerbuilds\">\r\n                <div class=\"row no-gutters\">\r\n");
#nullable restore
#line 15 "C:\Coding Directory\SimplyHorsePower\Pages\CustomerBuilds\CustomerBuilds.cshtml"
                     if (Model.CustomerBuilds.Count != 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Coding Directory\SimplyHorsePower\Pages\CustomerBuilds\CustomerBuilds.cshtml"
                         foreach (var customerbuild in Model.CustomerBuilds)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4 mt-2\">\r\n                                <div class=\"card flex-fill\">\r\n                                    <div class=\"card-body\">\r\n                                        <div class=\"card-img-actions\"> <img");
            BeginWriteAttribute("src", " src=\"", 827, "\"", 885, 2);
            WriteAttributeValue("", 833, "data:image/gif;base64,", 833, 22, true);
#nullable restore
#line 22 "C:\Coding Directory\SimplyHorsePower\Pages\CustomerBuilds\CustomerBuilds.cshtml"
WriteAttributeValue("", 855, customerbuild.MainBase64Image, 855, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img img-fluid\" width=\"96\" height=\"350\"");
            BeginWriteAttribute("alt", " alt=\"", 937, "\"", 943, 0);
            EndWriteAttribute();
            WriteLiteral(@"> </div>
                                    </div>
                                    <div class=""card-body bg-light text-center"">
                                        <div class=""mb-2"">
                                            <h6 class=""font-weight-semibold mb-2""> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ed6f46ca2428c944cf000c52adceb8352c09fcf6838", async() => {
#nullable restore
#line 26 "C:\Coding Directory\SimplyHorsePower\Pages\CustomerBuilds\CustomerBuilds.cshtml"
                                                                                                                                                                                                                         Write(customerbuild.CustomerName);

#line default
#line hidden
#nullable disable
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
#line 26 "C:\Coding Directory\SimplyHorsePower\Pages\CustomerBuilds\CustomerBuilds.cshtml"
                                                                                                                                        WriteLiteral(customerbuild.CustomerBuildId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </h6>\r\n                                            <h3 class=\"text-muted\" data-abc=\"true\">");
#nullable restore
#line 27 "C:\Coding Directory\SimplyHorsePower\Pages\CustomerBuilds\CustomerBuilds.cshtml"
                                                                              Write(customerbuild.CustomerBuildTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 32 "C:\Coding Directory\SimplyHorsePower\Pages\CustomerBuilds\CustomerBuilds.cshtml"


                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Coding Directory\SimplyHorsePower\Pages\CustomerBuilds\CustomerBuilds.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div><h3>There are no Customer Builds to display at this time!</h3></div>\r\n");
#nullable restore
#line 39 "C:\Coding Directory\SimplyHorsePower\Pages\CustomerBuilds\CustomerBuilds.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplyHorsePower.Pages.CustomerBuilds.CustomerBuildsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SimplyHorsePower.Pages.CustomerBuilds.CustomerBuildsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SimplyHorsePower.Pages.CustomerBuilds.CustomerBuildsModel>)PageContext?.ViewData;
        public SimplyHorsePower.Pages.CustomerBuilds.CustomerBuildsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
