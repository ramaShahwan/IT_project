#pragma checksum "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Views\Shared\_NotificatioPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e146e26dd6c0ee807d641762a89db38f04d1cdef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NotificatioPartial), @"mvc.1.0.view", @"/Views/Shared/_NotificatioPartial.cshtml")]
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
#line 1 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Views\_ViewImports.cshtml"
using learnIte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Views\_ViewImports.cshtml"
using learnIte.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Views\_ViewImports.cshtml"
using MyTables.Entity.NewFolder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Views\_ViewImports.cshtml"
using ITE_Project.Dto.Scholarship;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e146e26dd6c0ee807d641762a89db38f04d1cdef", @"/Views/Shared/_NotificatioPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1609a8f268206c99e9f7ce1600c062ab0f8bff1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NotificatioPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Views\Shared\_NotificatioPartial.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success notification\">\r\n        ");
#nullable restore
#line 4 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Views\Shared\_NotificatioPartial.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 6 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Views\Shared\_NotificatioPartial.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Views\Shared\_NotificatioPartial.cshtml"
 if (TempData["Error"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger alert-dismissible fade show\">\r\n    ");
#nullable restore
#line 11 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Views\Shared\_NotificatioPartial.cshtml"
Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n    </button>\r\n</div>\r\n");
#nullable restore
#line 16 "C:\Users\InformaTeam\Desktop\New folder (8)\New folder\ITE_Project\learnIte\Views\Shared\_NotificatioPartial.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("          ");
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