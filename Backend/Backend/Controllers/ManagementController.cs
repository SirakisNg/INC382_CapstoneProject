using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Backend.Models;
using Microsoft.AspNetCore.Http;
using Backend.Utill;
using System.Data;

namespace Backend.Controllers
{
    public class ManagementController : Controller
    {
        private readonly ILogger<ManagementController> _logger;

        private DBConnect ConnectDB = new DBConnect();//Database connection

        public ManagementController(ILogger<ManagementController> logger) => _logger = logger;
    }
}
