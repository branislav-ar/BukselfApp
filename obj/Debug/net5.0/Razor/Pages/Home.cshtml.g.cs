#pragma checksum "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b00f4c437a1da7d46e7776d98ead30e2c0a7c224"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Home), @"mvc.1.0.razor-page", @"/Pages/Home.cshtml")]
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
#line 2 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
using ProjekatSWE.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b00f4c437a1da7d46e7776d98ead30e2c0a7c224", @"/Pages/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da39a3ee5e6b4b0d3255bfef95601890afd80709", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Home";

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b00f4c437a1da7d46e7776d98ead30e2c0a7c2243682", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>NASLOVNA | BUKŠELF</title>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b00f4c437a1da7d46e7776d98ead30e2c0a7c2245240", async() => {
                WriteLiteral("\r\n\r\n    <!-- Header starting here! -->\r\n<header>\r\n    <h1 class=\"heading\"><a");
                BeginWriteAttribute("href", " href=\"", 1105, "\"", 1150, 2);
                WriteAttributeValue("", 1112, "home?username=", 1112, 14, true);
#nullable restore
#line 37 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 1126, Model.Korisnik.Username, 1126, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img width=\"200\" src=\"images/bukšelf_croppedLONG.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1205, "\"", 1211, 0);
                EndWriteAttribute();
                WriteLiteral("></a></h1>\r\n    \r\n    <div id=\"menu\" class=\"fas fa-bars\"></div>\r\n\r\n    <nav class=\"navbar\">\r\n        <ul>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 1337, "\"", 1384, 2);
                WriteAttributeValue("", 1344, "profil?username=", 1344, 16, true);
#nullable restore
#line 43 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 1360, Model.Korisnik.Username, 1360, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Moj profil</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 1425, "\"", 1470, 2);
                WriteAttributeValue("", 1432, "home?username=", 1432, 14, true);
#nullable restore
#line 44 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 1446, Model.Korisnik.Username, 1446, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Naslovna</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 1509, "\"", 1554, 2);
                WriteAttributeValue("", 1516, "feed?username=", 1516, 14, true);
#nullable restore
#line 45 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 1530, Model.Korisnik.Username, 1530, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">NEWS</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 1589, "\"", 1635, 2);
                WriteAttributeValue("", 1596, "index?username=", 1596, 15, true);
#nullable restore
#line 46 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 1611, Model.Korisnik.Username, 1611, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Početna</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 1673, "\"", 1719, 2);
                WriteAttributeValue("", 1680, "about?username=", 1680, 15, true);
#nullable restore
#line 47 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 1695, Model.Korisnik.Username, 1695, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">O nama!</a></li>
            <li><a href=""uhome"">Log out</a></li>
        </ul>
    </nav>
</header>
    <!-- Header ending here! -->

    <!-- BUKSELF starting here! -->
    <section class=""BUKSELF"">

        <div class=""box-container"">
            

            <!-- pretraga starting -->

            <div class=""segment-pretraga"">

                <div class=""naslov-deo"">
                    <h3>PRETRAŽI KNJIGE!</h3>
                    <h2>Odaberi žanr.</h2>
                </div>

                <div class=""naslov_i_pisac"">
                    <form method=""GET"">
                        <div class=""polje_BIG"">
                            <input type=""text"" class=""polje"" name=""searchIme"" placeholder=""Naslov dela..."">
                            <input type=""text"" class=""polje"" name=""searchPisac"" placeholder=""Ime pisca..."">
                            <input type=""hidden"" name=""username""");
                BeginWriteAttribute("value", " value=", 2651, "", 2682, 1);
#nullable restore
#line 74 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 2658, Model.Korisnik.Username, 2658, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            <button type=""submit"" class=""btn"">Pretraga</button>
                        </div>
                    </form>
                </div> 
                
                <div class=""zanrovi-deo"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 2941, "\"", 3003, 2);
                WriteAttributeValue("", 2948, "homes?zanr=Biografija&username=", 2948, 31, true);
#nullable restore
#line 81 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 2979, Model.Korisnik.Username, 2979, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Biografija</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3047, "\"", 3105, 2);
                WriteAttributeValue("", 3054, "homes?zanr=Decija&username=", 3054, 27, true);
#nullable restore
#line 82 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 3081, Model.Korisnik.Username, 3081, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Dečije</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3145, "\"", 3202, 2);
                WriteAttributeValue("", 3152, "homes?zanr=Drama&username=", 3152, 26, true);
#nullable restore
#line 83 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 3178, Model.Korisnik.Username, 3178, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Drama</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3241, "\"", 3303, 2);
                WriteAttributeValue("", 3248, "homes?zanr=Fantastika&username=", 3248, 31, true);
#nullable restore
#line 84 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 3279, Model.Korisnik.Username, 3279, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Fantastika</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3347, "\"", 3406, 2);
                WriteAttributeValue("", 3354, "homes?zanr=Fikcija&username=", 3354, 28, true);
#nullable restore
#line 85 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 3382, Model.Korisnik.Username, 3382, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Fikcija</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3447, "\"", 3504, 2);
                WriteAttributeValue("", 3454, "homes?zanr=Horor&username=", 3454, 26, true);
#nullable restore
#line 86 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 3480, Model.Korisnik.Username, 3480, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Horor</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3543, "\"", 3603, 2);
                WriteAttributeValue("", 3550, "homes?zanr=Istorija&username=", 3550, 29, true);
#nullable restore
#line 87 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 3579, Model.Korisnik.Username, 3579, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Istorija</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3645, "\"", 3706, 2);
                WriteAttributeValue("", 3652, "homes?zanr=Misterija&username=", 3652, 30, true);
#nullable restore
#line 88 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 3682, Model.Korisnik.Username, 3682, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Misterija</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3749, "\"", 3810, 2);
                WriteAttributeValue("", 3756, "homes?zanr=Romantika&username=", 3756, 30, true);
#nullable restore
#line 89 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 3786, Model.Korisnik.Username, 3786, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Romantika</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3853, "\"", 3911, 2);
                WriteAttributeValue("", 3860, "homes?zanr=Triler&username=", 3860, 27, true);
#nullable restore
#line 90 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 3887, Model.Korisnik.Username, 3887, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Triler</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3951, "\"", 4011, 2);
                WriteAttributeValue("", 3958, "homes?zanr=Umetnost&username=", 3958, 29, true);
#nullable restore
#line 91 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 3987, Model.Korisnik.Username, 3987, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Umetnost</a>\r\n                </div>\r\n                \r\n            </div>\r\n\r\n            <!-- pretraga ending -->\r\n\r\n            <!-- knjige starting -->\r\n\r\n");
#nullable restore
#line 100 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
             foreach (var v in Model.Knjige)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"segment-knjige\">\r\n\r\n                <div class=\"knjiga-singular\">\r\n\r\n                    <div class=\"cover-image\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4398, "\"", 4452, 4);
                WriteAttributeValue("", 4405, "book?id=", 4405, 8, true);
#nullable restore
#line 107 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 4413, v.ID, 4413, 5, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4418, "&username=", 4418, 10, true);
#nullable restore
#line 107 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 4428, Model.Korisnik.Username, 4428, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <img");
                BeginWriteAttribute("src", " src=", 4484, "", 4502, 1);
#nullable restore
#line 108 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 4489, v.BPhotoPath, 4489, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"naslovna_slika\">  \r\n                        </a>\r\n                    </div>\r\n                    <div class=\"description\">\r\n\r\n                        <div class=\"title\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 4710, "\"", 4764, 4);
                WriteAttributeValue("", 4717, "book?id=", 4717, 8, true);
#nullable restore
#line 114 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 4725, v.ID, 4725, 5, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4730, "&username=", 4730, 10, true);
#nullable restore
#line 114 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 4740, Model.Korisnik.Username, 4740, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 114 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
                                                                                 Write(v.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                        </div>\r\n\r\n                        <div class=\"author\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 4888, "\"", 4943, 4);
                WriteAttributeValue("", 4895, "Pisac?id=", 4895, 9, true);
#nullable restore
#line 118 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 4904, v.ID, 4904, 5, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4909, "&username=", 4909, 10, true);
#nullable restore
#line 118 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 4919, Model.Korisnik.Username, 4919, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span>");
#nullable restore
#line 118 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
                                                                                        Write(v.Pisac);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></a>\r\n                        </div>\r\n                         <div class=\"author\">\r\n                            <span>");
#nullable restore
#line 121 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
                             Write(v.Godina);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        </div>\r\n\r\n                        <div class=\"concrete-description\">\r\n                        \r\n                            <span>\r\n                            ");
#nullable restore
#line 127 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
                       Write(v.KnjigaOpis);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n                    \r\n                    </div>\r\n\r\n\r\n                </div>\r\n            \r\n            <!-- knjige ending -->\r\n    \r\n        </div>\r\n");
#nullable restore
#line 139 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </section>\r\n\r\n    <!-- BUKSELF ending here!-->\r\n\r\n    <!-- Footer section starting here! -->\r\n\r\n   <div class=\"footer\">\r\n        <div class=\"box-container\">\r\n            <div class=\"box\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 5749, "\"", 5795, 2);
                WriteAttributeValue("", 5756, "about?username=", 5756, 15, true);
#nullable restore
#line 150 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 5771, Model.Korisnik.Username, 5771, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("rel", " rel=\"", 5796, "\"", 5802, 0);
                EndWriteAttribute();
                WriteLiteral(">Saznaj ko smo mi!</a>\r\n            </div>\r\n\r\n            <div class=\"box\">\r\n                <h3>Prečice</h3>\r\n                    <div class=\"box2\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 5980, "\"", 6025, 2);
                WriteAttributeValue("", 5987, "home?username=", 5987, 14, true);
#nullable restore
#line 156 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 6001, Model.Korisnik.Username, 6001, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("rel", " rel=\"", 6026, "\"", 6032, 0);
                EndWriteAttribute();
                WriteLiteral(">Naslovna</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 6074, "\"", 6120, 2);
                WriteAttributeValue("", 6081, "about?username=", 6081, 15, true);
#nullable restore
#line 157 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\Home.cshtml"
WriteAttributeValue("", 6096, Model.Korisnik.Username, 6096, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("rel", " rel=\"", 6121, "\"", 6127, 0);
                EndWriteAttribute();
                WriteLiteral(">O nama!</a>\r\n                        <a href=\"uhome\"");
                BeginWriteAttribute("rel", " rel=\"", 6181, "\"", 6187, 0);
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HomeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HomeModel>)PageContext?.ViewData;
        public HomeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
