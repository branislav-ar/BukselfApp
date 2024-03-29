#pragma checksum "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f11fdac5644d5ec3817d65a68ebab48778aa7d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_UBook), @"mvc.1.0.razor-page", @"/Pages/UBook.cshtml")]
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
#line 2 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
using ProjekatSWE.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f11fdac5644d5ec3817d65a68ebab48778aa7d1", @"/Pages/UBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da39a3ee5e6b4b0d3255bfef95601890afd80709", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UBook : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = @Model.Knjiga.Ime;

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f11fdac5644d5ec3817d65a68ebab48778aa7d13700", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>KNJIGA | BUKŠELF</title>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f11fdac5644d5ec3817d65a68ebab48778aa7d15256", async() => {
                WriteLiteral("\r\n\r\n    <!-- Header starting here! -->\r\n<header>\r\n    <h1 class=\"heading\"><a href=\"uhome\"><img width=\"200\" src=\"images/bukšelf_croppedLONG.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1182, "\"", 1188, 0);
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

    <!-- book stariting here -->

    <section class=""book"">

        <form method=""post"">

            <div class=""title"">
                <h3>");
#nullable restore
#line 59 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
               Write(Model.Knjiga.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1765, "\"", 1798, 2);
                WriteAttributeValue("", 1772, "UPisac?id=", 1772, 10, true);
#nullable restore
#line 60 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
WriteAttributeValue("", 1782, Model.Knjiga.ID, 1782, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><h1>");
#nullable restore
#line 60 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                                                    Write(Model.Knjiga.Pisac);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1></a>\r\n            </div>\r\n\r\n            <div class=\"image_and_textinfo\">\r\n\r\n                <div class=\"cover-image\">\r\n                <img");
                BeginWriteAttribute("src", " src=", 1967, "", 1996, 1);
#nullable restore
#line 66 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
WriteAttributeValue("", 1972, Model.Knjiga.BPhotoPath, 1972, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"prof_img1\">\r\n                </div>\r\n    \r\n                <div class=\"textinfo\">\r\n                        \r\n                    <div class=\"sitnice\">\r\n                        <span> Izdato: </span>\r\n                        ");
#nullable restore
#line 73 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                   Write(Model.Knjiga.Godina);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"sitnice\">\r\n                        <span> Žanr: </span>\r\n                        ");
#nullable restore
#line 77 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                   Write(Model.Knjiga.Zanr);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"sitnice\">\r\n                        <span> Prosečna ocena: </span>\r\n");
#nullable restore
#line 81 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                           float f = (@Model.Knjiga.Br1*1 + @Model.Knjiga.Br2*2 + @Model.Knjiga.Br3*3 + @Model.Knjiga.Br4*4 + @Model.Knjiga.Br5*5);
                        float b=@Model.Knjiga.BrR;
                        f=f/b; 
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
#nullable restore
#line 85 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                   Write(f);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"sitnice\">\r\n                        <span> Broj recenzija: </span>\r\n                        ");
#nullable restore
#line 89 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                   Write(Model.Knjiga.BrR);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"sitnice\">\r\n                        <span> O knjizi: </span>\r\n                        <br>");
#nullable restore
#line 93 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                       Write(Model.Knjiga.KnjigaOpis);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>

                </div>

            </div>
               <div class=""podnaslov"">
                <h1>
                Da bi ostavili recenziju morate biti prijavljeni!
                </div>
                </h1>
                </div>
                <!-- </form> -->
            <div class=""podnaslov"">
                <h1>
                    RECENZIJE OSTALIH KORISNIKA:
                </h1>
                </div>

            <div class=""content"">
");
#nullable restore
#line 113 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                 foreach (var v in Model.Recenzije)
            {
                if (@v.IDK == @Model.Knjiga.ID)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <!-- BOX1 -->\r\n                <div class=\"review-box\">\r\n                    \r\n                    <div class=\"review-box-top\">\r\n\r\n                        <div class=\"info\">\r\n");
#nullable restore
#line 123 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                              
                                        string I = @Model.Korisnici.Find(u => u.Username == v.Uname).Ime;
                                        string P = @Model.Korisnici.Find(u => u.Username == v.Uname).Prezime;
                                        string S = @Model.Korisnici.Find(u => u.Username == v.Uname).KPhotoPath;
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"profile-img\">\r\n                                <img");
                BeginWriteAttribute("src", " src=", 4494, "", 4501, 1);
#nullable restore
#line 129 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
WriteAttributeValue("", 4499, S, 4499, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"prof_img1\">\r\n                            </div>\r\n                            <div class=\"name-user\">\r\n                                <strong>");
#nullable restore
#line 132 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                                   Write(I);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 132 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                                      Write(P);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                                <span>");
#nullable restore
#line 133 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                                 Write(v.Uname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"ocena\">\r\n");
#nullable restore
#line 138 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                             if(v.Ocena==1)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <i class=""fas fa-star""></i>
                            <i class=""far fa-star""></i>
                            <i class=""far fa-star""></i>
                            <i class=""far fa-star""></i>
                            <i class=""far fa-star""></i>
");
#nullable restore
#line 145 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                             if(v.Ocena==2)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""far fa-star""></i>
                            <i class=""far fa-star""></i>
                            <i class=""far fa-star""></i>
");
#nullable restore
#line 153 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                             if(v.Ocena==3)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""far fa-star""></i>
                            <i class=""far fa-star""></i>
");
#nullable restore
#line 161 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                             if(v.Ocena==4)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""far fa-star""></i>
");
#nullable restore
#line 169 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 170 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                             if(v.Ocena==5)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
");
#nullable restore
#line 177 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"client-comments\">\r\n                        <p>\r\n                        ");
#nullable restore
#line 183 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                   Write(v.Komentar);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                \r\n                </div>  \r\n");
#nullable restore
#line 188 "C:\Users\Lazar\Desktop\ProjekatSWE\Pages\UBook.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
        </form>
    </section>

    <!-- book ending here -->

    <!-- Footer section starting here! -->

    <div class=""footer"">
        <div class=""box-container"">
            <div class=""box"">
                    <a href=""uabout""");
                BeginWriteAttribute("rel", " rel=\"", 7374, "\"", 7380, 0);
                EndWriteAttribute();
                WriteLiteral(">Saznaj ko smo mi!</a>\r\n            </div>\r\n\r\n            <div class=\"box\">\r\n                <h3>Prečice</h3>\r\n                    <div class=\"box2\">\r\n                        <a href=\"uindex\"");
                BeginWriteAttribute("rel", " rel=\"", 7572, "\"", 7578, 0);
                EndWriteAttribute();
                WriteLiteral(">Naslovna</a>\r\n                        <a href=\"uabout\"");
                BeginWriteAttribute("rel", " rel=\"", 7634, "\"", 7640, 0);
                EndWriteAttribute();
                WriteLiteral(">O nama!</a>\r\n                        <a href=\"uhome\"");
                BeginWriteAttribute("rel", " rel=\"", 7694, "\"", 7700, 0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UBookModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UBookModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UBookModel>)PageContext?.ViewData;
        public UBookModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
