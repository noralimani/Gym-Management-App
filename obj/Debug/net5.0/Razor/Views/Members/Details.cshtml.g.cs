#pragma checksum "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f9ccbf07f7d758b2dc1c50de8752c64ae311357"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Members_Details), @"mvc.1.0.view", @"/Views/Members/Details.cshtml")]
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
#line 1 "C:\Users\Nora\source\repos\GymManagementSystem\Views\_ViewImports.cshtml"
using GymManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nora\source\repos\GymManagementSystem\Views\_ViewImports.cshtml"
using GymManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9ccbf07f7d758b2dc1c50de8752c64ae311357", @"/Views/Members/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cffd0d165a888fdb80de1b12061cf20813334fe7", @"/Views/_ViewImports.cshtml")]
    public class Views_Members_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GymManagementSystem.Models.Member>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-header"">
                <h3 class=""card-title"">
                    Member Details
                </h3>
            </div>
            <div class=""card-body"">
                <dl class=""row"">
                    <dt class=""col-5"">Name:</dt>
                    <dd class=""col-7""> ");
#nullable restore
#line 18 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.Member_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                    <dt class=\"col-5\">Surname:</dt>\r\n                    <dd class=\"col-7\"> ");
#nullable restore
#line 20 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.Member_Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                    <dt class=\"col-5\">Phone:</dt>\r\n                    <dd class=\"col-7\"> ");
#nullable restore
#line 22 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                    <dt class=\"col-5\">Email:</dt>\r\n                    <dd class=\"col-7\"> ");
#nullable restore
#line 24 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                    <dt class=\"col-5\">Joined Date:</dt>\r\n                    <dd class=\"col-7\"> ");
#nullable restore
#line 26 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.Days));

#line default
#line hidden
#nullable disable
            WriteLiteral(" days</dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"card-footer d-flex justify-content-between\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f9ccbf07f7d758b2dc1c50de8752c64ae3113576288", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
                                       WriteLiteral(Model.Member_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f9ccbf07f7d758b2dc1c50de8752c64ae3113578456", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>      \r\n    </div>\r\n    <div class=\"col-lg-8\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">              \r\n                <h3 class=\"card-title\">\r\n                    Memberships for ");
#nullable restore
#line 39 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
                               Write(Model.Member_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h3>
            </div>
            <table class=""table table-vcenter card-table"">
                <thead>
                    <tr>
                        <th>Start Date</th>
                        <th>End Date</th>
                        <th>Total</th>
                        <th class=""w-1""></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 52 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
                     foreach (var membership in Model.Memberships)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 55 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
                           Write(String.Format("{0:dd/MM/yyyy}", membership.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
                           Write(String.Format("{0:dd/MM/yyyy}", membership.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 57 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
                           Write(membership.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> <a");
            BeginWriteAttribute("href", " href=\"", 2407, "\"", 2460, 2);
            WriteAttributeValue("", 2414, "/Memberships/Details/", 2414, 21, true);
#nullable restore
#line 58 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"
WriteAttributeValue("", 2435, membership.Membership_Id, 2435, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> </td>\r\n                        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Members\Details.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>           \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymManagementSystem.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
