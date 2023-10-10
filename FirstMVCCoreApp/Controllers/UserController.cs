using Microsoft.AspNetCore.Mvc;
using System;

namespace FirstMVCCoreApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(string username, string password, int is_enabled)
        {
            var status_code = 100;
            var message = "";
            try
            {
                if (username == null || username == "")
                {
                    message = "Username tidak boleh kosong";
                }
                else if (password == null || password == "")
                {
                    message = "Password tidak boleh kosong";
                }
                else
                {
                    status_code = 200;
                    message = "Create user success";
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Json(new { status_code, message });
        }
    }
}