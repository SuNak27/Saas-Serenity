#pragma checksum "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f557cad01089944c92e221deea90af581b7397eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Purchase_BillPayment_BillPaymentPrint), @"mvc.1.0.view", @"/Modules/Purchase/BillPayment/BillPaymentPrint.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f557cad01089944c92e221deea90af581b7397eb", @"/Modules/Purchase/BillPayment/BillPaymentPrint.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"379c0792997c67bfc7f343d9d6c3fed35f906c44", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Purchase_BillPayment_BillPaymentPrint : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Indotalent.Purchase.BillPaymentPrintData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
 if ((bool?)ViewData["Printing"] == true)
{
    Layout = "_LayoutNoNavigation";
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"invoice\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12\">\r\n            <h2 class=\"page-header\">\r\n                PAYMENT VOUCHER (DISBURSE)\r\n                <small class=\"pull-right\">Print at: ");
#nullable restore
#line 13 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
                                               Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
            </h2>
        </div>
    </div>
    <!-- info row -->
    <div class=""row invoice-info"">
        <!-- /.col -->
        <div class=""col-sm-4 invoice-col"">
            Disburse Payment To
            <address>
                <strong>");
#nullable restore
#line 23 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
                   Write(Model.Vendor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br>\r\n                ");
#nullable restore
#line 24 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
           Write(Model.Vendor.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                ");
#nullable restore
#line 25 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
           Write(Model.Vendor.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
                              Write(Model.Vendor.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
                                                  Write(Model.Vendor.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                Phone: ");
#nullable restore
#line 26 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
                  Write(Model.Vendor.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                Email: ");
#nullable restore
#line 27 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
                  Write(Model.Vendor.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </address>\r\n        </div>\r\n        <!-- /.col -->\r\n        <div class=\"col-sm-4 invoice-col\">\r\n            Payment Number:<br>\r\n            ");
#nullable restore
#line 33 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
       Write(Model.Header.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n            Payment Date:<br>\r\n            ");
#nullable restore
#line 35 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
       Write(Model.Header.PaymentDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n        </div>\r\n        <!-- /.col -->\r\n        <div class=\"col-sm-4 invoice-col\">\r\n            Bill Number:<br>\r\n            ");
#nullable restore
#line 40 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
       Write(Model.Header.BillNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n            Amount Bill:<br>\r\n            ");
#nullable restore
#line 42 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
       Write(Model.Company.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 42 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
                               Write(Model.Header.BillAmount.Value.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
    <!-- /.row -->
    <!-- Table row -->
    <div class=""row"">
        <div class=""col-xs-12 table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Description</th>
                        <th>Info</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Payment Amount:</td>
                        <td>");
#nullable restore
#line 59 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
                       Write(Model.Company.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 59 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
                                               Write(Model.Header.PaymentAmount.Value.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Payment Mode:</td>\r\n                        <td>");
#nullable restore
#line 63 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Purchase\BillPayment\BillPaymentPrint.cshtml"
                       Write(Model.Header.CashBankName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </tbody>
            </table>
        </div>
        <!-- /.col -->
    </div>
    <br>
    <br>
    <br>
    <br>
    <div class=""row"">
        <div class=""col-xs-12"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th class=""text-center"">Prepared By</th>
                        <th class=""text-center"">Approved By</th>
                        <th class=""text-center"">Processed By</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <br>
                            <br>
                            <br>
                            <br>
                            <br>
                            <br>
                        </td>
                        <td>
                            <br>
                            <br>
                           ");
            WriteLiteral(@" <br>
                            <br>
                            <br>
                            <br>
                        </td>
                        <td>
                            <br>
                            <br>
                            <br>
                            <br>
                            <br>
                            <br>
                        </td>
                    </tr>
                </tbody>
            </table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Indotalent.Purchase.BillPaymentPrintData> Html { get; private set; }
    }
}
#pragma warning restore 1591
