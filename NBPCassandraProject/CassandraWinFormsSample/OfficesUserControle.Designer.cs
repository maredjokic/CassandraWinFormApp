namespace CassandraWinFormsSample
{
    partial class OfficesUserControle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOffices = new System.Windows.Forms.DataGridView();
            this.btnShowOffice = new System.Windows.Forms.Button();
            this.btnDeleteOffice = new System.Windows.Forms.Button();
            this.tbxDeleteOffice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddNewOffice = new System.Windows.Forms.Button();
            this.numNumberOfRooms = new System.Windows.Forms.NumericUpDown();
            this.numNumberOfWrokers = new System.Windows.Forms.NumericUpDown();
            this.tbxStreetAndNumber = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxFieldOfWork = new System.Windows.Forms.TextBox();
            this.tbxOfficeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffices)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfWrokers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOffices
            // 
            this.dgvOffices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOffices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOffices.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOffices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOffices.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOffices.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvOffices.Location = new System.Drawing.Point(18, 66);
            this.dgvOffices.Name = "dgvOffices";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOffices.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOffices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOffices.Size = new System.Drawing.Size(543, 207);
            this.dgvOffices.TabIndex = 0;
            this.dgvOffices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOffices_CellContentClick);
            this.dgvOffices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOffices_CellDoubleClick);
            // 
            // btnShowOffice
            // 
            this.btnShowOffice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOffice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowOffice.Location = new System.Drawing.Point(192, 21);
            this.btnShowOffice.Name = "btnShowOffice";
            this.btnShowOffice.Size = new System.Drawing.Size(96, 30);
            this.btnShowOffice.TabIndex = 2;
            this.btnShowOffice.Text = "Show offices";
            this.btnShowOffice.UseVisualStyleBackColor = true;
            this.btnShowOffice.Click += new System.EventHandler(this.btnShowOffice_Click);
            // 
            // btnDeleteOffice
            // 
            this.btnDeleteOffice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOffice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteOffice.Location = new System.Drawing.Point(348, 21);
            this.btnDeleteOffice.Name = "btnDeleteOffice";
            this.btnDeleteOffice.Size = new System.Drawing.Size(98, 30);
            this.btnDeleteOffice.TabIndex = 3;
            this.btnDeleteOffice.Text = "Delete office";
            this.btnDeleteOffice.UseVisualStyleBackColor = true;
            this.btnDeleteOffice.Click += new System.EventHandler(this.btnDeleteOffice_Click);
            // 
            // tbxDeleteOffice
            // 
            this.tbxDeleteOffice.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDeleteOffice.Location = new System.Drawing.Point(462, 21);
            this.tbxDeleteOffice.Multiline = true;
            this.tbxDeleteOffice.Name = "tbxDeleteOffice";
            this.tbxDeleteOffice.Size = new System.Drawing.Size(99, 30);
            this.tbxDeleteOffice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID for deletion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAddNewOffice);
            this.panel1.Controls.Add(this.numNumberOfRooms);
            this.panel1.Controls.Add(this.numNumberOfWrokers);
            this.panel1.Controls.Add(this.tbxStreetAndNumber);
            this.panel1.Controls.Add(this.tbxName);
            this.panel1.Controls.Add(this.tbxCountry);
            this.panel1.Controls.Add(this.tbxCity);
            this.panel1.Controls.Add(this.tbxFieldOfWork);
            this.panel1.Controls.Add(this.tbxOfficeId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(18, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 241);
            this.panel1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(308, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Street and number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Number of rooms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Number of workers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Field of work";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Office ID/Serial number";
            // 
            // btnAddNewOffice
            // 
            this.btnAddNewOffice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddNewOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewOffice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewOffice.Location = new System.Drawing.Point(207, 192);
            this.btnAddNewOffice.Name = "btnAddNewOffice";
            this.btnAddNewOffice.Size = new System.Drawing.Size(136, 37);
            this.btnAddNewOffice.TabIndex = 11;
            this.btnAddNewOffice.Text = "Add new office";
            this.btnAddNewOffice.UseVisualStyleBackColor = true;
            this.btnAddNewOffice.Click += new System.EventHandler(this.btnAddNewOffice_Click);
            // 
            // numNumberOfRooms
            // 
            this.numNumberOfRooms.BackColor = System.Drawing.SystemColors.Control;
            this.numNumberOfRooms.Location = new System.Drawing.Point(304, 123);
            this.numNumberOfRooms.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numNumberOfRooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfRooms.Name = "numNumberOfRooms";
            this.numNumberOfRooms.Size = new System.Drawing.Size(219, 20);
            this.numNumberOfRooms.TabIndex = 10;
            this.numNumberOfRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numNumberOfWrokers
            // 
            this.numNumberOfWrokers.BackColor = System.Drawing.SystemColors.Control;
            this.numNumberOfWrokers.Location = new System.Drawing.Point(304, 40);
            this.numNumberOfWrokers.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numNumberOfWrokers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfWrokers.Name = "numNumberOfWrokers";
            this.numNumberOfWrokers.Size = new System.Drawing.Size(219, 20);
            this.numNumberOfWrokers.TabIndex = 9;
            this.numNumberOfWrokers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxStreetAndNumber
            // 
            this.tbxStreetAndNumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbxStreetAndNumber.Location = new System.Drawing.Point(304, 166);
            this.tbxStreetAndNumber.Name = "tbxStreetAndNumber";
            this.tbxStreetAndNumber.Size = new System.Drawing.Size(219, 20);
            this.tbxStreetAndNumber.TabIndex = 8;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxName.Location = new System.Drawing.Point(304, 81);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(219, 20);
            this.tbxName.TabIndex = 6;
            // 
            // tbxCountry
            // 
            this.tbxCountry.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCountry.Location = new System.Drawing.Point(29, 166);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(219, 20);
            this.tbxCountry.TabIndex = 4;
            // 
            // tbxCity
            // 
            this.tbxCity.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCity.Location = new System.Drawing.Point(29, 123);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(219, 20);
            this.tbxCity.TabIndex = 3;
            // 
            // tbxFieldOfWork
            // 
            this.tbxFieldOfWork.BackColor = System.Drawing.SystemColors.Control;
            this.tbxFieldOfWork.Location = new System.Drawing.Point(29, 81);
            this.tbxFieldOfWork.Name = "tbxFieldOfWork";
            this.tbxFieldOfWork.Size = new System.Drawing.Size(219, 20);
            this.tbxFieldOfWork.TabIndex = 2;
            // 
            // tbxOfficeId
            // 
            this.tbxOfficeId.BackColor = System.Drawing.SystemColors.Control;
            this.tbxOfficeId.Location = new System.Drawing.Point(29, 40);
            this.tbxOfficeId.Name = "tbxOfficeId";
            this.tbxOfficeId.Size = new System.Drawing.Size(219, 20);
            this.tbxOfficeId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add new office";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(258, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Double click on office in table to see and write record";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::CassandraWinFormsSample.Properties.Resources._12__Company_adress_5aaa1das2;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage offices";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OfficesUserControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDeleteOffice);
            this.Controls.Add(this.btnDeleteOffice);
            this.Controls.Add(this.btnShowOffice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOffices);
            this.Name = "OfficesUserControle";
            this.Size = new System.Drawing.Size(578, 532);
            this.Load += new System.EventHandler(this.OfficesUserControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfWrokers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOffices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowOffice;
        private System.Windows.Forms.Button btnDeleteOffice;
        private System.Windows.Forms.TextBox tbxDeleteOffice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddNewOffice;
        private System.Windows.Forms.NumericUpDown numNumberOfRooms;
        private System.Windows.Forms.NumericUpDown numNumberOfWrokers;
        private System.Windows.Forms.TextBox tbxStreetAndNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxFieldOfWork;
        private System.Windows.Forms.TextBox tbxOfficeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
    }
}
