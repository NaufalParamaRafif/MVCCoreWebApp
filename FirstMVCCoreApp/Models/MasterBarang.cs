using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace FirstMVCCoreApp.Models
{
    public class MasterBarang
    {
        public string kode_barang { get; set; }
        public string nama_barang { get; set; }
        public int stock_barang { get; set; }
        public double harga_barang { get; set; }
        public int qty { get; set; }
        public int id_satuan { get; set; }
        public int id_supplier { get; set; }
        public int id_gudang { get; set; }
        public int is_enabled { get; set; }
        public DateTime created_datetime { get; set; }
        public string created_user { get; set; }
        public DateTime updated_datetime { get; set; }
        public string updated_user { get; set; }
    }
}
