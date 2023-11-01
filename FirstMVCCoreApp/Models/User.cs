using System;

namespace FirstMVCCoreApp.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int is_enabled { get; set; }
        public DateTime created_datetime { get; set; }
        public string created_user { get; set; }
        public DateTime updated_datetime { get; set; }
        public string updated_user { get; set; }

    }
}
