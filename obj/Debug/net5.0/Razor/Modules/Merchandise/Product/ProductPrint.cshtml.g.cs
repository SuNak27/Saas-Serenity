#pragma checksum "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7bc5c4ea80cf26ed6919cbc1a93f3cfcea32c08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Merchandise_Product_ProductPrint), @"mvc.1.0.view", @"/Modules/Merchandise/Product/ProductPrint.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7bc5c4ea80cf26ed6919cbc1a93f3cfcea32c08", @"/Modules/Merchandise/Product/ProductPrint.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"379c0792997c67bfc7f343d9d6c3fed35f906c44", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Merchandise_Product_ProductPrint : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Indotalent.Merchandise.ProductPrintData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
 if ((bool?)ViewData["Printing"] == true)
{
    Layout = "_LayoutNoNavigation";
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"invoice\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12\">\r\n            <h2 class=\"page-header\">\r\n                PRODUCT BROCHURE\r\n                <small class=\"pull-right\">Print at: ");
#nullable restore
#line 13 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                                               Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n            </h2>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12 text-center\">\r\n            <h3>");
#nullable restore
#line 19 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
           Write(Model.Header.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12 text-center\">\r\n");
#nullable restore
#line 24 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
             if (!String.IsNullOrWhiteSpace(Model.Header.Picture))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 743, "\"", 785, 1);
#nullable restore
#line 26 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
WriteAttributeValue("", 749, $"/upload/{Model.Header.Picture}", 749, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"200\" />\r\n");
#nullable restore
#line 27 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-12"">
            <h5>Product Info</h5>
            <table class=""table table-bordered"">
                <tbody>
                    <tr>
                        <td>Product Name:</td>
                        <td>");
#nullable restore
#line 37 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                       Write(Model.Header.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Internal Code:</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                       Write(Model.Header.InternalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Barcode:</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                       Write(Model.Header.Barcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Uom:</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                       Write(Model.Header.UomName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Description:</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                       Write(Model.Header.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-6"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <h5>Product Variant</h5>
                    <table class=""table table-bordered"">
                        <tbody>
                            <tr>
                                <td>Size:</td>
                                <td>");
#nullable restore
#line 68 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                               Write(Model.Header.SizeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Colour:</td>\r\n                                <td>");
#nullable restore
#line 72 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                               Write(Model.Header.ColourName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Flavour:</td>\r\n                                <td>");
#nullable restore
#line 76 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                               Write(Model.Header.FlavourName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-xs-12"">
                    <h5>Product Retail</h5>
                    <table class=""table table-bordered"">
                        <tbody>
                            <tr>
                                <td>Currency:</td>
                                <td>");
#nullable restore
#line 89 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                               Write(Model.Header.CurrencyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Sales Price:</td>\r\n                                <td>");
#nullable restore
#line 93 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                               Write(Model.Header.SalesPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""col-xs-6"">
            <h5>Product Purchase</h5>
            <small>Please contact us using below information for purchase and procurement.</small>
            <table class=""table table-bordered"">
                <tbody>
                    <tr>
                        <td>Company Name:</td>
                        <td>");
#nullable restore
#line 107 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                       Write(Model.Company.TenantName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Street Address:</td>\r\n                        <td>");
#nullable restore
#line 111 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                       Write(Model.Company.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>City:</td>\r\n                        <td>");
#nullable restore
#line 115 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                       Write(Model.Company.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>State:</td>\r\n                        <td>");
#nullable restore
#line 119 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                       Write(Model.Company.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>ZipCode:</td>\r\n                        <td>");
#nullable restore
#line 123 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                       Write(Model.Company.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Phone:</td>\r\n                        <td>");
#nullable restore
#line 127 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                       Write(Model.Company.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Email:</td>\r\n                        <td>");
#nullable restore
#line 131 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\Indotalent.Web\Modules\Merchandise\Product\ProductPrint.cshtml"
                       Write(Model.Company.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Indotalent.Merchandise.ProductPrintData> Html { get; private set; }
    }
}
#pragma warning restore 1591
