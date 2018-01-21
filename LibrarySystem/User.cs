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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            View view = new View();
            view.Show();
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser adduser = new AddUser();
            adduser.Show();
        }

        private void btn_find_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindUser finduser = new FindUser();
            finduser.Show();
        }
    }
}
