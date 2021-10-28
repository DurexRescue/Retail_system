namespace DataBase_Design
{
    partial class Sell_Process
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.onstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drsqlDataSet11 = new DataBase_Design.drsqlDataSet11();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.on_stockTableAdapter = new DataBase_Design.drsqlDataSet11TableAdapters.on_stockTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.inquirycustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drsqlDataSet12 = new DataBase_Design.drsqlDataSet12();
            this.inquiry_customerTableAdapter = new DataBase_Design.drsqlDataSet12TableAdapters.inquiry_customerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.onstockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsqlDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inquirycustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsqlDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.onstockBindingSource;
            this.comboBox1.DisplayMember = "SKU";
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 41);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "SKU";
            // 
            // onstockBindingSource
            // 
            this.onstockBindingSource.DataMember = "on_stock";
            this.onstockBindingSource.DataSource = this.drsqlDataSet11;
            // 
            // drsqlDataSet11
            // 
            this.drsqlDataSet11.DataSetName = "drsqlDataSet11";
            this.drsqlDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(132, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "SKU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(86, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户ID：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(243, 363);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 35);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(54, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "售卖日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(54, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "售卖价格：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文新魏", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(135, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 70);
            this.label5.TabIndex = 9;
            this.label5.Text = "售卖登记";
            // 
            // on_stockTableAdapter
            // 
            this.on_stockTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(54, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "咨询次数：";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(243, 286);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 44);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(243, 435);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(266, 44);
            this.textBox3.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.inquirycustomerBindingSource;
            this.comboBox2.DisplayMember = "User_ID";
            this.comboBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(243, 213);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(266, 41);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "User_ID";
            // 
            // inquirycustomerBindingSource
            // 
            this.inquirycustomerBindingSource.DataMember = "inquiry_customer";
            this.inquirycustomerBindingSource.DataSource = this.drsqlDataSet12;
            // 
            // drsqlDataSet12
            // 
            this.drsqlDataSet12.DataSetName = "drsqlDataSet12";
            this.drsqlDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inquiry_customerTableAdapter
            // 
            this.inquiry_customerTableAdapter.ClearBeforeFill = true;
            // 
            // Sell_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 610);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Sell_Process";
            this.Text = "Sell_Process";
            this.Load += new System.EventHandler(this.Sell_Process_Load);
            ((System.ComponentModel.ISupportInitialize)(this.onstockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsqlDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inquirycustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drsqlDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private drsqlDataSet11 drsqlDataSet11;
        private System.Windows.Forms.BindingSource onstockBindingSource;
        private drsqlDataSet11TableAdapters.on_stockTableAdapter on_stockTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private drsqlDataSet12 drsqlDataSet12;
        private System.Windows.Forms.BindingSource inquirycustomerBindingSource;
        private drsqlDataSet12TableAdapters.inquiry_customerTableAdapter inquiry_customerTableAdapter;
    }
}