#pragma checksum "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa455ade30dcd8b8ab5892e5ec50983a23ab03c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Tu_Views_Shared__Partial_Mainmenu_Tu), @"mvc.1.0.view", @"/Areas/Tu/Views/Shared/_Partial_Mainmenu_Tu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa455ade30dcd8b8ab5892e5ec50983a23ab03c", @"/Areas/Tu/Views/Shared/_Partial_Mainmenu_Tu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c63872adf158985dc29e69c8ab5f89b8bcb1b3", @"/Areas/Tu/Views/_ViewImports.cshtml")]
    public class Areas_Tu_Views_Shared__Partial_Mainmenu_Tu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"  <div class=""horizontal-menu-wrapper"">
        <div class=""header-navbar navbar-expand-sm navbar navbar-horizontal floating-nav navbar-light navbar-without-dd-arrow navbar-shadow menu-border""
            role=""navigation"" data-menu=""menu-wrapper"">
            <div class=""navbar-header"">
                <ul class=""nav navbar-nav flex-row "">
                    <li class=""nav-item mr-auto"">
");
#nullable restore
#line 7 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                          if(menu.logo != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img style=\"width: 200px; height: 64px;\"");
            BeginWriteAttribute("src", " src=\"", 515, "\"", 543, 2);
            WriteAttributeValue("", 521, "/fileupload/", 521, 12, true);
#nullable restore
#line 9 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
WriteAttributeValue("", 533, menu.logo, 533, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Logonuzu koyun\" >\r\n");
#nullable restore
#line 10 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img src=\"/app-assets/images/icons/defaultlogo.png\" alt=\"Logonuzu koyun\" >\r\n");
#nullable restore
#line 14 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </li>
                    <li class=""nav-item nav-toggle""><a class=""nav-link modern-nav-toggle pr-0"" data-toggle=""collapse""><i
                                class=""feather icon-x d-block d-xl-none font-medium-4 primary toggle-icon""></i><i
                                class=""toggle-icon feather icon-disc font-medium-4 d-none d-xl-block collapse-toggle-icon primary""
                                data-ticon=""icon-disc""></i></a></li>
                </ul>
            </div>
            <!-- Horizontal menu content-->
            <div class=""navbar-container main-menu-content justify-content-end"" data-menu=""menu-container"">
                <!-- include ~/includes/mixins-->
                <div class=""row ml-0.5"">
                    <ul class=""nav navbar-nav justify-content-center "" id=""main-menu-navigation""
                        data-menu=""menu-navigation"">
                        <li class=""dropdown nav-item "">
                            <a class="" nav-link"" href=""/T");
            WriteLiteral(@"u/home/index""><i class=""feather icon-home""></i><span
                                    data-i18n=""Dashboard"">Ana sayfa</span></a>

                        </li>
                        <li class=""dropdown nav-item"" data-menu=""dropdown"">
                            <a class=""dropdown-toggle nav-link"" href=""#"" data-toggle=""dropdown""><i
                                    class=""fa fa-shopping-cart""></i><span data-i18n=""Apps""> Ürün</span></a>
                            <ul class=""dropdown-menu"">

");
#nullable restore
#line 39 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                                 foreach (var item in menu.cat)
                                {
                                if (item.FatherIdCat==-1)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""dropdown dropdown-submenu"" data-menu=""dropdown-submenu""><a
                                        class=""dropdown-item dropdown-toggle"" href=""#"" data-toggle=""dropdown""
                                        data-i18n=""User""><i class=""fa fa-check-square-o""></i>");
#nullable restore
#line 46 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                                                                                        Write(item.NameCat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <ul class=\"dropdown-menu\">\r\n");
#nullable restore
#line 48 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                                         foreach (var item1 in menu.cat)
                                        {
                                        if (item1.FatherIdCat == item.Id)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li data-menu=\"\"><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 3157, "\"", 3191, 2);
            WriteAttributeValue("", 3164, "/Tu/product/index/", 3164, 18, true);
#nullable restore
#line 52 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
WriteAttributeValue("", 3182, item1.Id, 3182, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                                data-toggle=\"dropdown\" data-i18n=\"List\"><i\r\n                                                    class=\"feather icon-circle\"></i>");
#nullable restore
#line 54 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                                                                               Write(item1.NameCat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </li>\r\n");
#nullable restore
#line 56 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                                        }

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                    </ul>\r\n                                </li>\r\n");
#nullable restore
#line 64 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                                }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



                            </ul>
                        </li>
                        <li class=""dropdown nav-item"" data-menu=""dropdown"">
                            <a class=""dropdown-toggle nav-link"" href=""#"" data-toggle=""dropdown""><i
                                    class=""fa fa-newspaper-o""></i><span data-i18n=""Apps"">Haberler ve Blog</span></a>
                            <ul class=""dropdown-menu"">

");
#nullable restore
#line 77 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                                 foreach (var item in menu.cat)
                                {
                                if (item.FatherIdCat==-2)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""dropdown dropdown-submenu"" data-menu=""dropdown-submenu""><a
                                        class=""dropdown-item dropdown-toggle"" href=""#"" data-toggle=""dropdown""
                                        data-i18n=""User""><i class=""fa fa-check-square-o""></i>");
#nullable restore
#line 84 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                                                                                        Write(item.NameCat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <ul class=\"dropdown-menu\">\r\n");
#nullable restore
#line 86 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                                         foreach (var item1 in menu.cat)
                                        {
                                        if (item1.FatherIdCat == item.Id)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li data-menu=\"\"><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 5012, "\"", 5043, 2);
            WriteAttributeValue("", 5019, "/Tu/blog/index/", 5019, 15, true);
#nullable restore
#line 90 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
WriteAttributeValue("", 5034, item1.Id, 5034, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                                data-toggle=\"dropdown\" data-i18n=\"List\"><i\r\n                                                    class=\"feather icon-circle\"></i>");
#nullable restore
#line 92 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                                                                               Write(item1.NameCat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </li>\r\n");
#nullable restore
#line 94 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                                        }

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                    </ul>\r\n                                </li>\r\n");
#nullable restore
#line 102 "c:\Users\Neati\Desktop\SevenStar\hampad\Areas\Tu\Views\Shared\_Partial_Mainmenu_Tu.cshtml"
                                }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </ul>
                        </li>













                        <li class=""dropdown nav-item"" data-menu=""dropdown"">
                            <a class=""dropdown-toggle nav-link"" href=""#"" data-toggle=""dropdown""><i
                                    class=""fa fa-user-circle""></i><span data-i18n=""Apps"">Ajanslar ve uzmanlar</span></a>
                            <ul class=""dropdown-menu"">



                                <li data-menu=""""><a class=""dropdown-item"" href=""/Tu/expert/index""
                                        data-toggle=""dropdown"" data-i18n=""List""><i class=""feather icon-circle""></i>Uzman kadrosu</a>
                                </li>

                                <li data-menu=""""><a class=""dropdown-item"" href=""/Tu/agancy/index""
                                        data-toggle=""dropdown"" data-i18n=""List""><i class=""feather icon-circle""></i>Ajansların listesi</a>
                                </li>






      ");
            WriteLiteral(@"                      </ul>
                        </li>


                        <li class="" nav-item"">
                            <a class="" nav-link"" href=""/Tu/gallery/index""><i class=""fa fa-picture-o""></i><span>Fotoğraf Galerisi </span></a>

                        </li>
                        <li class="" nav-item"">
                            <a class="" nav-link"" href=""/Tu/teaser/index""><i class=""fa fa-play-circle""></i><span
                                    data-i18n=""Apps"">Filmler</span></a>

                        </li>
                        <li class="" nav-item"">
                            <a class="" nav-link"" href=""/Tu/contact/index""><i class=""fa fa-phone-square""></i><span
                                    data-i18n=""Apps"">bizi ara</span></a>

                        </li>
                      
                    </ul>
                </div>
            </div>
        </div>
    </div>");
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
