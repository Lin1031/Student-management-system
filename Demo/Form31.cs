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
    public partial class Form31 : Form
    {
        string SNO;
        public Form31(string Sno)
        {
            SNO = Sno;
            InitializeComponent();
            Table();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Table()
        {
            dataGridView2.Rows.Clear();
            string sql = "select *from SC where Sno='" + SNO + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);

            while (dr.Read())
            {
                string CNO = dr["Cno"].ToString();
                string sql2 = "select *from Course where Cno='" + CNO + "'";

                IDataReader dr2 = dao.read(sql2);
                dr2.Read();

                string Cno, Cname, Credit, Instructor;
                Cno = dr2["Cno"].ToString();
                Cname = dr2["Cname"].ToString();
                Credit = dr2["Credit"].ToString();
                Instructor = dr2["Instructor"].ToString();

                string[] str = { Cno, Cname, Credit, Instructor };
                dataGridView2.Rows.Add(str);
            }
            dr.Close();//关闭
        }

        private void 取消选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Cno = dataGridView2.SelectedCells[0].Value.ToString();
            string sql = "delete SC where Sno='" + SNO + "'and Cno = '" + Cno + "'";

            Dao dao = new Dao();
            dao.Excute(sql);
            Table();
        }
    }
}
