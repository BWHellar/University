#pragma checksum "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "839a13dc122735ec8314f15c0b3c300a21b0d8d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Show), @"mvc.1.0.view", @"/Views/Courses/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Show.cshtml", typeof(AspNetCore.Views_Courses_Show))]
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
#line 1 "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml"
using Registrar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"839a13dc122735ec8314f15c0b3c300a21b0d8d9", @"/Views/Courses/Show.cshtml")]
    public class Views_Courses_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 33, true);
            WriteLiteral("\n<h1>Registrar</h1>\n</h2>Course: ");
            EndContext();
            BeginContext(59, 28, false);
#line 4 "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml"
        Write(Model["selectedCourse"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(87, 14, true);
            WriteLiteral("</h2>\n<hr />\n\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml"
 if (@Model["enrolledStudents"].Count !=0)
{

#line default
#line hidden
            BeginContext(146, 66, true);
            WriteLiteral("  <h4>This course has the following students enrolled</h4>\n  <ul>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml"
   foreach (Student student in @Model["enrolledStudents"])
  {

#line default
#line hidden
            BeginContext(275, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(284, 12, false);
#line 13 "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml"
   Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(296, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml"
  }

#line default
#line hidden
            BeginContext(306, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 16 "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml"
}

#line default
#line hidden
            BeginContext(316, 45, true);
            WriteLiteral("\n<h4>Add a student to this course</h4>\n\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 361, "\'", 419, 3);
            WriteAttributeValue("", 370, "/courses/", 370, 9, true);
#line 20 "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml"
WriteAttributeValue("", 379, Model["selectedCourse"].Id, 379, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 406, "/students/new", 406, 13, true);
            EndWriteAttribute();
            BeginContext(420, 127, true);
            WriteLiteral(" method=\'post\'>\n  <label for=\'studentName\'>Select a student</label>\n  <select id=\'studentName\' name=\'studentName\' type=\'text\'>\n");
            EndContext();
#line 23 "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml"
     foreach (var student in @Model["allStudents"])
    {

#line default
#line hidden
            BeginContext(605, 13, true);
            WriteLiteral("      <option");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 618, "\'", 637, 1);
#line 25 "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml"
WriteAttributeValue("", 626, student.Id, 626, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(638, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(640, 12, false);
#line 25 "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml"
                             Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(652, 10, true);
            WriteLiteral("</option>\n");
            EndContext();
#line 26 "/Users/Guest/Desktop/university-solution/Registrar/Views/Courses/Show.cshtml"
    }

#line default
#line hidden
            BeginContext(668, 96, true);
            WriteLiteral("  </select>\n  <button type=\'submit\'>Add</button>\n</form>\n\n<p><a herf=\"/\">Return to Home</a></p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
