using System;

namespace ProjectWeb.Models
{
    public class Record
    {
        public int id { get; set; }
        public string document_name { get; set; }
        public string document_id { get; set; }
        public string document_type { get; set; }
        public DateTime signed_day { get; set; }
        public string book_number { get; set;}
        public string version { get; set;}
        public int last_fix { get; set; }
        public string tag { get; set; }
    }
}
