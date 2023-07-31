#pragma checksum "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "505018569e3e40c9a2d327d35362d86b85b3cc66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_WishList), @"mvc.1.0.view", @"/Views/Sales/WishList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"505018569e3e40c9a2d327d35362d86b85b3cc66", @"/Views/Sales/WishList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986f9477a1b535c92b3f32da28b3e1ee3bcdb34e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_WishList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PoojaStores.Models.ModelClasses.ProductDisplayModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<main class=""main"">
    <div class=""page-header"">
        <div class=""container d-flex flex-column align-items-center"">
            <nav aria-label=""breadcrumb"" class=""breadcrumb-nav"">
                <div class=""container"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "505018569e3e40c9a2d327d35362d86b85b3cc665178", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">
                            My Wishlist
                        </li>
                    </ol>
                </div>
            </nav>

            <h1>My Wishlist</h1>
        </div>
    </div>

    <div class=""container"">
        <div class=""wishlist-title"">
            <h2 class=""p-2"">My wishlist</h2>
        </div>
        <div class=""wishlist-table-container"">
            <table class=""table table-wishlist mb-0"">
                <thead>
                    <tr>
                        <th class=""thumbnail-col""></th>
                        <th class=""product-col"">Product</th>
                        <th class=""price-col"">Price</th>
                        <th class=""status-col"">Stock Status</th>
                        <th class=""action-col"">Actions</th>
                        <th class=""action-col"">Remove</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 38 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml"
                     foreach (var p in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"product-row\" id=\"row\">\n                        <td>\n                            <figure class=\"product-image-container\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "505018569e3e40c9a2d327d35362d86b85b3cc667701", async() => {
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "505018569e3e40c9a2d327d35362d86b85b3cc667988", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1787, "~/ProductImages/", 1787, 16, true);
#nullable restore
#line 44 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml"
AddHtmlAttributeValue("", 1803, p.ProductMainImage1, 1803, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1679, "~/Home/ProductDetails?id=", 1679, 25, true);
#nullable restore
#line 43 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml"
AddHtmlAttributeValue("", 1704, p.ProductId, 1704, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                <a href=""#"" class=""btn-remove icon-cancel"" title=""Remove Product""></a>
                            </figure>
                        </td>
                        <td>
                            <h5 class=""product-title"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "505018569e3e40c9a2d327d35362d86b85b3cc6611460", async() => {
#nullable restore
#line 52 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml"
                                                                           Write(p.ProductTitle);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2198, "~/Home/ProductDetails?id=", 2198, 25, true);
#nullable restore
#line 52 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml"
AddHtmlAttributeValue("", 2223, p.ProductId, 2223, 12, false);

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
            WriteLiteral("\n                            </h5>\n                        </td>\n                        <td class=\"price-box\">");
#nullable restore
#line 55 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml"
                                         Write(p.SellingPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n");
#nullable restore
#line 57 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml"
                             if (p.QtyAvailable > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"stock-status\">In stock</span>\n");
#nullable restore
#line 60 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"stock-status\">Out Of Stock</span>\n");
#nullable restore
#line 64 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\n                        <td class=\"action\">                           \n                         <button class=\"btn btn-dark btn-shop\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2936, "\"", 2967, 3);
            WriteAttributeValue("", 2946, "Addcart(", 2946, 8, true);
#nullable restore
#line 67 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml"
WriteAttributeValue("", 2954, p.ProductId, 2954, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2966, ")", 2966, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                ADD TO CART\n                            </button>\n                        </td>\n                        <td>\n                            <a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3167, "\"", 3198, 3);
            WriteAttributeValue("", 3177, "ShowDelete(", 3177, 11, true);
#nullable restore
#line 72 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml"
WriteAttributeValue("", 3188, p.CartId, 3188, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3197, ")", 3197, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                <button type=""button"" class=""btn btn-danger btn-sm"">
                                    <i class=""fa fa-trash""></i>
                                </button>
                            </a>
                        </td>
                    </tr>
");
#nullable restore
#line 79 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/WishList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                   
                </tbody>
            </table><br /><br /><br /><br />
        </div><!-- End .cart-table-container -->
    </div><!-- End .container -->
</main>

<script>
    function Addcart(id) {
        $.ajax({
            url: GlobalUrl + ""Sales/SaveCart?id=""+id,
            type: 'post',
            data :'{}',
            success: function (result) {
                if (result.result.statusCode == 1) {
                    window.location.href = window.location.href
                    $(""#row"").hide();
                } else {
                    toastr['error'](result.result.statusMessage);
                }
            }

        })
    }
    function ShowDelete(id) {
        swal(""Are you sure?"", {
            buttons: {
                yes: {
                    val: 'yes',
                    text: 'yes'
                },
                no: {
                    val: 'no',
                    text: 'no'
                }

            }
        }).then((value) => {
          ");
            WriteLiteral(@"  if (value == 'yes') {
                $.ajax({
                    url: GlobalUrl + 'Sales/DeleteWishList?id=' + id,
                    type: 'post',
                    data: '{}',

                    success: function (result) {
                        if (result.result.statusCode == 1) {
                            toastr['success'](""Successfully Deleted!"");
                            window.location.href = window.location.href;
                        }
                    }
                });
            }
            else {
                toastr['error'](""Delete Cancelled"");
            }

        })

    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PoojaStores.Models.ModelClasses.ProductDisplayModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
