#pragma checksum "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b0df0c96963e39d488bd0397d8c87c53a610b42645879e4a5d49e69df0f06735"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderCart_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderCart/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\_ViewImports.cshtml"
using CoffeeShopMangement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\_ViewImports.cshtml"
using CoffeeShopMangement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b0df0c96963e39d488bd0397d8c87c53a610b42645879e4a5d49e69df0f06735", @"/Views/Shared/Components/HeaderCart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f5d773c2d1227f59357877e38fb25d0d30de662f6ca8a55486ea33a868cced0c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_HeaderCart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoffeeShopMangement.ModelViews.CartItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""harmic-offcanvas-body"">
        <div class=""minicart-content"">
            <div class=""minicart-heading"">
                <h4 class=""mb-0"">Giỏ hàng</h4>
                <a href=""#"" class=""button-close""><i class=""pe-7s-close""></i></a>
            </div>
            <ul class=""minicart-list"">
");
#nullable restore
#line 11 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
                 foreach (var item in Model)
                {
                    string url = $"/{item.product.Alias}-{item.product.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"minicart-product\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 646, "\"", 657, 1);
#nullable restore
#line 15 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 653, url, 653, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-item_img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b0df0c96963e39d488bd0397d8c87c53a610b42645879e4a5d49e69df0f067355242", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 741, "~/images/products/", 741, 18, true);
#nullable restore
#line 16 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
AddHtmlAttributeValue("", 759, item.product.Thumb, 759, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
AddHtmlAttributeValue("", 785, item.product.ProductName, 785, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </a>\r\n                        <div class=\"product-item_content\">\r\n                            <a class=\"product-item_title\"");
            BeginWriteAttribute("href", " href=\"", 961, "\"", 972, 1);
#nullable restore
#line 19 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 968, url, 968, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                 Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <span class=\"product-item_quantity\">");
#nullable restore
#line 20 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                           Write(item.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 20 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                          Write(item.product.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 23 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"minicart-item_total\">\r\n            <span>Tổng tiền</span>\r\n            <span class=\"ammount\">");
#nullable restore
#line 28 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
                             Write(Model.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n        </div>\r\n        <div class=\"group-btn_wrap d-grid gap-2\">\r\n            <a href=\"/cart.html\" class=\"btn btn-secondary btn-primary-hover\"> Xem giỏ hàng</a>\r\n");
#nullable restore
#line 32 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Thanh toán</a>\r\n");
#nullable restore
#line 35 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/dang-nhap.html?returnUrl=/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Thanh toán</a>\r\n");
#nullable restore
#line 39 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 42 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <div class=\"harmic-offcanvas-body\">\r\n        <div class=\"minicart-content\">\r\n            <div class=\"minicart-heading\">\r\n                <h4 class=\"mb-0\">Giỏ hàng rỗng</h4>\r\n            </div>\r\n        </div>\r\n   </div>\r\n");
#nullable restore
#line 52 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\Components\HeaderCart\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoffeeShopMangement.ModelViews.CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
