#pragma checksum "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f84c308716062b5737554d5a1fe8ec685dd5a7e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Msg_send), @"mvc.1.0.view", @"/Views/Msg/send.cshtml")]
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
#line 1 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\_ViewImports.cshtml"
using hampad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\_ViewImports.cshtml"
using hampad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f84c308716062b5737554d5a1fe8ec685dd5a7e9", @"/Views/Msg/send.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c63872adf158985dc29e69c8ab5f89b8bcb1b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Msg_send : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.AdminViewModel.Message.Vm_Message>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("موضوع"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("پیام خود را  بنویسید"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-file-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/msg/add_msg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app-assets/images/icons/alert.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("avtar img holder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\vendors\css\vendors-rtl.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\vendors\css\editors\quill\katex.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\vendors\css\editors\quill\monokai-sublime.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\vendors\css\editors\quill\quill.snow.css"">
    <!-- END: Vendor CSS-->

    <!-- BEGIN: Theme CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\bootstrap.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\bootstrap-extended.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\colors.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\components.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\themes\dark-layout.min.css"">
    ");
            WriteLiteral(@"<link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\themes\semi-dark-layout.min.css"">

    <!-- BEGIN: Page CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\core\menu\menu-types\horizontal-menu.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\core\colors\palette-gradient.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\pages\app-email.min.css"">
    <!-- END: Page CSS-->

    <!-- BEGIN: Custom CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""..\..\..\app-assets\css-rtl\custom-rtl.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""../assets/css/style-rtl.css"">
    <!-- END: Custom CSS-->

 

  <!-- BEGIN: Body-->
 

    <!-- BEGIN: Header-->
   
    <!-- END: Header-->


    <!-- BEGIN: Main Menu-->
    
    <!-- END: Main Menu-->

    <!-- BEGIN: Content-->
");
#nullable restore
#line 43 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
        if (ViewBag.err != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"alert alert-success\">");
#nullable restore
#line 45 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
                                          Write(ViewBag.err);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 46 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      <div class=""content-area-wrapper"">
        <div class=""sidebar-left"">
          <div class=""sidebar""><div class=""sidebar-content email-app-sidebar d-flex"">
         
  <span class=""sidebar-close-icon"">
    <i class=""feather icon-x""></i>
  </span>
  <div class=""email-app-menu"">
    <div class=""form-group form-group-compose text-center compose-btn"">
      <button type=""button"" class=""btn btn-primary btn-block my-2"" data-toggle=""modal"" data-target=""#composeForm""><i class=""feather icon-edit""></i>ساختن</button>
    </div>
    <div class=""sidebar-menu-list"">
      <div class=""list-group list-group-messages font-medium-1"">
        <a href=""/msg/index"" class=""list-group-item list-group-item-action border-0 pt-0 active"">
          <i class=""font-medium-5 feather icon-mail mr-50""></i>  صندوق ورودی<span class=""badge badge-primary badge-pill float-right"">");
#nullable restore
#line 61 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
                                                                                                                                Write(ViewBag.resiver);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </a>\r\n        <a href=\"/msg/send\" class=\"list-group-item list-group-item-action border-0\"><i class=\"font-medium-5 fa fa-paper-plane-o mr-50\"></i>  ارسال شد<span class=\"badge badge-warning badge-pill float-right\">");
#nullable restore
#line 63 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
                                                                                                                                                                                                         Write(ViewBag.sender);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a>
        <a href=""#"" class=""list-group-item list-group-item-action border-0""><i class=""font-medium-5 feather icon-edit-2 mr-50""></i>  پیش نویس<span class=""badge badge-warning badge-pill float-right"">4</span> </a>
        <a href=""#"" class=""list-group-item list-group-item-action border-0""><i class=""font-medium-5 feather icon-star mr-50""></i> ستاره دار</a>
        <a href=""#"" class=""list-group-item list-group-item-action border-0""><i class=""font-medium-5 feather icon-info mr-50""></i> هرزنامه ها<span class=""badge badge-danger badge-pill float-right"">3</span> </a>
        <a href=""#"" class=""list-group-item list-group-item-action border-0""><i class=""font-medium-5 feather icon-trash mr-50""></i> زباله ها</a>
      </div>
      <hr>
      <h5 class=""my-2 pt-25"">برچسب ها</h5>
      <div class=""list-group list-group-labels font-medium-1"">
        <a href=""#"" class=""list-group-item list-group-item-action border-0 d-flex align-items-center""><span class=""bullet bullet-success mr-1""></span>  شخصی</a>
 ");
            WriteLiteral(@"       <a href=""#"" class=""list-group-item list-group-item-action border-0 d-flex align-items-center""><span class=""bullet bullet-primary mr-1""></span>  شرکت</a>
        <a href=""#"" class=""list-group-item list-group-item-action border-0 d-flex align-items-center""><span class=""bullet bullet-warning mr-1""></span>  مهم</a>
        <a href=""#"" class=""list-group-item list-group-item-action border-0 d-flex align-items-center""><span class=""bullet bullet-danger mr-1""></span>  خصوصی</a>
      </div>
    </div>
  </div>
</div>
<!-- Modal -->
<div class=""modal fade text-left"" id=""composeForm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""emailCompose"" aria-hidden=""true"">
  <div class=""modal-dialog modal-dialog-scrollable"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f84c308716062b5737554d5a1fe8ec685dd5a7e915284", async() => {
                WriteLiteral(@"
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h3 class=""modal-title text-text-bold-600"" id=""emailCompose"">پیام جدید</h3>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body pt-1"">
        <div class=""form-label-group mt-1"">
          <input type=""text""  class=""form-control"" placeholder=""پشتیبانی و فروش شرکت"" name=""fname-floating"" disabled>
          <label for=""emailTo"">به</label>
        </div>
        <div class=""form-label-group"">
          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f84c308716062b5737554d5a1fe8ec685dd5a7e916208", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 97 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubjectMess);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          <label for=\"emailSubject\">موضوع</label>\r\n        </div>\r\n       \r\n        <div id=\"email-container\">\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f84c308716062b5737554d5a1fe8ec685dd5a7e918529", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 102 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TextMess);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group mt-2\">\r\n          <div class=\"custom-file\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f84c308716062b5737554d5a1fe8ec685dd5a7e920809", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
#nullable restore
#line 106 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.file);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <label class=""custom-file-label"" for=""emailAttach"">افزودن فایل</label>
          </div>
        </div>
      </div>
      <div class=""modal-footer"">
        
        <input type=""Reset"" value=""لغو"" class=""btn btn-white"" data-dismiss=""modal"">
        <button type=""submit"" class=""btn btn-primary "">ارسال</button>
      </div>
    </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
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

          </div>
        </div>
        <div class=""content-right"">
          <div class=""content-wrapper"">
            <div class=""content-header row"">
            </div>
            <div class=""content-body""><div class=""app-content-overlay""></div>
<div class=""email-app-area"">
    <!-- Email list Area -->
    <div class=""email-app-list-wrapper"">
        <div class=""email-app-list"">
            <div class=""app-fixed-search"">
                <div class=""sidebar-toggle d-block d-lg-none""><i class=""feather icon-menu""></i></div>
                <fieldset class=""form-group position-relative has-icon-left m-0"">
                    <input type=""text"" class=""form-control"" id=""email-search"" placeholder=""جستجو ایمیل"">
                    <div class=""form-control-position"">
                        <i class=""feather icon-search""></i>
                    </div>
                </fieldset>
            </div>
            <div class=""app-action"">
                <div class=""action-l");
            WriteLiteral(@"eft"">
                    <div class=""vs-checkbox-con selectAll"">
                        <input type=""checkbox"">
                        <span class=""vs-checkbox"">
                          <span class=""vs-checkbox--check"">
                            <i class=""vs-icon feather icon-minus""></i>
                          </span>
                        </span>
                        <span>انتخاب همه</span>
                    </div>
                </div>
                <div class=""action-right"">
                    <ul class=""list-inline m-0"">
                        <li class=""list-inline-item"">
                            <div class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" id=""folder"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                  <i class=""feather icon-folder""></i>
                                </a>
                                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=");
            WriteLiteral(@"""folder"">
                                  <a class=""dropdown-item d-flex font-medium-1"" href=""#""><i class=""font-medium-3 feather icon-edit-2 mr-50""></i>  پیش نویس</a>
                                  <a class=""dropdown-item d-flex font-medium-1"" href=""#""><i class=""font-medium-3 feather icon-info mr-50""></i>  هرزنامه ها</a>
                                  <a class=""dropdown-item d-flex font-medium-1"" href=""#""><i class=""font-medium-3 feather icon-trash mr-50""></i>  زباله ها</a>
                                </div>
                            </div>
                        </li>
                        <li class=""list-inline-item"">
                            <div class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" id=""tag"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                  <i class=""feather icon-tag""></i>
                                </a>
                                <div class=""dropdown-menu dropdown-me");
            WriteLiteral(@"nu-right"" aria-labelledby=""tag"">
                                    <a href=""#"" class=""dropdown-item font-medium-1""><span class=""mr-1 bullet bullet-success bullet-sm""></span>  شخصی</a>
                                    <a href=""#"" class=""dropdown-item font-medium-1""><span class=""mr-1 bullet bullet-primary bullet-sm""></span>  شرکت</a>
                                    <a href=""#"" class=""dropdown-item font-medium-1""><span class=""mr-1 bullet bullet-warning bullet-sm""></span>  مهم</a>
                                    <a href=""#"" class=""dropdown-item font-medium-1""><span class=""mr-1 bullet bullet-danger bullet-sm""></span>  خصوصی</a>
                                </div>
                            </div>
                        </li>
                        <li class=""list-inline-item mail-unread""><span class=""action-icon""><i class=""feather icon-mail""></i></span></li>
                        <li class=""list-inline-item mail-delete""><span class=""action-icon""><i class=""feather icon-trash""></i></spa");
            WriteLiteral("n></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"email-user-list list-group\">\r\n                <ul class=\"users-list-wrapper media-list\">\r\n\r\n");
#nullable restore
#line 188 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
                     foreach (var item in  @ViewBag.msg)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"media mail-read\">\r\n                        <div class=\"media-left pr-50\">\r\n                            <div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f84c308716062b5737554d5a1fe8ec685dd5a7e929413", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""user-action"">
                                <div class=""vs-checkbox-con"">
                                    <input type=""checkbox"">
                                    <span class=""vs-checkbox vs-checkbox-sm"">
                                      <span class=""vs-checkbox--check"">
                                        <i class=""vs-icon feather icon-check""></i>
                                      </span>
                                    </span>
                                </div>
                                <span class=""favorite""><i class=""feather icon-star""></i></span>
                            </div>
                        </div>
                        <div class=""media-body"">
                            <div class=""user-details"">
                                <div class=""mail-items"">
                                    <h5 class=""list-group-item-heading text-bold-600 mb-25"">بخش پشتیبانی و فرو");
            WriteLiteral(@"ش شرکت</h5>
                                    <span class=""list-group-item-text text-truncate"">SevenStar</span>
                                </div>
                                <div class=""mail-meta-item"">
                                    <span class=""float-right"">
                                        <span class=""mr-1 bullet bullet-success bullet-sm""></span>
                                        <span class=""mail-date"">");
#nullable restore
#line 216 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
                                                           Write(item.DateMess);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                         <a");
            BeginWriteAttribute("href", " href=\"", 12823, "\"", 12854, 2);
            WriteAttributeValue("", 12830, "/msg/Detailssnd/", 12830, 16, true);
#nullable restore
#line 217 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
WriteAttributeValue("", 12846, item.Id, 12846, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\">مشاهده</a>\r\n");
#nullable restore
#line 218 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
                                          if (item.StateMess==false)
                                         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <a  class=\"btn btn-warning btn-sm\" style=\"color: white;\">خوانده نشده</a>\r\n");
#nullable restore
#line 221 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
                                         }else
                                         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <a  class=\"btn btn-success btn-sm\" style=\"color: white;\">خوانده شده</a>\r\n");
#nullable restore
#line 224 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                      
                                       
                                    </span>
                                   
                                     
                                </div>
                                
                            </div>
                            
                            <div class=""mail-message"">
                                <p class=""list-group-item-text truncate mb-0"">
                                    ");
#nullable restore
#line 236 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
                               Write(item.SubjectMess);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                     <a");
            BeginWriteAttribute("href", " href=\"", 14000, "\"", 14024, 2);
            WriteAttributeValue("", 14007, "/msg/del/", 14007, 9, true);
#nullable restore
#line 238 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
WriteAttributeValue("", 14016, item.Id, 14016, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'آیا از حذف مطمئن هستید؟\')\"><i class=\"feather icon-trash\"></i></a>\r\n                            </div>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 242 "c:\Users\Neati\Desktop\SevenStar\hampad\Views\Msg\send.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    
                  
                </ul>
                <div class=""no-results"">
                   <h5>موردی یافت نشد</h5>
                </div>
            </div>
        </div>
    </div>
    <!--/ Email list Area -->
   
    <!--/ Detailed Email View -->
</div>

            </div>
          </div>
        </div>
      </div>
    
    <!-- END: Content-->


    <!-- BEGIN: Customizer-->
    
    <!-- End: Customizer-->

    <!-- Buynow Button-->
  
    <!-- END: Footer-->


    <!-- BEGIN: Vendor JS-->
    <script src=""..\..\..\app-assets\vendors\js\vendors.min.js""></script>
    <!-- BEGIN Vendor JS-->

    <!-- BEGIN: Page Vendor JS-->
    <script src=""..\..\..\app-assets\vendors\js\ui\jquery.sticky.js""></script>
    <script src=""..\..\..\app-assets\vendors\js\editors\quill\katex.min.js""></script>
    <script src=""..\..\..\app-assets\vendors\js\editors\quill\highlight.min.js""></script>
    <script src=""..\..\..\app-assets\vendors\js\editors\qui");
            WriteLiteral(@"ll\quill.min.js""></script>
    <!-- END: Page Vendor JS-->

    <!-- BEGIN: Theme JS-->

    <!-- END: Theme JS-->

    <!-- BEGIN: Page JS-->
    <script src=""..\..\..\app-assets\js\scripts\pages\app-email.min.js""></script>
    <!-- END: Page JS-->

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.AdminViewModel.Message.Vm_Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
