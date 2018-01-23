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
            BookData bookdata = new BookData();
            bookdata(obj);


        }
    }
}
