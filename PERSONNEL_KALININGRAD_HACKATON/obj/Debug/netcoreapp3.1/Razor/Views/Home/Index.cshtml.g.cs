#pragma checksum "D:\VS\PERSONNEL_HACKATON\PERSONNEL_KALININGRAD_HACKATON\PERSONNEL_KALININGRAD_HACKATON\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17fc0f7f707026257c4dc4392795e484cde93f03"
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
#line 1 "D:\VS\PERSONNEL_HACKATON\PERSONNEL_KALININGRAD_HACKATON\PERSONNEL_KALININGRAD_HACKATON\Views\_ViewImports.cshtml"
using PERSONNEL_KALININGRAD_HACKATON;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS\PERSONNEL_HACKATON\PERSONNEL_KALININGRAD_HACKATON\PERSONNEL_KALININGRAD_HACKATON\Views\_ViewImports.cshtml"
using PERSONNEL_KALININGRAD_HACKATON.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17fc0f7f707026257c4dc4392795e484cde93f03", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75b9a9c3cb96f35bb1d55e780d5cb8608fdefba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\VS\PERSONNEL_HACKATON\PERSONNEL_KALININGRAD_HACKATON\PERSONNEL_KALININGRAD_HACKATON\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Оперативная информация";
    Layout = "/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""pcoded-content"">
    <div class=""pcoded-inner-content"">
        <div class=""main-body"">
            <div class=""page-wrapper"">
                <div class=""page-body"">
                    <div class=""row"">
                        <div class=""col-md-12 col-xl-8"">
                            <div class=""card sale-card"">
                                <div class=""card-header"">
                                    <h5>Новые вакансии</h5>
                                </div>
                                <div class=""card-block"">
                                    <div id=""sales-analytics"" class=""chart-shadow"" style=""height:380px""></div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-12 col-xl-4"">
                            <div class=""card comp-card"">
                                <div class=""card-body"">
                                    <div class=""row align-items-center"">
");
            WriteLiteral(@"                                        <div class=""col"">
                                            <h6 class=""m-b-25"">Численность населения</h6>
                                            <h3 class=""f-w-700 text-c-blue"">1 012 500</h3>
                                            <p class=""m-b-0"">14 Ноябрь 2020</p>
                                        </div>
                                        <div class=""col-auto"">
                                            <i class=""fas fa-eye bg-c-blue""></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card comp-card"">
                                <div class=""card-body"">
                                    <div class=""row align-items-center"">
                                        <div class=""col"">
                                            <h6 class=""m-b-25"">Средняя зар. плата</h6>
   ");
            WriteLiteral(@"                                         <h3 class=""f-w-700 text-c-green"">30 564</h3>
                                            <p class=""m-b-0"">15 Августа 2020</p>
                                        </div>
                                        <div class=""col-auto"">
                                            <i class=""fas fa-bullseye bg-c-green""></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card comp-card"">
                                <div class=""card-body"">
                                    <div class=""row align-items-center"">
                                        <div class=""col"">
                                            <h6 class=""m-b-25"">Уровень безработицы</h6>
                                            <h3 class=""f-w-700 text-c-yellow"">6.9%</h3>
                                            <p class=""m-b-0"">");
            WriteLiteral(@"10 октябрь 2020</p>
                                        </div>
                                        <div class=""col-auto"">
                                            <i class=""fas fa-hand-paper bg-c-yellow""></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-12"">
                            <div class=""card proj-progress-card"">
                                <div class=""card-block"">
                                    <div class=""row"">
                                        <div class=""col-xl-3 col-md-6"">
                                            <h6>Опубликовано вакансий</h6>
                                            <h5 class=""m-b-30 f-w-700"">127<span class=""text-c-green m-l-10"">+200(годом ранее)</span></h5>
                                            <div class=""progress"">
               ");
            WriteLiteral(@"                                 <div class=""progress-bar bg-c-red"" style=""width:25%""></div>
                                            </div>
                                        </div>
                                        <div class=""col-xl-3 col-md-6"">
                                            <h6>Закрыто вакансий</h6>
                                            <h5 class=""m-b-30 f-w-700"">23<span class=""text-c-red m-l-10"">-40(годом ранее)</span></h5>
                                            <div class=""progress"">
                                                <div class=""progress-bar bg-c-blue"" style=""width:65%""></div>
                                            </div>
                                        </div>
                                        <div class=""col-xl-3 col-md-6"">
                                            <h6>Уволилось сегодня</h6>
                                            <h5 class=""m-b-30 f-w-700"">0<span class=""text-c-green m-l-10""></span></h5>
        ");
            WriteLiteral(@"                                    <div class=""progress"">
                                                <div class=""progress-bar bg-c-green"" style=""width:85%""></div>
                                            </div>
                                        </div>
                                        <div class=""col-xl-3 col-md-6"">
                                            <h6>Устроилось сегодня</h6>
                                            <h5 class=""m-b-30 f-w-700"">15<span class=""text-c-green m-l-10""></span></h5>
                                            <div class=""progress"">
                                                <div class=""progress-bar bg-c-yellow"" style=""width:45%""></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>                     
                    </div>
     ");
            WriteLiteral("           </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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