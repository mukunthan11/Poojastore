#pragma checksum "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/DetailCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93a452adadebdb854bce8f1ffacbb2f594c21cbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_DetailCategory), @"mvc.1.0.view", @"/Views/Master/DetailCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a452adadebdb854bce8f1ffacbb2f594c21cbf", @"/Views/Master/DetailCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986f9477a1b535c92b3f32da28b3e1ee3bcdb34e", @"/Views/_ViewImports.cshtml")]
    public class Views_Master_DetailCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoojaStores.Models.ModelClasses.DetailCategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Master/DetailCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Master/DetailCategoryData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/DetailCategory.cshtml"
  
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
            <h1>All Deatil Categories</h1>
            <small>Master Data management.</small>
        </div>
    </section>
    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
            <div class=""col-lg-12 pinpin"">
                <div class=""card"" data-sortable=""true"">
                    <div class=""card-header"">
                        <div class=""row"">
                            <div class=""col-md-9"">
                                <div class=""card-title custom_title"">
                                    <div class=""row"">
                                        <h4 class=""col-md-4"">Select Categories</h4>
                                        <h4 class=""col-md-4"">Select SubCategories</h4>
                                    </div>
          ");
            WriteLiteral("                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93a452adadebdb854bce8f1ffacbb2f594c21cbf6231", async() => {
                WriteLiteral("\n                                        <div class=\"row\">\n                                            <div class=\"col-md-4\">\n                                                ");
#nullable restore
#line 34 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/DetailCategory.cshtml"
                                           Write(Html.DropDownList("catId", new SelectList(Model.catDrops, "CategoryId", "CategoryName",ViewBag.catId), new { @id = "catId", @class = "form-control", @onChange = "GetSubcats()" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                            </div>\n                                            <div class=\"col-md-4\">\n                                                ");
#nullable restore
#line 37 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/DetailCategory.cshtml"
                                           Write(Html.DropDownList("subcatId", new SelectList(Model.subCatDrops, "SubCategoryId", "SubCategoryName", ViewBag.subCatId), new { @id = "subcatId", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </div>

                                            <div class=""col-md-3"">
                                                <button type=""submit"" class=""btn btn-primary"">Search</button>
                                            </div>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                            <div class=""col-md-3"">
                                <div class=""btn-group float-right"" role=""group"">
                                    <div class=""buttonexport"" id=""buttonlist"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93a452adadebdb854bce8f1ffacbb2f594c21cbf9717", async() => {
                WriteLiteral("\n                                            <i class=\"fa fa-plus\"></i> Add New\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                    <div class=""card-body"">
                        <div id=""no-more-tables"">
                            <table class=""col-md-12 table-bordered table-striped table-condensed cf"">
                                <thead class=""cf"">
                                    <tr>
                                        <th>S.no</th>
                                        <th>DetailCategory Name</th>

                                        <th>Edit</th>
                                        <th>Delete</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 71 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/DetailCategory.cshtml"
                                     foreach (var u in Model.DetailedDetails)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td data-title=\"S.no\">");
#nullable restore
#line 74 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/DetailCategory.cshtml"
                                                              Write(rCnt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td data-title=\"Category Name\">");
#nullable restore
#line 75 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/DetailCategory.cshtml"
                                                                      Write(u.DetailCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                                            <td data-title=\"Edit\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93a452adadebdb854bce8f1ffacbb2f594c21cbf12955", async() => {
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4032, "~/Master/DetailCategoryData?id=", 4032, 31, true);
#nullable restore
#line 77 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/DetailCategory.cshtml"
AddHtmlAttributeValue("", 4063, u.DetailCategoryId, 4063, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                                            <td data-title=\"Edit\">\n                                                <a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4294, "\"", 4335, 3);
            WriteAttributeValue("", 4304, "ShowDelete(", 4304, 11, true);
#nullable restore
#line 79 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/DetailCategory.cshtml"
WriteAttributeValue("", 4315, u.DetailCategoryId, 4315, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4334, ")", 4334, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <button type=""button"" class=""btn btn-danger btn-sm"" data-toggle=""modal"">
                                                        <i class=""fa fa-trash""></i>
                                                    </button>
                                                </a>
                                            </td>
                                        </tr>
");
#nullable restore
#line 86 "/home/ubuntu/poojastores/ppojastores/trunk/PoojaStores/Views/Master/DetailCategory.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </section>
    <!-- /.content -->
</div>

<script>
    function ShowDelete(id) {
        swal(""Are you sure?"", {
            buttons: {
                yes: {
                    text: ""Yes"",
                    value: ""yes""
                },
                no: {
                    text: ""No"",
                    value: ""no""
                }
            }
        }).then((value) => {
            if (value === ""yes"") {
                $.ajax({
                    url: GlobalUrl + ""Master/DeleteDetailCategory?id="" + id,
                    type: 'post',
                    data: '{}',
                    success: function (result) {
                        toastr[""success""](""Successuflly deleted!"");
                        window.location.href = window.location.href;
                    }
                });
    ");
            WriteLiteral(@"        }
            else {
                toastr[""error""](""Delete cancelled!"")
            }
            return false;
        });
    }
    function GetSubcats() {
        var catId = $('#catId option:selected').val();
        $.ajax({
            url: GlobalUrl + ""Common/GetAllSubCats?catId="" + catId,
            type: 'post',
            data: '{}',
            success: function (res) {
                var r = res.result.length;
                var row = '';

                if (r > 0) {
                    for (var i = 0; i < r; i++) {
                        row = row + '<option value=""' + res.result[i].subCategoryId + '"">' + res.result[i].subCategoryName + '</option>';
                    }
                }
                $('#subcatId').html('');
                $('#subcatId').html(row);
                
            }
        });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoojaStores.Models.ModelClasses.DetailCategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
