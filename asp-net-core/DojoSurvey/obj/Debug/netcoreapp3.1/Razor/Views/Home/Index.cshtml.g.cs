#pragma checksum "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56fe6f2222c54e54c77d160ed8211dc44768629e"
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
#line 1 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/_ViewImports.cshtml"
using DojoSurvey;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Home/Index.cshtml"
using DojoSurvey.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56fe6f2222c54e54c77d160ed8211dc44768629e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a67436b50a8d850d5f878261256993a0b6c9782", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<p>Username: ");
#nullable restore
#line 12 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Home/Index.cshtml"
        Write(ViewBag.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>FirstName: ");
#nullable restore
#line 13 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Home/Index.cshtml"
         Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>LastName: ");
#nullable restore
#line 14 "/Users/mau/git/dotnet/asp-net-core/DojoSurvey/Views/Home/Index.cshtml"
        Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
