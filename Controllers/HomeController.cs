using Microsoft.AspNetCore.Mvc;
using NewApplication.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace NewApplication.Controllers
{
    public class HomeController : Controller
    {
        //System.Data.SqlClient.SqlConnection con;
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {

            SqlConnection con = new SqlConnection("Data Source=DDOKKARI-L-5501\\SQLEXPRESS;Initial Catalog=StoreDB;Persist Security Info=True;User ID=sa;Password=Welcome2evoke@1234");
            con.Open();
            SqlCommand cmd = new SqlCommand("selectStaff", con);

            //cmd.Connection = con;
            //cmd.CommandText = "Sp_Get_All_staffs";

            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@staff_id", 1069);
            //cmd.Parameters.AddWithValue("@First_Name", "Dhanush");
            //cmd.Parameters.AddWithValue("@Last_Name", "yallapragada");
            //cmd.Parameters.AddWithValue("@email", "Dh@email.com");
            //cmd.Parameters.AddWithValue("@phone", 982765676);
            //cmd.Parameters.AddWithValue("@active", "No");
            //cmd.Parameters.AddWithValue("@store_id", 203);
            //cmd.Parameters.AddWithValue("manager_id", 103);



            cmd.ExecuteNonQuery();

            con.Close();
            _logger = logger;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

