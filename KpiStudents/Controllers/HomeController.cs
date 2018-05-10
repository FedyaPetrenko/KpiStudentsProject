using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KpiStudents.Data;
using KpiStudents.Helpers;
using Microsoft.AspNetCore.Mvc;
using KpiStudents.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace KpiStudents.Controllers
{
    public class HomeController : Controller
    {
        private readonly Kpi_StudentsContext _context;

        public HomeController(Kpi_StudentsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Contracts()
        {
            ViewData["Message"] = "Your Contracts page.";

            var list = new List<SqlParameter>
            {
                //new SqlParameter("@ActiveSalespersonId", SqlDbType.Int) {Value = parameters.SalespersonId},
          
            };

            var models = await _context.ExecuteStoredProcedureAsync<ContractModel>("GetStudentsContracts", list);
            
            return View(models);
        }

        public IActionResult TeachPlans()
        {
            ViewData["Message"] = "Your Teach Plans page.";

            return View();
        }

        public IActionResult Diplomas()
        {
            ViewData["Message"] = "Your Diplomas page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
