#pragma checksum "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\ProductCategory\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c4751077362f104e3c5bce8b327f382d8e98f33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.ProductCategory.Pages_Shared_Components_ProductCategory_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/ProductCategory/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.ProductCategory
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c4751077362f104e3c5bce8b327f382d8e98f33", @"/Pages/Shared/Components/ProductCategory/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d277691ff97276995da980fa12d1415fd1863d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_ProductCategory_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_AnsarPlastQuery.Contracts.ProductCategory.ProductCategoryQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"    <!--  category Section Start -->
<section class=""section ec-category-section ec-category-wrapper-1 section-space-p"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 text-center"">
                    <div class=""section-title"">
                        <h2 class=""ec-bg-title"">دسته بندی محصولات</h2>
                        <h2 class=""ec-title"">دسته بندی محصولات</h2>
                        <p class=""sub-title""> مشاهده برترین دسته بندی های ما </p>
                    </div>
                </div>
            </div>
            <div class=""row margin-minus-tb-15"">
                <div class=""ec_cat_slider"">
");
#nullable restore
#line 16 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"ec_cat_content\">\r\n                            <div class=\"ec_cat_inner\">\r\n                                <div class=\"ec-cat-image\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c4751077362f104e3c5bce8b327f382d8e98f335135", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1055, "~/ProductPictures/", 1055, 18, true);
#nullable restore
#line 21 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
AddHtmlAttributeValue("", 1073, item.Picture, 1073, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
AddHtmlAttributeValue("", 1093, item.PictureAlt, 1093, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
AddHtmlAttributeValue("", 1118, item.PictureTitle, 1118, 18, false);

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
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"ec-cat-desc\">\r\n                                    <span class=\"ec-section-btn\"><a");
            BeginWriteAttribute("href", " href=\"", 1331, "\"", 1348, 1);
#nullable restore
#line 24 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
WriteAttributeValue("", 1338, item.Slug, 1338, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-primary\">");
#nullable restore
#line 24 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
                                                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 28 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Pages\Shared\Components\ProductCategory\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n<!--category Section End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_AnsarPlastQuery.Contracts.ProductCategory.ProductCategoryQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
