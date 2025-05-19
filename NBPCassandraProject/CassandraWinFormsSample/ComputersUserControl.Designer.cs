namespace CassandraWinFormsSample
{
    partial class ComputersUserControl
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
            this.btnShowComputers = new System.Windows.Forms.Button();
            this.dgvComputers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDeleteComputer = new System.Windows.Forms.TextBox();
            this.btnDeleteComputer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxGraphics = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxGuaranty = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.btnAddNewComputer = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxRam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxPurchasedDate = new System.Windows.Forms.TextBox();
            this.tbxOperatingSystem = new System.Windows.Forms.TextBox();
            this.tbxOfficeID = new System.Windows.Forms.TextBox();
            this.tbxLaptopDesktop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxDisc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCPU = new System.Windows.Forms.TextBox();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.tbxComputerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowComputers
            // 
            this.btnShowComputers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowComputers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowComputers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowComputers.Location = new System.Drawing.Point(214, 19);
            this.btnShowComputers.Name = "btnShowComputers";
            this.btnShowComputers.Size = new System.Drawing.Size(108, 30);
            this.btnShowComputers.TabIndex = 5;
            this.btnShowComputers.Text = "Show computers";
            this.btnShowComputers.UseVisualStyleBackColor = true;
            this.btnShowComputers.Click += new System.EventHandler(this.btnShowComputers_Click);
            // 
            // dgvComputers
            // 
            this.dgvComputers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvComputers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComputers.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComputers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComputers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComputers.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvComputers.Location = new System.Drawing.Point(18, 66);
            this.dgvComputers.Name = "dgvComputers";
            this.dgvComputers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComputers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvComputers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComputers.Size = new System.Drawing.Size(543, 187);
            this.dgvComputers.TabIndex = 3;
            this.dgvComputers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComputers_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID for deletion";
            // 
            // tbxDeleteComputer
            // 
            this.tbxDeleteComputer.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDeleteComputer.Location = new System.Drawing.Point(462, 19);
            this.tbxDeleteComputer.Multiline = true;
            this.tbxDeleteComputer.Name = "tbxDeleteComputer";
            this.tbxDeleteComputer.Size = new System.Drawing.Size(99, 30);
            this.tbxDeleteComputer.TabIndex = 7;
            // 
            // btnDeleteComputer
            // 
            this.btnDeleteComputer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteComputer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteComputer.Location = new System.Drawing.Point(348, 19);
            this.btnDeleteComputer.Name = "btnDeleteComputer";
            this.btnDeleteComputer.Size = new System.Drawing.Size(98, 30);
            this.btnDeleteComputer.TabIndex = 6;
            this.btnDeleteComputer.Text = "Delete computer";
            this.btnDeleteComputer.UseVisualStyleBackColor = true;
            this.btnDeleteComputer.Click += new System.EventHandler(this.btnDeleteComputer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxGraphics);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.tbxGuaranty);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tbxType);
            this.panel1.Controls.Add(this.btnAddNewComputer);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbxRam);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tbxPurchasedDate);
            this.panel1.Controls.Add(this.tbxOperatingSystem);
            this.panel1.Controls.Add(this.tbxOfficeID);
            this.panel1.Controls.Add(this.tbxLaptopDesktop);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxDisc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxCPU);
            this.panel1.Controls.Add(this.tbxCode);
            this.panel1.Controls.Add(this.tbxBrand);
            this.panel1.Controls.Add(this.tbxComputerID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(18, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 285);
            this.panel1.TabIndex = 10;
            // 
            // tbxGraphics
            // 
            this.tbxGraphics.BackColor = System.Drawing.SystemColors.Control;
            this.tbxGraphics.Location = new System.Drawing.Point(30, 220);
            this.tbxGraphics.Name = "tbxGraphics";
            this.tbxGraphics.Size = new System.Drawing.Size(219, 20);
            this.tbxGraphics.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Guaranty";
            // 
            // tbxGuaranty
            // 
            this.tbxGuaranty.BackColor = System.Drawing.SystemColors.Control;
            this.tbxGuaranty.Location = new System.Drawing.Point(30, 256);
            this.tbxGuaranty.Name = "tbxGuaranty";
            this.tbxGuaranty.Size = new System.Drawing.Size(219, 20);
            this.tbxGuaranty.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(298, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Type/Purpose";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // tbxType
            // 
            this.tbxType.BackColor = System.Drawing.SystemColors.Control;
            this.tbxType.Location = new System.Drawing.Point(298, 214);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(219, 20);
            this.tbxType.TabIndex = 39;
            // 
            // btnAddNewComputer
            // 
            this.btnAddNewComputer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddNewComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewComputer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewComputer.Location = new System.Drawing.Point(342, 240);
            this.btnAddNewComputer.Name = "btnAddNewComputer";
            this.btnAddNewComputer.Size = new System.Drawing.Size(122, 30);
            this.btnAddNewComputer.TabIndex = 10;
            this.btnAddNewComputer.Text = "Add new computer";
            this.btnAddNewComputer.UseVisualStyleBackColor = true;
            this.btnAddNewComputer.Click += new System.EventHandler(this.btnAddNewComputer_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Graphics";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ram";
            // 
            // tbxRam
            // 
            this.tbxRam.BackColor = System.Drawing.SystemColors.Control;
            this.tbxRam.Location = new System.Drawing.Point(295, 175);
            this.tbxRam.Name = "tbxRam";
            this.tbxRam.Size = new System.Drawing.Size(219, 20);
            this.tbxRam.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Purchased date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Operating system";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Office ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(295, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Laptop/Desktop";
            // 
            // tbxPurchasedDate
            // 
            this.tbxPurchasedDate.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPurchasedDate.Location = new System.Drawing.Point(295, 135);
            this.tbxPurchasedDate.Name = "tbxPurchasedDate";
            this.tbxPurchasedDate.Size = new System.Drawing.Size(219, 20);
            this.tbxPurchasedDate.TabIndex = 29;
            // 
            // tbxOperatingSystem
            // 
            this.tbxOperatingSystem.BackColor = System.Drawing.SystemColors.Control;
            this.tbxOperatingSystem.Location = new System.Drawing.Point(295, 96);
            this.tbxOperatingSystem.Name = "tbxOperatingSystem";
            this.tbxOperatingSystem.Size = new System.Drawing.Size(219, 20);
            this.tbxOperatingSystem.TabIndex = 28;
            // 
            // tbxOfficeID
            // 
            this.tbxOfficeID.BackColor = System.Drawing.SystemColors.Control;
            this.tbxOfficeID.Location = new System.Drawing.Point(295, 57);
            this.tbxOfficeID.Name = "tbxOfficeID";
            this.tbxOfficeID.Size = new System.Drawing.Size(219, 20);
            this.tbxOfficeID.TabIndex = 27;
            // 
            // tbxLaptopDesktop
            // 
            this.tbxLaptopDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.tbxLaptopDesktop.Location = new System.Drawing.Point(295, 18);
            this.tbxLaptopDesktop.Name = "tbxLaptopDesktop";
            this.tbxLaptopDesktop.Size = new System.Drawing.Size(219, 20);
            this.tbxLaptopDesktop.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Disc";
            // 
            // tbxDisc
            // 
            this.tbxDisc.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDisc.Location = new System.Drawing.Point(30, 182);
            this.tbxDisc.Name = "tbxDisc";
            this.tbxDisc.Size = new System.Drawing.Size(219, 20);
            this.tbxDisc.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "CPU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Computer ID/Serial number";
            // 
            // tbxCPU
            // 
            this.tbxCPU.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCPU.Location = new System.Drawing.Point(30, 145);
            this.tbxCPU.Name = "tbxCPU";
            this.tbxCPU.Size = new System.Drawing.Size(219, 20);
            this.tbxCPU.TabIndex = 19;
            // 
            // tbxCode
            // 
            this.tbxCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCode.Location = new System.Drawing.Point(30, 106);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(219, 20);
            this.tbxCode.TabIndex = 18;
            // 
            // tbxBrand
            // 
            this.tbxBrand.BackColor = System.Drawing.SystemColors.Control;
            this.tbxBrand.Location = new System.Drawing.Point(30, 67);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(219, 20);
            this.tbxBrand.TabIndex = 17;
            // 
            // tbxComputerID
            // 
            this.tbxComputerID.BackColor = System.Drawing.SystemColors.Control;
            this.tbxComputerID.Location = new System.Drawing.Point(30, 28);
            this.tbxComputerID.Name = "tbxComputerID";
            this.tbxComputerID.Size = new System.Drawing.Size(219, 20);
            this.tbxComputerID.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add new computer";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(345, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Double click on computer in table to see and write repairs and upgrades";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::CassandraWinFormsSample.Properties.Resources.computerdsfsd;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage computers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComputersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDeleteComputer);
            this.Controls.Add(this.btnDeleteComputer);
            this.Controls.Add(this.btnShowComputers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvComputers);
            this.Name = "ComputersUserControl";
            this.Size = new System.Drawing.Size(569, 563);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowComputers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvComputers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDeleteComputer;
        private System.Windows.Forms.Button btnDeleteComputer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxGuaranty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Button btnAddNewComputer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxRam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxPurchasedDate;
        private System.Windows.Forms.TextBox tbxOperatingSystem;
        private System.Windows.Forms.TextBox tbxOfficeID;
        private System.Windows.Forms.TextBox tbxLaptopDesktop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxDisc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCPU;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.TextBox tbxBrand;
        private System.Windows.Forms.TextBox tbxComputerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxGraphics;
        private System.Windows.Forms.Label label17;
    }
}
