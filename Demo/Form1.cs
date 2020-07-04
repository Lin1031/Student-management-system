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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Photo_Click(object sender, EventArgs e)
        {

        }
        //登陆事件
        private void button1_Click(object sender, EventArgs e)
        {
            if(Login())//启动计时器控件，图片开始移动
            {
                timer1.Start();
                UserNameLabel.Visible = false;
                PasswordLabel.Visible = false;
                PowerLabel.Visible = false;
                UserNameTextBox.Visible = false;
                PasswordTextBox.Visible = false;
                PowerComboBox.Visible = false;
                LoginButton.Visible = false;
                CancalButton.Visible = false;
            }
        }
        private bool Login()//封装一个登陆
        {
            if(UserNameTextBox.Text=="" || PasswordTextBox.Text=="" || PowerComboBox.Text=="")
            {
                MessageBox.Show("输入不完整，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (PowerComboBox.Text=="学生")//数据库中查找数据是否存在
            {
                string sql = "select *from Student where SName = '" + UserNameTextBox.Text + "'  and SPassword = ' " + PasswordTextBox.Text + "'";
                
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                if(dr.Read())//读数据，返回bool型
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                    return false;
                }
            }
            if (PowerComboBox.Text == "老师")
            {
                string sql = "select *from Teacher where TName = '" + UserNameTextBox.Text + "'  and TPassword = ' " + PasswordTextBox.Text + "'";

                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                if (dr.Read())//读数据，返回bool型
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                    return false;
                }
            }
            if (PowerComboBox.Text == "管理员")
            {
                if (UserNameTextBox.Text == "admin" && PasswordTextBox.Text == "admin") 
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                    return false;
                }
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Photo.Location.X<150)
            {
                Photo.Location = new Point(Photo.Location.X + 1, Photo.Location.Y);
            }
            else
            {
                if(PowerComboBox.Text=="学生")
                {
                    string sql = "select *from Student where SName = '" + UserNameTextBox.Text + "'  and SPassword = ' " + PasswordTextBox.Text + "'";

                    Dao dao = new Dao();
                    IDataReader dr = dao.read(sql);
                    dr.Read();

                    string Sno=dr["Sno"].ToString();

                    Form3 form3 = new Form3(Sno);

                    form3.Show();//显示这个船体
                    this.Hide();//隐藏这个窗体
                }
                else if (PowerComboBox.Text == "老师")
                {
                    Form2 form2 = new Form2();
                    form2.Show();//显示这个船体
                    this.Hide();//隐藏这个窗体
                }
                else if (PowerComboBox.Text == "管理员")
                {
                    Form4 form4 = new Form4();
                    form4.Show();//显示这个船体
                    this.Hide();//隐藏这个窗体
                }
                timer1.Stop();
            }
        }

        private void PowerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancalButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox = null;
            PasswordTextBox = null;
            PowerComboBox = null;
        }
    }
}
