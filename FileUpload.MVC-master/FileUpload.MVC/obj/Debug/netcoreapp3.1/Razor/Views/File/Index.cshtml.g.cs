#pragma checksum "C:\Users\Mehdi OA\Desktop\FileUpload.MVC-master\FileUpload.MVC-master\FileUpload.MVC\Views\File\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bb03b15ac2c69928a859fcb691ada494285b509"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_File_Index), @"mvc.1.0.view", @"/Views/File/Index.cshtml")]
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
#line 1 "C:\Users\Mehdi OA\Desktop\FileUpload.MVC-master\FileUpload.MVC-master\FileUpload.MVC\Views\_ViewImports.cshtml"
using FileUpload.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mehdi OA\Desktop\FileUpload.MVC-master\FileUpload.MVC-master\FileUpload.MVC\Views\_ViewImports.cshtml"
using FileUpload.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bb03b15ac2c69928a859fcb691ada494285b509", @"/Views/File/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cd9e3b3ff7b8b0dfa67e1fb673e438e869c242f", @"/Views/_ViewImports.cshtml")]
    public class Views_File_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FileUploadViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/File/UploadToFileSystem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropzone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("my-awesome-dropzone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Mehdi OA\Desktop\FileUpload.MVC-master\FileUpload.MVC-master\FileUpload.MVC\Views\File\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h4>Start Uploading Images Here</h4>\n<hr />\n");
#nullable restore
#line 9 "C:\Users\Mehdi OA\Desktop\FileUpload.MVC-master\FileUpload.MVC-master\FileUpload.MVC\Views\File\Index.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible\" style=\"margin-top:20px\">\n        ");
#nullable restore
#line 12 "C:\Users\Mehdi OA\Desktop\FileUpload.MVC-master\FileUpload.MVC-master\FileUpload.MVC\Views\File\Index.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 14 "C:\Users\Mehdi OA\Desktop\FileUpload.MVC-master\FileUpload.MVC-master\FileUpload.MVC\Views\File\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bb03b15ac2c69928a859fcb691ada494285b5096164", async() => {
                WriteLiteral("\r\n    <div class=\"fallback\">\r\n        <input name=\"file\" type=\"file\" multiple />\r\n    </div>\r\n");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<button id=\"uploadButton\" class=\"btn btn-success\">Upload Files</button>\r\n\n<hr />\n<div id=\"fileListContainer\">\r\n    ");
#nullable restore
#line 25 "C:\Users\Mehdi OA\Desktop\FileUpload.MVC-master\FileUpload.MVC-master\FileUpload.MVC\Views\File\Index.cshtml"
Write(Html.Partial("_FileListPartial", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>


<script>
    Dropzone.options.myAwesomeDropzone = {
        paramName: ""files"", // The name that will be used to transfer the file
        maxFilesize: null, // MB
        parallelUploads: 500,
        autoProcessQueue: false, // Prevents files from being uploaded immediately
        dictDefaultMessage: ""Drop files here to upload"",
        acceptedFiles: ""image/*,image/heic"",
        init: function() {
            var myDropzone = this;

            // Assign an initial order index to each file as they are added
            this.on(""addedfile"", function (file) {
                file.orderIndex = myDropzone.files.indexOf(file);
                // Initialize sortable
                $(""#my-awesome-dropzone"").sortable({
                    // ... sortable configuration ...
                    update: function (event, ui) {
                        // Update order indexes when files are rearranged
                        $('.dz-preview').each(function (index, element) {
                       ");
            WriteLiteral(@"     var dzFile = Dropzone.forElement(""#my-awesome-dropzone"").files[index];
                            dzFile.orderIndex = index;
                        });
                    }
                });
            });

            document.getElementById(""uploadButton"").addEventListener(""click"", function (e) {
                e.preventDefault();
                e.stopPropagation();

                var formData = new FormData();

                //pass the product id from here
                var productID = 'PROD1001';

                // Sort Dropzone files based on the order index
                myDropzone.files.sort(function (a, b) {
                    return a.orderIndex - b.orderIndex;
                });

                // Append files with their display sequence to FormData
                myDropzone.files.forEach(function (file, index) {
                    formData.append('files', file);
                    formData.append('displaySequences', index + 1);
                });");
            WriteLiteral(@"

                formData.append('productID', productID);

                $.ajax({
                    url: '/File/UploadToFileSystem',
                    type: 'POST',
                    data: formData,
                    processData: false,
                    contentType: false,
                    success: function (response) {
                        // Handle success
                        updateFileList();

                        // Introduce a delay of 2 seconds (2000 milliseconds) before clearing files
                        setTimeout(function () {
                            myDropzone.removeAllFiles();
                        }, 2000); // Adjust the delay time as needed
                    },
                    error: function (xhr, status, error) {
                        // Handle error
                        console.error(""Error uploading files: "", error);
                    }
                });

                // Start processing the queue
                ");
            WriteLiteral(@"myDropzone.processQueue();
                
            });

        }
    };

    function updateFileList() {
        $.ajax({
            url: '/File/FileListPartial',
            type: 'GET',
            cache: false,
            success: function (data) {
                if (data) {
                    console.log(""AJAX Success, received data:"", data);
                    $('#fileListContainer').html(data);
                } else {
                    console.log(""AJAX Success, but no data received."");
                    $('#fileListContainer').html(""<p>No files to display.</p>"");
                }
            },
            error: function (xhr, status, error) {
                console.error(""Error refreshing file list: "", error);
                $('#fileListContainer').html(""<p>Error loading files.</p>"");
            }
        });
    }

</script>

<style>
    .dz-preview {
        /* Apply any necessary styles for draggable items */
        cursor: move;
        margin: 5p");
            WriteLiteral("x;\r\n    }\r\n\r\n</style>\r\n\r\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FileUploadViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
