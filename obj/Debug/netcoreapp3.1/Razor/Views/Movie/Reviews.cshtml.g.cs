#pragma checksum "C:\Users\12052\source\repos\MyMovieApp\Views\Movie\Reviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e9beb78c09f32fa22c99b150ba3fde3464ecf31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Reviews), @"mvc.1.0.view", @"/Views/Movie/Reviews.cshtml")]
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
#line 1 "C:\Users\12052\source\repos\MyMovieApp\Views\_ViewImports.cshtml"
using MyMovieApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\12052\source\repos\MyMovieApp\Views\_ViewImports.cshtml"
using MyMovieApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e9beb78c09f32fa22c99b150ba3fde3464ecf31", @"/Views/Movie/Reviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a5a4fb3bfcfd7a6a892740ba698b495c54dc2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Reviews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyMovieApp.Models.Reviews.Root>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\12052\source\repos\MyMovieApp\Views\Movie\Reviews.cshtml"
  
    ViewData["Title"] = "Reviews";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4 align-self-md-center\" style=\"color: white;\">This is what is popular right now!</h1>\r\n\r\n</div>\r\n\r\n<div class=\"flex-container\">\r\n    <div class=\"row row-cols-1 row-cols-md-2 g-4\">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\12052\source\repos\MyMovieApp\Views\Movie\Reviews.cshtml"
         foreach (var item in Model.results)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-4"">
                <div class=""h-50"">
                    <div class=""card"" style=""width: 18rem;"">
                     

                        <div class=""card-body"">
                            <h5 class=""card-title"">User:");
#nullable restore
#line 22 "C:\Users\12052\source\repos\MyMovieApp\Views\Movie\Reviews.cshtml"
                                                   Write(item.author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"text-sm-right\">Created on ");
#nullable restore
#line 23 "C:\Users\12052\source\repos\MyMovieApp\Views\Movie\Reviews.cshtml"
                                                           Write(item.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <p class=\"card-text \">");
#nullable restore
#line 25 "C:\Users\12052\source\repos\MyMovieApp\Views\Movie\Reviews.cshtml"
                                             Write(item.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                         </div>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\12052\source\repos\MyMovieApp\Views\Movie\Reviews.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyMovieApp.Models.Reviews.Root> Html { get; private set; }
    }
}
#pragma warning restore 1591