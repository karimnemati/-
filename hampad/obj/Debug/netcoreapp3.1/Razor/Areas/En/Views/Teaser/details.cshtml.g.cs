#pragma checksum "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\En\Views\Teaser\details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "053b3c0c34908fe5ae9fcee7bf11a4dc651cdaab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_En_Views_Teaser_details), @"mvc.1.0.view", @"/Areas/En/Views/Teaser/details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"053b3c0c34908fe5ae9fcee7bf11a4dc651cdaab", @"/Areas/En/Views/Teaser/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c63872adf158985dc29e69c8ab5f89b8bcb1b3", @"/Areas/En/Views/_ViewImports.cshtml")]
    public class Areas_En_Views_Teaser_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataLayer.AdminEntities.Teaser.Tb_Teaser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("video/mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section id=""timeline-card"">

    <div class=""row "">


        <div class=""col-lg-12 col-sm-12"">
            <div class=""card"" >

                <div class=""card-content"">
                    <div class=""card-body"">
                        <ul class=""activity-timeline timeline-left list-unstyled"">

                            <li>
                                <div class=""timeline-icon bg-primary"">
                                    <i class=""feather icon-check font-medium-2""></i>
                                </div>
                                <div class=""timeline-info"">
                                    <p class=""font-weight-bold"" style=""text-align: right;"">
                                        عنوان :</p>
                                    <br>


                                    <div class=""col-lg-12 d-lg-block  text-center align-self-center px-1 py-0"">


                                        <div class=""footer-btn alert alert-primary  "" style=""line-height: 40p");
            WriteLiteral("x;font-size: 14px;text-align: justify;\">\r\n\r\n                                            ");
#nullable restore
#line 29 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\En\Views\Teaser\details.cshtml"
                                       Write(Model.TitleTeaser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            
                                        </div>
                                    </div>

                                </div>

                            </li>

                           
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-12 col-sm-12"">
            <div class=""card"" >

                <div class=""card-content"">
                    <div class=""card-body"">
                        <ul class=""activity-timeline timeline-left list-unstyled"" style=""margin-right: 0px !important;"">
                            <li>
                                <div class=""timeline-icon bg-primary"">
                                    <i class=""feather icon-check font-medium-2""></i>
                                </div>
                                <div class=""timeline-info"">
                                    <p class=""font-weight-bold"" style=""te");
            WriteLiteral(@"xt-align: right;""> Video
                                      </p>
                                    <br>

                                    <div class=""footer-btn alert alert-primary text-center "">

                                             <video width=""80%"" height=""400px"" controls  id=""output_image"">
                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "053b3c0c34908fe5ae9fcee7bf11a4dc651cdaab6387", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2579, "~/fileupload/", 2579, 13, true);
#nullable restore
#line 62 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\En\Views\Teaser\details.cshtml"
AddHtmlAttributeValue("", 2592, Model.LinkVideoTeaser, 2592, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <source src=""movie.ogg"" type=""video/ogg"">
                                        </video>
                                    </div>


                                </div>

                            </li>

                        </ul>
                    </div>
                </div>
            </div>
        </div>

    </div>


















    
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataLayer.AdminEntities.Teaser.Tb_Teaser> Html { get; private set; }
    }
}
#pragma warning restore 1591
