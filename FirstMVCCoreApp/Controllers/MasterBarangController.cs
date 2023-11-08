using Dapper;
using FirstMVCCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System;
using System.Reflection;

namespace FirstMVCCoreApp.Controllers
{
    public class MasterBarangController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private string connectionMYSQL = "Server=127.0.0.1;Port=3306;User ID=root;Password=;Database=nama_database";
        public async Task<IActionResult> GetData()
        {
            var conn = new MySqlConnection(connectionMYSQL);
            var status_code = 100;
            var message = "";
            IEnumerable<MasterBarang> result = new List<MasterBarang>() { };
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                var sql = "SELECT * FROM mst_barang where is_enabled=1";
                result = await SqlMapper.QueryAsync<MasterBarang>(conn, sql, null, null, null, CommandType.Text);
            }
            catch (Exception ex)
            {
                status_code = 500;
                message = ex.Message;
            }
            return Json(new { data = result, status_code, message });
        }

        [HttpPost]
        public async Task<IActionResult> Create(MasterBarang model)
        {
            var conn = new MySqlConnection(connectionMYSQL);
            var affected = 0;

            var status_code = 100;
            var message = "";
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                var sqlChecking = "select count(kode_barang) as total from mst_barang where kode_barang = '" + model.kode_barang + "' AND is_enabled = 1";

                var count = await SqlMapper.ExecuteScalarAsync<int>(conn, sqlChecking, null, null, null, CommandType.Text);
                var sql = "";
                if (count > 0)
                {

                    message = "Barang sudah ada";
                }
                else
                {
                    sql = "INSERT into mst_barang (kode_barang, nama_barang, stock_on_hand, harga_barang, " +
                    " is_enabled, created_datetime, created_user) " +
                    "values ('" + model.kode_barang + "', '" + model.nama_barang + "',0, '" + model.harga_barang + "', 1, NOW(), 'SYSTEM')";
                    message = "Insert";
                }


                affected = await SqlMapper.ExecuteAsync(conn, sql, null, null, null, CommandType.Text);

                if (affected > 0)
                {
                    status_code = 200;
                    message = "Success " + message + " New Item";
                }
                else
                {
                    message = "Failed " + message + " New Item";
                }
            }
            catch (Exception ex)
            {
                status_code = 500;
                message = ex.Message;
            }
            return Json(new { affected, message, status_code });
        }
    }
}