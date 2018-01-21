using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class bookDto
    {
        public string book_id { get; set; }
        public string book_name { get; set; }
        public string author { get; set; }
        public Nullable<System.DateTime> published_date { get; set; }
        public Nullable<decimal> price { get; set; }
        public string category { get; set; }
        public string existing_state { get; set; }
    }
}
