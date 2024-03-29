#pragma checksum "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "198edcabe931fd19c1a0b7ed55fa24ca507df626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Areas.Administration.Pages.Areas_Admininstration_Pages_Index), @"mvc.1.0.razor-page", @"/Areas/Admininstration/Pages/Index.cshtml")]
namespace ServiceHost.Areas.Administration.Pages
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
#line 2 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Index.cshtml"
using _01_AnsarPlastQuery.Contracts.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Index.cshtml"
using _01_AnsarPlastQuery.Contracts.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Index.cshtml"
using AccountManagement.Application.Contracts.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"198edcabe931fd19c1a0b7ed55fa24ca507df626", @"/Areas/Admininstration/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e25ad8efa72e2da71cf3335257970b7e2689da", @"/Areas/Admininstration/Pages/_ViewImports.cshtml")]
    public class Areas_Admininstration_Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 10 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Index.cshtml"
  
    ViewData["Title"] = "صفحه اصلی";
    var orderCount = _orderQuery.GetOrders().Count;
    var productCount = _productQuery.GetProductCount();
    var AccountCount = _accountApplication.GetAccounts().Count;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Page-Title -->
<div class=""row"">
    <div class=""col-sm-12"">
        <ol class=""breadcrumb pull-right"">
            <li><a>انصار پلاست</a></li>
            <li class=""active"">داشبورد</li>
        </ol>
    </div>
</div>

<!-- Start Widget -->
<div class=""row"">
    <div class=""col-md-6 col-sm-6 col-lg-3"">
        <div class=""mini-stat clearfix bx-shadow"">
            <span class=""mini-stat-icon bg-info""><i class=""ion-ios7-cart""></i></span>
            <div class=""mini-stat-info text-right text-muted"">
                <span class=""counter"">");
#nullable restore
#line 32 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Index.cshtml"
                                 Write(productCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                کل محصولات
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-sm-6 col-lg-3"">
        <div class=""mini-stat clearfix bx-shadow"">
            <span class=""mini-stat-icon bg-purple""><i class=""ionicon-list""></i></span>
            <div class=""mini-stat-info text-right text-muted"">
                کل سفارشات
                <span class=""counter"">");
#nullable restore
#line 42 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Index.cshtml"
                                 Write(orderCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>
    </div>

    <div class=""col-md-6 col-sm-6 col-lg-3"">
        <div class=""mini-stat clearfix bx-shadow"">
            <span class=""mini-stat-icon bg-success""><i class=""ion-eye""></i></span>
            <div class=""mini-stat-info text-right text-muted"">
                <span class=""counter"">0</span>
                میزان فروش
            </div>
        </div>
    </div>

    <div class=""col-md-6 col-sm-6 col-lg-3"">
        <div class=""mini-stat clearfix bx-shadow"">
            <span class=""mini-stat-icon bg-primary""><i class=""ion-android-contacts""></i></span>
            <div class=""mini-stat-info text-right text-muted"">
                کاربران وبسایت
                <span class=""counter"">");
#nullable restore
#line 62 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Index.cshtml"
                                 Write(AccountCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>
    </div>
</div>
<!-- End row-->


<!--<div class=""row"">
    <div class=""col-lg-8"">
        <div class=""portlet"">-->
            <!-- /portlet heading -->
            <!--<div class=""portlet-heading"">
                <h3 class=""portlet-title text-dark text-uppercase"">
                    Website Stats
                </h3>
                <div class=""portlet-widgets"">
                    <a href=""javascript:;"" data-toggle=""reload""><i class=""ion-refresh""></i></a>
                    <span class=""divider""></span>
                    <a data-toggle=""collapse"" data-parent=""#accordion1"" href=""#portlet1""><i class=""ion-minus-round""></i></a>
                    <span class=""divider""></span>
                    <a href=""#"" data-toggle=""remove""><i class=""ion-close-round""></i></a>
                </div>
                <div class=""clearfix""></div>
            </div>
            <div id=""portlet1"" class=""panel-collapse collapse in"">
                <div");
            WriteLiteral(@" class=""portlet-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div id=""website-stats"" style=""position: relative;height: 320px;""></div>
                            <div class=""row text-center m-t-30"">
                                <div class=""col-sm-4"">
                                    <h4 class=""counter"">86,956</h4>
                                    <small class=""text-muted""> Weekly Report</small>
                                </div>
                                <div class=""col-sm-4"">
                                    <h4 class=""counter"">86,69</h4>
                                    <small class=""text-muted"">Monthly Report</small>
                                </div>
                                <div class=""col-sm-4"">
                                    <h4 class=""counter"">948,16</h4>
                                    <small class=""text-muted"">Yearly Report</small>
                                <");
            WriteLiteral(@"/div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>--> <!-- /Portlet -->
    <!--</div>--> <!-- end col -->

    <!--<div class=""col-lg-4"">
        <div class=""portlet"">-->
            <!-- /portlet heading -->
            <!--<div class=""portlet-heading"">
                <h3 class=""portlet-title text-dark text-uppercase"">
                    Website Stats
                </h3>
                <div class=""portlet-widgets"">
                    <canvas id=""bar""></canvas>
                </div>
                <div class=""clearfix""></div>
            </div>
        </div>--> <!-- /Portlet -->
    <!--</div>--> <!-- end col -->
<!--</div>--> <!-- End row -->

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        const lineChartDiv = document.getElementById(\"line\");\r\n        const data = ");
#nullable restore
#line 133 "F:\Editable AnsarPlast\AnsarPlast10\Code\AnsarPlast\ServiceHost\Areas\Admininstration\Pages\Index.cshtml"
                Write(Html.Raw(JsonConvert.SerializeObject(Model.BarLineDataSet)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        const lineChart = new Chart(lineChartDiv,
            {
                type: ""line"",
                data: {
                    labels: [""مهر"", ""آبان"", ""آذر"", "" دی"", ""بهمن""],
                    datasets: data
                },
                options: {
                    elements: {
                        bar: {
                            borderWidth: 1
                        }
                    }
                }
            });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAccountApplication _accountApplication { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IProductQuery _productQuery { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOrderQuery _orderQuery { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Areas.Admininstration.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.Admininstration.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.Admininstration.Pages.IndexModel>)PageContext?.ViewData;
        public ServiceHost.Areas.Admininstration.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
