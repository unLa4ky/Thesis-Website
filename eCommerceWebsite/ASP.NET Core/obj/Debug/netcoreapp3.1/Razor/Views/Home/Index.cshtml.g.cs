#pragma checksum "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64e7bedd5f9d22651434c5e6fd0dd401aa8834af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\_ViewImports.cshtml"
using ASP.NET_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\_ViewImports.cshtml"
using ASP.NET_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64e7bedd5f9d22651434c5e6fd0dd401aa8834af", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cece8e97a48c14dc69f1e4bcc04dd0d337cf55c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\GIT HUB\Thesis-Website\eCommerceWebsite\ASP.NET Core\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Swift Claw";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container"">
    <div class=""text-center"" style=""margin-top:95px;"">
        <hr />
        <h1 class=""display-4"" >Swift Claw</h1>
    </div>
    <hr />
</div>


<div class=""container"">
    <div class=""jumbotron jumbotron-fluid"" style=""background-image:url(https://s5.gifyu.com/images/IMG_20191208_180520-1-1.png); border-radius:0; max-height:600px; background-size:100% 100%"">
        <div class=""col-md-6  text-center"" style=""margin-top:100px"">
            <h1 class=""display-4"" style=""-webkit-text-stroke: 3.5px #2E0D5F;""><em>Postani Kandžica!</em></h1>
            <p class=""lead"" style=""color:white; -webkit-text-stroke:1.25px #2E0D5F; font-size:25px; ""><em>Prva kupovina 20% popusta!</em></p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64e7bedd5f9d22651434c5e6fd0dd401aa8834af4921", async() => {
                WriteLiteral("\r\n                <input type=\"submit\" class=\"dugmejumbotron zoom\" value=\"Kupi odmah!\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
    <hr />
</div>


<div class=""container"">
    <p style=""font-size: 25px;  text-align: center;""><em>Naši proizvodi</em></p>
    <div class=""card-deck"" id=""cardDeck"">
        <div class=""row"">
            <div class=""container"">


                <div class=""col-md-4 card-space"">
                    <div class=""flip-box1 "">
                        <div class=""flip-box-inner1 "">
                            <div class=""flip-box-front1"">
                                <img class=""card-img-top"" src=""https://s6.gifyu.com/images/IMG_20191207_112344.jpg"" alt=""Card image cap"">
                                <div class=""card-body mt-4"">
                                    <h4 class=""card-title""><a style=""color:white"">Najprodavaniji</a></h4>
                                    <div class=""dropdown-divider""></div>
                                    <p class=""card-text"" style=""color:white"">Price: $0.5</p>
                                </div>
              ");
            WriteLiteral("              </div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64e7bedd5f9d22651434c5e6fd0dd401aa8834af7603", async() => {
                WriteLiteral("\r\n                                <div class=\"flip-box-back1\" style=\"font-size: 30px; font-family: Impact;\"> <br /><br /><br /><br />KUPI ODMAH!</div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                


                <div class=""col-md-4 card-space"">
                    <div class=""flip-box1 "">
                        <div class=""flip-box-inner1"">
                            <div class=""flip-box-front1"">
                                <img class=""card-img-top"" src=""https://s6.gifyu.com/images/IMG_20191207_112344.jpg"" alt=""Card image cap"">
                                <div class=""card-body mt-4"">
                                    <h4 class=""card-title""><a style=""color:white"">Najnoviji</a></h4>
                                    <div class=""dropdown-divider""></div>
                                    <p class=""card-text"" style=""color:white"">Price: $0.5</p>
                                </div>
                            </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64e7bedd5f9d22651434c5e6fd0dd401aa8834af9857", async() => {
                WriteLiteral("\r\n                                <div class=\"flip-box-back1\" style=\"font-size: 30px; font-family: Impact;\"> <br /><br /><br /><br />KUPI ODMAH!</div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                


                <div class=""col-md-4 card-space"">
                    <div class=""flip-box1 "">
                        <div class=""flip-box-inner1"">
                            <div class=""flip-box-front1"">
                                <img class=""card-img-top"" src=""https://s6.gifyu.com/images/IMG_20191207_112344.jpg"" alt=""Card image cap"">
                                <div class=""card-body mt-4"">
                                    <h4 class=""card-title""><a style=""color:white"">Popust</a></h4>
                                    <div class=""dropdown-divider""></div>
                                    <p class=""card-text"" style=""color:white"">Price: $0.5</p>
                                </div>
                            </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64e7bedd5f9d22651434c5e6fd0dd401aa8834af12108", async() => {
                WriteLiteral("\r\n                                <div class=\"flip-box-back1\" style=\"font-size: 30px; font-family: Impact;\"> <br /><br /><br /><br />KUPI ODMAH!</div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        </div>
    </div>
    <br />
    <hr />
</div>
<br>

<!--
    <div class=""container"">
        <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
            
<ol class=""carousel-indicators"">
    <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
    <li data-target=""#myCarousel"" data-slide-to=""1""></li>
    <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    <li data-target=""#myCarousel"" data-slide-to=""3""></li>
    <li data-target=""#myCarousel"" data-slide-to=""4""></li>
</ol>


<div class=""carousel-inner"">
    <div class=""item active"">
        <img src=""https://s5.gifyu.com/images/IMG_20191208_183750-2.png"" alt=""logogamescon"" style=""width:100%; height:550px;"">
    </div>

    <div class=""item"">
        <img src=""https://s5.gifyu.com/images/IMG-20191207-WA0014.jpg"" alt=""ekipa"" style=""width:100%; height:550px;"">
 ");
            WriteLiteral(@"   </div>

    <div class=""item"">
        <img src=""https://s5.gifyu.com/images/IMG_20191208_180520.jpg"" alt=""majicasc"" style=""width:100%; height:550px;"">
    </div>

    <div class=""item"">
        <img src=""https://s5.gifyu.com/images/IMG_20191208_182416.jpg"" alt=""asusrog"" style=""width:100%; height:550px;"">
    </div>

    <div class=""item"">
        <img src=""https://s5.gifyu.com/images/IMG_20191208_174034.jpg"" alt=""monster"" style=""width:100%; height:550px;"">
    </div>

</div>


<a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">
    <span class=""glyphicon glyphicon-chevron-left""></span>
    <span class=""sr-only"">Previous</span>
</a>
<a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">
    <span class=""glyphicon glyphicon-chevron-right""></span>
    <span class=""sr-only"">Next</span>
</a>
                </div>
</div>
-->

<div class=""container"">
    <div class=""video-responsive"">
        <iframe width=""420"" height=""315"" src=""https://www.you");
            WriteLiteral("tube.com/embed/RiV000Xg65c?autoplay=1\" frameborder=\"0\" allowfullscreen></iframe>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
