#pragma checksum "D:\13.AZURE-PROJECT\research\DoAn\CoffeeShopMangement\Views\Shared\_FooterPartialView.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8a78d2e6876113936d565eaebf79921b9f216cffdaf73e3a944b5ebcf8915ae8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartialView), @"mvc.1.0.view", @"/Views/Shared/_FooterPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8a78d2e6876113936d565eaebf79921b9f216cffdaf73e3a944b5ebcf8915ae8", @"/Views/Shared/_FooterPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f5d773c2d1227f59357877e38fb25d0d30de662f6ca8a55486ea33a868cced0c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__FooterPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/logo/dark.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("widget-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""footer-area"">
    <div class=""footer-top section-space-y-axis-100 text-black"" data-bg-color=""#e5ddcc"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-6"">
                    <div class=""widget-item"">
                        <div class=""footer-logo pb-4"">
                            <a href=""index.html"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a78d2e6876113936d565eaebf79921b9f216cffdaf73e3a944b5ebcf8915ae85473", async() => {
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
            WriteLiteral(@"
                            </a>
                        </div>
                        <p class=""short-desc mb-2"">Cà phê – Giải quyết mọi khó khăn của bạn. </p>
                        <div class=""widget-contact-info pb-6"">
                            <ul>
                                <li>
                                    <i class=""pe-7s-map-marker""></i>
                                    Số 3 Cầu Giấy, Đống Đa, Hà Nội
                                </li>
                                <li>
                                    <i class=""pe-7s-mail""></i>
                                    <a href=""mailto://info@example.com"">vuongquancoffee.com</a>
                                </li>
                            </ul>
                        </div>
");
            WriteLiteral(@"                    </div>
                </div>
                <div class=""col-lg-2 offset-lg-1 col-md-6 pt-10 pt-lg-0"">
                    <div class=""widget-item"">
                        <h3 class=""widget-title mb-5"">Về chúng tôi</h3>
                        <ul class=""widget-list-item"">
                            <li>
                                <a href=""javascript:void(0)"">Giới thiệu</a>
                            </li>
");
            WriteLiteral(@"                            <li>
                                <a href=""javascript:void(0)"">Giá trị cốt lõi</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Cơ hội nghề nghiệp</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Khuyến mại</a>
                            </li>
");
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
                <div class=""col-lg-2 offset-lg-1 col-md-6 pt-10 pt-lg-0"">
                    <div class=""widget-item"">
                        <h3 class=""widget-title mb-5"">My Account</h3>
                        <ul class=""widget-list-item"">
                            <li>
                                <a href=""javascript:void(0)"">Tài khoản</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Kiểm tra đơn hàng</a>
                            </li>
");
            WriteLiteral(@"                            <li>
                                <a href=""javascript:void(0)"">Danh sách yêu thích</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Chính sách sử dụng</a>
                            </li>
");
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 pt-10 pt-lg-0"">
                    <div class=""widget-item"">
                        <h3 class=""widget-title mb-5"">Phản hồi</h3>
                        <p class=""short-desc"">Chúc quý khách hàng có trải nghiệm mua hàng thật hài lòng.</p>
                    </div>
                    <div class=""widget-form-area"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a78d2e6876113936d565eaebf79921b9f216cffdaf73e3a944b5ebcf8915ae89918", async() => {
                WriteLiteral(@"
                            <input class=""input-field"" type=""email"" autocomplete=""off"" placeholder=""Your Email"">
                            <div class=""button-wrap pt-5"">
                                <button class=""btn btn-custom-size btn-primary btn-secondary-hover rounded-0"" id=""mc-submit"">Send Mail</button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
    <div class=""footer-bottom py-3"" data-bg-color=""#bac34e"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""copyright"">
                        <span class=""copyright-text text-white"">VuongAnhQuan-201205542-CNTT2K61 ");
            WriteLiteral("   ");
            WriteLiteral("</a> </span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
