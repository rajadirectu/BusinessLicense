#pragma checksum "C:\Users\raja.bose\source\repos\Dollar\Dollar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b5de23ff4cb37f0f94f9f703438403e0899c6d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\raja.bose\source\repos\Dollar\Dollar\Views\_ViewImports.cshtml"
using Dollar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\raja.bose\source\repos\Dollar\Dollar\Views\_ViewImports.cshtml"
using Dollar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b5de23ff4cb37f0f94f9f703438403e0899c6d7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd8766676eca770ccef6b3356c837f90ab7ff9b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("businessLicense"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\raja.bose\source\repos\Dollar\Dollar\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Business License</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b5de23ff4cb37f0f94f9f703438403e0899c6d73748", async() => {
                WriteLiteral(@"
    <table>
        <tr>
            <td>Store: </td>
            <td><input type=""text"" id=""txtStoreId"" name=""Store"" /></td>
        </tr>
        <tr>
            <td></td>
            <td><input type=""button"" id=""bLSubmit"" value=""Submit"" /></td>
        </tr>
    </table><br />
    
    <div style=""text-align:center"">
        <input type=""button"" id=""btnSave"" value=""Save"" style=""width:100px"" />
    </div>
    
");
            }
            );
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

<div style=""width:90%; margin:0 auto;"">
    <table id=""myTable"">
        <thead>
            <tr>
                <th>businessLicenseId</th>
                <th>store</th>
                <th>city</th>
                <th>country</th>
                <th>vendor</th>
                <th>name</th>
                <th>license Type</th>
                <th>expiration Date</th>
                <th>license Year</th>
            </tr>
        </thead>
    </table>
</div>
<style>
    tr.even {
        background-color: #F5F5F5 !important;
    }
</style>
");
            WriteLiteral("<link href=\"//cdn.datatables.net/1.10.9/css/jquery.dataTables.min.css\" rel=\"stylesheet\" />\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.10.9/js/jquery.dataTables.min.js""></script>
    <script>
       (function ($) {           
            $(document).ready(function () {                
            var country = [
                ""WHARTON"",
                ""SCOTT"",
                ""DAVIDSON"",
                ""WARREN""
                ];
                    
            $('#btnSave').prop('disabled', true);
            getBusinessLicense();
            function getBusinessLicense(storeId) {

                if (storeId != null || storeId != """")
                    $(""#myTable"").dataTable().fnDestroy();

                 $('#myTable').DataTable({
                    ""processing"": true,
                    //  ""serverSide"": true,
                    ""filter"": true,
                    ""ajax"": {
                        ""url"": ""/Home/GetAllBusinessLicense"",
                        ""type"": ""POST"",
                        ""data"": { storeId: storeId },
                        ""datatype");
                WriteLiteral(@""": ""json""
                    },
                    ""columnDefs"": [{
                        ""targets"": [0],
                        ""visible"": false,
                        ""searchable"": false
                    }],
                    ""aLengthMenu"": [[5, 10, 20, 50, 100, -1], [5, 10, 20, 50, 100, ""All""]],
                    ""iDisplayLength"": 10,
                    ""columns"": [
                        { ""data"": ""businessLicenseId"", ""autoWidth"": true },
                        { ""data"": ""store"", ""autoWidth"": true },
                        { ""data"": ""city"", ""autoWidth"": true },
                        // { ""data"": ""Country"", ""autoWidth"": true },
                        {
                            ""data"": ""country"", ""autoWidth"": true,
                            ""render"": function (d, t, r, index) {
                                var $select = $(""<select name='countries' title='countryName'></select>"", {
                                    ""id"": index.row + ""store"",
                 ");
                WriteLiteral(@"                   ""value"": d
                                });
                                $.each(country, function (k, v) {
                                    var $option = $(""<option></option>"", {
                                        ""text"": v,
                                        ""value"": v
                                    });
                                    if (d === v) {
                                        $option.attr(""selected"", ""selected"")
                                    }
                                    $select.append($option);
                                });
                                return $select.prop(""outerHTML"");
                            }
                        },

                        //dropdown end
                        { ""data"": ""vendor"", ""autoWidth"": true },
                        { ""data"": ""name"", ""autoWidth"": true },
                        { ""data"": ""licenseType"", ""autoWidth"": true },
                        { ""data");
                WriteLiteral(@""": ""expirationDate"", ""autoWidth"": true },
                        { ""data"": ""licenseYear"", ""autoWidth"": true }
                    ]
                    //  }
                });
            }

            $('input#bLSubmit').click(function () {                
                var storeId = $('input#txtStoreId').val();
                getBusinessLicense(storeId);
            });
                
            $(""#myTable"").on('change', 'tr td', function (e) {
               // e.preventDefault();
               
                $(""#btnSave"").prop('disabled', false);
            });            
        });
      })(jQuery);
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
