#pragma checksum "D:\Code\visualstudio\Authentication2\Client\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "104ba1e1888e135ce7863580dab89b9989d2026c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"104ba1e1888e135ce7863580dab89b9989d2026c", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "104ba1e1888e135ce7863580dab89b9989d2026c2711", async() => {
                WriteLiteral("\r\n    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1\" crossorigin=\"anonymous\">\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "104ba1e1888e135ce7863580dab89b9989d2026c3917", async() => {
                WriteLiteral(@"

    <form action=""/Home/secret"" class=""form-signin"" method=""get"" id=""secretform"">
        <div class=""card mx-auto mt-4"">
            <div class=""card-header"">
                2020 Presidential Election Turnout
            </div>
            <div class=""card-body"" style=""width:500px"">
                <!--<h5 class=""card-title"">Special title treatment</h5>-->
                <p class=""card-text"">This dataset contains information about 2020 US presidential election turnout</p>
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-8"">
                            <label for=""state"">Select a state:</label>
                            <select name=""state_id"" id=""state"" form=""secretform"">
                                <option value=""ALL"">All</option>
                                <option value=""AL"">Alabama</option>
                                <option value=""AK"">Alaska</option>
                                <option value=");
                WriteLiteral(@"""AZ"">Arizona</option>
                                <option value=""AR"">Arkansas</option>
                                <option value=""CA"">California</option>
                                <option value=""CO"">Colorado</option>
                                <option value=""CT"">Connecticut</option>
                                <option value=""DE"">Delaware</option>
                                <option value=""DC"">District of Columbia</option>
                                <option value=""FL"">Florida</option>
                                <option value=""GA"">Georgia</option>
                                <option value=""HI"">Hawaii</option>
                                <option value=""ID"">Idaho</option>
                                <option value=""IL"">Illinois</option>
                                <option value=""IN"">Indiana</option>
                                <option value=""IA"">Iowa</option>
                                <option value=""KS"">Kansas</option>
                  ");
                WriteLiteral(@"              <option value=""KY"">Kentucky</option>
                                <option value=""LA"">Louisiana</option>
                                <option value=""ME"">Maine</option>
                                <option value=""MD"">Maryland</option>
                                <option value=""MA"">Massachusetts</option>
                                <option value=""MI"">Michigan</option>
                                <option value=""MN"">Minnesota</option>
                                <option value=""MS"">Mississippi</option>
                                <option value=""MO"">Missouri</option>
                                <option value=""MT"">Montana</option>
                                <option value=""NE"">Nebraska</option>
                                <option value=""NV"">Nevada</option>
                                <option value=""NH"">New Hampshire</option>
                                <option value=""NJ"">New Jersey</option>
                                <option value=""NM"">");
                WriteLiteral(@"New Mexico</option>
                                <option value=""NY"">New York</option>
                                <option value=""NC"">North Carolina</option>
                                <option value=""ND"">North Dakota</option>
                                <option value=""OH"">Ohio</option>
                                <option value=""OK"">Oklahoma</option>
                                <option value=""OR"">Oregon</option>
                                <option value=""PA"">Pennsylvania</option>
                                <option value=""RI"">Rhode Island</option>
                                <option value=""SC"">South Carolina</option>
                                <option value=""SD"">South Dakota</option>
                                <option value=""TN"">Tennessee</option>
                                <option value=""TX"">Texas</option>
                                <option value=""UT"">Utah</option>
                                <option value=""VT"">Vermont</option>
        ");
                WriteLiteral(@"                        <option value=""VA"">Virginia</option>
                                <option value=""WA"">Washington</option>
                                <option value=""WV"">West Virginia</option>
                                <option value=""WI"">Wisconsin</option>
                                <option value=""WY"">Wyoming</option>
                            </select>
                        </div>
                    </div>
                </div>
                <div class=""row mt-2"">
                    <div class=""col-md-8""></div>
                    <div col=""col-md-4"">
                        <button type=""submit"" class=""btn btn-primary mb-3"">Get</button>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW"" crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\r\n</html>");
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
