#pragma checksum "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f90a701a3f283697a3615c77ed241c9b5934893"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teams_Team), @"mvc.1.0.view", @"/Views/Teams/Team.cshtml")]
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
#line 1 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\_ViewImports.cshtml"
using CodeCademyCapstone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\_ViewImports.cshtml"
using CodeCademyCapstone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f90a701a3f283697a3615c77ed241c9b5934893", @"/Views/Teams/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda6c50a5677ace81bd1f0cf9568ece46e5b87f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Teams_Team : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Player", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
  
    ViewData["Title"] = "NFL Team - " + @Html.DisplayFor(model => model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron p-2\">\r\n    <h1 class=\"display-4\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 175, "\"", 216, 3);
            WriteAttributeValue("", 181, "/image/nfl/logo/", 181, 16, true);
#nullable restore
#line 10 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
WriteAttributeValue("", 197, Model.TeamId, 197, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 212, ".png", 212, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 11 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
   Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n</div>\r\n\r\n<div class=\"d-flex justify-content-between pb-2\">\r\n    <div>\r\n        <div>");
#nullable restore
#line 18 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
        Write(Model.Division.ConferenceId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                                       Write(Model.DivisionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>Record: ");
#nullable restore
#line 19 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                Write(Model.Win);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 19 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                           Write(Model.Loss);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 19 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                                       Write(Model.Tie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <hr />\r\n        <div>");
#nullable restore
#line 21 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
        Write(Model.Stadium);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Stadium</div>\r\n        <div>Capacity: ");
#nullable restore
#line 22 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                  Write(Model.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <hr />\r\n        <div>");
#nullable restore
#line 24 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
        Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"pb-2\">");
#nullable restore
#line 25 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                     Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 25 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                                  Write(Model.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                                               Write(Model.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 718, "\"", 762, 3);
            WriteAttributeValue("", 724, "/image/nfl/stadium/", 724, 19, true);
#nullable restore
#line 26 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
WriteAttributeValue("", 743, Model.TeamId, 743, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 758, ".jpg", 758, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 786, "\"", 830, 3);
            WriteAttributeValue("", 792, "/image/nfl/seating/", 792, 19, true);
#nullable restore
#line 28 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
WriteAttributeValue("", 811, Model.TeamId, 811, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 826, ".png", 826, 4, true);
            EndWriteAttribute();
            WriteLiteral(@">
</div>

<section class=""grid container"">
    <div class=""d-flex bg-primary text-white"">
        <div class=""p-1"" style=""flex:0 0 10%"">Number</div>
        <div class=""p-1"" style=""flex:0 0 25%"">Name</div>
        <div class=""p-1"" style=""flex:0 0 10%"">Position</div>
        <div class=""p-1"" style=""flex:0 0 20%"">Experience</div>
        <div class=""p-1"" style=""flex:0 0 25%"">College</div>
        <div class=""p-1"" style=""flex:0 0 10%"">Depth</div>
    </div>

");
#nullable restore
#line 41 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
     foreach (Player Player in Model.Players)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f90a701a3f283697a3615c77ed241c9b59348939695", async() => {
                WriteLiteral("\r\n            <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 44 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                                             Write(Player.Number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 25%\">");
#nullable restore
#line 45 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                                             Write(Player.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 46 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                                             Write(Player.Position);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 20%\">");
#nullable restore
#line 47 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                                             Write(Player.Experience);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 25%\">");
#nullable restore
#line 48 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                                             Write(Player.College);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 49 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                                             Write(Player.Depth);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 43 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
AddHtmlAttributeValue("", 1376, Player.Depth == 1 ? "d-flex starter" : "d-flex", 1376, 50, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
                                                                                            WriteLiteral(Player.PlayerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\My Documents\Projects\Coding\C#\CodeAcademy\CodeCademyCapstone\Views\Teams\Team.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team> Html { get; private set; }
    }
}
#pragma warning restore 1591
