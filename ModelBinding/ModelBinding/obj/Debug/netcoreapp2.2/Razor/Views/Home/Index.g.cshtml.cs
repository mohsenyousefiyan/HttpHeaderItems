#pragma checksum "D:\Projects\NetCore\LearningProj\ModelBinding\ModelBinding\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55d4729449ee939ceb4f7f71006613a728060b6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Projects\NetCore\LearningProj\ModelBinding\ModelBinding\Views\_ViewImports.cshtml"
using ModelBinding.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55d4729449ee939ceb4f7f71006613a728060b6b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03245b11eef884dfdad803028cac4ab03e31b6ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string,object>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 203, true);
            WriteLiteral("\r\n<table class=\"table table-bordered table-responsive table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>ItemName</th>\r\n            <th>ItemValue</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 11 "D:\Projects\NetCore\LearningProj\ModelBinding\ModelBinding\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(286, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(347, 8, false);
#line 15 "D:\Projects\NetCore\LearningProj\ModelBinding\ModelBinding\Views\Home\Index.cshtml"
               Write(item.Key);

#line default
#line hidden
            EndContext();
            BeginContext(355, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(423, 10, false);
#line 18 "D:\Projects\NetCore\LearningProj\ModelBinding\ModelBinding\Views\Home\Index.cshtml"
               Write(item.Value);

#line default
#line hidden
            EndContext();
            BeginContext(433, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 21 "D:\Projects\NetCore\LearningProj\ModelBinding\ModelBinding\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(488, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string,object>> Html { get; private set; }
    }
}
#pragma warning restore 1591