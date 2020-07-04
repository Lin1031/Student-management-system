using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();

            Table();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
           
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//结束整个程序
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select *from Student";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string Sno, Sname, Class, Data, Place;
                Sno = dr["Sno"].ToString();
                Sname = dr["Sname"].ToString();
                Class = dr["Class"].ToString();
                Data = dr["Birthday"].ToString();
                Place = dr["Place"].ToString();

                string[] str = { Sno, Sname, Class, Data, Place };
                dataGridView1.Rows.Add(str);

            }
            dr.Close();//关闭
        }

        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21(this);
            form21.ShowDialog();//打开

        }

        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] vs = { dataGridView1.SelectedCells[0].Value.ToString(),
                dataGridView1.SelectedCells[1].Value.ToString(),
                dataGridView1.SelectedCells[2].Value.ToString(),
                dataGridView1.SelectedCells[3].Value.ToString(),
                dataGridView1.SelectedCells[4].Value.ToString() };

            MessageBox.Show(vs[0] + vs[1]);

            Form21 form21 = new Form21(vs,this);
            form21.ShowDialog();


        }

        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("请确认删除", "提示", MessageBoxButtons.OKCancel);

            if(result==DialogResult.OK)
            {
                string Sno, Sname;
                Sno = dataGridView1.SelectedCells[0].Value.ToString();
                Sname = dataGridView1.SelectedCells[1].Value.ToString();
                string sql = "delete from Student where Sno='" + Sno + "'and Sname='" + Sname + "'";

                MessageBox.Show(sql);

                Dao dao = new Dao();
                dao.Excute(sql);
                Table();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void 查询学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string sql = "select *from v1";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string Sno, Sname, Class, Sage, Place;
                Sno = dr["Sno"].ToString();
                Sname = dr["Sname"].ToString();
                Class = dr["Class"].ToString();
                Sage = dr["Sage"].ToString();
                Place = dr["Place"].ToString();

                string[] str = { Sno, Sname, Class, Sage, Place };
                dataGridView1.Rows.Add(str);

            }
            dr.Close();//关闭
        }
    }
}
