#pragma checksum "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Checkout\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43ab1c8373e63d13a012947dce1d4be249a01dfdcc505d5063e5d6cca90a621c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"43ab1c8373e63d13a012947dce1d4be249a01dfdcc505d5063e5d6cca90a621c", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f5d773c2d1227f59357877e38fb25d0d30de662f6ca8a55486ea33a868cced0c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeShopMangement.ModelViews.MuaHangVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Họ và Tên"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Số điện thoại"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Địa chỉ nhận hàng"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Checkout\Index.cshtml"
  
    ViewData["Title"] = "Mua hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<CoffeeShopMangement.ModelViews.CartItem> Carts = ViewBag.GioHang;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <main class=""main-content"">
        <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""/assets/images/banner/2-1-1920x523.jpg"">
            <div class=""container h-100"">
                <div class=""row h-100"">
                    <div class=""col-lg-12"">
                        <div class=""breadcrumb-item"">
                            <h2 class=""breadcrumb-heading"">THÔNG TIN MUA HÀNG</h2>
                            <ul>
                                <li>
                                    <a href=""/"">Trang chủ <i class=""pe-7s-angle-right""></i></a>
                                </li>
                                <li>THÔNG TIN MUA HÀNG</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""checkout-area section-space-y-axis-100"">
            <div class=""container"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43ab1c8373e63d13a012947dce1d4be249a01dfdcc505d5063e5d6cca90a621c7161", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "43ab1c8373e63d13a012947dce1d4be249a01dfdcc505d5063e5d6cca90a621c7463", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 28 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Checkout\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

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
                    <div class=""row"">
                        <div class=""col-lg-6 col-12"">

                            <div class=""checkbox-form"">
                                <h3>THÔNG TIN ĐƠN HÀNG</h3>
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""checkout-form-list"">
                                            <label>Họ và Tên</label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "43ab1c8373e63d13a012947dce1d4be249a01dfdcc505d5063e5d6cca90a621c9824", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 38 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Checkout\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FullName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                                    <div class=""col-md-12"">
                                        <div class=""checkout-form-list"">
                                            <label>Số điện thoại <span class=""required"">*</span></label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "43ab1c8373e63d13a012947dce1d4be249a01dfdcc505d5063e5d6cca90a621c12023", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 44 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Checkout\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Phone);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                                    <div class=""col-md-12"">
                                        <div class=""checkout-form-list"">
                                            <label>Địa chỉ nhận hàng <span class=""required"">*</span></label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "43ab1c8373e63d13a012947dce1d4be249a01dfdcc505d5063e5d6cca90a621c14224", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 50 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Checkout\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Address);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                        </div>
                        <div class=""col-lg-6 col-12"">
                            <div class=""your-order"">
                                <h3>THÔNG TIN ĐƠN HÀNG</h3>
                                <div class=""your-order-table table-responsive"">
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th class=""cart-product-name"">SẢN PHẨM</th>
                                                <th class=""cart-product-total"">THÀNH TIỀN</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 68 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Checkout\Index.cshtml"
                                         if (Carts.Count() > 0)
                                        {
                                            foreach (var item in Carts)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <tr class=\"cart_item\">\r\n                                                            <td class=\"cart-product-name\">\r\n                                                        ");
#nullable restore
#line 74 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Checkout\Index.cshtml"
                                                   Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("<strong class=\"product-quantity\">\r\n                                                                    × ");
#nullable restore
#line 75 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Checkout\Index.cshtml"
                                                                 Write(item.amount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                </strong>
                                                            </td>
                                                            <td class=""cart-product-total""><span class=""amount"">");
#nullable restore
#line 78 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Checkout\Index.cshtml"
                                                                                                           Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span></td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 80 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Checkout\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                    </tbody>
                                    <tfoot>
                                        <tr class=""order-total"">
                                            <th>TỔNG ĐƠN HÀNG</th>
                                            <td><strong><span class=""amount"">");
#nullable restore
#line 88 "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Checkout\Index.cshtml"
                                                                        Write(Carts.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" VNĐ</span></strong></td>
                                        </tr>
                                    </tfoot>
                                </table>
                            </div>
                            <h5 style=""color:red"">Vui lòng chọn hình thức thanh toán</h5>
                            <div class=""payment-method"">
                                <div class=""payment-accordion"">
                                    <div id=""accordion"">
                                        <div class=""card"">
                                            <div class=""card-header"" id=""#payment-1"">
                                                <h5 class=""panel-title"">
                                                    <a href=""javascript:void(0)""");
                BeginWriteAttribute("class", " class=\"", 5897, "\"", 5905, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-bs-toggle=""collapse"" data-bs-target=""#collapseOne"" aria-expanded=""true"">
                                                        Thanh toán khi giao hàng (COD)
                                                    </a>
                                                </h5>
                                            </div>
                                            <div id=""collapseOne"" class=""collapse show"" data-bs-parent=""#accordion"">
                                                <div class=""card-body"">
                                                    <p>
                                                        Khách hàng sẽ thanh toán khi nhận hàng
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""card"">
                                            <div class=""card-header"" id=""");
                WriteLiteral(@"#payment-2"">
                                                <h5 class=""panel-title"">
                                                    <a href=""javascript:void(0)"" class=""collapsed"" data-bs-toggle=""collapse"" data-bs-target=""#collapseTwo"" aria-expanded=""false"">
                                                        Chuyển khoản qua ngân hàng
                                                    </a>
                                                </h5>
                                            </div>
                                            <div id=""collapseTwo"" class=""collapse"" data-bs-parent=""#accordion"">
                                                <div class=""card-body"">
                                                    <p>
                                                        Thông tin tài khoản ngân hàng
                                                    </p>
                                                    <p>Chủ tài khoản: Vương Anh Quân</p>
                              ");
                WriteLiteral(@"                      <p>Số tài khoản: 19036890689014 - Ngân hàng Techcombank</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""card"">
                                            <div class=""card-header"" id=""#payment-3"">
                                                <h5 class=""panel-title"">
                                                    <a href=""javascript:void(0)"" class=""collapsed"" data-bs-toggle=""collapse"" data-bs-target=""#collapseThree"" aria-expanded=""false"">
                                                        Thanh toán qua MOMO
                                                    </a>
                                                </h5>
                                            </div>
                                            <div id=""collapseThree"" class=""collapse"" data-bs-parent=""#accordion"">
                          ");
                WriteLiteral(@"                      <div class=""card-body"">
                                                    <p>Thông tin MOMO</p>
                                                    <p>Chủ tài khoản: Vương Anh Quân</p>
                                                    <p>Số điện thoại: 0392598586</p>

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""order-button-payment"">
                                        <input value=""XÁC NHẬN ĐẶT HÀNG"" type=""submit"">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeShopMangement.ModelViews.MuaHangVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
