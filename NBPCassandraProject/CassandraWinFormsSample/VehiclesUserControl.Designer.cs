namespace CassandraWinFormsSample
{
    partial class VehiclesUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnShowVehicle = new System.Windows.Forms.Button();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDeleteVehicle = new System.Windows.Forms.TextBox();
            this.btnDeleteVehicles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numNumberOfSeats = new System.Windows.Forms.NumericUpDown();
            this.tbxEnginePower = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddNewVehicle = new System.Windows.Forms.Button();
            this.tbxVehicleType = new System.Windows.Forms.TextBox();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.tbxCapacity = new System.Windows.Forms.TextBox();
            this.tbxBrandType = new System.Windows.Forms.TextBox();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.tbxVehicleID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowVehicle
            // 
            this.btnShowVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowVehicle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowVehicle.Location = new System.Drawing.Point(205, 21);
            this.btnShowVehicle.Name = "btnShowVehicle";
            this.btnShowVehicle.Size = new System.Drawing.Size(95, 30);
            this.btnShowVehicle.TabIndex = 8;
            this.btnShowVehicle.Text = "Show vehicles";
            this.btnShowVehicle.UseVisualStyleBackColor = true;
            this.btnShowVehicle.Click += new System.EventHandler(this.btnShowVehicle_Click);
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehicles.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehicles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVehicles.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVehicles.Location = new System.Drawing.Point(18, 66);
            this.dgvVehicles.Name = "dgvVehicles";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(543, 207);
            this.dgvVehicles.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID for deletion";
            // 
            // tbxDeleteVehicle
            // 
            this.tbxDeleteVehicle.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDeleteVehicle.Location = new System.Drawing.Point(462, 21);
            this.tbxDeleteVehicle.Multiline = true;
            this.tbxDeleteVehicle.Name = "tbxDeleteVehicle";
            this.tbxDeleteVehicle.Size = new System.Drawing.Size(99, 30);
            this.tbxDeleteVehicle.TabIndex = 10;
            // 
            // btnDeleteVehicles
            // 
            this.btnDeleteVehicles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVehicles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteVehicles.Location = new System.Drawing.Point(348, 21);
            this.btnDeleteVehicles.Name = "btnDeleteVehicles";
            this.btnDeleteVehicles.Size = new System.Drawing.Size(98, 30);
            this.btnDeleteVehicles.TabIndex = 9;
            this.btnDeleteVehicles.Text = "Delete vehicle";
            this.btnDeleteVehicles.UseVisualStyleBackColor = true;
            this.btnDeleteVehicles.Click += new System.EventHandler(this.btnDeleteVehicles_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numNumberOfSeats);
            this.panel1.Controls.Add(this.tbxEnginePower);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tbxYear);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAddNewVehicle);
            this.panel1.Controls.Add(this.tbxVehicleType);
            this.panel1.Controls.Add(this.tbxNumber);
            this.panel1.Controls.Add(this.tbxCapacity);
            this.panel1.Controls.Add(this.tbxBrandType);
            this.panel1.Controls.Add(this.tbxBrand);
            this.panel1.Controls.Add(this.tbxVehicleID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(18, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 241);
            this.panel1.TabIndex = 12;
            // 
            // numNumberOfSeats
            // 
            this.numNumberOfSeats.BackColor = System.Drawing.SystemColors.Control;
            this.numNumberOfSeats.Location = new System.Drawing.Point(295, 107);
            this.numNumberOfSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfSeats.Name = "numNumberOfSeats";
            this.numNumberOfSeats.Size = new System.Drawing.Size(219, 20);
            this.numNumberOfSeats.TabIndex = 23;
            this.numNumberOfSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxEnginePower
            // 
            this.tbxEnginePower.BackColor = System.Drawing.SystemColors.Control;
            this.tbxEnginePower.Location = new System.Drawing.Point(295, 26);
            this.tbxEnginePower.Name = "tbxEnginePower";
            this.tbxEnginePower.Size = new System.Drawing.Size(219, 20);
            this.tbxEnginePower.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Year";
            // 
            // tbxYear
            // 
            this.tbxYear.BackColor = System.Drawing.SystemColors.Control;
            this.tbxYear.Location = new System.Drawing.Point(25, 210);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(219, 20);
            this.tbxYear.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Vehicle type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Number of seats";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Number/Label";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Engine power";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Capacity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Brand type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Registration number/Vehicle ID";
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewVehicle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewVehicle.Location = new System.Drawing.Point(330, 182);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.Size = new System.Drawing.Size(136, 37);
            this.btnAddNewVehicle.TabIndex = 11;
            this.btnAddNewVehicle.Text = "Add new vehicle";
            this.btnAddNewVehicle.UseVisualStyleBackColor = true;
            this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
            // 
            // tbxVehicleType
            // 
            this.tbxVehicleType.BackColor = System.Drawing.SystemColors.Control;
            this.tbxVehicleType.Location = new System.Drawing.Point(295, 150);
            this.tbxVehicleType.Name = "tbxVehicleType";
            this.tbxVehicleType.Size = new System.Drawing.Size(219, 20);
            this.tbxVehicleType.TabIndex = 8;
            // 
            // tbxNumber
            // 
            this.tbxNumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbxNumber.Location = new System.Drawing.Point(295, 65);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(219, 20);
            this.tbxNumber.TabIndex = 6;
            // 
            // tbxCapacity
            // 
            this.tbxCapacity.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCapacity.Location = new System.Drawing.Point(25, 166);
            this.tbxCapacity.Name = "tbxCapacity";
            this.tbxCapacity.Size = new System.Drawing.Size(219, 20);
            this.tbxCapacity.TabIndex = 4;
            // 
            // tbxBrandType
            // 
            this.tbxBrandType.BackColor = System.Drawing.SystemColors.Control;
            this.tbxBrandType.Location = new System.Drawing.Point(25, 123);
            this.tbxBrandType.Name = "tbxBrandType";
            this.tbxBrandType.Size = new System.Drawing.Size(219, 20);
            this.tbxBrandType.TabIndex = 3;
            // 
            // tbxBrand
            // 
            this.tbxBrand.BackColor = System.Drawing.SystemColors.Control;
            this.tbxBrand.Location = new System.Drawing.Point(25, 81);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(219, 20);
            this.tbxBrand.TabIndex = 2;
            // 
            // tbxVehicleID
            // 
            this.tbxVehicleID.BackColor = System.Drawing.SystemColors.Control;
            this.tbxVehicleID.Location = new System.Drawing.Point(25, 40);
            this.tbxVehicleID.Name = "tbxVehicleID";
            this.tbxVehicleID.Size = new System.Drawing.Size(219, 20);
            this.tbxVehicleID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add new vehicle";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::CassandraWinFormsSample.Properties.Resources.vehicldfsd;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage vehicles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VehiclesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDeleteVehicle);
            this.Controls.Add(this.btnDeleteVehicles);
            this.Controls.Add(this.btnShowVehicle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVehicles);
            this.Name = "VehiclesUserControl";
            this.Size = new System.Drawing.Size(578, 532);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDeleteVehicle;
        private System.Windows.Forms.Button btnDeleteVehicles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddNewVehicle;
        private System.Windows.Forms.TextBox tbxVehicleType;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.TextBox tbxCapacity;
        private System.Windows.Forms.TextBox tbxBrandType;
        private System.Windows.Forms.TextBox tbxBrand;
        private System.Windows.Forms.TextBox tbxVehicleID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxEnginePower;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.NumericUpDown numNumberOfSeats;
    }
}
