#pragma checksum "/Users/sirakis/Documents/GitHub/INC382_CapstoneProject/Backend/Backend/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8b343b39b3f6e8c6b2ebde43c75cf67cfbe6af8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b343b39b3f6e8c6b2ebde43c75cf67cfbe6af8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58f01d0c9c2dd0c1adc189b4df9db144da67c998", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b343b39b3f6e8c6b2ebde43c75cf67cfbe6af83655", async() => {
                WriteLiteral(@"
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
  <title>Management</title>
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
  <link rel=""stylesheet"" href=""../Utill/dist/css");
                WriteLiteral(@"/adminlte.min.css"">
  <!-- overlayScrollbars -->
  <link rel=""stylesheet"" href=""../Utill/plugins/overlayScrollbars/css/OverlayScrollbars.min.css"">
  <!-- Daterange picker -->
  <link rel=""stylesheet"" href=""../Utill/plugins/daterangepicker/daterangepicker.css"">
  <!-- summernote -->
  <link rel=""stylesheet"" href=""../Utill/plugins/summernote/summernote-bs4.min.css"">
  <!-- Google chart-->
  <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

  <!-- Pie Chart -->
  <script type=""text/javascript"">
    google.charts.load('current', { 'packages': ['corechart'] });      //Load Charts         
    google.charts.load(""current"", { 'packages': ['corechart'] });      //Load Column Charts and Bar Charts
    google.charts.setOnLoadCallback(drawFilledChart);               //Draw Amount of Filled Chart when charts is loaded.
    google.charts.setOnLoadCallback(drawSalesChart);               //Draw Sales Chart when charts is loaded.
    google.charts.setOnLoadCallback(drawTruckInOutChart);");
                WriteLiteral(@"               //Draw Truck-in and Truck-out column chart when charts is loaded.
    google.charts.setOnLoadCallback(drawWaitingTime);               //Draw Waiting Time column chart when charts is loaded.
    google.charts.setOnLoadCallback(drawFailedTime);               //Draw Number of Failed time column chart when charts is loaded.
    google.charts.setOnLoadCallback(drawUtilization);               //Draw Scheduled Utilization bar chart when charts is loaded.

    function drawFilledChart() {

      var data = new google.visualization.DataTable();
      data.addColumn('string', 'Topping');
      data.addColumn('number', 'Slices');
      data.addRows([
        ['Diesel', 55],
        ['Gasohol 95', 45],
      ]);

      var options = {
        title: 'Amount Filled (L)', width: 400, height: 400,
        titlePosition: 'none',
        titleTextStyle: {
          color: 'FFFDD0',
          fontName: 'Arial',
          fontSize: 22,
          bold: true,

        },
        pieSliceText: 'value-and-percentage'");
                WriteLiteral(@",          //show both of value and percentage in pie chart

        'is3D': true,
        slices: {
          1: { offset: 0.1 },                    // separate pie chart
          2: { offset: 0.05 },

        },
        backgroundColor: 'white',
        fontName: 'Arial',
        colors: ['65CCCC', 'FF9900'],                        //Color in pie chart
        fontSize: 16,
        legend: { position: 'top', textStyle: { color: 'black' }, frontSize: 12, alignment: 'center' },

        chartArea: { bottom: 12, width: '100%', 'height': '75%' },           //Pie chart position and size
        reverseCategories: true                             //Change color of object in piechart

      };

      var chart = new google.visualization.PieChart(document.getElementById('Filled_pie'));
      chart.draw(data, options);
    }

    function drawSalesChart() {
      var data = new google.visualization.DataTable();
      data.addColumn('string', 'Topping');
      data.addColumn('number', 'Slices');
      data.addRows([");
                WriteLiteral(@"
        ['Diesel', 550],
        ['Gasohol 95', 450],
      ]);

      var options = {
        title: 'Sales (฿)', width: 400, height: 400,
        titlePosition: 'none',
        titleTextStyle: {
          color: 'FFFDD0',
          fontName: 'Arial',
          fontSize: 22,
          bold: true,

        },
        pieSliceText: 'value-and-percentage',          //show both of value and percentage in pie chart    
        'is3D': true,
        pieStartAngle: -50,                              //Change degree of pie chart
        slices: {
          1: { offset: 0.1 },                    // separate pie chart
          2: { offset: 0.05 },

        },
        backgroundColor: 'white',
        fontName: 'Arial',
        colors: ['FF9900', '65CCCC'],                        //Color in pie chart
        fontSize: 16,
        legend: { position: 'top', textStyle: { color: 'black' }, frontSize: 12, alignment: 'center' },

        chartArea: { bottom: 12, width: '100%', 'height': '75%' },           //Pie chart posit");
                WriteLiteral(@"ion and size
        reverseCategories: false                             //Change color of object in piechart

      };

      var chart = new google.visualization.PieChart(document.getElementById('Sales_pie'));
      chart.draw(data, options);
    }

    function drawTruckInOutChart() {
      var data = google.visualization.arrayToDataTable([
        ["" Name"", ""number"", { role: ""style"" }],
        [""Truck in"", 90, ""#98B6D7""],
        [""Truck out"", 80, ""#F7D7C2""],
      ]);

      var view = new google.visualization.DataView(data);
      view.setColumns([0, 1,
        {
          calc: ""stringify"",
          sourceColumn: 1,
          type: ""string"",
          role: ""annotation""
        },
        2]);

      var options = {
        width: 366,
        height: 400,
        bar: { groupWidth: ""65%"" },
        legend: { position: ""none"" },
        backgroundColor: '#F0F8FF',
        fontSize: 14,

      };
      var chart = new google.visualization.ColumnChart(document.getElementById(""TruckInOut""));
      char");
                WriteLiteral(@"t.draw(view, options);
    }

    function drawWaitingTime() {
      var data = google.visualization.arrayToDataTable([
        ["" Name"", ""number"", { role: ""style"" }],
        [""Sale Office"", 9, ""#AFD7F6""],
        [""Inbound WB"", 8, ""#96CFCF""],
        [""DIESEL Bay"", 2, ""#FF8F7F""],
        [""GASOHOL95 Bay"", 5, ""#FEB9D0""],
        [""Outbound WB"", 10, ""#C1B2C6""],
      ]);

      var view = new google.visualization.DataView(data);
      view.setColumns([0, 1,
        {
          calc: ""stringify"",
          sourceColumn: 1,
          type: ""string"",
          role: ""annotation""
        },
        2]);

      var options = {
        title: ""Waiting Time at Each Station"",
        titleTextStyle: {
          color: 'Black',
          fontName: 'Arial',
          fontSize: 18,
          bold: false,

        },
        width: 780,
        height: 180,
        bar: { groupWidth: ""80%"" },
        legend: { position: ""none"" },
        backgroundColor: 'white',
        fontSize: 14,

      };
      var chart = new goog");
                WriteLiteral(@"le.visualization.ColumnChart(document.getElementById(""WaitingTime""));
      chart.draw(view, options);
    }

    function drawUtilization() {
      var data = google.visualization.arrayToDataTable([
        [""Station"", ""Percentage"", { role: ""style"" }],
        [""Sale Officer"", 8.94, ""#AFD7F6""],
        [""Inbound WB"", 10.49, ""#96CFCF""],
        [""DIESEL Dispenser"", 19.30, ""#FF8F7F""],
        [""GASOHOL95 Dispenser"", 21.45, ""#FEB9D0""],
        [""Outbound WB"", 21.45, ""#C1B2C6""],
      ]);

      var view = new google.visualization.DataView(data);
      view.setColumns([0, 1,
        {
          calc: ""stringify"",
          sourceColumn: 1,
          type: ""string"",
          role: ""annotation""
        },
        2]);

      var options = {
        title: ""Scheduled Utilization"",
        width: 790,
        height: 350,
        bar: { groupWidth: ""90%"" },
        legend: { position: ""none"" },
        titleTextStyle: {
          color: 'Black',
          fontName: 'Arial',
          fontSize: 18,
          bold: f");
                WriteLiteral(@"alse,
        },
        hAxis: {
          title: 'Percentage',
          minValue: 0,
          maxValue: 100,
          format: '#\'%\''
        }
      };
      var chart = new google.visualization.BarChart(document.getElementById(""Utilization_schedule""));
      chart.draw(view, options);
    }

    function drawFailedTime() {
      var data = google.visualization.arrayToDataTable([
        ["" Name"", ""number"", { role: ""style"" }],
        [""GASOHOL95 BAY"", 12, ""FF9900""],
        [""DIESEL BAY"", 8, ""65CCCC""],
      ]);

      var view = new google.visualization.DataView(data);
      view.setColumns([0, 1,
        {
          calc: ""stringify"",
          sourceColumn: 1,
          type: ""string"",
          role: ""annotation""
        },
        2]);

      var options = {
        title: ""Number of Failled Time at Each Station"",
        titleTextStyle: {
          color: 'Black',
          fontName: 'Arial',
          fontSize: 18,
          bold: false,

        },
        width: 780,
        height: 150,
    ");
                WriteLiteral(@"    bar: { groupWidth: ""60%"" },
        legend: { position: ""none"" },
        backgroundColor: 'white',
        fontSize: 14,

      };
      var chart = new google.visualization.ColumnChart(document.getElementById(""FailedTime""));
      chart.draw(view, options);
    }

  </script>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b343b39b3f6e8c6b2ebde43c75cf67cfbe6af814613", async() => {
                WriteLiteral(@"
  <div class=""wrapper"">

    <!-- Content Wrapper. Contains page content -->
    <div class=""content-wrapper"">
      <!-- Content Header (Page header) -->
      <div class=""content-header"">
        <div class=""container-fluid"">
          <div class=""row mb-2"">
            <div class=""col-sm-6"">
              <h1 class=""m-0"">MANAGEMENT DASHBOARD</h1>
            </div><!-- /.col -->

            <!-- Calendar Dropdown Menu -->
            <ul class=""navbar-nav ml-auto""></ul>
            <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
              <h1 class=""ion-calendar""></h1>
            </a>
            <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
              <div class=""dropdown-divider""></div>
              <a href=""#"" class=""dropdown-item dropdown-footer"">Week 1</a>
              <div class=""dropdown-divider""></div>
              <a href=""#"" class=""dropdown-item dropdown-footer"">Week 2</a>
              <div class=""dropdown-divider""></div>
              <a href=""#"" class=""drop");
                WriteLiteral(@"down-item dropdown-footer"">Week 3</a>
              <div class=""dropdown-divider""></div>
              <a href=""#"" class=""dropdown-item dropdown-footer"">Week 4</a>
              <div class=""dropdown-divider""></div>
              <a href=""#"" class=""dropdown-item dropdown-footer"">Monthly</a>
            </div>

          </div><!-- /.row -->
        </div><!-- /.container-fluid -->
      </div>

      <!-- Main content -->
      <section class=""content"">
        <class=""container-fluid"">
          <!-- Small boxes (Stat box) -->
          <div class=""row"">
            <!-- Amount of Filled pie chart -->
            <table class=""columns"">
              <tr>
                <td>
                  <div class=""col-sm"">
                    <div class=""card card-primary"">
                      <div class=""card-header"">
                        <h1 class=""card-title"">Amount Filled (L) </h1>
                      </div>
                      <div id=""Filled_pie"" style=""border: 1px solid #ccc""></div>
                   ");
                WriteLiteral(@" </div>
                  </div>
                </td>
                <td>
                  <div class=""col-sm"">
                    <div class=""card card-dark"">
                      <div class=""card-header"">
                        <h1 class=""card-title"">Total Sales (Baht)</h1>
                      </div>
                      <div id=""Sales_pie"" style=""border: 1px solid #ccc""></div>
                    </div>
                  </div>
                </td>

              </tr>
            </table>

            <div class=""col-sm"">

              <!-- small box of Average GASOHOL 95 Cycle Time -->
              <div class=""small-box bg-white"" style=""height:210px"">
                <div class=""card-header bg-success"">
                  <h1 class=""card-title"">Average GASOHOL 95 Cycle Time</h1>
                </div>
                <div class=""inner"">
                  <div class=""icon"">
                    <center>
                      <h3 class=""ion-clock"" style=""font-size:75px; color:black""></h3>
       ");
                WriteLiteral(@"             </center>
                  </div>
                  <center>
                    <h3>46.38 min</h3>
                  </center>
                </div>
              </div>

              <!-- small box of Average DIESEL Cycle Time -->
              <div class=""small-box bg-white"" style=""height:210px"">
                <div class=""card-header bg-success"">
                  <h1 class=""card-title"">Average DIESEL Cycle Time</h1>
                </div>
                <div class=""inner"">
                  <div class=""icon"">
                    <center>
                      <h3 class=""ion-clock"" style=""font-size:75px; color:black""></h3>
                    </center>
                  </div>
                  <center>
                    <h3>45.68 min</h3>
                  </center>
                </div>
              </div>

            </div>

            <div class=""col-sm"">
              <div class=""card card-info"">
                <div class=""card-header"">
                  <h1 class=""card-title");
                WriteLiteral(@""">Truck in & Truck out</h1>
                </div>
                <div id=""TruckInOut"" style=""width: 50px; height: 390px;""></div>
              </div>
            </div>
            <!-- End First Row -->
          </div>


          <div class=""row"">
            <div class=""col-sm"">
              <div class=""card"">
                <div id=""Utilization_schedule"" style=""width: 50px; height: 1px;""></div>
              </div>
            </div>
            <div class=""col-sm"">
              <div class=""card"">
                <div id=""WaitingTime"" style=""width: 50px; height: 175px;""></div>
                <!--Distance between graph-->
              </div>
              <div class=""card"">
                <div id=""FailedTime"" style=""width: 50px; height: 160px;""></div>
              </div>
            </div>
          </div>


          <div class=""row"">
            <div class=""col-sm"">
              <!-- Inventory CHART -->
              <div class=""card card-danger"">
                <!--Resize card-->
           ");
                WriteLiteral(@"     <div class=""card-header"">
                  <h3 class=""card-title"">Inventory</h3>
                </div>

                <div class=""card-body"">
                  <div class=""chart"">
                    <canvas id=""areaChart""
                      style=""min-height: 10px; height: 200px; max-height: 200px; max-width: 100%;""></canvas>
                  </div>
                </div>
                <!-- /.card-body -->
              </div>
              <!-- /.card -->
            </div>
          </div>

    </div>


  </div>
  </class>
  </section>
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
  <!-- Resolve conflict in jQuery UI tooltip with Bootstrap toolt");
                WriteLiteral(@"ip -->
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
  <script src=""../Utill/plugins/daterangepicker/daterangepicker.js""></script>
  <!-- Tempusdominus Bootstrap 4 -->
  <script src=""../Utill/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js""></script>
  <!-- Summernote -->
  <script src=""../Utill/plugins/summernote/summernote-bs4.min.js""></script>
 ");
                WriteLiteral(@" <!-- overlayScrollbars -->
  <script src=""../Utill/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js""></script>
  <!-- AdminLTE App -->
  <script src=""../Utill/dist/js/adminlte.js""></script>
  <!-- AdminLTE for demo purposes -->
  <script src=""../Utill/dist/js/demo.js""></script>
  <!-- AdminLTE dashboard demo (This is only for demo purposes) -->
  <script src=""../Utill/dist/js/pages/dashboard.js""></script>

");
                WriteLiteral(@"  <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.6.0/Chart.min.js"" type=""text/javascript""></script>  
  <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.6.0/Chart.min.js"" type=""text/javascript""></script>  
  <script src=""https://code.jquery.com/jquery-1.11.3.min.js""></script>  

  <!-- Inventory area chart information -->
  <script>
    $(function () {
      //ChartJS

      //--------------
      //- AREA CHART -
      //--------------

      // Get context with jQuery - using jQuery's .get() method.
      var areaChartCanvas = $('#areaChart').get(0).getContext('2d')

      var areaChartData = {
        labels: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31],
        datasets: [
          {
            label: 'Gasohol 95',
            backgroundColor: 'rgba(0, 188, 212, 0.3)',
            borderColor: 'rgba(0, 188, 212, 0.3)',
            pointRadius: false,
            pointColor: '#65CCCC',
            pointSt");
                WriteLiteral(@"rokeColor: 'rgba(0, 188, 212, 0.3)',
            pointHighlightFill: '#fff',
            pointHighlightStroke: 'rgba(0, 188, 212, 0.3)',
            data: [28, 48, 40, 19, 86, 27, 90, 150000, 300000, 120000, 130000, 140000, 150000, 160000, 30000, 320000, 280000, 280000, 280000, 280000, 280000, 280000, 280000, 280000, 280000, 280000, 280000, 280000, 280000, 280000, 280000]

          },
          {
            label: 'Diesel',
            backgroundColor: 'rgba(255, 152, 0, 0.3)',
            borderColor: 'rgba(255, 152, 0, 0.3)',
            pointRadius: false,
            pointColor: 'rgba(255, 152, 0, 0.3)',
            pointStrokeColor: '#FF9900',
            pointHighlightFill: '#fff',
            pointHighlightStroke: 'rgba(255, 152, 0, 0.3)',
            data: [65, 59, 80, 81, 56, 55, 40, 100000, 120000, 140000, 160000, 250000, 220000, 220000, 220000, 220000, 220000, 220000, 220000, 220000, 220000, 220000, 220000, 220000, 220000, 220000, 220000, 220000, 220000, 220000, 220000]
          },
        ]
   ");
                WriteLiteral(@"   }

      var areaChartOptions = {
        maintainAspectRatio: false,
        responsive: true,
        legend: {
          display: true
        },
        scales: {
          xAxes: [{
            scaleLabel: {
              display: true,
              labelString: ""Days"",
            },

            gridLines: {
              display: false,                  //Delete behind line of graph
            },
          }],
          yAxes: [{
            scaleLabel: {
              display: true,
              labelString: ""Liter""
            },

            gridLines: {
              display: false,
            },
          }]
        }
      }

      // This will get the first returned node in the jQuery collection.
      new Chart(areaChartCanvas, {
        type: 'line',
        data: areaChartData,
        options: areaChartOptions
      })

      //-------------
      //- LINE CHART -
      //--------------
      var lineChartCanvas = $('#lineChart').get(0).getContext('2d')
      var lineChartOptions = $");
                WriteLiteral(@".extend(true, {}, areaChartOptions)
      var lineChartData = $.extend(true, {}, areaChartData)
      lineChartData.datasets[0].fill = false;
      lineChartData.datasets[1].fill = false;
      lineChartOptions.datasetFill = false

      var lineChart = new Chart(lineChartCanvas, {
        type: 'line',
        data: lineChartData,
        options: lineChartOptions
      })
    })
  </script>

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
            WriteLiteral("\n\n</html>\n");
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
