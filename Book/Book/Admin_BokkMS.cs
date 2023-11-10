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
    public partial class Admin_BokkMS : Form
    {
        static string id;
        public Admin_BokkMS()
        {
            InitializeComponent();
            Table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_BokkMS_Load(object sender, EventArgs e)
        {
            Table();
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label2.Text = id + " " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
        public void Table()//刷新界面
        {
            dataGridView1.Rows.Clear();//把控件中已有的数据清除
            Dao dao = new Dao();
            string sql = "select * from t_book";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), 
                    dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button2_Click(object sender, EventArgs e)//添加图书
        {
            try
            {
                DialogResult dr = MessageBox.Show("确认删除吗？","信息提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(dr == DialogResult.OK)
                {
                    string sql = $"delete from t_book where id = '{id}'";
                    Dao dao = new Dao();
                    if (dao.Excute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败"+sql);
                    }
                    dao.DaoClose();
                }

            }
            catch
            {
                MessageBox.Show("请先在表格中选择要删除的记录", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book_Add book_Add = new Book_Add();
            this.Hide();
            book_Add.ShowDialog();
            Table();
            this.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)//每次点击切换当前选中的图书id和名称
        {
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label2.Text = id + " " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string author = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string press  = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string number = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Book_Update book_Update = new Book_Update(id,name,author,press,number);
                this.Hide();
                book_Update.ShowDialog();
                Table();
                this.Show();
            }
            catch
            {
                MessageBox.Show("应该不会报错吧");
            }

        }

        private void button5_Click(object sender, EventArgs e)//书号查询，根据书号显示信息
        {
            dataGridView1.Rows.Clear();//把控件中已有的数据清除
            Dao dao = new Dao();
            string sql = $"select * from t_book where id = '{textBox1.Text}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(),
                    dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button6_Click(object sender, EventArgs e)//书名查询，根据所给书名进行模糊查询
        {
            dataGridView1.Rows.Clear();//把控件中已有的数据清除
            Dao dao = new Dao();
            string sql = $"select * from t_book where name like  '%{textBox2.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(),
                    dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
