#pragma checksum "C:\Users\Sa3d\source\repos\FirstProjectV1\FirstProjectV1\Views\Games\Print.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9bbcb5d80500a12d72fd90b5731be0ff95c11c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Print), @"mvc.1.0.view", @"/Views/Games/Print.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9bbcb5d80500a12d72fd90b5731be0ff95c11c7", @"/Views/Games/Print.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c05210464e06c2b0acaea2dad787b9fdb54df870", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Print : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FirstProjectV1.Models.Game>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sa3d\source\repos\FirstProjectV1\FirstProjectV1\Views\Games\Print.cshtml"
  
    ViewData["Title"] = "Print";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Name : ");
#nullable restore
#line 6 "C:\Users\Sa3d\source\repos\FirstProjectV1\FirstProjectV1\Views\Games\Print.cshtml"
      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>Rating = ");
#nullable restore
#line 7 "C:\Users\Sa3d\source\repos\FirstProjectV1\FirstProjectV1\Views\Games\Print.cshtml"
        Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<h1>INDEX</h1>

<div class=""first"">
    <p> FIRST PROJECT TEST</p>
</div>

<div class=""container-fluid border border-primary"">
    zero
    <div class=""container border border-primary"">One
        <div class=""container border border-primary"">one point one
        </div>
    </div>
    <div class=""container border border-primary"">Two </div>
</div>

<br />

<table  border=""1""  width=""100%"">
    <tr>
        <td>first</td>
        <td>second</td>
        <td>Third</td>
    </tr>

    <tr>
        <td class=""col-sm-6""> first one</td>
        <td class="" col-1""> second one</td>
        <td class=""col""> third one</td>
    </tr>
</table>

<div class=""container img-fluid border border-secondary"">
    pic
</div>



");
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