#pragma checksum "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23ef1e2de5ca6eb69acad6670e86ba1a7de86d8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_NovPisac), @"mvc.1.0.razor-page", @"/Pages/NovPisac.cshtml")]
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
#line 2 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
using ProjekatSWE.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ef1e2de5ca6eb69acad6670e86ba1a7de86d8f", @"/Pages/NovPisac.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da39a3ee5e6b4b0d3255bfef95601890afd80709", @"/Pages/_ViewImports.cshtml")]
    public class Pages_NovPisac : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Nova knjiga";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"Styles/Style.css\">\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js\"></script>\r\n    <script language=\"JavaScript\" src=\"Scripts/Script.js\" type=\"text/javascript\" ></script>\r\n");
            }
            );
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ef1e2de5ca6eb69acad6670e86ba1a7de86d8f5126", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>IZMENI PROFIL | BUKŠELF</title>

    <!-- icon link -->
    <link rel=""icon"" href=""favicon.ico""/>

    <!-- font awesome cdn link  -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    
    <!-- custom css file link  -->
    <link rel=""stylesheet"" href=""css/style.css"">

");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ef1e2de5ca6eb69acad6670e86ba1a7de86d8f6693", async() => {
                WriteLiteral("\r\n\r\n    <!-- Header starting here! -->\r\n<header>\r\n    <h1 class=\"heading\"><a");
                BeginWriteAttribute("href", " href=\"", 1179, "\"", 1224, 2);
                WriteAttributeValue("", 1186, "home?username=", 1186, 14, true);
#nullable restore
#line 38 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
WriteAttributeValue("", 1200, Model.Korisnik.Username, 1200, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img width=\"200\" src=\"https://i.imgur.com/ErOW7Ri.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1280, "\"", 1286, 0);
                EndWriteAttribute();
                WriteLiteral("></a></h1>\r\n    \r\n    <div id=\"menu\" class=\"fas fa-bars\"></div>\r\n\r\n    <nav class=\"navbar\">\r\n        <ul>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 1412, "\"", 1459, 2);
                WriteAttributeValue("", 1419, "profil?username=", 1419, 16, true);
#nullable restore
#line 44 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
WriteAttributeValue("", 1435, Model.Korisnik.Username, 1435, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Moj profil</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 1500, "\"", 1545, 2);
                WriteAttributeValue("", 1507, "home?username=", 1507, 14, true);
#nullable restore
#line 45 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
WriteAttributeValue("", 1521, Model.Korisnik.Username, 1521, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Naslovna</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 1584, "\"", 1629, 2);
                WriteAttributeValue("", 1591, "feed?username=", 1591, 14, true);
#nullable restore
#line 46 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
WriteAttributeValue("", 1605, Model.Korisnik.Username, 1605, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">NEWS</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 1664, "\"", 1710, 2);
                WriteAttributeValue("", 1671, "index?username=", 1671, 15, true);
#nullable restore
#line 47 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
WriteAttributeValue("", 1686, Model.Korisnik.Username, 1686, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Početna</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 1748, "\"", 1794, 2);
                WriteAttributeValue("", 1755, "about?username=", 1755, 15, true);
#nullable restore
#line 48 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
WriteAttributeValue("", 1770, Model.Korisnik.Username, 1770, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">O nama!</a></li>\r\n            <li><a href=\"uhome\">Log out</a></li>\r\n        </ul>\r\n    </nav>\r\n</header>\r\n    <!-- Header ending here! -->\r\n       <!-- dodajKnjigu starting here! -->\r\n\r\n    <section class=\"profile\">\r\n    \r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ef1e2de5ca6eb69acad6670e86ba1a7de86d8f10478", async() => {
                    WriteLiteral("\r\n            ");
#nullable restore
#line 59 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
            <div class=""title""> 
                <h3>DODAJ NOVOG PISCA</h3>
            </div>
            
            <div class=""user-side"">

                <div class=""pic_and_button"">
                        <div class=""user-picEDIT"">
                            <img width=""200"" src=""images/basic.png""");
                    BeginWriteAttribute("alt", " alt=\"", 2443, "\"", 2449, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group row\">\r\n                \r\n                            <div>\r\n                                <div >\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23ef1e2de5ca6eb69acad6670e86ba1a7de86d8f11699", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 74 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Photo);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                
                <div class=""user-infoPRIMARY"">
                    <div class=""user-info"">

                        <div class=""info-boxEDIT"">
                            <span class=""item1"">Ime autora</span>
                            <input type=""text"" class=""item2EDIT"" name=Pisac.PIme placeholder=""Unesite ime pisca..."" required>
                        </div>
                        
                        <div class=""info-boxEDIT"">
                            <span class=""item1"">Prezime autora</span>
                            <input type=""text"" class=""item2EDIT"" name=Pisac.PPrezime placeholder=""Unesite prezime autora..."" required>
                        </div>

                    </div>
                    <div class=""user-info"">
                        
                        <div class=""info-box"">
                            <");
                    WriteLiteral(@"span class=""item1"">Datum rodjenja autora</span>
                            <input type=""date"" class=""item2EDIT"" name=Pisac.PDatum value=""2000-07-22"" min=""1500-01-01"" max=""2021-07-07"">
                        </div>



                
                    </div>
                </div>

            </div>

            <div class=""user-info"">
                <div class=""user-info2"">

                    <div class=""info-box"">
                        <span class=""item1"">Opis</span>
                        <textarea class=""item2EDIT_opis"" name=Pisac.POpis placeholder=""Unesite opis...""></textarea>
                    </div>

                </div>
            </div>

        </div>
    </div>
    
        <!-- Inof deo ending here! -->

        <!-- Ekstra content starting here! -->

        <div class=""content"">
                   

            <div class=""button_partSAVE"">
                <input type=""submit"" value=""Sačuvaj izmene!"" class=""btnEDIT_save"">
            </div> 

");
                    WriteLiteral("        </div>\r\n\r\n            <!-- Ekstra content ending here! -->\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </section>\r\n    <!-- profile section starting here! -->\r\n\r\n    <!-- Footer section starting here! -->\r\n\r\n    <div class=\"footer\">\r\n        <div class=\"box-container\">\r\n            <div class=\"box\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 5045, "\"", 5091, 2);
                WriteAttributeValue("", 5052, "about?username=", 5052, 15, true);
#nullable restore
#line 146 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
WriteAttributeValue("", 5067, Model.Korisnik.Username, 5067, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("rel", " rel=\"", 5092, "\"", 5098, 0);
                EndWriteAttribute();
                WriteLiteral(">Saznaj ko smo mi!</a>\r\n            </div>\r\n\r\n            <div class=\"box\">\r\n                <h3>Prečice</h3>\r\n                    <div class=\"box2\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 5276, "\"", 5321, 2);
                WriteAttributeValue("", 5283, "home?username=", 5283, 14, true);
#nullable restore
#line 152 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
WriteAttributeValue("", 5297, Model.Korisnik.Username, 5297, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("rel", " rel=\"", 5322, "\"", 5328, 0);
                EndWriteAttribute();
                WriteLiteral(">Naslovna</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 5370, "\"", 5416, 2);
                WriteAttributeValue("", 5377, "about?username=", 5377, 15, true);
#nullable restore
#line 153 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\NovPisac.cshtml"
WriteAttributeValue("", 5392, Model.Korisnik.Username, 5392, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("rel", " rel=\"", 5417, "\"", 5423, 0);
                EndWriteAttribute();
                WriteLiteral(">O nama!</a>\r\n                        <a href=\"uhome\"");
                BeginWriteAttribute("rel", " rel=\"", 5477, "\"", 5483, 0);
                EndWriteAttribute();
                WriteLiteral(@">Log out</a>                       
                    </div>
            </div>
            
            <div class=""box"">


                   <div class=""socials"">
                        <a href=""#""><i class=""fa fa-facebook""></i></a>
                        <a href=""#""><i class=""fa fa-instagram""></i></a>
                        <a href=""#""><i class=""fa fa-twitter""></i></a>
                    </div>
            </div>
        </div>

        <h1 class=""credit""> created by <a href=""#"">TeamBLS</a> | all rights reserved. </h1>
    </div>

    <!-- Footer section ending here! -->

    <!-- jquery cdn link  -->
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>

    <!-- custom js file link  -->
<script src=""js/script.js""></script>

");
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NovPisacModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NovPisacModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NovPisacModel>)PageContext?.ViewData;
        public NovPisacModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
