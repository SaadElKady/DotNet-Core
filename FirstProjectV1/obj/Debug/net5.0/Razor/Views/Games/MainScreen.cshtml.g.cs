#pragma checksum "C:\Users\Sa3d\source\repos\FirstProjectV1\FirstProjectV1\Views\Games\MainScreen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d21cb045be005789e17b171d66ae97be2e59593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_MainScreen), @"mvc.1.0.view", @"/Views/Games/MainScreen.cshtml")]
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
#line 1 "C:\Users\Sa3d\source\repos\FirstProjectV1\FirstProjectV1\Views\_ViewImports.cshtml"
using FirstProjectV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sa3d\source\repos\FirstProjectV1\FirstProjectV1\Views\_ViewImports.cshtml"
using FirstProjectV1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d21cb045be005789e17b171d66ae97be2e59593", @"/Views/Games/MainScreen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c05210464e06c2b0acaea2dad787b9fdb54df870", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_MainScreen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FirstProjectV1.Models.Game>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sa3d\source\repos\FirstProjectV1\FirstProjectV1\Views\Games\MainScreen.cshtml"
  
    ViewData["Title"] = "MainScreen";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MainScreen</h1>\r\n<fieldset>\r\n");
#nullable restore
#line 8 "C:\Users\Sa3d\source\repos\FirstProjectV1\FirstProjectV1\Views\Games\MainScreen.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Sa3d\source\repos\FirstProjectV1\FirstProjectV1\Views\Games\MainScreen.cshtml"
   Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Sa3d\source\repos\FirstProjectV1\FirstProjectV1\Views\Games\MainScreen.cshtml"
   Write(Html.EditorFor(y => y.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Sa3d\source\repos\FirstProjectV1\FirstProjectV1\Views\Games\MainScreen.cshtml"
                                    
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</fieldset>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstProjectV1.Models.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
