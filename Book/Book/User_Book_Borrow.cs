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
    public partial class User_Book_Borrow : Form
    {
        public User_Book_Borrow()
        {
            InitializeComponent();
            Table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Table()//刷新界面
        {
            dataGridView1.Rows.Clear();//把控件中已有的数据清除
            Dao dao = new Dao();
            string sql = $"select * from t_lend where uid = '{Data.UID}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[2].ToString(),
                    dc[3].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string sql = $"delete from t_lend where [no] = {no};update t_book set number=number+1 where id = '{id}'";
            Dao dao = new Dao();
            if(dao.Excute(sql) > 1)
            {
                MessageBox.Show("归还成功");
                Table();
            }
            else
            {
                MessageBox.Show("归还失败");
            }
        }
    }
}
