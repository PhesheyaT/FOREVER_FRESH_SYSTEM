namespace FOREVER_FRESH
{
    partial class man_staff
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ZZ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idtextBox2 = new System.Windows.Forms.TextBox();
            this.groupWst7DataSet = new FOREVER_FRESH.GroupWst7DataSet();
            this.passtextBox3 = new System.Windows.Forms.TextBox();
            this.nametextBox4 = new System.Windows.Forms.TextBox();
            this.lnametextBox5 = new System.Windows.Forms.TextBox();
            this.emtextBox6 = new System.Windows.Forms.TextBox();
            this.phonetextBox7 = new System.Windows.Forms.TextBox();
            this.towntextBox8 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.achievetextBox9 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new FOREVER_FRESH.GroupWst7DataSetTableAdapters.EmployeeTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANAGE ALL EMPLOYEES";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(1115, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "BACK ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZZ
            // 
            this.ZZ.AutoSize = true;
            this.ZZ.Location = new System.Drawing.Point(9, 552);
            this.ZZ.Name = "ZZ";
            this.ZZ.Size = new System.Drawing.Size(85, 16);
            this.ZZ.TabIndex = 4;
            this.ZZ.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(802, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(987, 552);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Town";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // idtextBox2
            // 
            this.idtextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Employee_ID", true));
            this.idtextBox2.Location = new System.Drawing.Point(12, 571);
            this.idtextBox2.Name = "idtextBox2";
            this.idtextBox2.Size = new System.Drawing.Size(82, 22);
            this.idtextBox2.TabIndex = 15;
            // 
            // groupWst7DataSet
            // 
            this.groupWst7DataSet.DataSetName = "GroupWst7DataSet";
            this.groupWst7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passtextBox3
            // 
            this.passtextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Password", true));
            this.passtextBox3.Location = new System.Drawing.Point(951, 17);
            this.passtextBox3.Name = "passtextBox3";
            this.passtextBox3.Size = new System.Drawing.Size(71, 22);
            this.passtextBox3.TabIndex = 16;
            // 
            // nametextBox4
            // 
            this.nametextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "First_Name", true));
            this.nametextBox4.Location = new System.Drawing.Point(109, 571);
            this.nametextBox4.Name = "nametextBox4";
            this.nametextBox4.Size = new System.Drawing.Size(199, 22);
            this.nametextBox4.TabIndex = 17;
            // 
            // lnametextBox5
            // 
            this.lnametextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Last_Name", true));
            this.lnametextBox5.Location = new System.Drawing.Point(324, 571);
            this.lnametextBox5.Name = "lnametextBox5";
            this.lnametextBox5.Size = new System.Drawing.Size(171, 22);
            this.lnametextBox5.TabIndex = 18;
            // 
            // emtextBox6
            // 
            this.emtextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Email_Address", true));
            this.emtextBox6.Location = new System.Drawing.Point(531, 571);
            this.emtextBox6.Name = "emtextBox6";
            this.emtextBox6.Size = new System.Drawing.Size(201, 22);
            this.emtextBox6.TabIndex = 19;
            // 
            // phonetextBox7
            // 
            this.phonetextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone_Number", true));
            this.phonetextBox7.Location = new System.Drawing.Point(767, 571);
            this.phonetextBox7.Name = "phonetextBox7";
            this.phonetextBox7.Size = new System.Drawing.Size(153, 22);
            this.phonetextBox7.TabIndex = 20;
            this.phonetextBox7.TextChanged += new System.EventHandler(this.phonetextBox7_TextChanged);
            // 
            // towntextBox8
            // 
            this.towntextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Town", true));
            this.towntextBox8.Location = new System.Drawing.Point(969, 571);
            this.towntextBox8.Name = "towntextBox8";
            this.towntextBox8.Size = new System.Drawing.Size(211, 22);
            this.towntextBox8.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(12, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 44);
            this.button2.TabIndex = 23;
            this.button2.Text = "INSERT NEW EMPLOYEE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(436, 614);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 44);
            this.button3.TabIndex = 24;
            this.button3.Text = "UPDATE OLD EMPLOYEE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.Location = new System.Drawing.Point(894, 614);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(296, 44);
            this.button4.TabIndex = 25;
            this.button4.Text = "DELETE OLD EMPLOYEE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // achievetextBox9
            // 
            this.achievetextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Archived", true));
            this.achievetextBox9.Location = new System.Drawing.Point(1028, 17);
            this.achievetextBox9.Name = "achievetextBox9";
            this.achievetextBox9.Size = new System.Drawing.Size(63, 22);
            this.achievetextBox9.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harrington", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "SEARCH  STAFF :";
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.townDataGridViewTextBoxColumn,
            this.archivedDataGridViewCheckBoxColumn});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(12, 53);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(1186, 496);
            this.employeeDataGridView.TabIndex = 28;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.groupWst7DataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "Email_Address";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email_Address";
            this.emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // townDataGridViewTextBoxColumn
            // 
            this.townDataGridViewTextBoxColumn.DataPropertyName = "Town";
            this.townDataGridViewTextBoxColumn.HeaderText = "Town";
            this.townDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.townDataGridViewTextBoxColumn.Name = "townDataGridViewTextBoxColumn";
            this.townDataGridViewTextBoxColumn.ReadOnly = true;
            this.townDataGridViewTextBoxColumn.Width = 125;
            // 
            // archivedDataGridViewCheckBoxColumn
            // 
            this.archivedDataGridViewCheckBoxColumn.DataPropertyName = "Archived";
            this.archivedDataGridViewCheckBoxColumn.HeaderText = "Archived";
            this.archivedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.archivedDataGridViewCheckBoxColumn.Name = "archivedDataGridViewCheckBoxColumn";
            this.archivedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.archivedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // man_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1210, 664);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.achievetextBox9);
            this.Controls.Add(this.towntextBox8);
            this.Controls.Add(this.phonetextBox7);
            this.Controls.Add(this.emtextBox6);
            this.Controls.Add(this.lnametextBox5);
            this.Controls.Add(this.nametextBox4);
            this.Controls.Add(this.passtextBox3);
            this.Controls.Add(this.idtextBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZZ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "man_staff";
            this.Text = "man_staff";
            this.Load += new System.EventHandler(this.man_staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupWst7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ZZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox idtextBox2;
        private System.Windows.Forms.TextBox passtextBox3;
        private System.Windows.Forms.TextBox nametextBox4;
        private System.Windows.Forms.TextBox lnametextBox5;
        private System.Windows.Forms.TextBox emtextBox6;
        private System.Windows.Forms.TextBox phonetextBox7;
        private System.Windows.Forms.TextBox towntextBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox achievetextBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private GroupWst7DataSet groupWst7DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private GroupWst7DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn archivedDataGridViewCheckBoxColumn;
    }
}