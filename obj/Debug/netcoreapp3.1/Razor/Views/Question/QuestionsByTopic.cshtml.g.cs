#pragma checksum "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59f48395802e5506595b6faa018da870939b8442"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_QuestionsByTopic), @"mvc.1.0.view", @"/Views/Question/QuestionsByTopic.cshtml")]
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
#line 1 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\_ViewImports.cshtml"
using Lethal.Developer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\_ViewImports.cshtml"
using Lethal.Developer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59f48395802e5506595b6faa018da870939b8442", @"/Views/Question/QuestionsByTopic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b216d145f3a8e4f78ff817bb359c70d0ad228d", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_QuestionsByTopic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lethal.Developer.ViewModels.QuestionViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml"
  
    ViewData["Title"] = "Detail";
    var cardcollapseId = "#collapseCardExample";
    var collapse = "collapseCardExample";
    var index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"page-header\">Topic: <span class=\"btc-color\">");
#nullable restore
#line 10 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml"
                                                  Write(Model.TopicName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59f48395802e5506595b6faa018da870939b84424020", async() => {
                WriteLiteral("\r\n    <div class=\"input-group\">\r\n        <input id=\"question-input\" type=\"text\" class=\"form-control bg-light border-0 large\" placeholder=\" Type the exam question... \" aria-label=\"Type Your Question\" aria-describedby=\"basic-addon2\">\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59f48395802e5506595b6faa018da870939b84425518", async() => {
                WriteLiteral("\r\n    <textarea name=\"editor1\" id=\"editor1\" rows=\"10\" cols=\"80\"></textarea>\r\n    <script>\r\n        CKEDITOR.replace(\'editor1\');\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<button onclick=\"createQuestion()\" class=\"btn-success create-button\">Create Question</button>\r\n\r\n<div id=\"question-alert\" class=\"alert alert-warning d-none text-center\" role=\"alert\">\r\n    Dafuq dude, you didn\'t type a question.\r\n</div>\r\n\r\n");
#nullable restore
#line 31 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml"
  

    foreach (var item in Model?.Questions)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card shadow\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1068, "\"", 1100, 1);
#nullable restore
#line 36 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml"
WriteAttributeValue("", 1075, cardcollapseId + index, 1075, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block card-header py-3\" data-toggle=\"collapse\" role=\"button\" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1192, "\"", 1227, 1);
#nullable restore
#line 36 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml"
WriteAttributeValue("", 1208, collapse + index, 1208, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"float-left\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">");
#nullable restore
#line 38 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml"
                                                             Write(Html.Raw(item.Q));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </div>\r\n                <div class=\"float-right\">\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1457, "\"", 1499, 3);
            WriteAttributeValue("", 1467, "openIndividualQuestion(", 1467, 23, true);
#nullable restore
#line 41 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml"
WriteAttributeValue("", 1490, item.Id, 1490, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1498, ")", 1498, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-warning rounded\">Edit</button>\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1571, "\"", 1605, 3);
            WriteAttributeValue("", 1581, "deleteQuestion(", 1581, 15, true);
#nullable restore
#line 42 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml"
WriteAttributeValue("", 1596, item.Id, 1596, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1604, ")", 1604, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-danger rounded\">Delete</button>\r\n                </div>\r\n            </a>\r\n                <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1730, "\"", 1754, 1);
#nullable restore
#line 45 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml"
WriteAttributeValue("", 1735, collapse + index, 1735, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card-body\">\r\n                        ");
#nullable restore
#line 47 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml"
                   Write(Html.Raw(item.A));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 51 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml"
            index++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function createQuestion() {
        var question = document.getElementsByTagName(""input"")[0].value;

        var iframe = document.getElementsByTagName(""iframe"")[0];
        var html = iframe.contentWindow.document.getElementsByTagName(""html"")[0];
        var body = html.getElementsByTagName(""body"")[0];

        var insideBody = body.querySelectorAll('body > *');
        var returnHtml = """";

        insideBody.forEach(x => returnHtml += x.outerHTML);

        var data = {
            Question: question,
            Answer: returnHtml,
            TopicId: ");
#nullable restore
#line 71 "C:\Users\13127\Documents\repos\LD-E-Buider-2.0\Views\Question\QuestionsByTopic.cshtml"
                Write(Model.TopicId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        };

        if (question == """") {
            document.getElementById(""question-alert"").style = ""display:block !important;""
        }
        else {
            $.ajax({
                type: ""POST"",
                url: '/questions/create',
                //headers: {
                //    'Authorization': `Bearer ${token}`,
                //},
                datatype: ""json"",
                contentType: ""application/json"",
                data: JSON.stringify(data),
                success: function (result) {
                    console.log(result);
                    window.location.reload();
                },
                error: function (error) {
                }
            })
        }
    }

    function openIndividualQuestion(id) {
        window.location.href = `/question/${id}`
    }

    function deleteQuestion(id) {
        $.ajax({
            type: ""DELETE"",
            url: `/questions/delete/${id}`,
            success: function (result) {");
            WriteLiteral("\r\n                console.log(result);\r\n                window.location.reload();\r\n            },\r\n            error: function (error) {\r\n            }\r\n        })\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lethal.Developer.ViewModels.QuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
