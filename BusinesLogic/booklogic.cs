using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHandler;

namespace BusinesLogic
{
   public class booklogic
    {

      

        public void addbooklogic(bookDto obj)
        {
            bookDto bobj = new bookDto();
            bobj.author = obj.author;
            bobj.book_id = obj.book_id;
            bobj.book_name = obj.book_name;
            bobj.category = obj.category;
            bobj.price = obj.price;
            bobj.published_date = obj.published_date;






        }
    }
}
