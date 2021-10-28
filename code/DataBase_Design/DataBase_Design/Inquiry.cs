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
    public partial class Inquiry : Form
    {
        public string SKU, uID, Date, itime;
        public Inquiry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SKU = comboBox1.Text;
            uID = textBox1.Text;
            Date = dateTimePicker1.Text;
            itime = textBox2.Text;
            this.Hide();
        }
    }
}
