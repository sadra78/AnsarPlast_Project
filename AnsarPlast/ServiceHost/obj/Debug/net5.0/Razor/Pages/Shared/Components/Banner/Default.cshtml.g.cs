#pragma checksum "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\Banner\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f09a1cf29af9c0302b64ccdeffcca7fd65194db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Banner.Pages_Shared_Components_Banner_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Banner/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Banner
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
#line 1 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\Banner\Default.cshtml"
using Microsoft.CodeAnalysis.FlowAnalysis;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f09a1cf29af9c0302b64ccdeffcca7fd65194db", @"/Pages/Shared/Components/Banner/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d277691ff97276995da980fa12d1415fd1863d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Banner_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_AnsarPlastQuery.Contracts.Banner.BannerQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("800"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<section class=""ec-banner section section-space-p"">
    <h2 class=""d-none"">Banner</h2>
    <div class=""container"">
        <!-- ec Banners Start -->
        <div class=""ec-banner-inner"">
            <!--ec Banner Start -->
            <div class=""ec-banner-block ec-banner-block-2"">
                <div class=""row"">
");
#nullable restore
#line 12 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\Banner\Default.cshtml"
                     foreach (var banner in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"banner-block col-lg-6 col-md-12 margin-b-30\" data-animation=\"slideInRight\">\r\n                            <div class=\"bnr-overlay\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f09a1cf29af9c0302b64ccdeffcca7fd65194db4912", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 724, "~/ProductPictures/", 724, 18, true);
#nullable restore
#line 16 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\Banner\Default.cshtml"
AddHtmlAttributeValue("", 742, banner.Picture, 742, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\Banner\Default.cshtml"
AddHtmlAttributeValue("", 764, banner.PictureAlt, 764, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\Banner\Default.cshtml"
AddHtmlAttributeValue("", 791, banner.PictureTitle, 791, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"banner-text\">\r\n                                    <span class=\"ec-banner-stitle\">");
#nullable restore
#line 18 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\Banner\Default.cshtml"
                                                              Write(banner.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"ec-banner-title\">");
#nullable restore
#line 19 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\Banner\Default.cshtml"
                                                             Write(banner.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 22 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\Banner\Default.cshtml"
                                 if (!string.IsNullOrWhiteSpace(@banner.BtnText))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"banner-content\">\r\n                                        <span class=\"ec-banner-btn\"><a");
            BeginWriteAttribute("href", " href=\"", 1460, "\"", 1479, 1);
#nullable restore
#line 25 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\Banner\Default.cshtml"
WriteAttributeValue("", 1467, banner.Link, 1467, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">ارسال</a></span>\r\n                                    </div>\r\n");
#nullable restore
#line 27 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\Banner\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 31 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\Banner\Default.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!-- ec Banner End -->\r\n            </div>\r\n            <!-- ec Banners End -->\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_AnsarPlastQuery.Contracts.Banner.BannerQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591