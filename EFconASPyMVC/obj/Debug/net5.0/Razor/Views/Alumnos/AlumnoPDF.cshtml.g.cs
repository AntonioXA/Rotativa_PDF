#pragma checksum "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7674a0e6816716a8897c7447466bcbb32926458e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumnos_AlumnoPDF), @"mvc.1.0.view", @"/Views/Alumnos/AlumnoPDF.cshtml")]
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
#line 1 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\_ViewImports.cshtml"
using EFconASPyMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\_ViewImports.cshtml"
using EFconASPyMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7674a0e6816716a8897c7447466bcbb32926458e", @"/Views/Alumnos/AlumnoPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c45910b61296ae55acfee50127034d2e663ec7e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Alumnos_AlumnoPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EFconASPyMVC.Models.Alumno>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
  
	ViewData["Title"] = "AlumnoPDF";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
  
	Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7674a0e6816716a8897c7447466bcbb32926458e5022", async() => {
                WriteLiteral("\r\n\t<meta name=\"viewport\" content=\"width=device-width\" />\r\n\t<title>AlumnoPDF</title>\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7674a0e6816716a8897c7447466bcbb32926458e5375", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7674a0e6816716a8897c7447466bcbb32926458e6551", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7674a0e6816716a8897c7447466bcbb32926458e8433", async() => {
                WriteLiteral("\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-sm-8 text-right\">\r\n\t\t\t<h2>Lista de Alumnos</h2>\r\n\t\t</div>\r\n\t</div>\r\n\t<table class=\"table\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n");
                WriteLiteral("\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 28 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 31 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 34 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
               Write(Html.DisplayNameFor(model => model.Edad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 37 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
               Write(Html.DisplayNameFor(model => model.ClaseId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 40 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
               Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 43 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
               Write(Html.DisplayNameFor(model => model.AlumnoTareas));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 46 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
               Write(Html.DisplayNameFor(model => model.Clase));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
#nullable restore
#line 51 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
             foreach (var item in Model)
			{
				

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 56 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 59 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 62 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Edad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 65 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ClaseId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 68 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Usuario));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 71 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AlumnoTareas));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 74 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Clase));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 77 "C:\Users\Usuario\OneDrive\Escritorio\EFconASPyMVC\EFconASPyMVC\Views\Alumnos\AlumnoPDF.cshtml"
			}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EFconASPyMVC.Models.Alumno>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591