#pragma checksum "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cc9f7813ac0bdabd1299253269799cebadb981f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cc9f7813ac0bdabd1299253269799cebadb981f", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("no-js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 605, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da3c79679294ba38cd42b24be67e481", async() => {
                BeginContext(41, 592, true);
                WriteLiteral(@"
<meta charset=""utf-8"">
<title>Welcome to Explore California</title>
<meta name=""description"" content=""A lynda.com example of HTML5 and CSS3"">
<meta name=""keywords"" content=""html5, css3, lynda, local storage, canvas, forms, semantics, web apps"">
<!--make sure mobile devices display the page at the proper scale	-->
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<!--[if lt IE 9]>
<script src=""http://html5shiv.googlecode.com/svn/trunk/html5.js""></script>
<![endif]-->
<link href=""/css/main.css"" rel=""stylesheet"" type=""text/css"" media=""screen, projection"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(640, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(642, 4085, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eabad7d5c394d8bab279a052c6f1dff", async() => {
                BeginContext(672, 1648, true);
                WriteLiteral(@"
<div id=""wrapper"">
  <header id=""mainHeader""> <a href=""/"" title=""home"" class=""logo"">
   <!-- I need this div because IE is an affront to mankind-->
    <div>
    <h1>Explore California</h1>
    </div>
    </a>
    <nav id=""siteNav"">
      <h1>Where do you want to go?</h1>
      <ul>
       <li><a href=""/tours.htm"" title=""Our tours"">Tours <br /><span class=""tagline"">follow our bliss</span></a>
          <ul>
            <li><a href=""/tours.htm"" title=""Our tours"">All Tours</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tours by Activity</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tours by Region</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tour Finder</a></li>
          </ul>
        </li>
        <li><a href=""mission.htm"" title=""What we believe"">Mission <br /><span class=""tagline"">what makes us different?</span></a></li>
        <li><a href=""resources.htm"" title=""planning resources"">Resources <br /><span class=""tagline"">plan your t");
                WriteLiteral(@"rip</span></a>
          <ul>
            <li><a href=""resources/faq.htm"" title=""Got questions?"">Tour FAQs</a></li>
            <li><a href=""resources/additional_resources.htm"" title=""additional resources"">Tour Information</a></li>
            <li><a href=""resources/terms.htm"" title=""terms and conditions"">Site Terms</a></li>
          </ul>
        </li>
        <li><a href=""explorers.htm"" title=""Our community"">Explorers <br /><span class=""tagline"">join our community</span></a>
          <ul>
            <li><a href=""explorers/join.htm"" title=""join our community"">Join the Explorers</a></li>
            <li>");
                EndContext();
                BeginContext(2321, 86, false);
#line 45 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Layout.cshtml"
           Write(Html.ActionLink("Read Our blog", "Index", "Blog", null, new { title="Read our blog"} ));

#line default
#line hidden
                EndContext();
                BeginContext(2407, 615, true);
                WriteLiteral(@"</li> <!--asp way of  of doing href and title -->
            <li><a href=""explorers/gallery.htm"" title=""contributor photos"">Tour Photos</a></li>
            <li><a href=""_video/EC_podcast_full version.mov"" title=""check out our podcast"">Video podcast</a></li>
          </ul>
        </li>
        <li><a href=""contact.htm"" title=""contact us"" class=""last"">Contact <br /><span class=""tagline"">we're listening</span></a>
          <ul>
            <li><a href=""support.htm"" title=""need help?"">Support</a></li>
          </ul>
        </li>
      </ul>
    </nav>
  </header>
  <section id=""actionCall"">
");
                EndContext();
#line 59 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Layout.cshtml"
       if (IsSectionDefined("header"))
      {
          

#line default
#line hidden
                BeginContext(3082, 30, false);
#line 61 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Layout.cshtml"
     Write(RenderSection("header", false));

#line default
#line hidden
                EndContext();
#line 61 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Layout.cshtml"
                                         
      }
      else
      {

#line default
#line hidden
                BeginContext(3144, 39, true);
                WriteLiteral("          <h1>put your shit here</h1>\r\n");
                EndContext();
#line 66 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Layout.cshtml"
      }

#line default
#line hidden
                BeginContext(3192, 79, true);
                WriteLiteral("\r\n  </section>\r\n  <div id=\"contentWrapper\">\r\n  <section id=\"mainContent\">\r\n    ");
                EndContext();
                BeginContext(3272, 12, false);
#line 71 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3284, 108, true);
                WriteLiteral("\r\n  </section>\r\n    <aside id=\"secondaryContent\">\r\n        <div id=\"specials\" class=\"callOut\">\r\n            ");
                EndContext();
                BeginContext(3393, 93, false);
#line 75 "F:\University\ASP.Net_core\MVC_application\MVC_application\MVC_application\Views\Shared\_Layout.cshtml"
       Write(await  (Component.InvokeAsync<MVC_application.ViewComponents.MonthlySpecialsViewComponent>()));

#line default
#line hidden
                EndContext();
                BeginContext(3486, 1234, true);
                WriteLiteral(@"
        </div>
    </aside>
  </div>
  <footer id=""pageFooter"">
  <section id=""quickLinks"">
  <h1>Quick Nav</h1>
    <ul id=""quickNav"">
      <li><a href=""/"" title=""Our home page"">Home</a></li>
      <li><a href=""/tours.htm"" title=""Explore our tours"">Tours</a></li>
      <li><a href=""mission.htm"" title=""What we think"">Mission</a></li>
      <li><a href=""resources.htm"" title=""Guidance and planning"">Resources</a></li>
      <li><a href=""explorers.htm"" title=""Join our community"">Explorers</a></li>
      <li><a href=""contact.htm"" title=""Contact and support"">Contact</a></li>
    </ul>
  </section>
  <section id=""footerResources"">
  <h1>Resources</h1>
    <ul id=""quickNav"">
      <li><a href=""resources/faq.htm"" title=""Our home page"">FAQ</a></li>
      <li><a href=""support.htm"" title=""Need help?"">Support</a></li>
      <li><a href=""resources/legal.htm"" title=""The fine print"">Legal</a></li><li><a href=""login.htm"">Login</a></li>
    </ul>
  </section>
  <section id=""companyInfo"">
  <h1>Contac");
                WriteLiteral("t</h1>\r\n  <h2>Explore California</h2>\r\n      <p>5605 Nota Street<br />\r\n        Ventura, CA 93003</p>\r\n      <p>866.555.4310<br />866.555.4315 <em>(24 hour support)</em></p>\r\n  </section>\r\n  </footer>\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4727, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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