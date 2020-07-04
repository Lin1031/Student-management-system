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
    public partial class Form41 : Form
    {
        Form4 form4;
        string[] str = new string[5];
        public Form41(Form4 f)
        {
            InitializeComponent();
            button3.Visible = false;//修改时隐藏修改按钮
            form4 = f;
        }
        public Form41(string[] vs, Form4 f)//重写
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                str[i] = vs[i];
            }
            textBox1.Text = str[0];
            textBox2.Text = str[1];
            textBox3.Text = str[2];
            textBox4.Text = str[3];
            textBox5.Text = str[4];
           

            button1.Visible = false;//修改时隐藏保存按钮

            form4 = f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "")
            {
                string sql = "insert into Teacher values('" + textBox1.Text + "','" + textBox2.Text + "','123456','" + textBox4.Text + "','" + textBox5.Text + "')";
                MessageBox.Show(sql);

                Dao dao = new Dao();
                int i = dao.Excute(sql);
                if (i > 0)
                {
                    MessageBox.Show("插入成功！");
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                }
                form4.Table();
            }
            else
            {
                MessageBox.Show("输入不完整，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void Form41_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "")
            {
                if (textBox1.Text != str[0])//记录
                {
                    string sql = "update Teacher set Sno='" + textBox1.Text + "'where TID='" + str[0] + "'and Tname='" + str[1] + "'";

                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[0] = textBox1.Text;
                }
                if (textBox2.Text != str[1])//记录
                {
                    string sql = "update Teacher set Sno='" + textBox1.Text + "'where TID='" + str[0] + "'and Tname='" + str[1] + "'";

                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[1] = textBox2.Text;
                }
                if (textBox3.Text != str[2])//记录
                {
                    string sql = "update Teacher set Sno='" + textBox1.Text + "'where TID='" + str[0] + "'and Tname='" + str[1] + "'";

                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[2] = textBox3.Text;
                }
                if (textBox4.Text != str[3])//记录
                {
                    string sql = "update Teacher set Sno='" + textBox1.Text + "'where TID='" + str[0] + "'and Tname='" + str[1] + "'";

                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[3] = textBox4.Text;
                }
                if (textBox5.Text != str[4])//记录
                {
                    string sql = "update Teacher set Sno='" + textBox1.Text + "'where TID='" + str[0] + "'and Tname='" + str[1] + "'";

                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[4] = textBox1.Text;
                }
                MessageBox.Show("修改成功！");
                form4.Table();
            }
            else
            {
                MessageBox.Show("修改后有空项，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
