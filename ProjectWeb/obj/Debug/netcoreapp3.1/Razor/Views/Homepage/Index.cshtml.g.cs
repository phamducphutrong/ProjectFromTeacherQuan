#pragma checksum "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aa518b4652589a81b1b71a04ab8a736cf407fa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Homepage_Index), @"mvc.1.0.view", @"/Views/Homepage/Index.cshtml")]
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
#line 1 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\_ViewImports.cshtml"
using ProjectWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\_ViewImports.cshtml"
using ProjectWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aa518b4652589a81b1b71a04ab8a736cf407fa7", @"/Views/Homepage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"354f54e7c7d14d0a3c3033cbd7a22f0285355f31", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Homepage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Record>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Homepage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-2 pt-3"">
        <div class=""dropdown"">
            <button type=""button"" class=""btn btn-primary dropdown-toggle container-fluid ml-2"" data-toggle=""dropdown"">Lưu trữ</button>
            <div class=""dropdown-menu container-fluid"">
                <a class=""dropdown-item"" href=""#"">Link 1</a>
                <a class=""dropdown-item"" href=""#"">Link 2</a>
                <a class=""dropdown-item"" href=""#"">Link 3</a>
            </div>
        </div>
        <div class=""dropdown"">
            <button type=""button"" class=""btn btn-primary dropdown-toggle container-fluid ml-2"" data-toggle=""dropdown"">Tìm kiếm</button>
            <div class=""dropdown-menu  container-fluid"">
                <a class=""dropdown-item"" href=""#"">Link 1</a>
                <a class=""dropdown-item"" href=""#"">Link 2</a>
                <a class=""dropdown-item"" href=""#"">Link 3</a>
            </div>
        </div>
    </div>
    <div class=""col-md-10 pt-3"">
        <div class=""row"">
   ");
            WriteLiteral(@"         <div class=""col-7 border rounded mx-auto h-100"">
                <div name=""nav"" class=""h-25"">
                    <ul class=""nav"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Danh mục tài liệu</a>
                            <hr class=""bg-primary"" />
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link text-dark"" href=""#"">So sánh tài liệu</a>
                            <hr />
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link text-dark"" href=""#"">Thêm ghi chú</a>
                            <hr />
                        </li>
                    </ul>
                </div>
                <div name=""table"" class=""h-50"">
                    <table class=""table text-center"">
                        <thead>
                            <tr>
                                <th>Tài liệ");
            WriteLiteral(@"u</th>
                                <th>Loại tài liệu</th>
                                <th>Ngày sửa đổi</th>
                                <th>Phiên bản</th>
                                <th colspan=""2"">Thao tác</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 52 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                             foreach (var record in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aa518b4652589a81b1b71a04ab8a736cf407fa77290", async() => {
                WriteLiteral("\r\n                                    <td><input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 2709, "\"", 2738, 1);
#nullable restore
#line 56 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
WriteAttributeValue("", 2717, record.document_name, 2717, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                                                                         WriteLiteral(record.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <td>");
#nullable restore
#line 58 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                   Write(record.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 59 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                   Write(record.last_fix);

#line default
#line hidden
#nullable disable
            WriteLiteral(" phút trước</td>\r\n                                    <td>");
#nullable restore
#line 60 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                   Write(record.version);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><a class=\"btn btn-primary btn-sm text-white\">Mở</a></td>\r\n                                    <td><a class=\"btn btn-danger btn-sm text-white\">Xóa</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 64 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                    <div>
                        Loại tài liệu
                        <div class=""form-check-inline"">
                            <label class=""form-check-label"">
                                <input type=""radio"" class=""form-check-input"" name=""optradio"">Quyết định
                            </label>
                        </div>
                        <div class=""form-check-inline"">
                            <label class=""form-check-label"">
                                <input type=""radio"" class=""form-check-input"" name=""optradio"">Nghị định
                            </label>
                        </div>
                        <div class=""form-check-inline disabled"">
                            <label class=""form-check-label"">
                                <input type=""radio"" class=""form-check-input"" name=""optradio"">Thông tư
                            </label>
                        </div>
      ");
            WriteLiteral(@"                  <div class=""form-check-inline disabled"">
                            <label class=""form-check-label"">
                                <input type=""radio"" class=""form-check-input"" name=""optradio"">Thông báo
                            </label>
                        </div>
                    </div>
                    <div class=""my-2"">
                        <button class=""btn btn-primary container-fluid"">Thêm mới</button>
                    </div>
                </div>
            </div>
            <div class=""col-4 border rounded mx-auto mh-100"" name=""preview"">
                <h5 class=""text-center"">Xem trước tài liệu</h5>
                <div class=""bg-light d-flex justify-content-center align-items-center h-75"">320x320</div>
                <button class=""btn btn-primary container-fluid mt-3"">Chỉnh sửa chi tiết</button>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-9"">
                <h5 class=""text-primary"">Thông tin ch");
            WriteLiteral("i tiết</h5>\r\n                <hr class=\"bg-primary\" />\r\n                <div class=\"row\">\r\n                    <div class=\"col-3 form-group\">\r\n                        <label for=\"document-id\">Mã tài liệu:</label>\r\n");
#nullable restore
#line 108 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                         if (TempData["document_id"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"text\" class=\"form-control\" id=\"document-id\"");
            BeginWriteAttribute("value", " value=\"", 5700, "\"", 5732, 1);
#nullable restore
#line 110 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
WriteAttributeValue("", 5708, TempData["document_id"], 5708, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 111 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"text\" class=\"form-control\" id=\"document-id\">\r\n");
#nullable restore
#line 115 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"col-3 form-group\">\r\n                        <label for=\"document-type\">Loại tài liệu:</label>\r\n");
#nullable restore
#line 119 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                         if (TempData["category_id"] == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <select class=\"form-control\" id=\"document-type\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aa518b4652589a81b1b71a04ab8a736cf407fa716414", async() => {
                WriteLiteral("Hãy chọn loại tài liệu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 123 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                 foreach (var category in ViewBag.Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aa518b4652589a81b1b71a04ab8a736cf407fa717956", async() => {
#nullable restore
#line 125 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                                            Write(category.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 125 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                       WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 126 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </select>\r\n");
#nullable restore
#line 128 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <select class=\"form-control\" id=\"document-type\">\r\n");
#nullable restore
#line 154 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                 foreach (var category in ViewBag.Categories)
                                {
                                    if (category.Id.ToString() == TempData["category_id"].ToString())
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aa518b4652589a81b1b71a04ab8a736cf407fa721054", async() => {
#nullable restore
#line 158 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                                                         Write(category.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 158 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                           WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 159 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aa518b4652589a81b1b71a04ab8a736cf407fa723638", async() => {
#nullable restore
#line 162 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                                                Write(category.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 162 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                           WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 163 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </select>\r\n");
#nullable restore
#line 166 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 168 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                     if (TempData["signed_day"] == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-3 form-group\">\r\n                            <label for=\"signed-day\">Ngày ký:</label>\r\n                            <input type=\"date\" class=\"form-control\" id=\"signed-day\">\r\n                        </div>\r\n");
#nullable restore
#line 174 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-3 form-group\">\r\n                            <label for=\"signed-day\">Ngày ký:</label>\r\n                            <input type=\"text\" class=\"form-control\" id=\"signed-day\"");
            BeginWriteAttribute("value", " value=\"", 9102, "\"", 9144, 1);
#nullable restore
#line 179 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
WriteAttributeValue("", 9110, TempData["signed_day"].ToString(), 9110, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n");
#nullable restore
#line 181 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-3 form-group\">\r\n                        <label for=\"book-number\">Số sổ:</label>\r\n");
#nullable restore
#line 184 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                         if (TempData["book_number"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"text\" class=\"form-control\" id=\"book-number\"");
            BeginWriteAttribute("value", " value=\"", 9494, "\"", 9526, 1);
#nullable restore
#line 186 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
WriteAttributeValue("", 9502, TempData["book_number"], 9502, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 187 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"text\" class=\"form-control\" id=\"book-number\">\r\n");
#nullable restore
#line 191 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 195 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                     if (TempData["dear_to"] == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-6 form-group\">\r\n                            <label for=\"dear_to\">Kính gửi:</label>\r\n                            <textarea rows=\"3\" class=\"form-control\" id=\"dear_to\"></textarea>\r\n                        </div>\r\n");
#nullable restore
#line 201 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-6 form-group\">\r\n                            <label for=\"dear_to\">Kính gửi:</label>\r\n                            <textarea rows=\"3\" class=\"form-control\" id=\"dear_to\">");
#nullable restore
#line 206 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                                                            Write(TempData["dear_to"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                        </div>\r\n");
#nullable restore
#line 208 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 209 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                     if (TempData["destination"] == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-6 form-group"">
                            <label for=""destination"">Nơi nhận:</label>
                            <textarea rows=""3"" class=""form-control"" id=""destination""></textarea>
                        </div>
");
#nullable restore
#line 215 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-6 form-group\">\r\n                            <label for=\"destination\">Nơi nhận:</label>\r\n                            <textarea rows=\"3\" class=\"form-control\" id=\"destination\">");
#nullable restore
#line 220 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                                                                Write(TempData["destination"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                        </div>\r\n");
#nullable restore
#line 222 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div>\r\n");
#nullable restore
#line 225 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                     if (TempData["content"] == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group\">\r\n                            <label for=\"content\">Nội dung:</label>\r\n                            <textarea rows=\"5\" class=\"form-control\" id=\"content\"></textarea>\r\n                        </div>\r\n");
#nullable restore
#line 231 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group\">\r\n                            <label for=\"content\">Nội dung:</label>\r\n                            <textarea rows=\"5\" class=\"form-control\" id=\"content\">");
#nullable restore
#line 236 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                                                                            Write(TempData["content"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                        </div>\r\n");
#nullable restore
#line 238 "C:\Users\phamd\OneDrive\Documents\GitHub\ProjectFromTeacherQuan\ProjectWeb\Views\Homepage\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div><button class=""btn btn-primary float-right"">Cập nhật</button></div>
            </div>
            <div class=""col-3"">
                <h5>Các tài liệu liên quan</h5>
            </div>
        </div>
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Record>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591