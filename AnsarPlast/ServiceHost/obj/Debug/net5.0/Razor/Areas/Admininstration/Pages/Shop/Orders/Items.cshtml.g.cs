#pragma checksum "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Shop\Orders\Items.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be721f95f1e0f08ba60e68dd763a176e7afcf7c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Areas.Administration.Pages.Shop.Orders.Areas_Admininstration_Pages_Shop_Orders_Items), @"mvc.1.0.view", @"/Areas/Admininstration/Pages/Shop/Orders/Items.cshtml")]
namespace ServiceHost.Areas.Administration.Pages.Shop.Orders
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
#line 1 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Shop\Orders\Items.cshtml"
using _0_Framework.Application;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be721f95f1e0f08ba60e68dd763a176e7afcf7c4", @"/Areas/Admininstration/Pages/Shop/Orders/Items.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e25ad8efa72e2da71cf3335257970b7e2689da", @"/Areas/Admininstration/Pages/_ViewImports.cshtml")]
    public class Areas_Admininstration_Pages_Shop_Orders_Items : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShopManagement.Application.Contracts.Order.OrderItemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""modal-header"">
    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
    <h4 class=""modal-title"">آیتم های سفارش</h4>
</div>

<div class=""modal-body"">
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>محصول</th>
                <th>تعداد</th>
                <th>قیمت واحد</th>
                <th>درصد تخفیف</th>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Shop\Orders\Items.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Shop\Orders\Items.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Shop\Orders\Items.cshtml"
                   Write(item.Product);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Shop\Orders\Items.cshtml"
                   Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Shop\Orders\Items.cshtml"
                   Write(item.UnitPrice.ToMoney());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Shop\Orders\Items.cshtml"
                   Write(item.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Shop\Orders\Items.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div class=\"modal-footer\">\r\n    <button type=\"button\" class=\"btn btn-default waves-effect\" data-dismiss=\"modal\">بستن</button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShopManagement.Application.Contracts.Order.OrderItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591