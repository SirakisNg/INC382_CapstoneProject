#pragma checksum "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/JournalizingTransaction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccfee1f7dc168f921dd4f1e897000a2bee09facd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finance_JournalizingTransaction), @"mvc.1.0.view", @"/Views/Finance/JournalizingTransaction.cshtml")]
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
#line 1 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/_ViewImports.cshtml"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/_ViewImports.cshtml"
using Backend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccfee1f7dc168f921dd4f1e897000a2bee09facd", @"/Views/Finance/JournalizingTransaction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58f01d0c9c2dd0c1adc189b4df9db144da67c998", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Finance_JournalizingTransaction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccfee1f7dc168f921dd4f1e897000a2bee09facd3760", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Journalizing Transaction</title>
    <link rel=""icon"" type=""image/x-icon"" href=""../Utill/dist/img/Group2_LOGO.ico"">

    <!-- Google Font: Source Sans Pro -->
    <link rel=""stylesheet""
        href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""../Utill/plugins/fontawesome-free/css/all.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <!-- Tempusdominus Bootstrap 4 -->
    <link rel=""stylesheet"" href=""../Utill/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css"">
    <!-- iCheck -->
    <link rel=""stylesheet"" href=""../Utill/plugins/icheck-bootstrap/icheck-bootstrap.min.css"">
    <!-- JQVMap -->
    <link rel=""stylesheet"" href=""../Utill/plugins/jqvmap/jqvmap.min.css"">
    <!-- Theme style ");
                WriteLiteral(@"-->
    <link rel=""stylesheet"" href=""../Utill/dist/css/adminlte.min.css"">
    <!-- overlayScrollbars -->
    <link rel=""stylesheet"" href=""../Utill/plugins/overlayScrollbars/css/OverlayScrollbars.min.css"">
    <!-- Daterange picker -->
    <link rel=""stylesheet"" href=""../Utill/plugins/daterangepicker/daterangepicker.css"">
    <!-- summernote -->
    <link rel=""stylesheet"" href=""../Utill/plugins/summernote/summernote-bs4.min.css"">
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccfee1f7dc168f921dd4f1e897000a2bee09facd6253", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">

        <!-- -------------------------------------------------------------------- -->
        <!-- Content Wrapper. Contains page content -->
        <div class=""content-wrapper"">
            <!-- Content Header (Page header) -->
            <div class=""content-header"">
                <div class=""container-fluid"">
                    <div class=""row mb-2"">
                        <div class=""col-sm-6"">
                            <!-- <h1 class=""m-0"">General Ledger</h1> -->
                        </div><!-- /.col -->
                    </div><!-- /.row -->

                    <div class=""row"">
                        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">
                            <div class=""card mb-3"">
                                <div class=""card-header"">
                                    <!-- <h3><i class=""fa fa-table""></i> PTT General Ledger </h3> -->
                                </div>

                                <div class=""card-bo");
                WriteLiteral(@"dy"">

                                    <div class=""container"">

                                        <div class=""row"">
                                            <div class=""col-xl-12"">
                                                <div class=""breadcrumb-holder"">
                                                    <ol class=""breadcrumb float-right"">
                                                        <label for=""site-search"">Search Date: </label>
                                                        <input type=""search"" id=""site-search"" name=""q"">
                                                        <button>Enter</button>
                                                    </ol>
                                                    <div class=""clearfix""></div>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- end row -->
                            ");
                WriteLiteral(@"            <div class=""row"">
                                            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-6 col-xl-12"">
                                                <div class=""card mb-3"">
                                                    <div class=""card-header"">
                                                        <h3><i class=""fa fa-table""></i> Journalizing Transaction</h3>
                                                    </div>

                                                    <div class=""card-body"">
                                                        <div class=""table-responsive"">
                                                            <table id=""example1""
                                                                class=""table table-bordered table-hover display "">
                                                                <!--///////////////////////////////////////////////////////////////////////////////////
                                                ");
                WriteLiteral(@"    ///////////////////////  TABLE HERE////////////////////////////////////////////////////
                                                    //////////////////////////////////////////////////////////////////////////////////-->
                                                                <div class=""table-responsive"">
                                                                    <!--Sort-->
                                                                    <link rel=""stylesheet""
                                                                        href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
                                                                    <script
                                                                        src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"">
                                                                        </script>
                                                                    <script
");
                WriteLiteral(@"                                                                        src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"">
                                                                        </script>
                                                                    <script
                                                                        src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"">
                                                                        </script>
                                                                    <link rel=""stylesheet""
                                                                        href=""https://cdn.datatables.net/1.10.22/css/dataTables.bootstrap4.min.css"">
                                                                    <script
                                                                        src=""https://cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js"">
                          ");
                WriteLiteral(@"                                              </script>
                                                                    <script
                                                                        src=""https://cdn.datatables.net/1.10.22/js/dataTables.bootstrap4.min.js"">
                                                                        </script>
                                                                    <!-- Search -->
                                                                    <meta charset=""utf-8"">
                                                                    <meta name=""viewport""
                                                                        content=""width=device-width, initial-scale=1"">
                                                                    <script
                                                                        src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
                                                   ");
                WriteLiteral(@"                 <script
                                                                        src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
                                                                    <style>
                                                                        table {
                                                                            border-spacing: 0;
                                                                            width: 100%;
                                                                            border: 1px solid #ddd;
                                                                        }

                                                                        th {
                                                                            cursor: pointer;
                                                                        }

                                                                        th,
       ");
                WriteLiteral(@"                                                                 td {
                                                                            text-align: left;
                                                                            padding: 16px;
                                                                        }

                                                                        tr:nth-child(even) {
                                                                            background-color: #f2f2f2
                                                                        }
                                                                    </style>

                                                                    <!-- data table-->
                                                                    <input class=""form-control"" id=""myInput"" type=""text""
                                                                        placeholder=""Search.."">
                                           ");
                WriteLiteral(@"                         <br>
                                                                    <table class=""table"">
                                                                        <tr>

                                                                            <th>Date</th>
                                                                            <th>Title</th>
                                                                            <th>Description</th>
                                                                            <th>Debit</th>
                                                                            <th>Credit</th>
                                                                        </tr>
");
#nullable restore
#line 150 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/JournalizingTransaction.cshtml"
                                                                         foreach (var item in Model)
                                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                            <tr>\n\n                                                                                <td>");
#nullable restore
#line 154 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/JournalizingTransaction.cshtml"
                                                                               Write(item.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 155 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/JournalizingTransaction.cshtml"
                                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 156 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/JournalizingTransaction.cshtml"
                                                                               Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 157 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/JournalizingTransaction.cshtml"
                                                                               Write(item.Debit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 158 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/JournalizingTransaction.cshtml"
                                                                               Write(item.Credit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n\n                                                                            </tr>\n");
#nullable restore
#line 161 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Finance/JournalizingTransaction.cshtml"
                                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                    </table>
                                                                    <!-- Search -->
                                                                    <script>
                                                                        $(document).ready(function () {
                                                                            $(""#myInput"").on(""keyup"", function () {
                                                                                var value = $(this).val().toLowerCase();
                                                                                $(""#myTable tr"").filter(function () {
                                                                                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                                                                                });
                                                                            });
              ");
                WriteLiteral(@"                                                          });
                                                                    </script>

                                                                    <!-- Sort -->
                                                                    <script>
                                                                        $('#myTable').DataTable();
                                                                    </script>
                                                                    <script>
                                                                        function sortTable(n) {
                                                                            var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
                                                                            table = document.getElementById(""myTable"");
                                                                            switching = true;
           ");
                WriteLiteral(@"                                                                 //Set the sorting direction to ascending:
                                                                            dir = ""asc"";
                                                                            /*Make a loop that will continue until
                                                                            no switching has been done:*/
                                                                            while (switching) {
                                                                                //start by saying: no switching is done:
                                                                                switching = false;
                                                                                rows = table.rows;
                                                                                /*Loop through all table rows (except the
                                                                      ");
                WriteLiteral(@"          first, which contains table headers):*/
                                                                                for (i = 1; i < (rows.length - 1); i++) {
                                                                                    //start by saying there should be no switching:
                                                                                    shouldSwitch = false;
                                                                                    /*Get the two elements you want to compare,
                                                                                    one from current row and one from the next:*/
                                                                                    x = rows[i].getElementsByTagName(""TD"")[n];
                                                                                    y = rows[i + 1].getElementsByTagName(""TD"")[n];
                                                                                    /*check if the");
                WriteLiteral(@" two rows should switch place,
                                                                                    based on the direction, asc or desc:*/
                                                                                    if (dir == ""asc"") {
                                                                                        if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                                                                                            //if so, mark as a switch and break the loop:
                                                                                            shouldSwitch = true;
                                                                                            break;
                                                                                        }
                                                                                    } else if (dir == ""desc"") {
                                                                 ");
                WriteLiteral(@"                       if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                                                                                            //if so, mark as a switch and break the loop:
                                                                                            shouldSwitch = true;
                                                                                            break;
                                                                                        }
                                                                                    }
                                                                                }
                                                                                if (shouldSwitch) {
                                                                                    /*If a switch has been marked, make the switch
                                                                                    and mark that a s");
                WriteLiteral(@"witch has been done:*/
                                                                                    rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
                                                                                    switching = true;
                                                                                    //Each time a switch is done, increase this count by 1:
                                                                                    switchcount++;
                                                                                } else {
                                                                                    /*If no switching has been done AND the direction is ""asc"",
                                                                                    set the direction to ""desc"" and run the while loop again.*/
                                                                                    if (switchcount == 0 && dir == ""asc"") {
                    ");
                WriteLiteral(@"                                                                    dir = ""desc"";
                                                                                        switching = true;
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    </script>
                                                                </div>
                                                                <!--///////////////////////////////////////////////////////////////////////////////////
                                                    ///////////////////////  TABLE HERE////////////////////////////////////////////////////
                                                    ///////////////////////");
                WriteLiteral(@"///////////////////////////////////////////////////////////-->

                                                                <tbody>

                                                                    <!-- -------------------------------------------------------------------- -->
                                                                    <!-- Control Sidebar -->
                                                                    <aside class=""control-sidebar control-sidebar-dark"">
                                                                        <!-- Control sidebar content goes here -->
                                                                    </aside>
                                                                    <!-- /.control-sidebar -->
                                                        </div>
                                                        <!-- ./wrapper -->

                                                        <!-- jQuery -->
                             ");
                WriteLiteral(@"                           <script src=""../Utill/plugins/jquery/jquery.min.js""></script>
                                                        <!-- jQuery UI 1.11.4 -->
                                                        <script
                                                            src=""../Utill/plugins/jquery-ui/jquery-ui.min.js""></script>
                                                        <!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
                                                        <script>
                                                            $.widget.bridge('uibutton', $.ui.button)
                                                        </script>
                                                        <!-- Bootstrap 4 -->
                                                        <script
                                                            src=""../Utill/plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
                                        ");
                WriteLiteral(@"                <!-- ChartJS -->
                                                        <script src=""../Utill/plugins/chart.js/Chart.min.js""></script>
                                                        <!-- Sparkline -->
                                                        <script src=""../Utill/plugins/sparklines/sparkline.js""></script>
                                                        <!-- JQVMap -->
                                                        <script
                                                            src=""../Utill/plugins/jqvmap/jquery.vmap.min.js""></script>
                                                        <script
                                                            src=""../Utill/plugins/jqvmap/maps/jquery.vmap.usa.js""></script>
                                                        <!-- jQuery Knob Chart -->
                                                        <script
                                                            src=""../Utill/plugins/jque");
                WriteLiteral(@"ry-knob/jquery.knob.min.js""></script>
                                                        <!-- daterangepicker -->
                                                        <script src=""../Utill/plugins/moment/moment.min.js""></script>
                                                        <script
                                                            src=""../Utill/plugins/daterangepicker/daterangepicker.js""></script>
                                                        <!-- Tempusdominus Bootstrap 4 -->
                                                        <script
                                                            src=""../Utill/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js""></script>
                                                        <!-- Summernote -->
                                                        <script
                                                            src=""../Utill/plugins/summernote/summernote-bs4.min.js""></script>
                   ");
                WriteLiteral(@"                                     <!-- overlayScrollbars -->
                                                        <script
                                                            src=""../Utill/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js""></script>
                                                        <!-- AdminLTE App -->
                                                        <script src=""../Utill/dist/js/adminlte.js""></script>
                                                        <!-- AdminLTE for demo purposes -->
                                                        <script src=""../Utill/dist/js/demo.js""></script>
                                                        <!-- AdminLTE dashboard demo (This is only for demo purposes) -->
                                                        <script src=""../Utill/dist/js/pages/dashboard.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
