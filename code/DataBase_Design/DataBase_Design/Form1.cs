using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel=Microsoft.Office.Interop.Excel;
using System.IO;


using System.Data.OleDb;
using Microsoft.SqlServer.Server;
using Microsoft.Office.Interop.Excel;

namespace DataBase_Design
{
    public partial class Form1 : Form
    {
        string[] columns = new string[10];
        public Form1()
        {
            InitializeComponent();
        }
        //MySqlDataAdapter adp = new MySqlDataAdapter("select * from Product", new MySqlConnection("server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL"));
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“drsqlDataSet15.inquiry_customer”中。您可以根据需要移动或删除它。
            this.inquiry_customerTableAdapter2.Fill(this.drsqlDataSet15.inquiry_customer);
            // TODO: 这行代码将数据加载到表“drsqlDataSet14.put_in”中。您可以根据需要移动或删除它。
            this.put_inTableAdapter2.Fill(this.drsqlDataSet14.put_in);
            // TODO: 这行代码将数据加载到表“drsqlDataSet13.put_in”中。您可以根据需要移动或删除它。
            this.put_inTableAdapter1.Fill(this.drsqlDataSet13.put_in);
            // TODO: 这行代码将数据加载到表“drsqlDataSet8.inquiry”中。您可以根据需要移动或删除它。
            this.inquiryTableAdapter.Fill(this.drsqlDataSet8.inquiry);
            // TODO: 这行代码将数据加载到表“drsqlDataSet7.put_in”中。您可以根据需要移动或删除它。
            this.put_inTableAdapter.Fill(this.drsqlDataSet7.put_in);
            
            // TODO: 这行代码将数据加载到表“drsqlDataSet4.inquiry_customer”中。您可以根据需要移动或删除它。
            //this.inquiry_customerTableAdapter1.Fill(this.drsqlDataSet4.inquiry_customer);
            
            // TODO: 这行代码将数据加载到表“drsqlDataSet3.supplier”中。您可以根据需要移动或删除它。
            this.supplierTableAdapter1.Fill(this.drsqlDataSet3.supplier);
            
            // TODO: 这行代码将数据加载到表“drsqlDataSet2.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter1.Fill(this.drsqlDataSet2.product);
            
            
            
            
            // TODO: 这行代码将数据加载到表“drsqlDataSet.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.drsqlDataSet.product);
            // TODO: 这行代码将数据加载到表“drsqlDataSet.supplier”中。您可以根据需要移动或删除它。
            this.supplierTableAdapter.Fill(this.drsqlDataSet.supplier);
            // TODO: 这行代码将数据加载到表“drsqlDataSet.inquiry_customer”中。您可以根据需要移动或删除它。
            this.inquiry_customerTableAdapter.Fill(this.drsqlDataSet.inquiry_customer);

            String ConString = "server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL";
            MySqlConnection conn = new MySqlConnection(ConString);
            comboBox1.Items.Clear();//清空ComBox    
            MySqlCommand cmd = new MySqlCommand("show columns from product", conn);//构造连接字符串并切打开数据库连接    
            conn.Open();
            MySqlDataReader sdr = cmd.ExecuteReader();
            int i = 0;
            while (sdr.Read())
            {
                comboBox1.Items.Add(sdr[0].ToString());//循环读取数据    
                columns[i] = sdr.GetString(0);
                i++;

            }//end block while    

            sdr.Close();//  关闭数据集    
            conn.Close();//关闭数据库连接


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { this.productTableAdapter1.Update(drsqlDataSet2); }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "错误信息");
            }//更新Product表用

            try { this.supplierTableAdapter1.Update(drsqlDataSet3); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "错误信息");
            }//更新Supplier表用

            try { this.inquiry_customerTableAdapter2.Update(drsqlDataSet15);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "错误信息");
            }//更新Inquiry_Customer表用

            try { //this.put_inTableAdapter.Update(drsqlDataSet7); 
                this.put_inTableAdapter2.Update(drsqlDataSet14); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "错误信息");
            }//更新Put_in表用

            try { this.inquiryTableAdapter.Update(drsqlDataSet8); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "错误信息");
            }//更新Inquiry表用
        }

        private void DGV_Refresh()
        {
            // TODO: 这行代码将数据加载到表“drsqlDataSet15.inquiry_customer”中。您可以根据需要移动或删除它。
            this.inquiry_customerTableAdapter2.Fill(this.drsqlDataSet15.inquiry_customer);
            // TODO: 这行代码将数据加载到表“drsqlDataSet14.put_in”中。您可以根据需要移动或删除它。
            this.put_inTableAdapter2.Fill(this.drsqlDataSet14.put_in);
            // TODO: 这行代码将数据加载到表“drsqlDataSet13.put_in”中。您可以根据需要移动或删除它。
            this.put_inTableAdapter1.Fill(this.drsqlDataSet13.put_in);
            // TODO: 这行代码将数据加载到表“drsqlDataSet8.inquiry”中。您可以根据需要移动或删除它。
            this.inquiryTableAdapter.Fill(this.drsqlDataSet8.inquiry);
            // TODO: 这行代码将数据加载到表“drsqlDataSet7.put_in”中。您可以根据需要移动或删除它。
            this.put_inTableAdapter.Fill(this.drsqlDataSet7.put_in);

            // TODO: 这行代码将数据加载到表“drsqlDataSet4.inquiry_customer”中。您可以根据需要移动或删除它。
            //this.inquiry_customerTableAdapter1.Fill(this.drsqlDataSet4.inquiry_customer);

            // TODO: 这行代码将数据加载到表“drsqlDataSet3.supplier”中。您可以根据需要移动或删除它。
            this.supplierTableAdapter1.Fill(this.drsqlDataSet3.supplier);

            // TODO: 这行代码将数据加载到表“drsqlDataSet2.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter1.Fill(this.drsqlDataSet2.product);




            // TODO: 这行代码将数据加载到表“drsqlDataSet.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.drsqlDataSet.product);
            // TODO: 这行代码将数据加载到表“drsqlDataSet.supplier”中。您可以根据需要移动或删除它。
            this.supplierTableAdapter.Fill(this.drsqlDataSet.supplier);
            // TODO: 这行代码将数据加载到表“drsqlDataSet.inquiry_customer”中。您可以根据需要移动或删除它。
            this.inquiry_customerTableAdapter.Fill(this.drsqlDataSet.inquiry_customer);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            DGV_Refresh();
        }

        private void button9_Click(object sender, EventArgs e)//进货过程
        {
            Put_In_Process PIP1 = new Put_In_Process();
            PIP1.ShowDialog();
            string SKU = PIP1.SKU;
            string description = PIP1.description;
            string condition = PIP1.condition;
            string price = PIP1.price;
            string Supp_Name = PIP1.Supp_Name;
            string Supp_Country = PIP1.Supp_Country;
            string Order = PIP1.Order;
            string cost = PIP1.cost;
            string d1 = PIP1.d1;
            string d2 = PIP1.d2;
            string d3 = PIP1.d3;
            bool check = PIP1.check;


            
            String ConString = "server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL";
            MySqlConnection conn = new MySqlConnection(ConString);
            
            //存储过程 Insert_Product设置
            String command1 = string.Format("call Insert_Product('{0}','{1}','{2}','{3}');", SKU, description, condition, price);
            MySqlCommand cmd1 = new MySqlCommand(command1, conn);

            conn.Open();
            if (check == false)
            {
                //存储过程 Insert_Supplier设置
                String command2 = string.Format("call Insert_Supplier('{0}','{1}');", Supp_Name, Supp_Country);
                MySqlCommand cmd2 = new MySqlCommand(command2, conn);
                cmd2.ExecuteNonQuery();
            }
           
            //存储过程 Insert_Put_in设置
            String command3 = string.Format("call Insert_Put_in('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", Order,SKU,cost,d1,d2,d3,Supp_Name);
            MySqlCommand cmd3 = new MySqlCommand(command3, conn);

            //统一执行,EXCEPT Insert_Supplier
            
            cmd1.ExecuteNonQuery();
            
            cmd3.ExecuteNonQuery();
            conn.Close();

            //执行后刷新DataGrdView
            DGV_Refresh();
        }

        private void button8_Click(object sender, EventArgs e)//售卖过程
        {
            Sell_Process SP1 = new Sell_Process();
            SP1.ShowDialog();
            string SKU = SP1.SKU;
            string uID = SP1.uID;
            string itime = SP1.itime;
            string d1 = SP1.d1;
            string price = SP1.price;

            String ConString = "server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL";
            MySqlConnection conn = new MySqlConnection(ConString);
            //存储过程Update_Product设置
            String command1 = string.Format("call Update_Product('{0}','{1}','{2}');", SKU, price,d1);
            MySqlCommand cmd1 = new MySqlCommand(command1, conn);

            //存储过程Update_Inquiry_customer设置
            String command2 = string.Format("call Update_Inquiry_customer('{0}','{1}','{2}');", SKU,uID,itime);
            MySqlCommand cmd2 = new MySqlCommand(command2, conn);
            //统一执行

            conn.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();

            //执行后刷新DataGrdView
            DGV_Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Inquiry iq1 = new Inquiry();
            iq1.ShowDialog();
            string SKU = iq1.SKU;
            string uID = iq1.uID;
            string Date = iq1.Date;
            string itime = iq1.itime;

            String ConString = "server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL";
            MySqlConnection conn = new MySqlConnection(ConString);
            //存储过程Insert_Inquiry_customer设置
            String command1 = string.Format("call Insert_Inquiry_customer('{0}','{1}','{2}');", uID,SKU,itime);
            MySqlCommand cmd1 = new MySqlCommand(command1, conn);

            //存储过程Insert_Inquiry设置
            String command2 = string.Format("call Insert_Inquiry('{0}','{1}','{2}');", Date,SKU,uID);
            MySqlCommand cmd2 = new MySqlCommand(command2, conn);
            //统一执行

            conn.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();

            //执行后刷新DataGrdView
            DGV_Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            String ConString = "server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL";
            MySqlConnection conn = new MySqlConnection(ConString);
            //存储过程call Delete_cascade_1p设置 单参数 适合于产品和供货商的删除
            if (tabControl1.SelectedTab.Name == "tabPage1"|| tabControl1.SelectedTab.Name == "tabPage2") {

                string[] str;
                //获取要处理的数据
                if (tabControl1.SelectedTab.Name == "tabPage1"){
                    str = new string[dataGridView1.Rows.Count];
                    for (int i=0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Selected == true)
                        {
                            str[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            //MessageBox.Show(str[i]);
                        }
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        String command1 = string.Format("call Delete_cascade_product('{0}');", str[i]);
                        MySqlCommand cmd1 = new MySqlCommand(command1, conn);
                        conn.Open();
                        cmd1.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                else{
                    str = new string[dataGridView2.Rows.Count];
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Selected == true)
                        {
                            str[i] = dataGridView2.Rows[i].Cells[0].Value.ToString();
                            //MessageBox.Show(str[i]);
                        }
                    }
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        String command1 = string.Format("call Delete_cascade_supplier('{0}');", str[i]);
                        MySqlCommand cmd1 = new MySqlCommand(command1, conn);
                        conn.Open();
                        cmd1.ExecuteNonQuery();
                        conn.Close();
                    }

                }
               
                
            }
            

            else
            {
                MessageBox.Show("请直接使用Delete键删除！");
            }


            //执行后刷新DataGrdView
            DGV_Refresh();
            
        }



        private void Change_CBOX(object sender, EventArgs e)
        {
            String ConString = "server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL";
            MySqlConnection conn = new MySqlConnection(ConString);
            comboBox1.Items.Clear();//清空ComBox    
            string [] table_name= { "product", "supplier", "inquiry_customer", "put_in", "inquiry" };
            
            int selected_tab_num = tabControl1.SelectedIndex;
            string sql = string.Format("show columns from {0}", table_name[selected_tab_num]);
            MySqlCommand cmd = new MySqlCommand(sql, conn);//构造连接字符串并切打开数据库连接    
            conn.Open();
            MySqlDataReader sdr = cmd.ExecuteReader();
            int i = 0;
            while (sdr.Read())
            {
                comboBox1.Items.Add(sdr[0].ToString());//循环读取数据    
                
                columns[i] = sdr.GetString(0);
                i++;
            }//end block while    
            
            sdr.Close();//  关闭数据集    
            conn.Close();//关闭数据库连接 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.ClearSelection();
            dataGridView5.ClearSelection();



            String ConString = "server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL";
            MySqlConnection conn = new MySqlConnection(ConString);
            string[] table_name = { "product", "supplier", "inquiry_customer", "put_in", "inquiry" };
            string matchstr = "%" + textBox1.Text + "%";
            int selected_tab_num = tabControl1.SelectedIndex;//栏目框所选的内容
            int comboBox_selection = comboBox1.SelectedIndex;//下拉栏的所选内容
            if (comboBox_selection == -1) { MessageBox.Show("请选择后再搜索！"); return;}
            string sql = string.Format("select {0} from {1} where {2} like '{3}'", columns[comboBox_selection], table_name[selected_tab_num], columns[comboBox_selection], matchstr);//查询语句OK
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            switch (selected_tab_num)
            {
                case 0:
                    
                    while (reader.Read())
                    {
                        int n = dataGridView1.RowCount-1;
                        
                        string temp = reader[0].ToString();
                        for(i = 0; i < n; i++)
                        {
                            if(temp == dataGridView1.Rows[i].Cells[comboBox_selection].Value.ToString()) 
                            dataGridView1.Rows[i].Selected = true;
                        }
                        

                    }
                    break;
                case 1:

                    while (reader.Read())
                    {
                        int n = dataGridView2.RowCount - 1;

                        string temp = reader[0].ToString();
                        for (i = 0; i < n; i++)
                        {
                            if (temp == dataGridView2.Rows[i].Cells[comboBox_selection].Value.ToString())
                                dataGridView2.Rows[i].Selected = true;
                        }


                    }
                    break;
                case 2:

                    while (reader.Read())
                    {
                        int n = dataGridView3.RowCount - 1;

                        string temp = reader[0].ToString();
                        for (i = 0; i < n; i++)
                        {
                            if (temp == dataGridView3.Rows[i].Cells[comboBox_selection].Value.ToString())
                                dataGridView3.Rows[i].Selected = true;
                        }


                    }
                    break;
                case 3:

                    while (reader.Read())
                    {
                        int n = dataGridView4.RowCount - 1;

                        string temp = reader[0].ToString();
                        for (i = 0; i < n; i++)
                        {
                            if (temp == dataGridView4.Rows[i].Cells[comboBox_selection].Value.ToString())
                                dataGridView4.Rows[i].Selected = true;
                        }


                    }
                    break;
                case 4:

                    while (reader.Read())
                    {
                        int n = dataGridView5.RowCount - 1;

                        string temp = reader[0].ToString();
                        for (i = 0; i < n; i++)
                        {
                            if (temp == dataGridView5.Rows[i].Cells[comboBox_selection].Value.ToString())
                                dataGridView5.Rows[i].Selected = true;
                        }


                    }
                    break;

            }


            conn.Close();

        }





        public void DataToExcel(DataGridView m_DataView)

        {

            SaveFileDialog kk = new SaveFileDialog();

            kk.Title = "保存EXECL文件";

            kk.Filter = "EXECL文件(*.xls) |*.xls |所有文件(*.*) |*.*";

            kk.FilterIndex = 1;

            if (kk.ShowDialog() == DialogResult.OK)

            {

                string FileName = kk.FileName + "";

                if (File.Exists(FileName))

                    File.Delete(FileName);

                FileStream objFileStream;

                StreamWriter objStreamWriter;

                string strLine = "";

                objFileStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);

                objStreamWriter = new StreamWriter(objFileStream, System.Text.Encoding.Unicode);

                for (int i = 0; i < m_DataView.Columns.Count; i++)

                {

                    if (m_DataView.Columns[i].Visible == true)

                    {

                        strLine = strLine + m_DataView.Columns[i].HeaderText.ToString() + Convert.ToChar(9);

                    }

                }

                objStreamWriter.WriteLine(strLine);

                strLine = "";



                for (int i = 0; i < m_DataView.Rows.Count; i++)

                {

                    if (m_DataView.Columns[0].Visible == true)

                    {

                        if (m_DataView.Rows[i].Cells[0].Value == null)

                            strLine = strLine + " " + Convert.ToChar(9);

                        else

                            strLine = strLine + m_DataView.Rows[i].Cells[0].Value.ToString() + Convert.ToChar(9);

                    }

                    for (int j = 1; j < m_DataView.Columns.Count; j++)

                    {

                        if (m_DataView.Columns[j].Visible == true)

                        {

                            if (m_DataView.Rows[i].Cells[j].Value == null)

                                strLine = strLine + " " + Convert.ToChar(9);

                            else

                            {

                                string rowstr = "";

                                rowstr = m_DataView.Rows[i].Cells[j].Value.ToString();

                                if (rowstr.IndexOf("\r\n") > 0)

                                    rowstr = rowstr.Replace("\r\n", " ");

                                if (rowstr.IndexOf("\t") > 0)

                                    rowstr = rowstr.Replace("\t", " ");

                                strLine = strLine + rowstr + Convert.ToChar(9);

                            }

                        }

                    }

                    objStreamWriter.WriteLine(strLine);

                    strLine = "";

                }

                objStreamWriter.Close();

                objFileStream.Close();

                MessageBox.Show(this, "保存EXCEL成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                

                int selected_tab_num = tabControl1.SelectedIndex;//栏目框所选的内容
                switch (selected_tab_num)
                {
                    case 0:

                        DataToExcel(dataGridView1);
                        break;
                    case 1:

                        DataToExcel(dataGridView2);
                        break;
                    case 2:

                        DataToExcel(dataGridView3);
                        break;
                    case 3:

                        DataToExcel(dataGridView4);
                        break;
                    case 4:

                        DataToExcel(dataGridView5);
                        break;

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//首先根据打开文件对话框，选择excel表格
            ofd.Filter = "表格|*.xls";//打开文件对话框筛选器
            string strPath;//文件完整的路径名
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //读取Excel数据
                    strPath = ofd.FileName;
                    string strCon = "provider=microsoft.jet.oledb.4.0;data source=" + strPath + ";extended properties=excel 8.0";//关键是红色区域
                    OleDbConnection Con = new OleDbConnection(strCon);//建立连接
                    


                    int selected_tab_num = tabControl1.SelectedIndex;//栏目框所选的内容

                    //填充到DataSet
                    if (selected_tab_num == 0)
                    {
                        string strSql = "select * from [sheet1$]";//表名的写法也应注意不同，对应的excel表为sheet1，在这里要在其后加美元符号$，并用中括号
                        OleDbCommand Cmd = new OleDbCommand(strSql, Con);//建立要执行的命令
                        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);//建立数据适配器
                        DataSet ds = new DataSet();//新建数据集
                        da.Fill(ds, "product");//把数据适配器中的数据读到数据集中的一个表中（此处表名为shyman，可以任取表名）
                                               //指定datagridview1的数据源为数据集ds的第一张表（也就是shyman表），也可以写ds.Table["shyman"]

                        //插入工程 
                        int n = ds.Tables["product"].Rows.Count;
                        string[] str = new string[7];
                        string command = "";
                        string temp = "";
                        string[] template = new string[5]{"Insert into Product(SKU, Product_description, Product_condition, Expected_Price, Selling_Price, Selling_date) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');\n",
                                                        "Insert into Supplier(Name, Country) VALUES ('{0}','{1}');\n",
                                                        "Insert into Inquiry_customer(User_ID、SKU、Times、Purchased) VALUES ('{0}'.'{1}','{2}','{3}');\n",
                                                        "Insert into Put_in(Order_Num,SKU,cost,Payment_Date,Delivery_Date,Arrival_Date,Supplier_Name) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');\n",
                                                        "Insert into Inquiry(Inquiry_Date,SKU,User_ID) VALUES ('{0}'.'{1}','{2}');\n" };

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < 7; j++) { str[j] = ""; }
                            str[0] = string.Format(ds.Tables["product"].Rows[i]["SKU"].ToString());

                            str[1] = string.Format(ds.Tables["product"].Rows[i]["产品描述"].ToString());

                            str[2] = string.Format(ds.Tables["product"].Rows[i]["产品成色"].ToString());

                            str[3] = string.Format(ds.Tables["product"].Rows[i]["预期售价"].ToString());

                            str[4] = string.Format(ds.Tables["product"].Rows[i]["实际售价"].ToString());

                            str[5] = string.Format(ds.Tables["product"].Rows[i]["销售日期"].ToString());

                            temp = "";
                            temp = string.Format(template[0], str[0], str[1], str[2], str[3], str[4], str[5]);
                            command = command + temp;

                        }


                        String ConString = "server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL";
                        MySqlConnection conn = new MySqlConnection(ConString);
                        MySqlCommand cmd = new MySqlCommand(command, conn);//构造连接字符串并切打开数据库连接    
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else if (selected_tab_num == 1)
                    {
                        string strSql = "select * from [sheet1$]";//表名的写法也应注意不同，对应的excel表为sheet1，在这里要在其后加美元符号$，并用中括号
                        OleDbCommand Cmd = new OleDbCommand(strSql, Con);//建立要执行的命令
                        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);//建立数据适配器
                        DataSet ds = new DataSet();//新建数据集
                        da.Fill(ds, "supplier");//把数据适配器中的数据读到数据集中的一个表中（此处表名为shyman，可以任取表名）
                                                //指定datagridview1的数据源为数据集ds的第一张表（也就是shyman表），也可以写ds.Table["shyman"]

                        //插入工程 
                        int n = ds.Tables["supplier"].Rows.Count;
                        string[] str = new string[7];
                        string command = "";
                        string temp = "";
                        string[] template = new string[5]{"Insert into Product(SKU, Product_description, Product_condition, Expected_Price, Selling_Price, Selling_date) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');\n",
                                                        "Insert into Supplier(Name, Country) VALUES ('{0}','{1}');\n",
                                                        "Insert into Inquiry_customer(User_ID、SKU、Times、Purchased) VALUES ('{0}'.'{1}','{2}','{3}');\n",
                                                        "Insert into Put_in(Order_Num,SKU,cost,Payment_Date,Delivery_Date,Arrival_Date,Supplier_Name) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');\n",
                                                        "Insert into Inquiry(Inquiry_Date,SKU,User_ID) VALUES ('{0}'.'{1}','{2}');\n" };

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < 7; j++) { str[j] = ""; }
                            str[0] = string.Format(ds.Tables["supplier"].Rows[i]["名称"].ToString());

                            str[1] = string.Format(ds.Tables["supplier"].Rows[i]["所在国"].ToString());


                            temp = "";
                            temp = string.Format(template[1], str[0], str[1]);
                            command = command + temp;

                        }
                        String ConString = "server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL";
                        MySqlConnection conn = new MySqlConnection(ConString);
                        MySqlCommand cmd = new MySqlCommand(command, conn);//构造连接字符串并切打开数据库连接    
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else if (selected_tab_num == 2)
                    {
                        string strSql = "select * from [sheet1$]";//表名的写法也应注意不同，对应的excel表为sheet1，在这里要在其后加美元符号$，并用中括号
                        OleDbCommand Cmd = new OleDbCommand(strSql, Con);//建立要执行的命令
                        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);//建立数据适配器
                        DataSet ds = new DataSet();//新建数据集
                        da.Fill(ds, "inquiry_customer");//把数据适配器中的数据读到数据集中的一个表中（此处表名为shyman，可以任取表名）
                                                //指定datagridview1的数据源为数据集ds的第一张表（也就是shyman表），也可以写ds.Table["shyman"]

                        //插入工程 
                        int n = ds.Tables["inquiry_customer"].Rows.Count;
                        string[] str = new string[7];
                        string command = "";
                        string temp = "";
                        string[] template = new string[5]{"Insert into Product(SKU, Product_description, Product_condition, Expected_Price, Selling_Price, Selling_date) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');\n",
                                                        "Insert into Supplier(Name, Country) VALUES ('{0}','{1}');\n",
                                                        "Insert into Inquiry_customer(User_ID,SKU,Times,Purchased) VALUES ('{0}','{1}','{2}','{3}');\n",
                                                        "Insert into Put_in(Order_Num,SKU,cost,Payment_Date,Delivery_Date,Arrival_Date,Supplier_Name) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');\n",
                                                        "Insert into Inquiry(Inquiry_Date,SKU,User_ID) VALUES ('{0}'.'{1}','{2}');\n" };

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < 7; j++) { str[j] = ""; }
                            str[0] = string.Format(ds.Tables["inquiry_customer"].Rows[i]["用户ID"].ToString());

                            str[1] = string.Format(ds.Tables["inquiry_customer"].Rows[i]["所咨询产品的SKU"].ToString());

                            str[2] = string.Format(ds.Tables["inquiry_customer"].Rows[i]["次数"].ToString());

                            str[3] = string.Format(ds.Tables["inquiry_customer"].Rows[i]["是否购买该SKU"].ToString());

                            if (str[3] == "True") { str[3] = "1"; }
                            else { str[3] = "0"; }


                            temp = "";
                            temp = string.Format(template[2], str[0], str[1], str[2], str[3]);
                            command = command + temp;

                        }


                        String ConString = "server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL";
                        MySqlConnection conn = new MySqlConnection(ConString);
                        MySqlCommand cmd = new MySqlCommand(command, conn);//构造连接字符串并切打开数据库连接    
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    else if (selected_tab_num == 3)
                    {
                        string strSql = "select * from [sheet1$]";//表名的写法也应注意不同，对应的excel表为sheet1，在这里要在其后加美元符号$，并用中括号
                        OleDbCommand Cmd = new OleDbCommand(strSql, Con);//建立要执行的命令
                        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);//建立数据适配器
                        DataSet ds = new DataSet();//新建数据集
                        da.Fill(ds, "Put_in");//把数据适配器中的数据读到数据集中的一个表中（此处表名为shyman，可以任取表名）
                                                        //指定datagridview1的数据源为数据集ds的第一张表（也就是shyman表），也可以写ds.Table["shyman"]

                        //插入工程 
                        int n = ds.Tables["Put_in"].Rows.Count;
                        string[] str = new string[7];
                        string command = "";
                        string temp = "";
                        string[] template = new string[5]{"Insert into Product(SKU, Product_description, Product_condition, Expected_Price, Selling_Price, Selling_date) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');\n",
                                                        "Insert into Supplier(Name, Country) VALUES ('{0}','{1}');\n",
                                                        "Insert into Inquiry_customer(User_ID、SKU、Times、Purchased) VALUES ('{0}'.'{1}','{2}','{3}');\n",
                                                        "Insert into Put_in(Order_Num,SKU,cost,Payment_Date,Delivery_Date,Arrival_Date,Supplier_Name) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');\n",
                                                        "Insert into Inquiry(Inquiry_Date,SKU,User_ID) VALUES ('{0}'.'{1}','{2}');\n" };

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < 7; j++) { str[j] = ""; }
                            str[0] = string.Format(ds.Tables["Put_in"].Rows[i]["订单号"].ToString());

                            str[1] = string.Format(ds.Tables["Put_in"].Rows[i]["SKU"].ToString());

                            str[2] = string.Format(ds.Tables["Put_in"].Rows[i]["成本"].ToString());

                            str[3] = string.Format(ds.Tables["Put_in"].Rows[i]["支付日期"].ToString());

                            str[4] = string.Format(ds.Tables["Put_in"].Rows[i]["寄出日期"].ToString());

                            str[5] = string.Format(ds.Tables["Put_in"].Rows[i]["到达日期"].ToString());

                            str[6] = string.Format(ds.Tables["Put_in"].Rows[i]["供应商名称"].ToString());


                            temp = "";
                            temp = string.Format(template[3], str[0], str[1], str[2], str[3], str[4], str[5],str[6]);
                            command = command + temp;

                        }


                        String ConString = "server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL";
                        MySqlConnection conn = new MySqlConnection(ConString);
                        MySqlCommand cmd = new MySqlCommand(command, conn);//构造连接字符串并切打开数据库连接    
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    else if (selected_tab_num == 4)
                    {
                        string strSql = "select * from [sheet1$]";//表名的写法也应注意不同，对应的excel表为sheet1，在这里要在其后加美元符号$，并用中括号
                        OleDbCommand Cmd = new OleDbCommand(strSql, Con);//建立要执行的命令
                        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);//建立数据适配器
                        DataSet ds = new DataSet();//新建数据集
                        da.Fill(ds, "Inquiry");//把数据适配器中的数据读到数据集中的一个表中（此处表名为shyman，可以任取表名）
                                                        //指定datagridview1的数据源为数据集ds的第一张表（也就是shyman表），也可以写ds.Table["shyman"]

                        //插入工程 
                        int n = ds.Tables["Inquiry"].Rows.Count;
                        string[] str = new string[7];
                        string command = "";
                        string temp = "";
                        string[] template = new string[5]{"Insert into Product(SKU, Product_description, Product_condition, Expected_Price, Selling_Price, Selling_date) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');\n",
                                                        "Insert into Supplier(Name, Country) VALUES ('{0}','{1}');\n",
                                                        "Insert into Inquiry_customer(User_ID、SKU、Times、Purchased) VALUES ('{0}'.'{1}','{2}','{3}');\n",
                                                        "Insert into Put_in(Order_Num,SKU,cost,Payment_Date,Delivery_Date,Arrival_Date,Supplier_Name) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');\n",
                                                        "Insert into Inquiry(Inquiry_Date,SKU,User_ID) VALUES ('{0}','{1}','{2}');\n" };

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < 7; j++) { str[j] = ""; }
                            str[0] = string.Format(ds.Tables["Inquiry"].Rows[i]["咨询日期"].ToString());

                            str[1] = string.Format(ds.Tables["Inquiry"].Rows[i]["所咨询产品的SKU"].ToString());

                            str[2] = string.Format(ds.Tables["Inquiry"].Rows[i]["用户ID"].ToString());



                            temp = "";
                            temp = string.Format(template[4], str[0], str[1],str[2]);
                            command = command + temp;

                        }


                        String ConString = "server=localhost;User Id=" + "root" + ";password=" + "123456" + ";Database=DRSQL";
                        MySqlConnection conn = new MySqlConnection(ConString);
                        MySqlCommand cmd = new MySqlCommand(command, conn);//构造连接字符串并切打开数据库连接    
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }





                    DGV_Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//捕捉异常
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Views View1 = new Views();
            View1.ShowDialog();
        }
    }
}


//String command3 = string.Format("call Insert_Put_in('{0}','{1}','{2}','{3}','{4}','{5}');", Order,SKU,cost,d1,d2,d3);