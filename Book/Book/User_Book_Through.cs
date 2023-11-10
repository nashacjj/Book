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
    public partial class User_Book_Through : Form
    {
        static string id;
        public User_Book_Through()
        {
            InitializeComponent();
            Table();
        }

        private void User_Book_Through_Load(object sender, EventArgs e)
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label2.Text = id + " " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            if (number < 1)
            {
                MessageBox.Show("库存不足，请联系管理员购入");
            }
            else
            {
                string sql = $"insert into t_lend ([uid],bid,[datetime]) values('{Data.UID}','{id}',getdate());" +
                    $"update t_book set number = number - 1 where id ='{id}'";
                Dao dao = new Dao();
                if (dao.Excute(sql) > 1)
                {
                    MessageBox.Show($"用户{Data.UName}借阅了图书{id}");
                }
                else
                {
                    MessageBox.Show("借阅失败");
                }
                Table();
            }
        }
    }
}
