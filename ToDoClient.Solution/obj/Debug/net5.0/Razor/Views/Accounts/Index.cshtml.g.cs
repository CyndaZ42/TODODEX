#pragma checksum "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/Accounts/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b026b904866d26f319b5ec06eddbb29072b2960"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Index), @"mvc.1.0.view", @"/Views/Accounts/Index.cshtml")]
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
#line 1 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/_ViewImports.cshtml"
using ToDoClient.Solution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/Accounts/Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/Accounts/Index.cshtml"
using ToDoClient.Solution.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b026b904866d26f319b5ec06eddbb29072b2960", @"/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b342d05df0d6b78ae0edad84545d664f9b9665", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoClient.Solution.Models.ApplicationUser>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/Accounts/Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>Hello ");
#nullable restore
#line 7 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/Accounts/Index.cshtml"
      Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 8 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/Accounts/Index.cshtml"
   using (Html.BeginForm("LogOff", "Accounts"))
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Log Out</button>\n");
#nullable restore
#line 11 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/Accounts/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/Accounts/Index.cshtml"
   
}
else
{
  

#line default
#line hidden
#nullable disable
            WriteLiteral("  <a");
            BeginWriteAttribute("href", " href=\'", 330, "\'", 360, 1);
#nullable restore
#line 16 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/Accounts/Index.cshtml"
WriteAttributeValue("", 337, Url.Action("Register"), 337, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"w3-button w3-border w3-hover-indigo\">Register</button></a>\n  <a");
            BeginWriteAttribute("href", " href=\'", 440, "\'", 467, 1);
#nullable restore
#line 17 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/Accounts/Index.cshtml"
WriteAttributeValue("", 447, Url.Action("Login"), 447, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"w3-button w3-border w3-hover-indigo\">Log In</button></a>\n");
#nullable restore
#line 18 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/Accounts/Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoClient.Solution.Models.ApplicationUser> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
