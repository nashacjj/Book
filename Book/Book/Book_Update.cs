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
    public partial class Book_Update : Form
    {
        string ID = "";
        public Book_Update()
        {
            InitializeComponent();
        }
        public Book_Update(string id,string name,string author,string press,string number)
        {
            InitializeComponent(); 
            ID = textBox1.Text = id;
            textBox2.Text = name;
            textBox3.Text = author;
            textBox4.Text = press;
            textBox5.Text = number;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                string sql = $"update t_book set id='{textBox1.Text}',name='{textBox2.Text}',author='{textBox3.Text}',press='{textBox4.Text}',number='{textBox5.Text}'where id='{ID}'";
                Dao dao = new Dao();
                if (dao.Excute(sql) > 0)
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            else
            {
                MessageBox.Show("输入不能有空");
            }


        }
    }
}
