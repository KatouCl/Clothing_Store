#pragma checksum "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37c8828042320aa3f6945d3ce68c9d2ed20bc1a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Chart_Order), @"mvc.1.0.view", @"/Areas/Admin/Views/Chart/Order.cshtml")]
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
#line 1 "M:\KataStore\KS.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using KS.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "M:\KataStore\KS.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using KS.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "M:\KataStore\KS.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using KS.WEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "M:\KataStore\KS.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37c8828042320aa3f6945d3ce68c9d2ed20bc1a3", @"/Areas/Admin/Views/Chart/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a3ffd2718f35aba8b71860d98af4838f2ae35c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Chart_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KS.ViewModels.Order.OrderListVm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
  
    ViewBag.Title = "Заказы";
    Layout = "_AdminLayout";

	decimal SumProduct = 0.0m;
	int QuantityProduct = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""tab"">
                <ul class=""nav nav-tabs"" role=""tablist"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" href=""#tab-1"" data-bs-toggle=""tab"" role=""tab"" aria-selected=""true"">Заказы</a>
                    </li>
");
            WriteLiteral(@"                </ul>
                <div class=""tab-content"">
                    <div class=""tab-pane active"" id=""tab-1"" role=""tabpanel"">
                        <div class=""row pt-4"">
                            <div class=""col-md-12"">


                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37c8828042320aa3f6945d3ce68c9d2ed20bc1a36523", async() => {
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""mb-3 col-md-6"">
                                            <label class=""form-label"">Начало переода</label>
                                            <input name=""firstTime"" type=""date"" id=""start"" class=""form-control flatpickr-minimum flatpickr-input"" placeholder=""Начало переода""");
                BeginWriteAttribute("value", "\r\n                                                   value=\"", 1516, "\"", 1594, 1);
#nullable restore
#line 34 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
WriteAttributeValue("", 1576, ViewBag.firstTime, 1576, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                                   min=""2021-01-01"" max=""2045-12-31"">
                                        </div>
                                        <div class=""mb-3 col-md-4"">
                                            <label class=""form-label"">Конец переода</label>
                                            <input name=""lastTime"" type=""date"" id=""start"" class=""form-control flatpickr-minimum flatpickr-input"" placeholder=""Конец переода""");
                BeginWriteAttribute("value", "\r\n                                                   value=\"", 2066, "\"", 2143, 1);
#nullable restore
#line 40 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
WriteAttributeValue("", 2126, ViewBag.lastTime, 2126, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                                   min=""2021-01-01"" max=""2045-12-31"">
                                        </div>
                                        <div class=""mb-3 col-md-2"">
                                            <label class=""form-label"">ᅠ ᅠᅠ ᅠᅠ ᅠ</label>
                                            <button class=""btn btn-primary"" type=""submit"">Применить</button>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                <hr>\r\n\r\n                                <!-- Output -->\r\n");
#nullable restore
#line 53 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                 if (Model.Any())
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""card-body"">
                                        <table class=""table table-striped"" style=""width:100%"">
                                            <thead>
                                            <tr>
                                                <th>Клиент</th>
                                                <th>Количество</th>
                                                <th>Сумма</th>
                                                <th>Дата создания</th>
                                                <th></th>
                                            </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 67 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                             foreach (var order in Model)
                                            {
	                                            SumProduct += order.Price;
	                                            QuantityProduct += order.QuantityProduct;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>");
#nullable restore
#line 72 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                                   Write(order.Customer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 73 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                                   Write(order.QuantityProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>₽ ");
#nullable restore
#line 74 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                                     Write(order.Price.ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 75 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                                   Write(order.CreationDate.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37c8828042320aa3f6945d3ce68c9d2ed20bc1a313830", async() => {
                WriteLiteral("Подробнее");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                                                                                                                    WriteLiteral(order.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 80 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                             if (QuantityProduct != 0 && SumProduct != 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td colspan=\"1\"></td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td colspan=\"1\">Общее количество товаров: ");
#nullable restore
#line 85 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                                                                         Write(QuantityProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td colspan=\"3\">Общая сумма товаров: ₽ ");
#nullable restore
#line 86 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                                                                      Write(SumProduct.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 88 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </tbody>\r\n                                        </table>\r\n                                    </div>\r\n");
#nullable restore
#line 92 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"text-center\">Заказов нет.</div>\r\n");
#nullable restore
#line 96 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n\t$.getJSON(\"/Chart/Order\", function(data) {\r\n\t  document.addEventListener(\"DOMContentLoaded\", function() {\r\n\t  \t\tvar Price = ");
#nullable restore
#line 133 "M:\KataStore\KS.WEB\Areas\Admin\Views\Chart\Order.cshtml"
                     Write(Html.Raw(Json.Serialize(ViewBag.Price)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
	  		var Qts = []
	  		for (var i =0; i < data.length; i++){
	  			Price.push(data[i]);
	  			Qts.push(data[i]);
	  			}
      			// Line chart
      			new Chart(document.getElementById(""chartjs-line""), {
      				type: ""line"",
      				data: {
      					labels: [""Jan"", ""Feb"", ""Mar"", ""Apr"", ""May"", ""Jun"", ""Jul"", ""Aug"", ""Sep"", ""Oct"", ""Nov"", ""Dec""],
      					datasets: [{
      						label: ""Продаж (₽)"",
      						fill: true,
      						backgroundColor: ""transparent"",
      						borderColor: window.theme.primary,
      						data: Price
      					}]
      				},
      				options: {
      					maintainAspectRatio: false,
      					legend: {
      						display: false
      					},
      					tooltips: {
      						intersect: false
      					},
      					hover: {
      						intersect: true
      					},
      					plugins: {
      						filler: {
      							propagate: false
      						}
      					},
      					scales: {
      						xAxes: [{
      							r");
            WriteLiteral(@"everse: true,
      							gridLines: {
      								color: ""rgba(0,0,0,0.05)""
      							}
      						}],
      						yAxes: [{
      							ticks: {
      								stepSize: 500
      							},
      							display: true,
      							borderDash: [5, 5],
      							gridLines: {
      								color: ""rgba(0,0,0,0)"",
      								fontColor: ""#fff""
      							}
      						}]
      					}
      				}
      			});
      		});
	});
		
	</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> _signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KS.ViewModels.Order.OrderListVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
