#pragma checksum "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1da756ecc01b759138b7ee091eef16af6ae5f29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Post), @"mvc.1.0.view", @"/Views/Shared/_Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Post.cshtml", typeof(AspNetCore.Views_Shared__Post))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1da756ecc01b759138b7ee091eef16af6ae5f29", @"/Views/Shared/_Post.cshtml")]
    public class Views_Shared__Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_application.Models.Post_Model>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(105, 37, true);
            WriteLiteral("<article class=\"blog-post\">\r\n    <h1>");
            EndContext();
            BeginContext(143, 11, false);
#line 4 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Post.cshtml"
   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(154, 54, true);
            WriteLiteral("</h1>\r\n    <div class=\"detail\">\r\n        Posted <span>");
            EndContext();
            BeginContext(209, 38, false);
#line 6 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Post.cshtml"
                Write(DateFormate.ReadableDate(Model.Posted));

#line default
#line hidden
            EndContext();
            BeginContext(247, 17, true);
            WriteLiteral("</span> by <span>");
            EndContext();
            BeginContext(265, 12, false);
#line 6 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Post.cshtml"
                                                                        Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(277, 56, true);
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"content\">\r\n        ");
            EndContext();
            BeginContext(334, 10, false);
#line 9 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Post.cshtml"
   Write(Model.Body);

#line default
#line hidden
            EndContext();
            BeginContext(344, 26, true);
            WriteLiteral("\r\n    </div>\r\n</article>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MVC_application.Models.FormattingServices DateFormate { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_application.Models.Post_Model> Html { get; private set; }
    }
}
#pragma warning restore 1591
