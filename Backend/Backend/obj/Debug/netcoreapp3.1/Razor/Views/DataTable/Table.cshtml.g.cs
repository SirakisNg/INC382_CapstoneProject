#pragma checksum "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7570127db73cd35f9ab86aaa42eca934f8e698"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataTable_Table), @"mvc.1.0.view", @"/Views/DataTable/Table.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7570127db73cd35f9ab86aaa42eca934f8e698", @"/Views/DataTable/Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58f01d0c9c2dd0c1adc189b4df9db144da67c998", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DataTable_Table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef7570127db73cd35f9ab86aaa42eca934f8e6983680", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Data table</title>
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
    <!-- Theme style -->
    <link ");
                WriteLiteral(@"rel=""stylesheet"" href=""../Utill/dist/css/adminlte.min.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef7570127db73cd35f9ab86aaa42eca934f8e6986159", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">


        <!-- Content Wrapper. Contains page content -->
        <div class=""content-wrapper"">
            <!-- Content Header (Page header) -->
            <div class=""content-header"">
                <div class=""container-fluid"">
                    <div class=""row mb-2"">
                        <div class=""col-sm-6"">
                        </div><!-- /.col -->
                    </div><!-- /.row -->

                    <div class=""row"">

                        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">

                            <div class=""card mb-3"">
                                <div class=""card-header"">

                                </div>

                                <div class=""card-body"">

                                    <div class=""container"">

                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""invo");
                WriteLiteral(@"ice-title text-center mb-3"">
                                                    <h1>PTT</h1>
                                                    <h2>Data table</h2>
                                                    <h5><strong>Date:</strong> May, 2022</h5>

                                                </div>
                                                <hr>

                                            </div>
                                        </div>



                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""panel panel-default"">
                                                    <div class=""panel-heading"">
                                                    </div>
                                                    <div class=""panel-body"">
                                                        <div class=""panel-body"">
                                                ");
                WriteLiteral(@"            <div class=""table-responsive"">
                                                                <!-- Search -->
                                                                <meta charset=""utf-8"">
                                                                <meta name=""viewport""
                                                                    content=""width=device-width, initial-scale=1"">
                                                                <script
                                                                    src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
                                                                <script
                                                                    src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
                                                                <style>
                                                                    table {
                    ");
                WriteLiteral(@"                                                    border-spacing: 0;
                                                                        width: 100%;
                                                                        border: 1px solid #ddd;
                                                                    }

                                                                    th {
                                                                        cursor: pointer;
                                                                    }

                                                                    th,
                                                                    td {
                                                                        text-align: left;
                                                                        padding: 16px;
                                                                    }

                                                                    tr:nth-");
                WriteLiteral(@"child(even) {
                                                                        background-color: #f2f2f2
                                                                    }
                                                                </style>

                                                                <!-- data table-->
                                                                <p>Search :</p>
                                                                <input class=""form-control"" id=""myInput"" type=""text""
                                                                    placeholder=""Search.."">
                                                                <br>
                                                                <table class=""table"">
                                                                    <thead>
                                                                        <tr>
                                                                            <th onclick=");
                WriteLiteral(@"""sortTable(6)""><strong>Pruchase
                                                                                    No</strong></th>
                                                                            <th onclick=""sortTable(6)""><strong>Customer
                                                                                    Name</strong></th>
                                                                            <th onclick=""sortTable(6)""><strong>Plate
                                                                                    No</strong></th>
                                                                            <th onclick=""sortTable(6)""><strong>Enter
                                                                                    sale</strong></th>
                                                                            <th onclick=""sortTable(6)""><strong>Sale
                                                                                    service time</strong></th>
   ");
                WriteLiteral(@"                                                                         <th onclick=""sortTable(6)""><strong>Exit
                                                                                    sale</strong></th>
                                                                            <th onclick=""sortTable(6)""><strong>Enter
                                                                                    inbound weighbridge</strong></th>
                                                                            <th onclick=""sortTable(6)""><strong>Inweight
                                                                                    service time</strong></th>
                                                                            <th onclick=""sortTable(6)""><strong>Exit
                                                                                    inbound weighbridge</strong></th>
                                                                            <th onclick=""sortTable(6)""><stro");
                WriteLiteral(@"ng>Enter
                                                                                    bayloading</strong></th>
                                                                            <th onclick=""sortTable(6)"">
                                                                                <strong>Bayloaing service time</strong>
                                                                            </th>
                                                                            <th onclick=""sortTable(6)""><strong>Exit
                                                                                    bayloading</strong></th>
                                                                            <th onclick=""sortTable(6)""><strong>Outbound
                                                                                    weighbridge service time</strong>
                                                                            </th>

                                                      ");
                WriteLiteral(@"                      <th onclick=""sortTable(6)""><strong>Exit
                                                                                    outbound weighbridge</strong></th>
                                                                            <th onclick=""sortTable(6)""><strong>Exit
                                                                                    gate</strong></th>

                                                                            <th onclick=""sortTable(6)"">
                                                                                <strong>Enter_outbound_weighbridge</strong>
                                                                            </th>

                                                                        </tr>
                                                                    </thead>
");
#nullable restore
#line 161 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                     foreach (var item in Model)
                                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                        <tbody id=""myTable"">
                                                                            <tr>
                                                                                <td>");
#nullable restore
#line 165 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.ponumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 166 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.CN);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 167 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.Plate_number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 168 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.Enter_Sale);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 169 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.Sales_Service_Time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 170 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.Exit_Sale);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 171 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.Enter_Inbound_weighbridge);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 172 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.in_weight_service_time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 173 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.Exit_Inbound_weighbridge);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 174 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.Enter_bayloading);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 175 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.bayloaing_service_time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 176 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.Exit_bayloading);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 177 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.Enter_outbound_weighbridge);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 178 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.outbound_weighbridge_servicetime);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                                                                </td>\n                                                                                <td>");
#nullable restore
#line 180 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.Exit_outbound_weighbridge);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                                <td>");
#nullable restore
#line 181 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                               Write(item.exit_gate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                            </tr>\n                                                                        </tbody>\n");
#nullable restore
#line 184 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                </table>
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
                WriteLiteral(@"              });
                                                                </script>

                                                                <!-- Sort -->
                                                                <script>
                                                                    function sortTable(n) {
                                                                        var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
                                                                        table = document.getElementById(""myTable"");
                                                                        switching = true;
                                                                        //Set the sorting direction to ascending:
                                                                        dir = ""asc"";
                                                                        /*Make a loop that will continue until
                           ");
                WriteLiteral(@"                                             no switching has been done:*/
                                                                        while (switching) {
                                                                            //start by saying: no switching is done:
                                                                            switching = false;
                                                                            rows = table.rows;
                                                                            /*Loop through all table rows (except the
                                                                            first, which contains table headers):*/
                                                                            for (i = 1; i < (rows.length - 1); i++) {
                                                                                //start by saying there should be no switching:
                                                                      ");
                WriteLiteral(@"          shouldSwitch = false;
                                                                                /*Get the two elements you want to compare,
                                                                                one from current row and one from the next:*/
                                                                                x = rows[i].getElementsByTagName(""TD"")[n];
                                                                                y = rows[i + 1].getElementsByTagName(""TD"")[n];
                                                                                /*check if the two rows should switch place,
                                                                                based on the direction, asc or desc:*/
                                                                                if (dir == ""asc"") {
                                                                                    if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
   ");
                WriteLiteral(@"                                                                                     //if so, mark as a switch and break the loop:
                                                                                        shouldSwitch = true;
                                                                                        break;
                                                                                    }
                                                                                } else if (dir == ""desc"") {
                                                                                    if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                                                                                        //if so, mark as a switch and break the loop:
                                                                                        shouldSwitch = true;
                                                                                        break;
            ");
                WriteLiteral(@"                                                                        }
                                                                                }
                                                                            }
                                                                            if (shouldSwitch) {
                                                                                /*If a switch has been marked, make the switch
                                                                                and mark that a switch has been done:*/
                                                                                rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
                                                                                switching = true;
                                                                                //Each time a switch is done, increase this count by 1:
                                                                              ");
                WriteLiteral(@"  switchcount++;
                                                                            } else {
                                                                                /*If no switching has been done AND the direction is ""asc"",
                                                                                set the direction to ""desc"" and run the while loop again.*/
                                                                                if (switchcount == 0 && dir == ""asc"") {
                                                                                    dir = ""desc"";
                                                                                    switching = true;
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                  ");
                WriteLiteral(@"                                              </script>
                                                            </div>

                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>


                    </div><!-- end card body -->

                </div><!-- end card-->

            </div><!-- end col-->

        </div><!-- end row-->
    </div><!-- /.container-fluid -->
    </div>
    </div>
    </div>

    <!-- Control Sidebar -->
    <aside class=""control-sidebar control-sidebar-dark"">
        <!-- Control sidebar content goes here -->
    </aside>
    <!-- /.control-sidebar -->
    </div>
    <!-- ./wrapper -->

    <!-- jQuery -->
    <script ");
                WriteLiteral(@"src=""../Utill/plugins/jquery/jquery.min.js""></script>
    <!-- jQuery UI 1.11.4 -->
    <script src=""../Utill/plugins/jquery-ui/jquery-ui.min.js""></script>
    <!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
    <script>
        $.widget.bridge('uibutton', $.ui.button)
    </script>
    <!-- Bootstrap 4 -->
    <script src=""../Utill/plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- ChartJS -->
    <script src=""../Utill/plugins/chart.js/Chart.min.js""></script>
    <!-- Sparkline -->
    <script src=""../Utill/plugins/sparklines/sparkline.js""></script>
    <!-- JQVMap -->
    <script src=""../Utill/plugins/jqvmap/jquery.vmap.min.js""></script>
    <script src=""../Utill/plugins/jqvmap/maps/jquery.vmap.usa.js""></script>
    <!-- jQuery Knob Chart -->
    <script src=""../Utill/plugins/jquery-knob/jquery.knob.min.js""></script>
    <!-- daterangepicker -->
    <script src=""../Utill/plugins/moment/moment.min.js""></script>
    <script src=""../Utill/plugins/daterangepicker/daterangepic");
                WriteLiteral(@"ker.js""></script>
    <!-- Tempusdominus Bootstrap 4 -->
    <script src=""../Utill/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js""></script>
    <!-- Summernote -->
    <script src=""../Utill/plugins/summernote/summernote-bs4.min.js""></script>
    <!-- overlayScrollbars -->
    <script src=""../Utill/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js""></script>
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
