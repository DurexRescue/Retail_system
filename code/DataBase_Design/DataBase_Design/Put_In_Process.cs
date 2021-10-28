using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Design
{
    public partial class Put_In_Process : Form
    {
        public string SKU;
        public string description;
        public string condition;
        public string price;
        public string Supp_Name;
        public string Supp_Country;
        public string Order;
        public string cost;
        public string d1;
        public string d2;
        public string d3;
        public bool check = false;
        public Put_In_Process()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Put_In_Process_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“drsqlDataSet10.supplier”中。您可以根据需要移动或删除它。
            this.supplierTableAdapter.Fill(this.drsqlDataSet10.supplier);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SKU = this.textBox1.Text;
            description = this.textBox2.Text;
            condition= this.textBox3.Text;
            price= this.textBox4.Text;
            Supp_Name=this.comboBox1.Text;
            Supp_Country=this.textBox5.Text;
            Order= this.textBox6.Text;
            cost= this.textBox7.Text;
            d1= this.dateTimePicker1.Text;
            d2 = this.dateTimePicker2.Text;
            d3 = this.dateTimePicker3.Text;
            check = this.checkBox1.Checked;
            this.Hide();
        }
    }
}
