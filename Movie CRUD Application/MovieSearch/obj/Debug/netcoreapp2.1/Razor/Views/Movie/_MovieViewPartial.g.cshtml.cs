#pragma checksum "C:\DotNet\Movie CRUD Application\MovieSearch\Views\Movie\_MovieViewPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3ee52badfeec2e68d60901e8d80f989ae81e46f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie__MovieViewPartial), @"mvc.1.0.view", @"/Views/Movie/_MovieViewPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/_MovieViewPartial.cshtml", typeof(AspNetCore.Views_Movie__MovieViewPartial))]
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
#line 1 "C:\DotNet\Movie CRUD Application\MovieSearch\Views\_ViewImports.cshtml"
using MovieSearch;

#line default
#line hidden
#line 2 "C:\DotNet\Movie CRUD Application\MovieSearch\Views\_ViewImports.cshtml"
using MovieSearch.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3ee52badfeec2e68d60901e8d80f989ae81e46f", @"/Views/Movie/_MovieViewPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18789f2355399d033ad6d68ba76fb8314163d9ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie__MovieViewPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieSearch.Models.Movie.MovieModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\DotNet\Movie CRUD Application\MovieSearch\Views\Movie\_MovieViewPartial.cshtml"
  
    ViewData["Title"] = "_MovieViewPartial";

#line default
#line hidden
            BeginContext(110, 74, true);
            WriteLiteral("\r\n<h2>Movie Details</h2>\r\n<table border=\"1\" align=\"center\" width=\"100%\">\r\n");
            EndContext();
#line 8 "C:\DotNet\Movie CRUD Application\MovieSearch\Views\Movie\_MovieViewPartial.cshtml"
     foreach (var movie in Model)
    {

#line default
#line hidden
            BeginContext(226, 97, true);
            WriteLiteral("        <tr style=\"text-align: center; font-size: large; font-family: Calibri\">\r\n            <td>");
            EndContext();
            BeginContext(324, 13, false);
#line 11 "C:\DotNet\Movie CRUD Application\MovieSearch\Views\Movie\_MovieViewPartial.cshtml"
           Write(movie.MovieId);

#line default
#line hidden
            EndContext();
            BeginContext(337, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(361, 15, false);
#line 12 "C:\DotNet\Movie CRUD Application\MovieSearch\Views\Movie\_MovieViewPartial.cshtml"
           Write(movie.MovieName);

#line default
#line hidden
            EndContext();
            BeginContext(376, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(400, 17, false);
#line 13 "C:\DotNet\Movie CRUD Application\MovieSearch\Views\Movie\_MovieViewPartial.cshtml"
           Write(movie.ReleaseYear);

#line default
#line hidden
            EndContext();
            BeginContext(417, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(441, 11, false);
#line 14 "C:\DotNet\Movie CRUD Application\MovieSearch\Views\Movie\_MovieViewPartial.cshtml"
           Write(movie.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(452, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 16 "C:\DotNet\Movie CRUD Application\MovieSearch\Views\Movie\_MovieViewPartial.cshtml"
    }

#line default
#line hidden
            BeginContext(481, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieSearch.Models.Movie.MovieModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591