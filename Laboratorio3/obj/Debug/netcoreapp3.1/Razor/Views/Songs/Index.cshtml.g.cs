#pragma checksum "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53584a1d877871119bf699dcf5262ca3bfd5b75d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Songs_Index), @"mvc.1.0.view", @"/Views/Songs/Index.cshtml")]
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
#line 1 "D:\source\repos\Laboratorio3\Laboratorio3\Views\_ViewImports.cshtml"
using Laboratorio3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\source\repos\Laboratorio3\Laboratorio3\Views\_ViewImports.cshtml"
using Laboratorio3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53584a1d877871119bf699dcf5262ca3bfd5b75d", @"/Views/Songs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e7dd5c7c732b0d76f4dc87d0019fc2954704402", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Songs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Laboratorio3.Models.SongsModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
  
  ViewData["Title"] = "Songs";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 11 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
Write(ViewBag.MainTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n  <table class = \"table\">\r\n    <tbody>\r\n\r\n      <tr>\r\n        <td><strong>Name</strong></td>\r\n");
#nullable restore
#line 19 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 21 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tr>\r\n      <tr>\r\n        <td><strong>Author</strong></td>\r\n");
#nullable restore
#line 26 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 28 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
       Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 29 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tr>\r\n      <tr>\r\n        <td><strong>Genre</strong></td>\r\n");
#nullable restore
#line 33 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
       foreach (var item in Model)
      { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 35 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
       Write(item.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tr>\r\n      <tr>\r\n        <td><strong>Album</strong></td>\r\n");
#nullable restore
#line 40 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
       foreach (var item in Model)
      {      

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 42 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
       Write(item.Album);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 43 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tr>\r\n      <tr>\r\n        <td><strong>ReleasedDate</strong></td>\r\n");
#nullable restore
#line 47 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 49 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
       Write(item.ReleasedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 50 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tr>\r\n      <tr>\r\n        <td><strong>Duration</strong></td>\r\n");
#nullable restore
#line 54 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 56 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
       Write(item.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 57 "D:\source\repos\Laboratorio3\Laboratorio3\Views\Songs\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tr>\r\n\r\n    </tbody>\r\n  </table>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Laboratorio3.Models.SongsModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
