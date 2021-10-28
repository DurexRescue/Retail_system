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
    public partial class Sell_Process : Form
    {
        public string SKU, uID, itime, d1, price;
        public Sell_Process()
        {
            InitializeComponent();
        }

        private void Sell_Process_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“drsqlDataSet12.inquiry_customer”中。您可以根据需要移动或删除它。
            this.inquiry_customerTableAdapter.Fill(this.drsqlDataSet12.inquiry_customer);
            // TODO: 这行代码将数据加载到表“drsqlDataSet11.on_stock”中。您可以根据需要移动或删除它。
            this.on_stockTableAdapter.Fill(this.drsqlDataSet11.on_stock);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SKU = comboBox1.Text;
            uID = comboBox2.Text;
            itime = textBox2.Text;
            d1 = this.dateTimePicker1.Text;
            price = textBox3.Text;
            this.Hide();
        }
    }
}
