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
    public partial class Form3 : Form
    {
        string SNO;
        public Form3(string Sno)
        {
            SNO = Sno;
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            toolStripStatusLabel1.Text = "欢迎学号为" + SNO + "的同学登陆选课系统";
            timer1.Start();
            Table();
        }

        private void 选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Cno = dataGridView1.SelectedCells[0].Value.ToString();//获取选中课程号
            //判断是否重复选课
            string sql1 = "select *from SC where Sno='" + SNO + "'and Cno='" + Cno + "'";
            Dao dao = new Dao();
            IDataReader data = dao.read(sql1);

            if(!data.Read())//读不到记录
            {
                string sql = "insert into SC values('" + SNO + "','" + Cno + "')";
                MessageBox.Show(sql);

                int i = dao.Excute(sql);
                if (i > 0)
                {
                    MessageBox.Show("选课成功！");
                }
            }
            else
            {
                MessageBox.Show("不允许重复选课！");
            }

        }
        public void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select *from Course";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())

            {
                string Cno, Cname, Credit, Instructor;
                Cno = dr["Cno"].ToString();
                Cname = dr["Cname"].ToString();
                Credit = dr["Credit"].ToString();
                Instructor = dr["Instructor"].ToString();

                string[] str = { Cno, Cname, Credit, Instructor };
                dataGridView1.Rows.Add(str);

            }
            dr.Close();//关闭
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//结束整个程序
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void 我的课表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 form31 = new Form31(SNO);
            form31.Show();
        }
    }
}
