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
    //用于插入
    public partial class Form21 : Form
    {
        Form2 form2;
        string[] str = new string[5];
        public Form21(Form2 f)
        {
            InitializeComponent();

            button3.Visible = false;//修改时隐藏修改按钮
            form2 = f;
        }

        //用于修改，参数为一个数组
        public Form21(string[] vs,Form2 f)//重写
        {
            InitializeComponent();
            for(int i=0;i<5;i++)
            {
                str[i] = vs[i];
            }
            textBox1.Text = str[0];
            textBox2.Text = str[1];
            textBox3.Text = str[2];
            textBox4.Text = str[3];
            textBox5.Text = str[4];

            button1.Visible = false;//修改时隐藏保存按钮

            form2 = f;
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
        
        //添加一条学生记录
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "") 
            {
                string sql = "insert into Student values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','123456')";
                MessageBox.Show(sql);

                Dao dao = new Dao();
                int i = dao.Excute(sql);
                if(i>0)
                {
                    MessageBox.Show("插入成功！");
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                }
                form2.Table();
            }
            else
            {
                MessageBox.Show("输入不完整，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void Form21_Load(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)//修改语句，判断哪些改变
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "")
            {
                if(textBox1.Text!=str[0])//记录
                {
                    string sql = "update Student set Sno='" + textBox1.Text + "'where Sno='" + str[0] + "'and Sname='" + str[1] + "'";
                    
                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[0] = textBox1.Text;
                }
                if (textBox2.Text != str[1])//记录
                {
                    string sql = "update Student set Sname='" + textBox2.Text + "'where Sno='" + str[0] + "'and Sname='" + str[1] + "'";

                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[1] = textBox2.Text;
                }
                if (textBox3.Text != str[2])//记录
                {
                    string sql = "update Student set Class='" + textBox1.Text + "'where Sno='" + str[0] + "'and Sname='" + str[1] + "'";

                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[2] = textBox3.Text;
                }
                if (textBox4.Text != str[3])//记录
                {
                    string sql = "update Student set Birthday='" + textBox1.Text + "'where Sno='" + str[0] + "'and Sname='" + str[1] + "'";

                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[3] = textBox4.Text;
                }
                if (textBox5.Text != str[4])//记录
                {
                    string sql = "update Student set Place='" + textBox1.Text + "'where Sno='" + str[0] + "'and Sname='" + str[1] + "'";

                    Dao dao = new Dao();
                    dao.Excute(sql);
                    str[4] = textBox1.Text;
                }
                MessageBox.Show("修改成功！");
                form2.Table();
            }
            else
            {
                MessageBox.Show("修改后有空项，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
