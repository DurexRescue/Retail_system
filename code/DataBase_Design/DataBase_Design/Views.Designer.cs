namespace DataBase_Design
{
    partial class Views
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.drsqlDataSet16 = new DataBase_Design.drsqlDataSet16();
            this.onstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.on_stockTableAdapter = new DataBase_Design.drsqlDataSet16TableAdapters.on_stockTableAdapter();
            this.drsqlDataSet17 = new DataBase_Design.drsqlDataSet17();
            this.onstockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.on_stockTableAdapter1 = new DataBase_Design.drsqlDataSet17TableAdapters.on_stockTableAdapter();
            this.sKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productconditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.drsqlDataSet18 = new DataBase_Design.drsqlDataSet18();
            this.soldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soldTableAdapter = new DataBase_Design.drsqlDataSet18TableAdapters.soldTableAdapter();
            this.sKUDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productconditionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsqlDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onstockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsqlDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onstockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsqlDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1781, 1423);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1458, 1135);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未售出产品";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1765, 1376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "已售出分析";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sKUDataGridViewTextBoxColumn,
            this.productdescriptionDataGridViewTextBoxColumn,
            this.productconditionDataGridViewTextBoxColumn,
            this.expectedPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.onstockBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1452, 1129);
            this.dataGridView1.TabIndex = 0;
            // 
            // drsqlDataSet16
            // 
            this.drsqlDataSet16.DataSetName = "drsqlDataSet16";
            this.drsqlDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // onstockBindingSource
            // 
            this.onstockBindingSource.DataMember = "on_stock";
            this.onstockBindingSource.DataSource = this.drsqlDataSet16;
            // 
            // on_stockTableAdapter
            // 
            this.on_stockTableAdapter.ClearBeforeFill = true;
            // 
            // drsqlDataSet17
            // 
            this.drsqlDataSet17.DataSetName = "drsqlDataSet17";
            this.drsqlDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // onstockBindingSource1
            // 
            this.onstockBindingSource1.DataMember = "on_stock";
            this.onstockBindingSource1.DataSource = this.drsqlDataSet17;
            // 
            // on_stockTableAdapter1
            // 
            this.on_stockTableAdapter1.ClearBeforeFill = true;
            // 
            // sKUDataGridViewTextBoxColumn
            // 
            this.sKUDataGridViewTextBoxColumn.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sKUDataGridViewTextBoxColumn.Name = "sKUDataGridViewTextBoxColumn";
            // 
            // productdescriptionDataGridViewTextBoxColumn
            // 
            this.productdescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product_description";
            this.productdescriptionDataGridViewTextBoxColumn.HeaderText = "产品描述";
            this.productdescriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productdescriptionDataGridViewTextBoxColumn.Name = "productdescriptionDataGridViewTextBoxColumn";
            // 
            // productconditionDataGridViewTextBoxColumn
            // 
            this.productconditionDataGridViewTextBoxColumn.DataPropertyName = "Product_condition";
            this.productconditionDataGridViewTextBoxColumn.HeaderText = "产品成色";
            this.productconditionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productconditionDataGridViewTextBoxColumn.Name = "productconditionDataGridViewTextBoxColumn";
            // 
            // expectedPriceDataGridViewTextBoxColumn
            // 
            this.expectedPriceDataGridViewTextBoxColumn.DataPropertyName = "Expected_Price";
            this.expectedPriceDataGridViewTextBoxColumn.HeaderText = "预期售价";
            this.expectedPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.expectedPriceDataGridViewTextBoxColumn.Name = "expectedPriceDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sKUDataGridViewTextBoxColumn1,
            this.productdescriptionDataGridViewTextBoxColumn1,
            this.productconditionDataGridViewTextBoxColumn1,
            this.profitDataGridViewTextBoxColumn,
            this.duringDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.soldBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 37;
            this.dataGridView2.Size = new System.Drawing.Size(1759, 1370);
            this.dataGridView2.TabIndex = 0;
            // 
            // drsqlDataSet18
            // 
            this.drsqlDataSet18.DataSetName = "drsqlDataSet18";
            this.drsqlDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soldBindingSource
            // 
            this.soldBindingSource.DataMember = "sold";
            this.soldBindingSource.DataSource = this.drsqlDataSet18;
            // 
            // soldTableAdapter
            // 
            this.soldTableAdapter.ClearBeforeFill = true;
            // 
            // sKUDataGridViewTextBoxColumn1
            // 
            this.sKUDataGridViewTextBoxColumn1.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn1.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.sKUDataGridViewTextBoxColumn1.Name = "sKUDataGridViewTextBoxColumn1";
            // 
            // productdescriptionDataGridViewTextBoxColumn1
            // 
            this.productdescriptionDataGridViewTextBoxColumn1.DataPropertyName = "Product_description";
            this.productdescriptionDataGridViewTextBoxColumn1.HeaderText = "产品描述";
            this.productdescriptionDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.productdescriptionDataGridViewTextBoxColumn1.Name = "productdescriptionDataGridViewTextBoxColumn1";
            // 
            // productconditionDataGridViewTextBoxColumn1
            // 
            this.productconditionDataGridViewTextBoxColumn1.DataPropertyName = "Product_condition";
            this.productconditionDataGridViewTextBoxColumn1.HeaderText = "产品成色";
            this.productconditionDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.productconditionDataGridViewTextBoxColumn1.Name = "productconditionDataGridViewTextBoxColumn1";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "利润";
            this.profitDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            // 
            // duringDataGridViewTextBoxColumn
            // 
            this.duringDataGridViewTextBoxColumn.DataPropertyName = "During";
            this.duringDataGridViewTextBoxColumn.HeaderText = "售卖周期";
            this.duringDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.duringDataGridViewTextBoxColumn.Name = "duringDataGridViewTextBoxColumn";
            // 
            // Views
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1456);
            this.Controls.Add(this.tabControl1);
            this.Name = "Views";
            this.Text = "Views";
            this.Load += new System.EventHandler(this.Views_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsqlDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onstockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsqlDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onstockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsqlDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private drsqlDataSet16 drsqlDataSet16;
        private System.Windows.Forms.BindingSource onstockBindingSource;
        private drsqlDataSet16TableAdapters.on_stockTableAdapter on_stockTableAdapter;
        private drsqlDataSet17 drsqlDataSet17;
        private System.Windows.Forms.BindingSource onstockBindingSource1;
        private drsqlDataSet17TableAdapters.on_stockTableAdapter on_stockTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productconditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private drsqlDataSet18 drsqlDataSet18;
        private System.Windows.Forms.BindingSource soldBindingSource;
        private drsqlDataSet18TableAdapters.soldTableAdapter soldTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productconditionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duringDataGridViewTextBoxColumn;
    }
}