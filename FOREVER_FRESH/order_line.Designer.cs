namespace FOREVER_FRESH
{
    partial class order_line
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
            this.order_LineDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_LineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst7DataSet = new FOREVER_FRESH.GroupWst7DataSet();
            this.ordernotextBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.totaltextBox4 = new System.Windows.Forms.TextBox();
            this.datetextBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.order_LineTableAdapter = new FOREVER_FRESH.GroupWst7DataSetTableAdapters.Order_LineTableAdapter();
            this.tableAdapterManager = new FOREVER_FRESH.GroupWst7DataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.order_LineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_LineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst7DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // order_LineDataGridView
            // 
            this.order_LineDataGridView.AutoGenerateColumns = false;
            this.order_LineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_LineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.order_LineDataGridView.DataSource = this.order_LineBindingSource;
            this.order_LineDataGridView.Location = new System.Drawing.Point(-2, 84);
            this.order_LineDataGridView.Name = "order_LineDataGridView";
            this.order_LineDataGridView.RowHeadersWidth = 51;
            this.order_LineDataGridView.RowTemplate.Height = 24;
            this.order_LineDataGridView.Size = new System.Drawing.Size(1402, 488);
            this.order_LineDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderNumber";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Order_Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Order_Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Product_Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Product_Description";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Order_Total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Order_Total";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Amount_Paid";
            this.dataGridViewTextBoxColumn8.HeaderText = "Amount_Paid";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Change";
            this.dataGridViewTextBoxColumn9.HeaderText = "Change";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // order_LineBindingSource
            // 
            this.order_LineBindingSource.DataMember = "Order_Line";
            this.order_LineBindingSource.DataSource = this.groupWst7DataSet;
            // 
            // groupWst7DataSet
            // 
            this.groupWst7DataSet.DataSetName = "GroupWst7DataSet";
            this.groupWst7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordernotextBox1
            // 
            this.ordernotextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_LineBindingSource, "OrderNumber", true));
            this.ordernotextBox1.Location = new System.Drawing.Point(-2, 598);
            this.ordernotextBox1.Name = "ordernotextBox1";
            this.ordernotextBox1.Size = new System.Drawing.Size(124, 22);
            this.ordernotextBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_LineBindingSource, "Quantity", true));
            this.textBox2.Location = new System.Drawing.Point(138, 598);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_LineBindingSource, "Amount_Paid", true));
            this.textBox3.Location = new System.Drawing.Point(1065, 598);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 22);
            this.textBox3.TabIndex = 4;
            // 
            // totaltextBox4
            // 
            this.totaltextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_LineBindingSource, "Order_Total", true));
            this.totaltextBox4.Location = new System.Drawing.Point(840, 598);
            this.totaltextBox4.Name = "totaltextBox4";
            this.totaltextBox4.Size = new System.Drawing.Size(151, 22);
            this.totaltextBox4.TabIndex = 5;
            // 
            // datetextBox5
            // 
            this.datetextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_LineBindingSource, "Order_Date", true));
            this.datetextBox5.Location = new System.Drawing.Point(299, 598);
            this.datetextBox5.Name = "datetextBox5";
            this.datetextBox5.Size = new System.Drawing.Size(136, 22);
            this.datetextBox5.TabIndex = 6;
            this.datetextBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_LineBindingSource, "Product_Name", true));
            this.textBox6.Location = new System.Drawing.Point(457, 598);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(142, 22);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_LineBindingSource, "Product_Description", true));
            this.textBox7.Location = new System.Drawing.Point(647, 598);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(137, 22);
            this.textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_LineBindingSource, "Change", true));
            this.textBox8.Location = new System.Drawing.Point(1259, 598);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(141, 22);
            this.textBox8.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(12, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(845, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "ORDER COMPLETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // order_LineTableAdapter
            // 
            this.order_LineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
        //    this.tableAdapterManager.CustTableAdapter = null;
  //          this.tableAdapterManager.Employee1TableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.Food_ReceiptTableAdapter = null;
            this.tableAdapterManager.Ingredient_ConsumptionTableAdapter = null;
            this.tableAdapterManager.IngredientTableAdapter = null;
            this.tableAdapterManager.Order_HistoryTableAdapter = null;
            this.tableAdapterManager.Order_LineTableAdapter = this.order_LineTableAdapter;
            this.tableAdapterManager.ORDERSTableAdapter = null;
            this.tableAdapterManager.Product_Invoice1TableAdapter = null;
            this.tableAdapterManager.Product_InvoiceTableAdapter = null;
            this.tableAdapterManager.Product_TypeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Sale_ItemTableAdapter = null;
            this.tableAdapterManager.Sale_type2TableAdapter = null;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.Supplier_ProductTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
    //        this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FOREVER_FRESH.GroupWst7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(951, 637);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "VIEW ALL ORDERS TO BE PROCESSED";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "SEARCH :";
            // 
            // order_line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1412, 685);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.datetextBox5);
            this.Controls.Add(this.totaltextBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ordernotextBox1);
            this.Controls.Add(this.order_LineDataGridView);
            this.Name = "order_line";
            this.Text = "order_line";
            this.Load += new System.EventHandler(this.order_line_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_LineDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_LineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst7DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupWst7DataSet groupWst7DataSet;
        private System.Windows.Forms.BindingSource order_LineBindingSource;
        private GroupWst7DataSetTableAdapters.Order_LineTableAdapter order_LineTableAdapter;
        private GroupWst7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView order_LineDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox ordernotextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox totaltextBox4;
        private System.Windows.Forms.TextBox datetextBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}