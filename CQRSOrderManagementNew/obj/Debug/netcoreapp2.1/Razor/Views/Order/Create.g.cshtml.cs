#pragma checksum "C:\Users\SANSLI\Source\Repos\CQRSOrderManagementNew\CQRSOrderManagementNew\Views\Order\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6278936e4e7d249f2d84693568448e0d492a8a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Create), @"mvc.1.0.razor-page", @"/Views/Order/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/Order/Create.cshtml", typeof(AspNetCore.Views_Order_Create), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6278936e4e7d249f2d84693568448e0d492a8a6", @"/Views/Order/Create.cshtml")]
    public class Views_Order_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 37, true);
            WriteLiteral("    <!DOCTYPE html>\r\n    <html>\r\n    ");
            EndContext();
            BeginContext(96, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "259b3ff02ca14072806d068dc670d4cb", async() => {
                BeginContext(102, 100, true);
                WriteLiteral("\r\n        <meta name=\"viewport\" content=\"width=device-width\" />\r\n        <title>Create</title>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(209, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(215, 1967, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c29e262bf25846caae6306193e82534a", async() => {
                BeginContext(221, 35, true);
                WriteLiteral("\r\n        <div class=\"container\">\r\n");
                EndContext();
#line 12 "C:\Users\SANSLI\Source\Repos\CQRSOrderManagementNew\CQRSOrderManagementNew\Views\Order\Create.cshtml"
             using (Html.BeginForm())
            {

#line default
#line hidden
                BeginContext(308, 210, true);
                WriteLiteral("<div class=\"panel panel-default\">\r\n                    <div class=\"panel-heading\">\r\n                        <h4>Add Order Details</h4>\r\n                    </div>\r\n                    <div class=\"panel-body\">\r\n");
                EndContext();
#line 18 "C:\Users\SANSLI\Source\Repos\CQRSOrderManagementNew\CQRSOrderManagementNew\Views\Order\Create.cshtml"
                         if (TempData["Message"] != null)
                        {
                            

#line default
#line hidden
                BeginContext(633, 19, false);
#line 20 "C:\Users\SANSLI\Source\Repos\CQRSOrderManagementNew\CQRSOrderManagementNew\Views\Order\Create.cshtml"
                       Write(TempData["Message"]);

#line default
#line hidden
                EndContext();
#line 20 "C:\Users\SANSLI\Source\Repos\CQRSOrderManagementNew\CQRSOrderManagementNew\Views\Order\Create.cshtml"
                                                
                        }

#line default
#line hidden
                BeginContext(681, 200, true);
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-xs-12 col-sm-6 col-sm-6 col-lg-4\">\r\n                                OrderCode\r\n                                ");
                EndContext();
                BeginContext(882, 66, false);
#line 26 "C:\Users\SANSLI\Source\Repos\CQRSOrderManagementNew\CQRSOrderManagementNew\Views\Order\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.OrderCode, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(948, 265, true);
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-xs-12 col-sm-6 col-sm-6 col-lg-4"">
                                Amount
                                ");
                EndContext();
                BeginContext(1214, 63, false);
#line 32 "C:\Users\SANSLI\Source\Repos\CQRSOrderManagementNew\CQRSOrderManagementNew\Views\Order\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.Amount, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1277, 644, true);
                WriteLiteral(@"
                            </div>
                        </div>
                         
                        

                        <br />
                        <div class=""row"">
                            <div class=""col-xs-12 col-sm-6 col-sm-6 col-lg-4"">
                                <input id=""Submit1"" class=""btn btn-success"" type=""submit"" value=""submit"" />
                            </div>
                        </div>
                        <br />
                        <div class=""row"">
                            <div class=""col-xs-12 col-sm-6 col-sm-6 col-lg-4"">
                                ");
                EndContext();
                BeginContext(1922, 96, false);
#line 47 "C:\Users\SANSLI\Source\Repos\CQRSOrderManagementNew\CQRSOrderManagementNew\Views\Order\Create.cshtml"
                           Write(Html.ActionLink("Back to Home Page", "Index", "Order", null, new { @class = "btn btn-warning" }));

#line default
#line hidden
                EndContext();
                BeginContext(2018, 122, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
                EndContext();
#line 52 "C:\Users\SANSLI\Source\Repos\CQRSOrderManagementNew\CQRSOrderManagementNew\Views\Order\Create.cshtml"
            }

#line default
#line hidden
                BeginContext(2155, 20, true);
                WriteLiteral("        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2182, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CQRSOrderManagementNew.Model.OrderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CQRSOrderManagementNew.Model.OrderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CQRSOrderManagementNew.Model.OrderModel>)PageContext?.ViewData;
        public CQRSOrderManagementNew.Model.OrderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
