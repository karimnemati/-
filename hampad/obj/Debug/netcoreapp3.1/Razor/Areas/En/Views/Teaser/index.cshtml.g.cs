#pragma checksum "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\En\Views\Teaser\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9438b9dab3924b611cefaee366fdfa583f0b78ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_En_Views_Teaser_index), @"mvc.1.0.view", @"/Areas/En/Views/Teaser/index.cshtml")]
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
#line 1 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\En\Views\_ViewImports.cshtml"
using hampad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\En\Views\_ViewImports.cshtml"
using hampad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9438b9dab3924b611cefaee366fdfa583f0b78ad", @"/Areas/En/Views/Teaser/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c63872adf158985dc29e69c8ab5f89b8bcb1b3", @"/Areas/En/Views/_ViewImports.cshtml")]
    public class Areas_En_Views_Teaser_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" mt-1  img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app-assets/images/icons/playicon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img-placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class="" text-center"">


    <h3 class=""text-center"">
        <p style=""vertical-align: inherit;"">
        <p style=""vertical-align: inherit;"">Teasers and videos</p>
        </p>
        </h1>
        <br>
</div>

<section id=""ecommerce-products"" class=""row"">


");
#nullable restore
#line 15 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\En\Views\Teaser\index.cshtml"
     foreach (var item in ViewBag.Teaser)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card ecommerce-card col-lg-4 col-xl-4 col-md-4 col-sm-6 col-12""
        style=""background-image:url('../app-assets/images/icons/sidRight1.png')"">
        <div class=""card-content alert alert-secondary "">
            <div class=""item-img text-center"">
                <a");
            BeginWriteAttribute("href", " href=\"", 619, "\"", 650, 2);
            WriteAttributeValue("", 626, "/teaser/details/", 626, 16, true);
#nullable restore
#line 21 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\En\Views\Teaser\index.cshtml"
WriteAttributeValue("", 642, item.Id, 642, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9438b9dab3924b611cefaee366fdfa583f0b78ad5839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </a>
            </div>
            <div class=""card-body"">
                <div class=""item-wrapper text-center"">
                    <div class=""item-rating"">
                        <div class=""badge badge-primary badge-md "">


                            ");
#nullable restore
#line 32 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\En\Views\Teaser\index.cshtml"
                       Write(item.TitleTeaser);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n            <div class=\"item-options text-center \">\r\n\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 54 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\En\Views\Teaser\index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
