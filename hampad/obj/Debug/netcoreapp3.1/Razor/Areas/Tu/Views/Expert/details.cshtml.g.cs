#pragma checksum "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Expert\details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e64a1646c1eec66d380800d13a8c467d94350924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Tu_Views_Expert_details), @"mvc.1.0.view", @"/Areas/Tu/Views/Expert/details.cshtml")]
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
#line 1 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\_ViewImports.cshtml"
using hampad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\_ViewImports.cshtml"
using hampad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64a1646c1eec66d380800d13a8c467d94350924", @"/Areas/Tu/Views/Expert/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c63872adf158985dc29e69c8ab5f89b8bcb1b3", @"/Areas/Tu/Views/_ViewImports.cshtml")]
    public class Areas_Tu_Views_Expert_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataLayer.AdminEntities.Experts.Tb_Experts>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n   <link rel=\"stylesheet\" href=\"https://unpkg.com/leaflet@1.3.4/dist/leaflet.css\" />\r\n<script src=\"https://unpkg.com/leaflet@1.3.4/dist/leaflet.js\"></script>\r\n   \r\n    <style>\r\n        #map { height:300px; width:100%; }\r\n       \r\n\r\n    </style>\r\n");
            WriteLiteral(@"<section id=""timeline-card"">

    <div class=""row "">


        <div class=""col-lg-6 col-sm-12"">
            <div class=""card"" >

                <div class=""card-content"">
                    <div class=""card-body"">
                        <ul class=""activity-timeline timeline-left list-unstyled"">

                            <li>
                                <div class=""timeline-icon bg-warning"">
                                    <i class=""feather icon-check font-medium-2""></i>
                                </div>
                                <div class=""timeline-info"">
                                    <p class=""font-weight-bold mt-2 mb-2"" style=""text-align: right;"">
                                      Ad ve soyad : ");
#nullable restore
#line 29 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Expert\details.cshtml"
                                               Write(Model.NameEx);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                                    <br>


                                    <div class=""col-lg-12 d-lg-block  text-center align-self-center px-1 py-0"">
                                         <div class=""footer-btn alert alert-primary  "" style=""line-height: 40px;font-size: 18px;text-align: justify;"">

                                            Adres:");
#nullable restore
#line 36 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Expert\details.cshtml"
                                             Write(Model.address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            
                                        </div>
                                         <div class=""footer-btn alert alert-primary  "" style=""line-height: 40px;font-size: 18px;text-align: justify;"">

                                             Sabit telefon numarası:");
#nullable restore
#line 41 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Expert\details.cshtml"
                                                               Write(Model.OfficeTelEx);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            
                                        </div>
                                         <div class=""footer-btn alert alert-primary  "" style=""line-height: 40px;font-size: 18px;text-align: justify;"">

                                             Mobil iletişim numarası:");
#nullable restore
#line 46 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Expert\details.cshtml"
                                                                Write(Model.TelEx);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            
                                        </div>

                                        
                                         
                                        
                                        
                                    </div>

                                </div>

                            </li>

                            <li>
                             

                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 col-sm-12"">
            <div class=""card"" >

                <div class=""card-content"">
                    <div class=""card-body"">
                        <ul class=""activity-timeline timeline-left list-unstyled"" style=""margin-right: 0px !important;"">
                            <li>
                                <div class=""timeline-icon bg-success"">
                 ");
            WriteLiteral(@"                   <i class=""feather icon-check font-medium-2""></i>
                                </div>
                                <div class=""timeline-info"">
                                    <p class=""font-weight-bold"" style=""text-align: right;""> Fotoğraf Uzmanı
                                      </p>
                                    <br>

                                    <div class=""footer-btn alert alert-primary text-center "">

                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e64a1646c1eec66d380800d13a8c467d943509248263", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3661, "~/fileupload/", 3661, 13, true);
#nullable restore
#line 86 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Expert\details.cshtml"
AddHtmlAttributeValue("", 3674, Model.ImageEx, 3674, 14, false);

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
                                    </div>


                                </div>

                            </li>

                        </ul>
                    </div>
                </div>
            </div>
        </div>

    </div>















<style>
    img{
        max-width: 50%;
  height: auto;
    }
    p{
        text-align:justify;
    }
    
</style>
    <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 4142, "\"", 4167, 1);
#nullable restore
#line 126 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Expert\details.cshtml"
WriteAttributeValue("", 4150, Model.LocationEx, 4150, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"location\" style=\"display:none;\">\r\n<div class=\"row \">\r\n    <div class=\"col-lg-12 col-12 p-0\">\r\n        <div class=\"card rounded-0 mb-0 px-2\"");
            BeginWriteAttribute("style", " style=\"", 4312, "\"", 4320, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""card-header pb-1 alert alert-primary"">
                <div class=""card-title "">
                    <h4 class=""mb-0"">توضیحات بیشتر</h4>
                </div>
            </div>
            
           <div class=""display-field"" class="" col-9 "">
              ");
#nullable restore
#line 137 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Expert\details.cshtml"
         Write(Html.Raw(Model.AboutEx));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
             </div>
            
        </div>
    </div>
</div> 

                           <div class=""col-sm-12 col-12"">
                               <div id=""map""></div>
                            </div>



 <script>
 var locationToStringed=document.getElementById('location').value;
                                
var input = locationToStringed.replace('(', '');
var latlngStr = input.split("","", 2);
var lat = parseFloat(latlngStr[0]);
var lng = parseFloat(latlngStr[1]);

                                 debugger
         // Creating map options
         var mapOptions = {
            center: [lat,lng],
            zoom: 12
         }
         // Creating a map object
         var map = new L.map('map', mapOptions);

         // Creating a Layer object
         var layer = new L.TileLayer('http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png');

         // Adding layer to the map
         map.addLayer(layer);

         // Creating a Marker
         var markerOptions");
            WriteLiteral(@" = {
            title: ""MyLocation"",
            clickable: true,
            draggable: false
         }
         // Creating a marker
         var marker = L.marker([lat,lng], markerOptions);

         // Adding marker to the map
         marker.addTo(map);


        



      </script>

















    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataLayer.AdminEntities.Experts.Tb_Experts> Html { get; private set; }
    }
}
#pragma warning restore 1591
