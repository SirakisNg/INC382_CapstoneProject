#pragma checksum "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de490fe885a11f66ca38cacf7407b513f83e5cbe"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de490fe885a11f66ca38cacf7407b513f83e5cbe", @"/Views/DataTable/Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58f01d0c9c2dd0c1adc189b4df9db144da67c998", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DataTable_Table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de490fe885a11f66ca38cacf7407b513f83e5cbe4310", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Inventory Stock Card</title>
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
");
                WriteLiteral(@"    <link rel=""stylesheet"" href=""../Utill/dist/css/adminlte.min.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de490fe885a11f66ca38cacf7407b513f83e5cbe6799", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">

        <!-- Preloader -->
        <div class=""preloader flex-column justify-content-center align-items-center"">
            <img class=""animation__shake"" src=""../Utill/dist/img/Group2_LOGO.png"" alt=""Group2_LOGO.png"" height=""100""
                width=""100"">
        </div>

        <!-- Navbar -->
        <nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
            <!-- Left navbar links -->
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
                </li>
                <li class=""nav-item d-none d-sm-inline-block"">
                    <!-- Go to Home page -->
                    <a href=""../Management/Management.html"" class=""nav-link"">Home</a>
                </li>
            </ul>

            <!-- Right navbar links -->
            <ul class=""navbar-nav ml-auto"">
                <!-- Navbar Search -->
     ");
                WriteLiteral(@"           <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""navbar-search"" href=""#"" role=""button"">
                        <i class=""fas fa-search""></i>
                    </a>
                    <div class=""navbar-search-block"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de490fe885a11f66ca38cacf7407b513f83e5cbe8445", async() => {
                    WriteLiteral(@"
                            <div class=""input-group input-group-sm"">
                                <input class=""form-control form-control-navbar"" type=""search"" placeholder=""Search""
                                    aria-label=""Search"">
                                <div class=""input-group-append"">
                                    <button class=""btn btn-navbar"" type=""submit"">
                                        <i class=""fas fa-search""></i>
                                    </button>
                                    <button class=""btn btn-navbar"" type=""button"" data-widget=""navbar-search"">
                                        <i class=""fas fa-times""></i>
                                    </button>
                                </div>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </li>
            </ul>
        </nav>

        <!-- /.navbar -->

        <!-- Main Sidebar Container -->
        <aside class=""main-sidebar sidebar-dark-primary elevation-4"">
            <!-- Brand Logo -->
            <a href=""../Management/Management.html"" class=""brand-link"">
                <img src=""../Utill/dist/img/Group2_LOGO.png"" alt=""Group2_LOGO""
                    class=""brand-image img-circle elevation-3"" style=""opacity: .8"">
                <span class=""brand-text font-weight-light"">TAS_Group 2</span>
            </a>

            <!-- Sidebar -->
            <class=""sidebar"">
                <!-- Sidebar user panel (optional) -->
                <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
                    <div class=""image"">
                        <img src=""../Utill/dist/img/User_LOGO.png"" class=""img-circle elevation-2"" alt=""User Image"">
                    </div>
                    <div class=""info"">
                        <a href=""#"" class");
                WriteLiteral(@"=""d-block"">cChung_Auto</a>
                    </div>
                </div>

                <!-- SidebarSearch Form -->
                <div class=""form-inline"">
                    <div class=""input-group"" data-widget=""sidebar-search"">
                        <input class=""form-control form-control-sidebar"" type=""search"" placeholder=""Search""
                            aria-label=""Search"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-sidebar"">
                                <i class=""fas fa-search fa-fw""></i>
                            </button>
                        </div>
                    </div>
                </div>

                <!-- Sidebar Menu -->
                <nav class=""mt-2"">
                    <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu""
                        data-accordion=""false"">
                        <!-- Add icons to the links using the .nav-icon class
                  ");
                WriteLiteral(@"   with font-awesome or any other icon font library -->
                        <li class=""nav-item menu-open"">

                            <!-- Management DashBoard in leftSide -->
                        <li class=""nav-item"">
                            <a href=""../Management/Management.html"" class=""nav-link"">
                                <i class=""ion-briefcase""></i>
                                <p>&nbsp;MANAGEMENT</p>
                            </a>
                        </li>

                        <!-- Operation DashBoard in leftSide -->
                        <li class=""nav-item"">
                            <a href=""../Operation/Operation.html"" class=""nav-link"">
                                <i class=""ion-gear-b""></i>
                                <p>&nbsp;OPERATION</p>
                            </a>
                        </li>

                        <!-- Finance DashBoard in leftSide -->
                        <li class=""nav-item"">
                            <a href=""#"" class");
                WriteLiteral(@"=""nav-link"">
                                <i class=""ion-cash""></i>
                                <p>
                                    &nbsp;FINANCE
                                    <i class=""fas fa-angle-left right""></i>
                                </p>
                            </a>
                            <ul class=""nav nav-treeview"">
                                <li class=""nav-item"">
                                    <a href=""Mothly_Income_Statement.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Mothly Income Statement</p>
                                    </a>
                                </li>
                            </ul>
                            <ul class=""nav nav-treeview"">
                                <li class=""nav-item"">
                                    <a href=""Journalizing_Transaction.html"" class=""nav-link"">
                                        <i class");
                WriteLiteral(@"=""far fa-circle nav-icon""></i>
                                        <p>Journalizing Transaction</p>
                                    </a>
                                </li>
                            </ul>
                            <ul class=""nav nav-treeview"">
                                <li class=""nav-item"">
                                    <a href=""General Ledger.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>General Ledger</p>
                                    </a>
                                </li>
                            </ul>
                            <ul class=""nav nav-treeview"">
                                <li class=""nav-item"">
                                    <a href=""Inventory.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Inventory Stock</p>
                         ");
                WriteLiteral(@"           </a>
                                </li>
                            </ul>
                            <ul class=""nav nav-treeview"">
                                <li class=""nav-item"">
                                    <a href=""Purchase_order.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Purchase Order</p>
                                    </a>
                                </li>
                            </ul>
                            <ul class=""nav nav-treeview"">
                                <li class=""nav-item"">
                                    <a href=""Invoice.html"" class=""nav-link"">
                                        <i class=""far fa-circle nav-icon""></i>
                                        <p>Invoice</p>
                                    </a>
                                </li>
                            </ul>

                        </li>

                  ");
                WriteLiteral(@"      <!-- Data table in leftSide -->
                        <li class=""nav-item"">
                            <a href=""../Data_Table/Data_Table.html"" class=""nav-link"">
                                <i class=""ion-navicon""></i>
                                <p>&nbsp;Data Table</p>
                            </a>
                        </li>

                        </li>
                    </ul>
                </nav>
                </class>
                <!-- /.sidebar-menu -->
    </div>
    <!-- /.sidebar -->
    </aside>

    <!-- Content Wrapper. Contains page content -->
    <div class=""content-wrapper"">
        <!-- Content Header (Page header) -->
        <div class=""content-header"">
            <div class=""container-fluid"">
                <div class=""row mb-2"">
                    <div class=""col-sm-6"">
                        <h1 class=""m-0"">Inventory Stock Card</h1>
                    </div><!-- /.col -->
                </div><!-- /.row -->

                <div class=""row"">

         ");
                WriteLiteral(@"           <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">

                        <div class=""card mb-3"">
                            <div class=""card-header"">
                                <h3><i class=""fa fa-table""></i> Inventory Stock Card </h3>
                            </div>

                            <div class=""card-body"">

                                <div class=""container"">

                                    <div class=""row"">
                                        <div class=""col-md-12"">
                                            <div class=""invoice-title text-center mb-3"">
                                                <h1>PTT</h1>
                                                <h2>Inventory Stock Card</h2>
                                                <h5><strong>Date:</strong> May, 2022</h5>

                                            </div>
                                            <hr>

                                        </div>
                        ");
                WriteLiteral(@"            </div>



                                    <div class=""row"">
                                        <div class=""col-md-12"">
                                            <div class=""panel panel-default"">
                                                <div class=""panel-heading"">
                                                    <h3 class=""panel-title"">Purchase Order</h3>
                                                </div>
                                                <div class=""panel-body"">
                                                    <div class=""panel-body"">
                                                        <div class=""table-responsive"">
                                                            <table class=""table table-condensed"">
                                                                <thead>
                                                                    <tr>
                                                                        <td><strong>No.</strong></t");
                WriteLiteral(@"d>
                                                                        <td class=""text-left""><strong>date</strong></td>
                                                                        <td class=""text-right""><strong>time</strong>
                                                                        </td>
                                                                        <td class=""text-right""><strong>Payment
                                                                                No</strong></td>
                                                                        <td class=""text-right""><strong>Invoice
                                                                                No</strong></td>
                                                                        <td class=""text-right""><strong>User ID</strong>
                                                                        </td>
                                                                        <td class=""text-rig");
                WriteLiteral(@"ht""><strong>Order ID</strong>
                                                                        </td>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>

");
#nullable restore
#line 286 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                     foreach (var item in Model)
                                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                        <tr>\n                                                                            <td>");
#nullable restore
#line 289 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                           Write(item.purchaseOrder_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                        </tr>\n                                                                        <tr>\n                                                                            <td>");
#nullable restore
#line 292 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                           Write(item.paymentNo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                        </tr>\n                                                                        <tr>\n                                                                            <td>");
#nullable restore
#line 295 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                           Write(item.invoiceNo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                        </tr>\n                                                                        <tr>\n                                                                            <td>");
#nullable restore
#line 298 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                           Write(item.user_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                        </tr>\n                                                                        <tr>\n                                                                            <td>");
#nullable restore
#line 301 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                           Write(item.price_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                        </tr>\n");
#nullable restore
#line 303 "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/DataTable/Table.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                    <tr>
                                                                        <td class=""thick-line""></td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
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
    </");
                WriteLiteral(@"div>
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
    <script src=""../Utill/plugins/jquery/jquery.min.js""></script>
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
    <script src=""../Utill/plugins/jqvmap/maps/jquery.vmap.usa.js");
                WriteLiteral(@"""></script>
    <!-- jQuery Knob Chart -->
    <script src=""../Utill/plugins/jquery-knob/jquery.knob.min.js""></script>
    <!-- daterangepicker -->
    <script src=""../Utill/plugins/moment/moment.min.js""></script>
    <script src=""../Utill/plugins/daterangepicker/daterangepicker.js""></script>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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