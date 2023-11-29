namespace FOREVER_FRESH
{
    partial class manage_products
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
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.idtextBox1 = new System.Windows.Forms.TextBox();
            this.archievedtextBox2 = new System.Windows.Forms.TextBox();
            this.quantitytextBox3 = new System.Windows.Forms.TextBox();
            this.reordertextBox4 = new System.Windows.Forms.TextBox();
            this.saletextBox6 = new System.Windows.Forms.TextBox();
            this.costtextBox7 = new System.Windows.Forms.TextBox();
            this.namtextBox8 = new System.Windows.Forms.TextBox();
            this.proidtextBox9 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.srchtextBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupWst7DataSet = new FOREVER_FRESH.GroupWst7DataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new FOREVER_FRESH.GroupWst7DataSetTableAdapters.ProductTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityonHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productTypeIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.quantityonHandDataGridViewTextBoxColumn,
            this.archivedDataGridViewTextBoxColumn,
            this.costPriceDataGridViewTextBoxColumn});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(12, 59);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(1267, 499);
            this.productDataGridView.TabIndex = 1;
            // 
            // idtextBox1
            // 
            this.idtextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_ID", true));
            this.idtextBox1.Location = new System.Drawing.Point(12, 580);
            this.idtextBox1.Name = "idtextBox1";
            this.idtextBox1.Size = new System.Drawing.Size(100, 22);
            this.idtextBox1.TabIndex = 2;
            // 
            // archievedtextBox2
            // 
            this.archievedtextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Archived", true));
            this.archievedtextBox2.Location = new System.Drawing.Point(1179, 580);
            this.archievedtextBox2.Name = "archievedtextBox2";
            this.archievedtextBox2.Size = new System.Drawing.Size(100, 22);
            this.archievedtextBox2.TabIndex = 3;
            // 
            // quantitytextBox3
            // 
            this.quantitytextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Quantity_on_Hand", true));
            this.quantitytextBox3.Location = new System.Drawing.Point(1060, 580);
            this.quantitytextBox3.Name = "quantitytextBox3";
            this.quantitytextBox3.Size = new System.Drawing.Size(100, 22);
            this.quantitytextBox3.TabIndex = 4;
            // 
            // reordertextBox4
            // 
            this.reordertextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Reorder_Level", true));
            this.reordertextBox4.Location = new System.Drawing.Point(939, 580);
            this.reordertextBox4.Name = "reordertextBox4";
            this.reordertextBox4.Size = new System.Drawing.Size(100, 22);
            this.reordertextBox4.TabIndex = 5;
            // 
            // saletextBox6
            // 
            this.saletextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Sale_Price", true));
            this.saletextBox6.Location = new System.Drawing.Point(600, 580);
            this.saletextBox6.Name = "saletextBox6";
            this.saletextBox6.Size = new System.Drawing.Size(111, 22);
            this.saletextBox6.TabIndex = 7;
            // 
            // costtextBox7
            // 
            this.costtextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Cost_Price", true));
            this.costtextBox7.Location = new System.Drawing.Point(494, 580);
            this.costtextBox7.Name = "costtextBox7";
            this.costtextBox7.Size = new System.Drawing.Size(100, 22);
            this.costtextBox7.TabIndex = 8;
            // 
            // namtextBox8
            // 
            this.namtextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Name", true));
            this.namtextBox8.Location = new System.Drawing.Point(292, 580);
            this.namtextBox8.Name = "namtextBox8";
            this.namtextBox8.Size = new System.Drawing.Size(179, 22);
            this.namtextBox8.TabIndex = 9;
            // 
            // proidtextBox9
            // 
            this.proidtextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Type_ID", true));
            this.proidtextBox9.Location = new System.Drawing.Point(135, 580);
            this.proidtextBox9.Name = "proidtextBox9";
            this.proidtextBox9.Size = new System.Drawing.Size(134, 22);
            this.proidtextBox9.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.richTextBox1.Location = new System.Drawing.Point(728, 580);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(176, 83);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "PRODUCT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "PRODUCT TYPE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "COST";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1080, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "QUANTITY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "SALE PRICE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(777, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "DESCRIPTION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(927, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "RE-ORDER LEVEL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1192, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "ARCHIVED";
            // 
            // srchtextBox1
            // 
            this.srchtextBox1.Location = new System.Drawing.Point(248, 31);
            this.srchtextBox1.Name = "srchtextBox1";
            this.srchtextBox1.Size = new System.Drawing.Size(223, 22);
            this.srchtextBox1.TabIndex = 21;
            this.srchtextBox1.TextChanged += new System.EventHandler(this.srchtextBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Harrington", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "SEARCH PRODUCT :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(1130, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(41, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 55);
            this.button2.TabIndex = 24;
            this.button2.Text = "ADD NEW PRODUCT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(391, 608);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 55);
            this.button3.TabIndex = 25;
            this.button3.Text = "UPDATE OLD PRODUCT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(967, 608);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 55);
            this.button4.TabIndex = 26;
            this.button4.Text = "DELETE PRODUCT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Harrington", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(540, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(419, 47);
            this.label11.TabIndex = 42;
            this.label11.Text = "MANAGE PRODUCTS";
            // 
            // groupWst7DataSet
            // 
            this.groupWst7DataSet.DataSetName = "GroupWst7DataSet";
            this.groupWst7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.groupWst7DataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productTypeIDDataGridViewTextBoxColumn
            // 
            this.productTypeIDDataGridViewTextBoxColumn.DataPropertyName = "Product_Type_ID";
            this.productTypeIDDataGridViewTextBoxColumn.HeaderText = "Product_Type_ID";
            this.productTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productTypeIDDataGridViewTextBoxColumn.Name = "productTypeIDDataGridViewTextBoxColumn";
            this.productTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "Sale_Price";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "Sale_Price";
            this.salePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.salePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "Reorder_Level";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "Reorder_Level";
            this.reorderLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            this.reorderLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.reorderLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityonHandDataGridViewTextBoxColumn
            // 
            this.quantityonHandDataGridViewTextBoxColumn.DataPropertyName = "Quantity_on_Hand";
            this.quantityonHandDataGridViewTextBoxColumn.HeaderText = "Quantity_on_Hand";
            this.quantityonHandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityonHandDataGridViewTextBoxColumn.Name = "quantityonHandDataGridViewTextBoxColumn";
            this.quantityonHandDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityonHandDataGridViewTextBoxColumn.Width = 125;
            // 
            // archivedDataGridViewTextBoxColumn
            // 
            this.archivedDataGridViewTextBoxColumn.DataPropertyName = "Archived";
            this.archivedDataGridViewTextBoxColumn.HeaderText = "Archived";
            this.archivedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.archivedDataGridViewTextBoxColumn.Name = "archivedDataGridViewTextBoxColumn";
            this.archivedDataGridViewTextBoxColumn.ReadOnly = true;
            this.archivedDataGridViewTextBoxColumn.Width = 125;
            // 
            // costPriceDataGridViewTextBoxColumn
            // 
            this.costPriceDataGridViewTextBoxColumn.DataPropertyName = "Cost_Price";
            this.costPriceDataGridViewTextBoxColumn.HeaderText = "Cost_Price";
            this.costPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costPriceDataGridViewTextBoxColumn.Name = "costPriceDataGridViewTextBoxColumn";
            this.costPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.costPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // manage_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1280, 665);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.srchtextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.proidtextBox9);
            this.Controls.Add(this.namtextBox8);
            this.Controls.Add(this.costtextBox7);
            this.Controls.Add(this.saletextBox6);
            this.Controls.Add(this.reordertextBox4);
            this.Controls.Add(this.quantitytextBox3);
            this.Controls.Add(this.archievedtextBox2);
            this.Controls.Add(this.idtextBox1);
            this.Controls.Add(this.productDataGridView);
            this.Name = "manage_products";
            this.Text = "manage_products";
            this.Load += new System.EventHandler(this.manage_products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.TextBox idtextBox1;
        private System.Windows.Forms.TextBox archievedtextBox2;
        private System.Windows.Forms.TextBox quantitytextBox3;
        private System.Windows.Forms.TextBox reordertextBox4;
        private System.Windows.Forms.TextBox saletextBox6;
        private System.Windows.Forms.TextBox costtextBox7;
        private System.Windows.Forms.TextBox namtextBox8;
        private System.Windows.Forms.TextBox proidtextBox9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox srchtextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private GroupWst7DataSet groupWst7DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private GroupWst7DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityonHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
    }
}