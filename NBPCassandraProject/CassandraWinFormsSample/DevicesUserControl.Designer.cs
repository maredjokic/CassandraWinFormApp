namespace CassandraWinFormsSample
{
    partial class DevicesUserControl
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
            this.btnShowFurniture = new System.Windows.Forms.Button();
            this.dgvDevices = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addNewDevice = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.tbxPurpose = new System.Windows.Forms.TextBox();
            this.tbxPurchasedDate = new System.Windows.Forms.TextBox();
            this.tbxOfficeID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMaterial = new System.Windows.Forms.TextBox();
            this.tbxAccessories = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxDeviceID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDeleteDevice = new System.Windows.Forms.TextBox();
            this.btnDeleteDevice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowFurniture
            // 
            this.btnShowFurniture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowFurniture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFurniture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowFurniture.Location = new System.Drawing.Point(189, 19);
            this.btnShowFurniture.Name = "btnShowFurniture";
            this.btnShowFurniture.Size = new System.Drawing.Size(98, 30);
            this.btnShowFurniture.TabIndex = 14;
            this.btnShowFurniture.Text = "Show devices";
            this.btnShowFurniture.UseVisualStyleBackColor = true;
            this.btnShowFurniture.Click += new System.EventHandler(this.btnShowFurniture_Click);
            // 
            // dgvDevices
            // 
            this.dgvDevices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDevices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevices.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevices.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDevices.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDevices.Location = new System.Drawing.Point(18, 66);
            this.dgvDevices.Name = "dgvDevices";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevices.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevices.Size = new System.Drawing.Size(543, 207);
            this.dgvDevices.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addNewDevice);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbxType);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tbxSize);
            this.panel1.Controls.Add(this.tbxPurpose);
            this.panel1.Controls.Add(this.tbxPurchasedDate);
            this.panel1.Controls.Add(this.tbxOfficeID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxNumber);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxMaterial);
            this.panel1.Controls.Add(this.tbxAccessories);
            this.panel1.Controls.Add(this.tbxName);
            this.panel1.Controls.Add(this.tbxDeviceID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(18, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 260);
            this.panel1.TabIndex = 15;
            // 
            // addNewDevice
            // 
            this.addNewDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.addNewDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewDevice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addNewDevice.Location = new System.Drawing.Point(206, 218);
            this.addNewDevice.Name = "addNewDevice";
            this.addNewDevice.Size = new System.Drawing.Size(122, 30);
            this.addNewDevice.TabIndex = 10;
            this.addNewDevice.Text = "Add new device";
            this.addNewDevice.UseVisualStyleBackColor = true;
            this.addNewDevice.Click += new System.EventHandler(this.addNewDevice_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Type";
            // 
            // tbxType
            // 
            this.tbxType.BackColor = System.Drawing.SystemColors.Control;
            this.tbxType.Location = new System.Drawing.Point(296, 192);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(219, 20);
            this.tbxType.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Size";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Purpose";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Purchased date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(296, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Office ID";
            // 
            // tbxSize
            // 
            this.tbxSize.BackColor = System.Drawing.SystemColors.Control;
            this.tbxSize.Location = new System.Drawing.Point(296, 152);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(219, 20);
            this.tbxSize.TabIndex = 29;
            // 
            // tbxPurpose
            // 
            this.tbxPurpose.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPurpose.Location = new System.Drawing.Point(296, 113);
            this.tbxPurpose.Name = "tbxPurpose";
            this.tbxPurpose.Size = new System.Drawing.Size(219, 20);
            this.tbxPurpose.TabIndex = 28;
            // 
            // tbxPurchasedDate
            // 
            this.tbxPurchasedDate.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPurchasedDate.Location = new System.Drawing.Point(296, 74);
            this.tbxPurchasedDate.Name = "tbxPurchasedDate";
            this.tbxPurchasedDate.Size = new System.Drawing.Size(219, 20);
            this.tbxPurchasedDate.TabIndex = 27;
            // 
            // tbxOfficeID
            // 
            this.tbxOfficeID.BackColor = System.Drawing.SystemColors.Control;
            this.tbxOfficeID.Location = new System.Drawing.Point(296, 35);
            this.tbxOfficeID.Name = "tbxOfficeID";
            this.tbxOfficeID.Size = new System.Drawing.Size(219, 20);
            this.tbxOfficeID.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Number";
            // 
            // tbxNumber
            // 
            this.tbxNumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbxNumber.Location = new System.Drawing.Point(33, 189);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(219, 20);
            this.tbxNumber.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Accessories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Device ID/Serial number";
            // 
            // tbxMaterial
            // 
            this.tbxMaterial.BackColor = System.Drawing.SystemColors.Control;
            this.tbxMaterial.Location = new System.Drawing.Point(33, 152);
            this.tbxMaterial.Name = "tbxMaterial";
            this.tbxMaterial.Size = new System.Drawing.Size(219, 20);
            this.tbxMaterial.TabIndex = 19;
            // 
            // tbxAccessories
            // 
            this.tbxAccessories.BackColor = System.Drawing.SystemColors.Control;
            this.tbxAccessories.Location = new System.Drawing.Point(33, 113);
            this.tbxAccessories.Name = "tbxAccessories";
            this.tbxAccessories.Size = new System.Drawing.Size(219, 20);
            this.tbxAccessories.TabIndex = 18;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxName.Location = new System.Drawing.Point(33, 74);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(219, 20);
            this.tbxName.TabIndex = 17;
            // 
            // tbxDeviceID
            // 
            this.tbxDeviceID.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDeviceID.Location = new System.Drawing.Point(33, 35);
            this.tbxDeviceID.Name = "tbxDeviceID";
            this.tbxDeviceID.Size = new System.Drawing.Size(219, 20);
            this.tbxDeviceID.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add new device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID for deletion";
            // 
            // tbxDeleteDevice
            // 
            this.tbxDeleteDevice.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDeleteDevice.Location = new System.Drawing.Point(462, 19);
            this.tbxDeleteDevice.Multiline = true;
            this.tbxDeleteDevice.Name = "tbxDeleteDevice";
            this.tbxDeleteDevice.Size = new System.Drawing.Size(99, 30);
            this.tbxDeleteDevice.TabIndex = 17;
            // 
            // btnDeleteDevice
            // 
            this.btnDeleteDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDevice.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteDevice.Location = new System.Drawing.Point(348, 19);
            this.btnDeleteDevice.Name = "btnDeleteDevice";
            this.btnDeleteDevice.Size = new System.Drawing.Size(98, 30);
            this.btnDeleteDevice.TabIndex = 16;
            this.btnDeleteDevice.Text = "Delete device";
            this.btnDeleteDevice.UseVisualStyleBackColor = true;
            this.btnDeleteDevice.Click += new System.EventHandler(this.btnDeleteDevice_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::CassandraWinFormsSample.Properties.Resources.device;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage devices";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DevicesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDeleteDevice);
            this.Controls.Add(this.btnDeleteDevice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowFurniture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDevices);
            this.Name = "DevicesUserControl";
            this.Size = new System.Drawing.Size(571, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowFurniture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDevices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addNewDevice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.TextBox tbxPurpose;
        private System.Windows.Forms.TextBox tbxPurchasedDate;
        private System.Windows.Forms.TextBox tbxOfficeID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMaterial;
        private System.Windows.Forms.TextBox tbxAccessories;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxDeviceID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDeleteDevice;
        private System.Windows.Forms.Button btnDeleteDevice;
    }
}
