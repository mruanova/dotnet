#pragma checksum "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Survey/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32648d1b12b4ef1544c294d2cdd4eecbd787b029"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_Result), @"mvc.1.0.view", @"/Views/Survey/Result.cshtml")]
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
#line 1 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/_ViewImports.cshtml"
using DojoSurvey;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Survey/Result.cshtml"
using DojoSurvey.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32648d1b12b4ef1544c294d2cdd4eecbd787b029", @"/Views/Survey/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a67436b50a8d850d5f878261256993a0b6c9782", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Survey/Result.cshtml"
  
    ViewData["Title"] = "Result Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Name: ");
#nullable restore
#line 7 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Survey/Result.cshtml"
    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Location: ");
#nullable restore
#line 8 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Survey/Result.cshtml"
        Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Language: ");
#nullable restore
#line 9 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Survey/Result.cshtml"
        Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Comment: ");
#nullable restore
#line 10 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Survey/Result.cshtml"
       Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
