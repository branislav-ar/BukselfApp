#pragma checksum "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c4355c6c94a113906926ec29f7cd145059afdad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_UHomeS), @"mvc.1.0.razor-page", @"/Pages/UHomeS.cshtml")]
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
#line 2 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
using ProjekatSWE.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c4355c6c94a113906926ec29f7cd145059afdad", @"/Pages/UHomeS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da39a3ee5e6b4b0d3255bfef95601890afd80709", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UHomeS : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c4355c6c94a113906926ec29f7cd145059afdad3696", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c4355c6c94a113906926ec29f7cd145059afdad5254", async() => {
                WriteLiteral("\r\n\r\n    <!-- Header starting here! -->\r\n<header>\r\n    <h1 class=\"heading\"><a href=\"uhome\"><img width=\"200\" src=\"images/bukšelf_croppedLONG.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1174, "\"", 1180, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a></h1>
    
    <div id=""menu"" class=""fas fa-bars""></div>

    <nav class=""navbar"">
        <ul>
            <li><a href=""login"">Log in</a></li>
            <li><a href=""uhome"">Početna</a></li>
            <li><a href=""uindex"">Naslovna</a></li>
            <li><a href=""uabout"">O nama!</a></li>
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
                    <form method=""POST"">
                         ");
#nullable restore
#line 69 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
                    Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <div class=""polje_BIG"">
                            <input type=""text"" class=""polje"" name=""searchIme"" placeholder=""Naslov dela..."">
                            <input type=""text"" class=""polje"" name=""searchPisac"" placeholder=""Ime pisca..."">
                            <button type=""submit"" class=""btn"">Pretraga</button>
                        </div>
                    </form>
                </div>
                
                <div class=""zanrovi-deo"">
                        <a href=""uhomes?zanr=Biografija"">Biografija</a>
                        <a href=""uhomes?zanr=Decija"">Dečije</a>
                        <a href=""uhomes?zanr=Drama"">Drama</a>
                        <a href=""uhomes?zanr=Fantastika"">Fantastika</a>
                        <a href=""uhomes?zanr=Fikcija"">Fikcija</a>
                        <a href=""uhomes?zanr=Horor"">Horor</a>
                        <a href=""uhomes?zanr=Istorija"">Istorija</a>
                        <a href=""uhomes?zanr=Misterija""");
                WriteLiteral(@">Misterija</a>
                        <a href=""uhomes?zanr=Romantika"">Romantika</a>
                        <a href=""uhomes?zanr=Triler"">Triler</a>
                        <a href=""uhomes?zanr=Umetnost"">Umetnost</a>
                </div>
                
            </div>

            <!-- pretraga ending -->

            <!-- knjige starting -->

");
#nullable restore
#line 98 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
             foreach (var v in Model.Knjige)
            {
                if(v.Zanr == @Model.zanrr)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"segment-knjige\">\r\n\r\n                <div class=\"knjiga-singular\">\r\n                    <div class=\"cover-image\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3748, "\"", 3769, 2);
                WriteAttributeValue("", 3755, "ubook?id=", 3755, 9, true);
#nullable restore
#line 106 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
WriteAttributeValue("", 3764, v.ID, 3764, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <img");
                BeginWriteAttribute("src", " src=", 3805, "", 3823, 1);
#nullable restore
#line 107 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
WriteAttributeValue("", 3810, v.BPhotoPath, 3810, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"naslovna_slika\">\r\n                        </a>\r\n                    </div>\r\n\r\n                    <div class=\"description\">\r\n\r\n                        <div class=\"title\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 4031, "\"", 4052, 2);
                WriteAttributeValue("", 4038, "ubook?id=", 4038, 9, true);
#nullable restore
#line 114 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
WriteAttributeValue("", 4047, v.ID, 4047, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 114 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
                                                Write(v.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                        </div>\r\n\r\n                        <div class=\"author\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 4176, "\"", 4198, 2);
                WriteAttributeValue("", 4183, "UPisac?id=", 4183, 10, true);
#nullable restore
#line 118 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
WriteAttributeValue("", 4193, v.ID, 4193, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span>");
#nullable restore
#line 118 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
                                                       Write(v.Pisac);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></a>\r\n                        </div>\r\n                         <div class=\"author\">\r\n                            <span>");
#nullable restore
#line 121 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
                             Write(v.Godina);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        </div>\r\n\r\n                        <div class=\"concrete-description\">\r\n                        \r\n                            <span>\r\n                            ");
#nullable restore
#line 127 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
                       Write(v.KnjigaOpis);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n                    \r\n                    </div>\r\n\r\n\r\n                </div>\r\n            \r\n            <!-- knjige ending -->\r\n    \r\n        </div>\r\n");
#nullable restore
#line 139 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UHomeS.cshtml"
                }   
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </section>\r\n\r\n    <!-- BUKSELF ending here!-->\r\n\r\n    <!-- Footer section starting here! -->\r\n\r\n    <div class=\"footer\">\r\n        <div class=\"box-container\">\r\n            <div class=\"box\">\r\n                    <a href=\"uabout\"");
                BeginWriteAttribute("rel", " rel=\"", 5045, "\"", 5051, 0);
                EndWriteAttribute();
                WriteLiteral(">Saznaj ko smo mi!</a>\r\n            </div>\r\n\r\n            <div class=\"box\">\r\n                <h3>Prečice</h3>\r\n                    <div class=\"box2\">\r\n                        <a href=\"uindex\"");
                BeginWriteAttribute("rel", " rel=\"", 5243, "\"", 5249, 0);
                EndWriteAttribute();
                WriteLiteral(">Naslovna</a>\r\n                        <a href=\"uabout\"");
                BeginWriteAttribute("rel", " rel=\"", 5305, "\"", 5311, 0);
                EndWriteAttribute();
                WriteLiteral(">O nama!</a>\r\n                        <a href=\"uhome\"");
                BeginWriteAttribute("rel", " rel=\"", 5365, "\"", 5371, 0);
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

                <!-- NEWSLETTER

                <h3>Newsletter</h3>
                <form action="""">
                        <div> <input type=""email"" placeholder=""your email...""></div>
                        <div> <input type=""submit"" class=""btnFooter"" values=""subscribe""></div>
                </form>

                -->
            </div>
        </div>

        <h1 class=""credit""> created by <a href=""#"">TeamBLS</a> | all rights reserved. </h1>
    </div>

    <!-- Footer section ending here! -->

    <!-- jquery cdn link  -->
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jque");
                WriteLiteral("ry.min.js\"></script>\r\n\r\n    <!-- custom js file link  -->\r\n<script src=\"js/script.js\"></script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UHomeSModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UHomeSModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UHomeSModel>)PageContext?.ViewData;
        public UHomeSModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
