#pragma checksum "C:\Users\Hoang\Desktop\Login\Web_PL\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34731e4dc9e9bf370ac76934f285c0c02c031832"
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
#line 1 "C:\Users\Hoang\Desktop\Login\Web_PL\Views\_ViewImports.cshtml"
using Web_PL;

#line default
#line hidden
#line 2 "C:\Users\Hoang\Desktop\Login\Web_PL\Views\_ViewImports.cshtml"
using Web_PL.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34731e4dc9e9bf370ac76934f285c0c02c031832", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ecce4bff551818234d8309d4bbd890b9bf02ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Hoang\Desktop\Login\Web_PL\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Login";
    

#line default
#line hidden
            BeginContext(47, 39, true);
            WriteLiteral("<!-- Html.Action(\"Index\",\"Home\"); -->\r\n");
            EndContext();
            BeginContext(106, 273, true);
            WriteLiteral(@"<!-- bool anyRows = custs.Any(); -->



    



  
    
     <!-- <img src=""Logo.png"" alt=""Responsive Image"" class= ""d-flex justify-content-center mx-auto my-5"" height=10% width=10%></div> -->
<div class=""wrapper"">
    <div class=""form-signin"" name=""logform"">
");
            EndContext();
#line 20 "C:\Users\Hoang\Desktop\Login\Web_PL\Views\Home\Index.cshtml"
     using (Html.BeginForm()) 
    {  

#line default
#line hidden
            BeginContext(420, 38, true);
            WriteLiteral("        <h3 >Login</h3>\r\n        <!-- ");
            EndContext();
            BeginContext(459, 64, false);
#line 23 "C:\Users\Hoang\Desktop\Login\Web_PL\Views\Home\Index.cshtml"
        Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(523, 6, true);
            WriteLiteral(" -->\r\n");
            EndContext();
            BeginContext(538, 180, false);
#line 24 "C:\Users\Hoang\Desktop\Login\Web_PL\Views\Home\Index.cshtml"
   Write(Html.EditorFor(Model => Model.userName, new { htmlAttributes = new { @class = "form-control inputaspun", @name="username" , @placeholder="User Name", @required="", @autofocus=""}}));

#line default
#line hidden
            EndContext();
            BeginContext(720, 13, true);
            WriteLiteral("        <!-- ");
            EndContext();
            BeginContext(734, 86, false);
#line 25 "C:\Users\Hoang\Desktop\Login\Web_PL\Views\Home\Index.cshtml"
        Write(Html.ValidationMessageFor(model => model.userName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(820, 137, true);
            WriteLiteral("       -->\r\n      <!-- <input type=\"text\" class=\"form-control\" name=\"username\"  placeholder=\"User Name\" required=\"\" autofocus=\"\" /> -->\r\n");
            EndContext();
            BeginContext(966, 181, false);
#line 27 "C:\Users\Hoang\Desktop\Login\Web_PL\Views\Home\Index.cshtml"
   Write(Html.EditorFor(Model => Model.password, new { htmlAttributes = new { @class = "form-control inputasppw",@type="password", @name="password" , @placeholder="Password", @required=""}}));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 13, true);
            WriteLiteral("        <!-- ");
            EndContext();
            BeginContext(1163, 85, false);
#line 28 "C:\Users\Hoang\Desktop\Login\Web_PL\Views\Home\Index.cshtml"
        Write(Html.ValidationMessageFor(model => model.password, "", new {@class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 70, true);
            WriteLiteral("       -->\r\n        <p class=\"text-center col-sm-8\" style=\'color:red\'>");
            EndContext();
            BeginContext(1319, 17, false);
#line 29 "C:\Users\Hoang\Desktop\Login\Web_PL\Views\Home\Index.cshtml"
                                                     Write(ViewData["wrong"]);

#line default
#line hidden
            EndContext();
            BeginContext(1336, 237, true);
            WriteLiteral("</p>\r\n      <!-- <input type=\"password\" class=\"form-control\" name=\"password\"  minlength=\"8\" maxlength=\"12\" placeholder=\"Password\" required=\"\"/> -->\r\n      <button class=\"btn btn-lg btn-success btn-block\" type=\"submit\">Login</button>   \r\n");
            EndContext();
#line 32 "C:\Users\Hoang\Desktop\Login\Web_PL\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1580, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
