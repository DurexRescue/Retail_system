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
    public partial class Views : Form
    {
        public Views()
        {
            InitializeComponent();
        }

        private void Views_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“drsqlDataSet18.sold”中。您可以根据需要移动或删除它。
            this.soldTableAdapter.Fill(this.drsqlDataSet18.sold);
            // TODO: 这行代码将数据加载到表“drsqlDataSet17.on_stock”中。您可以根据需要移动或删除它。
            this.on_stockTableAdapter1.Fill(this.drsqlDataSet17.on_stock);
            // TODO: 这行代码将数据加载到表“drsqlDataSet16.on_stock”中。您可以根据需要移动或删除它。
            this.on_stockTableAdapter.Fill(this.drsqlDataSet16.on_stock);

        }
    }
}
