#pragma checksum "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\HospitalDatabase\hospitaldatabase\Views\Medications_Patients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a255f2a27d53590af2851221bf1526124a9fc67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medications_Patients_Index), @"mvc.1.0.view", @"/Views/Medications_Patients/Index.cshtml")]
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
#line 1 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\HospitalDatabase\hospitaldatabase\Views\_ViewImports.cshtml"
using HospitalDatabase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\HospitalDatabase\hospitaldatabase\Views\_ViewImports.cshtml"
using HospitalDatabase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a255f2a27d53590af2851221bf1526124a9fc67", @"/Views/Medications_Patients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a9fe5adcbb57a60ddcf5926b068ff4fcfeb4573", @"/Views/_ViewImports.cshtml")]
    public class Views_Medications_Patients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\HospitalDatabase\hospitaldatabase\Views\Medications_Patients\Index.cshtml"
  
    var MedicationsPatients = (List<Medication_Patient_Model>)ViewData["MedicationsPatients"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>This is the Doctor and Patient Index</h1>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <td> ID: </td>\r\n            <td> Patient ID: </td>\r\n            <td> Medication ID: </td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\HospitalDatabase\hospitaldatabase\Views\Medications_Patients\Index.cshtml"
         foreach (var mp in MedicationsPatients)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\HospitalDatabase\hospitaldatabase\Views\Medications_Patients\Index.cshtml"
               Write(mp.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\HospitalDatabase\hospitaldatabase\Views\Medications_Patients\Index.cshtml"
               Write(mp.PatientId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\HospitalDatabase\hospitaldatabase\Views\Medications_Patients\Index.cshtml"
               Write(mp.MedicationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\HospitalDatabase\hospitaldatabase\Views\Medications_Patients\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
