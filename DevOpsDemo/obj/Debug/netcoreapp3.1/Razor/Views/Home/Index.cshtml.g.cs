#pragma checksum "C:\Users\shshi\source\repos\DevOpsDemo\DevOpsDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e2e900e9eb09f63f5ca1a215426c1eecddf06fd"
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
#line 1 "C:\Users\shshi\source\repos\DevOpsDemo\DevOpsDemo\Views\_ViewImports.cshtml"
using DevOpsDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shshi\source\repos\DevOpsDemo\DevOpsDemo\Views\_ViewImports.cshtml"
using DevOpsDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e2e900e9eb09f63f5ca1a215426c1eecddf06fd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53164ecf124f82c327bac34a1f33e331068f0293", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<DevOpsDemo.Models.PostViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\shshi\source\repos\DevOpsDemo\DevOpsDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""row"">
    <h2>Post List</h2>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Post ID
                </th>
                <th>
                    Title
                </th>
                <th>
                    Description
                </th>
                <th>
                    Author
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 30 "C:\Users\shshi\source\repos\DevOpsDemo\DevOpsDemo\Views\Home\Index.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\shshi\source\repos\DevOpsDemo\DevOpsDemo\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PostId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\shshi\source\repos\DevOpsDemo\DevOpsDemo\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\shshi\source\repos\DevOpsDemo\DevOpsDemo\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\shshi\source\repos\DevOpsDemo\DevOpsDemo\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\shshi\source\repos\DevOpsDemo\DevOpsDemo\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<DevOpsDemo.Models.PostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591