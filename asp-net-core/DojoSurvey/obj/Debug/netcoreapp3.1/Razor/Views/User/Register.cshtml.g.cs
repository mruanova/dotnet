#pragma checksum "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/User/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8898847b5cd25b19378b3ef735b03254a0ed92ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Register), @"mvc.1.0.view", @"/Views/User/Register.cshtml")]
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
#line 4 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/User/Register.cshtml"
using DojoSurvey.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8898847b5cd25b19378b3ef735b03254a0ed92ef", @"/Views/User/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a67436b50a8d850d5f878261256993a0b6c9782", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/User/Register.cshtml"
  
    ViewData["Title"] = "Register Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>FirstName: ");
#nullable restore
#line 7 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/User/Register.cshtml"
         Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>LastName: ");
#nullable restore
#line 8 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/User/Register.cshtml"
        Write(Model.LastName);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
