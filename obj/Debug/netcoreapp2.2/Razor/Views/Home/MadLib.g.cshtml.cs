#pragma checksum "/Users/frederickernest/Desktop/MadLib.Solution/MadLib/Views/Home/MadLib.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd409def034d5ea418a23dd23ddcea4ae0473ce4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MadLib), @"mvc.1.0.view", @"/Views/Home/MadLib.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MadLib.cshtml", typeof(AspNetCore.Views_Home_MadLib))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd409def034d5ea418a23dd23ddcea4ae0473ce4", @"/Views/Home/MadLib.cshtml")]
    public class Views_Home_MadLib : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<h1>Hello From Afar</h1>\n<p>Dear ");
            EndContext();
            BeginContext(34, 10, false);
#line 2 "/Users/frederickernest/Desktop/MadLib.Solution/MadLib/Views/Home/MadLib.cshtml"
   Write(Model.Noun);

#line default
#line hidden
            EndContext();
            BeginContext(44, 131, true);
            WriteLiteral(",</p>\n<p>How are you? I hope that you are having a nice weekend. I\'m vacationing in the Iceland while I learn programming! </p>\n<p>");
            EndContext();
            BeginContext(176, 15, false);
#line 4 "/Users/frederickernest/Desktop/MadLib.Solution/MadLib/Views/Home/MadLib.cshtml"
Write(Model.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(191, 268, true);
            WriteLiteral(@", you would not believe how cold it is here. I should have gone to Hawaii instead.</p>
<p>But I like programming a lot, so I've got that going for me. </p>
<p>Looking forward to seeing you soon. I'll bring you back a souvenir. </p>
<p>Cheers,</p>
<p>Travel Enthusiast ");
            EndContext();
            BeginContext(460, 12, false);
#line 8 "/Users/frederickernest/Desktop/MadLib.Solution/MadLib/Views/Home/MadLib.cshtml"
                Write(Model.Sender);

#line default
#line hidden
            EndContext();
            BeginContext(472, 4, true);
            WriteLiteral("</p>");
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