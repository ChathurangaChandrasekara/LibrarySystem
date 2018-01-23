using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    class BookData
    {
        LibraryProjectEntities db = new LibraryProjectEntities();
        public void Addbook(model.bookDto obj)
        {
            Book bookobj = new Book();

            bookobj.author = obj.author;
            bookobj.book_id = obj.book_id;
            bookobj.book_name = obj.book_name;
            bookobj.category = obj.category;
            bookobj.existing_state = obj.existing_state;
            bookobj.price = obj.price;
            bookobj.published_date = obj.published_date;

            db.Books.Add(bookobj);
            db.SaveChanges();

        }
    }
}
