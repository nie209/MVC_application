#pragma checksum "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Blog\post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42916b1566fbbb240cbdb1d4db5d9c579faacdbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_post), @"mvc.1.0.view", @"/Views/Blog/post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/post.cshtml", typeof(AspNetCore.Views_Blog_post))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42916b1566fbbb240cbdb1d4db5d9c579faacdbb", @"/Views/Blog/post.cshtml")]
    public class Views_Blog_post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_application.Models.Post_Model>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Blog\post.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(70, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(72, 21, false);
#line 6 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Blog\post.cshtml"
Write(Html.Partial("_Post"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_application.Models.Post_Model> Html { get; private set; }
    }
}
#pragma warning restore 1591
