#pragma checksum "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\Membership\Account\SignUp\AccountSignUp.AdminLTE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c675372b7af6e1bc2a83f03034212c34f3ce2ed5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_SignUp_AccountSignUp_AdminLTE), @"mvc.1.0.view", @"/Modules/Membership/Account/SignUp/AccountSignUp.AdminLTE.cshtml")]
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
#line 1 "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\_ViewImports.cshtml"
using Indotalent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c675372b7af6e1bc2a83f03034212c34f3ce2ed5", @"/Modules/Membership/Account/SignUp/AccountSignUp.AdminLTE.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"379c0792997c67bfc7f343d9d6c3fed35f906c44", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_SignUp_AccountSignUp_AdminLTE : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/iCheck/square/blue.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.icheck.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\Membership\Account\SignUp\AccountSignUp.AdminLTE.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.SignUp.FormTitle.ToString(Localizer);
    ViewData["PageId"] = "SignUp";
    ViewData["BodyClass"] = "register-page";
    Layout = MVC.Views.Shared._LayoutNoNavigation;

#line default
#line hidden
#nullable disable
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c675372b7af6e1bc2a83f03034212c34f3ce2ed56315", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c675372b7af6e1bc2a83f03034212c34f3ce2ed57493", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<script id=""Template_Membership_SignUpPanel"" type=""text/template"">
    <div class=""s-Form"">
        <form id=""~_Form"" action="""">
            <div class=""fieldset"">
                <div id=""~_PropertyGrid""></div>
                <div class=""clear""></div>
            </div>
            <div class=""row"" style=""margin-top: 10px"">
                <div class=""col-xs-7"">
                    <div class=""checkbox icheck"">
                        <label>
                            <input type=""checkbox""> ");
#nullable restore
#line 23 "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\Membership\Account\SignUp\AccountSignUp.AdminLTE.cshtml"
                                               Write(Texts.Forms.Membership.SignUp.AcceptTerms.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </label>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-xs-5\">\r\n                    <button id=\"~_SubmitButton\" type=\"submit\" class=\"btn btn-primary btn-block btn-flat\">");
#nullable restore
#line 28 "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\Membership\Account\SignUp\AccountSignUp.AdminLTE.cshtml"
                                                                                                    Write(Texts.Forms.Membership.SignUp.SubmitButton.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </div>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</script>\r\n\r\n<div class=\"register-box\">\r\n    <div class=\"register-logo\">\r\n        ");
#nullable restore
#line 37 "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\Membership\Account\SignUp\AccountSignUp.AdminLTE.cshtml"
   Write(Texts.Navigation.SiteTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"register-box-body\">\r\n        <h3 class=\"page-title\">");
#nullable restore
#line 40 "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\Membership\Account\SignUp\AccountSignUp.AdminLTE.cshtml"
                          Write(Texts.Forms.Membership.SignUp.FormTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p class=\"login-box-msg\">");
#nullable restore
#line 41 "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\Membership\Account\SignUp\AccountSignUp.AdminLTE.cshtml"
                            Write(Texts.Forms.Membership.SignUp.FormInfo.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div id=\"SignUpPanel\">\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c675372b7af6e1bc2a83f03034212c34f3ce2ed511660", async() => {
#nullable restore
#line 44 "C:\_serenity\products\serenity-jazz-multitenant-invoice\Indotalent\Indotalent.Web\Modules\Membership\Account\SignUp\AccountSignUp.AdminLTE.cshtml"
                                                 Write(Texts.Forms.Membership.SignUp.BackToLogin.ToString(Localizer));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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

<script type=""text/javascript"">
$(function() {
    new Indotalent.Membership.SignUpPanel($('#SignUpPanel')).init();
    $('.field.DisplayName,.field.Email,.field.ConfirmEmail,.field.Password,.field.ConfirmPassword').addClass(""has-icon"");
    $('.field.DisplayName input').after(""<span class='glyphicon glyphicon-user form-control-feedback'></span>"");
    $('.emaildomain').after(""<span class='glyphicon glyphicon-envelope form-control-feedback'></span>"");
    $('.field.Password input').after(""<span class='glyphicon glyphicon-lock form-control-feedback'></span>"");
    $('.field.ConfirmPassword input').after(""<span class='glyphicon glyphicon-log-in form-control-feedback'></span>"");
    $('input').iCheck({
        checkboxClass: 'icheckbox_square-blue',
        radioClass: 'iradio_square-blue',
        increaseArea: '20%'
    });
});
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
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
