#pragma checksum "C:\Users\Nora\source\repos\GymManagementSystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "277a6b65fcb838a2a1b1587bf7dc2771ae58ae38"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"277a6b65fcb838a2a1b1587bf7dc2771ae58ae38", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cffd0d165a888fdb80de1b12061cf20813334fe7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row row-deck row-cards"">
    <div class=""col-4"">
        <div class=""card card-sm"">
            <div class=""card-body"">
                <div class=""row align-items-center"">
                    <div class=""col-auto"">
                        <span class=""bg-red text-white avatar"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" class=""icon"" width=""24"" height=""24"" viewBox=""0 0 24 24"" stroke-width=""2"" stroke=""currentColor"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round""><path stroke=""none"" d=""M0 0h24v24H0z"" fill=""none""></path><circle cx=""12"" cy=""7"" r=""4""></circle><path d=""M6 21v-2a4 4 0 0 1 4 -4h4a4 4 0 0 1 4 4v2""></path></svg>
                        </span>
                    </div>
                    <div class=""col"">
                        <div class=""font-weight-medium h3"">
                            ");
#nullable restore
#line 17 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Home\Index.cshtml"
                       Write(ViewBag.Total_Members);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Members
                        </div>
                        <div class=""text-muted"">
                            Total Number Of Members
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-4"">
        <div class=""card card-sm"">
            <div class=""card-body"">
                <div class=""row align-items-center"">
                    <div class=""col-auto"">
                        <span class=""bg-red text-white avatar"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" class=""icon"" width=""24"" height=""24"" viewBox=""0 0 24 24"" stroke-width=""2"" stroke=""currentColor"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round""><path stroke=""none"" d=""M0 0h24v24H0z"" fill=""none"" /><circle cx=""9"" cy=""7"" r=""4"" /><path d=""M3 21v-2a4 4 0 0 1 4 -4h4a4 4 0 0 1 4 4v2"" /><path d=""M16 3.13a4 4 0 0 1 0 7.75"" /><path d=""M21 21v-2a4 4 0 0 0 -3 -3.85"" /></svg>
                        </span>
        ");
            WriteLiteral("            </div>\r\n                    <div class=\"col\">\r\n                        <div class=\"font-weight-medium h3\">\r\n                            ");
#nullable restore
#line 38 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Home\Index.cshtml"
                       Write(ViewBag.Total_Memberships);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Memberships
                        </div>
                        <div class=""text-muted"">
                            Total Number Of Memberships
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-4"">
        <div class=""card card-sm"">
            <div class=""card-body"">
                <div class=""row align-items-center"">
                    <div class=""col-auto"">
                        <span class=""bg-red text-white avatar"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" class=""icon"" width=""24"" height=""24"" viewBox=""0 0 24 24"" stroke-width=""2"" stroke=""currentColor"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round""><path stroke=""none"" d=""M0 0h24v24H0z"" fill=""none"" /><path d=""M15 3v4a1 1 0 0 0 1 1h4"" /><path d=""M18 17h-7a2 2 0 0 1 -2 -2v-10a2 2 0 0 1 2 -2h4l5 5v7a2 2 0 0 1 -2 2z"" /><path d=""M16 17v2a2 2 0 0 1 -2 2h-7a2 2 0 0 1 -2 -2v-10a2 2 0 0 1 2 -2h2"" /></svg>
   ");
            WriteLiteral("                     </span>\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <div class=\"font-weight-medium h3\">\r\n                            ");
#nullable restore
#line 59 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Home\Index.cshtml"
                       Write(ViewBag.Total_Services);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Services
                        </div>
                        <div class=""text-muted"">
                            Total Number Of Services
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row mt-5"">
    <div class=""col-4"">
        <div class=""card mb-3"">
            <div class=""card-header"">
                <h3 class=""card-title"">Expired Memberships</h3>
            </div>
            <div class=""list-group list-group-flush list-group-hoverable"">
");
#nullable restore
#line 77 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Home\Index.cshtml"
                 foreach (var membership in ViewBag.Memberships)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""list-group-item"">
                        <div class=""row align-items-center"">
                            <div class=""col-auto""><span class=""badge bg-red""></span></div>
                            <div class=""col text-truncate"">
                                <span class=""text-body d-block""> ");
#nullable restore
#line 83 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Home\Index.cshtml"
                                                            Write(membership.Member.Member_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - #");
#nullable restore
#line 83 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Home\Index.cshtml"
                                                                                              Write(membership.Member_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <small class=\"d-block text-muted text-truncate mt-n1\">\r\n                                    Membership expired on - ");
#nullable restore
#line 85 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Home\Index.cshtml"
                                                       Write(String.Format("{0:dd/MM/yyyy}", membership.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </small>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 90 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""col-8"">
        <div class=""card"">
            <div class=""card-header"">
                <h3 class=""card-title"">Memberships calendar</h3>
            </div>
            <div class=""card-body"">
                 <div id=""calendar"" data-events=""");
#nullable restore
#line 100 "C:\Users\Nora\source\repos\GymManagementSystem\Views\Home\Index.cshtml"
                                            Write(ViewBag.Calendar);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        document.addEventListener('DOMContentLoaded', (event) => {

            const calendarEl = document.getElementById('calendar');
          
            let events = eval(calendarEl.dataset.events);

            events = events.map(event => {
                return {
                    title: `Membership Expired for #${event.Member_Id}`, 
                    start: event.StartDate,
                    end: event.EndDate,
                    color: `#${Math.floor(Math.random() * 16777215).toString(16)}`
                }
            });

        const calendar = new FullCalendar.Calendar(calendarEl, {
        firstDay: 1,
        headerToolbar: {
            start: 'prev,next today',
            center: 'title',
            end: 'dayGridMonth,dayGridWeek'
        },
        businessHours: {
            daysOfWeek: [ 1, 2, 3, 4, 5 ],
            startTime: '10:00',
            endTime: '23:00',
        },
            eventBackgroundColor: ");
                WriteLiteral("\'#206bc4\',\r\n            events: events\r\n    });\r\n\r\n    calendar.render();\r\n});\r\n    </script>\r\n\r\n");
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