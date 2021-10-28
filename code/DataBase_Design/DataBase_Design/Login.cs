using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBase_Design
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. 获取数据
            //从TextBox中获取用户输入信息
            string userName = this.textBox1.Text;
            string userPassword = this.textBox2.Text;

            //2. 验证数据
            // 验证用户输入是否为空，若为空，提示用户信息
            if (userName.Equals("") || userPassword.Equals("")){
                MessageBox.Show("用户名或密码不能为空！");
            }
            // 若不为空，验证用户名和密码是否与数据库匹配
            // 这里只做字符串对比验证
            else{
                string ConString = "server=localhost;User Id="+userName+";password="+userPassword+";Database=DRSQL";
                MySqlConnection conn = new MySqlConnection(ConString);//连接数据库    
                try{
                    conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句  
                    MessageBox.Show("已经建立连接");
                    conn.Close();
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                    
                    
                }
                catch (MySqlException ex){

                    MessageBox.Show("建立连接失败!");
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
