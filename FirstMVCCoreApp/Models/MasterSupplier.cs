using System;

namespace FirstMVCCoreApp.Models
{
    public class MasterSupplier
    {
        public string id_supplier { get; set; }
        public string nama_supplier { get; set; }
        public string alamat { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int is_enabled { get; set; }
        public DateTime created_datetime { get; set; }
        public string created_user { get; set; }
        public DateTime updated_datetime { get; set; }
        public string updated_user { get; set; }
    }
}
