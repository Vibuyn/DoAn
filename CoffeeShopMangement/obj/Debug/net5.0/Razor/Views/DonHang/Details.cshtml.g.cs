#pragma checksum "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adc094f97845530dab2d6fce1eb2404436ad036c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonHang_Details), @"mvc.1.0.view", @"/Views/DonHang/Details.cshtml")]
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
#line 1 "D:\DoAn\DoAn\CoffeeShopMangement\Views\_ViewImports.cshtml"
using CoffeeShopMangement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAn\DoAn\CoffeeShopMangement\Views\_ViewImports.cshtml"
using CoffeeShopMangement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adc094f97845530dab2d6fce1eb2404436ad036c", @"/Views/DonHang/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1fbff6ed3fb2df6caccf6b3bc2e967120906a6a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DonHang_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeShopMangement.ModelViews.XemDonHang>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
  
    var total = Model.ChiTietDonHang.Sum(x => x.TotalMoney).Value.ToString("#,##0");

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Thông tin đơn hàng: #");
#nullable restore
#line 5 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
                    Write(Model.DonHang.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br />\r\n<p>Ngày đặt hàng: ");
#nullable restore
#line 7 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
             Write(Model.DonHang.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Trạng thái đơn hàng: ");
#nullable restore
#line 8 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
                   Write(Model.DonHang.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Tổng giá trị đơn hàng: <strong> ");
#nullable restore
#line 9 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
                              Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</strong></p>\r\n<p>Ngày giao hàng: ");
#nullable restore
#line 10 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
              Write(Model.DonHang.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

<div class=""table-responsive"">
    <table class=""table table-bordered table-hover"">
        <tbody>
            <tr>
                <th>#</th>
                <th>Sản phẩm</th>
                <th>Số lượng</th>
                <th>Đơn giá</th>
                <th>Thành tiền</th>
            </tr>

");
#nullable restore
#line 23 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
             foreach (var item in Model.ChiTietDonHang)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
                   Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
                   Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
                   Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
                   Write(item.Product.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
                   Write(item.TotalMoney.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ </td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "D:\DoAn\DoAn\CoffeeShopMangement\Views\DonHang\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeShopMangement.ModelViews.XemDonHang> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
