#pragma checksum "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d31917352e42d0e8af22ee2c219f99a41424716a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_ForgotPassword_AccountForgotPassword), @"mvc.1.0.view", @"/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml")]
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
#line 1 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\_ViewImports.cshtml"
using Indotalent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d31917352e42d0e8af22ee2c219f99a41424716a", @"/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"379c0792997c67bfc7f343d9d6c3fed35f906c44", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_ForgotPassword_AccountForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.ForgotPassword.FormTitle.ToString(Localizer);
    ViewData["PageId"] = "ForgotPassword";
    Layout = MVC.Views.Shared._LayoutNoNavigation;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script id=\"Template_Membership_ForgotPasswordPanel\" type=\"text/template\">\r\n    <div>\r\n        <h3 class=\"page-title\">");
#nullable restore
#line 10 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
                          Write(Texts.Forms.Membership.ForgotPassword.FormTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p class=\"form-info\">");
#nullable restore
#line 11 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
                        Write(Texts.Forms.Membership.ForgotPassword.FormInfo.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <form id=""~_Form"" action="""">
            <div class=""s-Form"">
                <div class=""fieldset ui-widget ui-widget-content ui-corner-all"">
                    <div id=""~_PropertyGrid""></div>
                    <div class=""clear""></div>
                </div>
                <div class=""buttons"">
                    <button id=""~_SubmitButton"" type=""submit"" class=""btn btn-primary"">
                        ");
#nullable restore
#line 20 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
                   Write(Texts.Forms.Membership.ForgotPassword.SubmitButton.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </button>
                </div>
            </div>
        </form>
    </div>
</script>

<div class=""page-content"">
    <div id=""ForgotPasswordPanel"">
    </div>
</div>

<script type=""text/javascript"">
$(function() {
    new Indotalent.Membership.ForgotPasswordPanel($('#ForgotPasswordPanel')).init();
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
