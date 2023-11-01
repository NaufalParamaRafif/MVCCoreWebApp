using System;

namespace FirstMVCCoreApp.Models
{
    public class MasterGudang
    {
        public string id_gudang { get; set; }
        public string nama_gudang { get; set; }
        public int is_enabled { get; set; }
        public DateTime created_datetime { get; set; }
        public string created_user { get; set; }
        public DateTime updated_datetime { get; set; }
        public string updated_user { get; set; }
    }
}
