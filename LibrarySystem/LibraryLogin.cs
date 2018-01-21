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
    public partial class LibraryLogin : Form
    {
        public LibraryLogin()
        {
            InitializeComponent();
        }

        private void txtbx_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_user_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            View V = new View();
            V.Show();
        }
    }
}
