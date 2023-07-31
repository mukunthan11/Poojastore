#pragma checksum "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41f1a476e62966373d20f4ac749a8645a22392af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_DispatchedOrderDetails), @"mvc.1.0.view", @"/Views/Order/DispatchedOrderDetails.cshtml")]
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
#line 1 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/_ViewImports.cshtml"
using PoojaStores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/_ViewImports.cshtml"
using PoojaStores.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f1a476e62966373d20f4ac749a8645a22392af", @"/Views/Order/DispatchedOrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986f9477a1b535c92b3f32da28b3e1ee3bcdb34e", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_DispatchedOrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoojaStores.Models.ModelClasses.OrderDetailPage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
  
    int rCnt = 1;
    Layout = "~/Views/Shared/AdminMaster.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""header-icon"">
            <i class=""fa fa-book""></i>
        </div>
        <div class=""header-title"">
            <h1>Dispatched Orders</h1>
            <small>Order management.</small>
        </div>
    </section>
    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
            <div class=""col-lg-12 pinpin"">
                <div class=""card"" data-sortable=""true"">
                    <div class=""card-header"">
                        <div class=""card-title custom_title"">
                            <h4>Dispatched Orders List</h4>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div id=""no-more-tables"">
                            <table class=""col-md-12 table-bordered table-striped table-condensed cf"">
                                <thead class=""cf"">
                        ");
            WriteLiteral(@"            <tr>
                                        <th>S.no</th>
                                        <th>OrderId</th>
                                        <th>Product Code</th>
                                        <th>Product</th>
                                        <th>No Of Items Ordered</th>
                                        <th>Dispatch Details</th>
                                        <th>Deliver</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 42 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
                                     foreach (var u in Model.odetails)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td data-title=\"S.no\">");
#nullable restore
#line 45 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
                                                          Write(rCnt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td data-title=\"Category Name\">");
#nullable restore
#line 46 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
                                                                  Write(u.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td data-title=\"Category Name\">");
#nullable restore
#line 47 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
                                                                  Write(u.ProductCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td data-title=\"Category Name\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "41f1a476e62966373d20f4ac749a8645a22392af7653", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2245, "~/ProductImages/", 2245, 16, true);
#nullable restore
#line 49 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
AddHtmlAttributeValue("", 2261, u.Image, 2261, 8, false);

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
            WriteLiteral("\n                                        </td>\n                                        <td data-title=\"Category Name\">");
#nullable restore
#line 51 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
                                                                  Write(u.NumberOfItems);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td data-title=\"Category Name\">\n                                            Dispatched Through :\n                                            ");
#nullable restore
#line 54 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
                                       Write(u.DispatchedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            <br />\n");
#nullable restore
#line 56 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
                                              
                                                DateTime co = Convert.ToDateTime(u.DispatchedOn);
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            Dispatched On :\n                                            ");
#nullable restore
#line 60 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
                                       Write(co.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            <br />\n                                            Dispatch Number :\n                                            ");
#nullable restore
#line 63 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
                                       Write(u.DispatchNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                            <td data-title=\"Dispatch\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f1a476e62966373d20f4ac749a8645a22392af11535", async() => {
                WriteLiteral("Deliver");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3306, "~/Order/DeliveryDetails?id=", 3306, 27, true);
#nullable restore
#line 65 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
AddHtmlAttributeValue("", 3333, u.PODetailId, 3333, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n\n                                        </tr>\n");
#nullable restore
#line 68 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Order/DispatchedOrderDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\n                            </table>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n\n    </section>\n    <!-- /.content -->\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoojaStores.Models.ModelClasses.OrderDetailPage> Html { get; private set; }
    }
}
#pragma warning restore 1591
