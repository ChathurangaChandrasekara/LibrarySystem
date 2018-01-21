using BusinesLogic;
using model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
        }

        private void lbl_author_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book book = new Book();
            book.Show();
        }

        private void btn_add_book_Click(object sender, EventArgs e)
        {
            bookDto obj = new bookDto();
            obj.author = txtbx_author.Text;
            obj.book_id = txtbx_book_id.Text;
            obj.book_name = txtbx_book_name.Text;
            obj.category = txtbx_category.Text;
            obj.price = Convert.ToInt32(txtbx_price.Text);
            obj.published_date = Convert.ToDateTime(txtbx_published_date.Text);

            booklogic blogic = new booklogic();
            blogic.addbooklogic(obj);

                
        }
    }
}
