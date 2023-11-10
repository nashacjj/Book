using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void 图书查阅和借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Book_Through user_Book_Through = new User_Book_Through();
            this.Hide();
            user_Book_Through.ShowDialog();
            this.Show();
        }

        private void 当前借出图书和归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Book_Borrow user_Book_Borrow = new User_Book_Borrow();
            this.Hide();
            user_Book_Borrow.ShowDialog();
            this.Show();
        }
    }
}
