using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCCoreApp.Controllers
{
    public class UserController : Controller
    {
        private string connectionMYSQL = "Server=127.0.0.1;Port=3306;User ID=root;Password=;Database=gurutamu";
        public IActionResult Index()
        {
            return View();
        }

        private async Task<int> insertUser(string username, string password, int is_enabled)
        {
            var conn = new MySqlConnection(connectionMYSQL);
            var affected_row = 0;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "INSERT INTO tbl_user(username,password,is_enabled,created_datetime,created_user)" + "VALUES('" + username + "', '" + password + "', 1, NOW(), 'SYSTEM')";
                affected_row = await SqlMapper.ExecuteAsync(conn, sql, null, null, null, CommandType.Text);
                return affected_row;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<IActionResult> Create(string username, string password, int is_enabled)
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
                    var affected = await insertUser(username, password, 1);
                    if (affected > 0)
                    {
                        status_code = 200;
                        message = "Create user success";
                    }
                    else
                    {
                        status_code = 200;
                        message = "Create user failed";
                    }

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