#pragma checksum "C:\Users\Gebruiker\Documents\Hw Dingen VS\Periode_3\c-sharp-introductie-157964\MVC\MVC-School\Views\Studenten\Components\StudentVakken\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dca2d09be67f1d8ebc7f15e1a1d445430cadda4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Studenten_Components_StudentVakken_Default), @"mvc.1.0.view", @"/Views/Studenten/Components/StudentVakken/Default.cshtml")]
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
#line 1 "C:\Users\Gebruiker\Documents\Hw Dingen VS\Periode_3\c-sharp-introductie-157964\MVC\MVC-School\Views\_ViewImports.cshtml"
using MVC_School;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gebruiker\Documents\Hw Dingen VS\Periode_3\c-sharp-introductie-157964\MVC\MVC-School\Views\_ViewImports.cshtml"
using MVC_School.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca2d09be67f1d8ebc7f15e1a1d445430cadda4a", @"/Views/Studenten/Components/StudentVakken/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5840a6d38d21f7f843721a8093c58e56f2e3dca0", @"/Views/_ViewImports.cshtml")]
    public class Views_Studenten_Components_StudentVakken_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_School.Models.VakStudent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gebruiker\Documents\Hw Dingen VS\Periode_3\c-sharp-introductie-157964\MVC\MVC-School\Views\Studenten\Components\StudentVakken\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Vakken</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\Gebruiker\Documents\Hw Dingen VS\Periode_3\c-sharp-introductie-157964\MVC\MVC-School\Views\Studenten\Components\StudentVakken\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Vak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Gebruiker\Documents\Hw Dingen VS\Periode_3\c-sharp-introductie-157964\MVC\MVC-School\Views\Studenten\Components\StudentVakken\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Uren));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\Gebruiker\Documents\Hw Dingen VS\Periode_3\c-sharp-introductie-157964\MVC\MVC-School\Views\Studenten\Components\StudentVakken\Default.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 23 "C:\Users\Gebruiker\Documents\Hw Dingen VS\Periode_3\c-sharp-introductie-157964\MVC\MVC-School\Views\Studenten\Components\StudentVakken\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vak.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\Gebruiker\Documents\Hw Dingen VS\Periode_3\c-sharp-introductie-157964\MVC\MVC-School\Views\Studenten\Components\StudentVakken\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Uren));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Gebruiker\Documents\Hw Dingen VS\Periode_3\c-sharp-introductie-157964\MVC\MVC-School\Views\Studenten\Components\StudentVakken\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_School.Models.VakStudent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
