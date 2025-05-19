namespace CassandraWinFormsSample
{
    partial class FurnitureUserControl
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
            this.dgvFurniture = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxPurchaseDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddNewFurniture = new System.Windows.Forms.Button();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.tbxOfficeID = new System.Windows.Forms.TextBox();
            this.tbxMaterial = new System.Windows.Forms.TextBox();
            this.tbxColour = new System.Windows.Forms.TextBox();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.tbxFurnitureID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDeleteFurniture = new System.Windows.Forms.TextBox();
            this.btnDeleteFurniture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurniture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowFurniture
            // 
            this.btnShowFurniture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowFurniture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFurniture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowFurniture.Location = new System.Drawing.Point(200, 20);
            this.btnShowFurniture.Name = "btnShowFurniture";
            this.btnShowFurniture.Size = new System.Drawing.Size(114, 30);
            this.btnShowFurniture.TabIndex = 11;
            this.btnShowFurniture.Text = "Show furniture";
            this.btnShowFurniture.UseVisualStyleBackColor = true;
            this.btnShowFurniture.Click += new System.EventHandler(this.btnShowFurniture_Click);
            // 
            // dgvFurniture
            // 
            this.dgvFurniture.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFurniture.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFurniture.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFurniture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFurniture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFurniture.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFurniture.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFurniture.Location = new System.Drawing.Point(18, 66);
            this.dgvFurniture.Name = "dgvFurniture";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFurniture.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFurniture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFurniture.Size = new System.Drawing.Size(543, 207);
            this.dgvFurniture.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxPurchaseDate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAddNewFurniture);
            this.panel1.Controls.Add(this.numNumber);
            this.panel1.Controls.Add(this.tbxOfficeID);
            this.panel1.Controls.Add(this.tbxMaterial);
            this.panel1.Controls.Add(this.tbxColour);
            this.panel1.Controls.Add(this.tbxType);
            this.panel1.Controls.Add(this.tbxFurnitureID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(18, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 241);
            this.panel1.TabIndex = 12;
            // 
            // tbxPurchaseDate
            // 
            this.tbxPurchaseDate.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPurchaseDate.Location = new System.Drawing.Point(304, 137);
            this.tbxPurchaseDate.Name = "tbxPurchaseDate";
            this.tbxPurchaseDate.Size = new System.Drawing.Size(219, 20);
            this.tbxPurchaseDate.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Purchase date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Office ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Colour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Futniture ID";
            // 
            // btnAddNewFurniture
            // 
            this.btnAddNewFurniture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddNewFurniture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewFurniture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewFurniture.Location = new System.Drawing.Point(336, 171);
            this.btnAddNewFurniture.Name = "btnAddNewFurniture";
            this.btnAddNewFurniture.Size = new System.Drawing.Size(136, 37);
            this.btnAddNewFurniture.TabIndex = 11;
            this.btnAddNewFurniture.Text = "Add new furniture";
            this.btnAddNewFurniture.UseVisualStyleBackColor = true;
            this.btnAddNewFurniture.Click += new System.EventHandler(this.btnAddNewFurniture_Click);
            // 
            // numNumber
            // 
            this.numNumber.BackColor = System.Drawing.SystemColors.Control;
            this.numNumber.Location = new System.Drawing.Point(304, 54);
            this.numNumber.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(219, 20);
            this.numNumber.TabIndex = 9;
            this.numNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxOfficeID
            // 
            this.tbxOfficeID.BackColor = System.Drawing.SystemColors.Control;
            this.tbxOfficeID.Location = new System.Drawing.Point(304, 95);
            this.tbxOfficeID.Name = "tbxOfficeID";
            this.tbxOfficeID.Size = new System.Drawing.Size(219, 20);
            this.tbxOfficeID.TabIndex = 6;
            // 
            // tbxMaterial
            // 
            this.tbxMaterial.BackColor = System.Drawing.SystemColors.Control;
            this.tbxMaterial.Location = new System.Drawing.Point(29, 180);
            this.tbxMaterial.Name = "tbxMaterial";
            this.tbxMaterial.Size = new System.Drawing.Size(219, 20);
            this.tbxMaterial.TabIndex = 4;
            // 
            // tbxColour
            // 
            this.tbxColour.BackColor = System.Drawing.SystemColors.Control;
            this.tbxColour.Location = new System.Drawing.Point(29, 137);
            this.tbxColour.Name = "tbxColour";
            this.tbxColour.Size = new System.Drawing.Size(219, 20);
            this.tbxColour.TabIndex = 3;
            // 
            // tbxType
            // 
            this.tbxType.BackColor = System.Drawing.SystemColors.Control;
            this.tbxType.Location = new System.Drawing.Point(29, 95);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(219, 20);
            this.tbxType.TabIndex = 2;
            // 
            // tbxFurnitureID
            // 
            this.tbxFurnitureID.BackColor = System.Drawing.SystemColors.Control;
            this.tbxFurnitureID.Location = new System.Drawing.Point(29, 54);
            this.tbxFurnitureID.Name = "tbxFurnitureID";
            this.tbxFurnitureID.Size = new System.Drawing.Size(219, 20);
            this.tbxFurnitureID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adding new furniture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID for deletion";
            // 
            // tbxDeleteFurniture
            // 
            this.tbxDeleteFurniture.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDeleteFurniture.Location = new System.Drawing.Point(462, 20);
            this.tbxDeleteFurniture.Multiline = true;
            this.tbxDeleteFurniture.Name = "tbxDeleteFurniture";
            this.tbxDeleteFurniture.Size = new System.Drawing.Size(99, 30);
            this.tbxDeleteFurniture.TabIndex = 14;
            // 
            // btnDeleteFurniture
            // 
            this.btnDeleteFurniture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteFurniture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFurniture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteFurniture.Location = new System.Drawing.Point(348, 20);
            this.btnDeleteFurniture.Name = "btnDeleteFurniture";
            this.btnDeleteFurniture.Size = new System.Drawing.Size(98, 30);
            this.btnDeleteFurniture.TabIndex = 13;
            this.btnDeleteFurniture.Text = "Delete furniture";
            this.btnDeleteFurniture.UseVisualStyleBackColor = true;
            this.btnDeleteFurniture.Click += new System.EventHandler(this.btnDeleteFurniture_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::CassandraWinFormsSample.Properties.Resources.chair;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Manage furniture";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDeleteFurniture);
            this.Controls.Add(this.btnDeleteFurniture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowFurniture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFurniture);
            this.Name = "FurnitureUserControl";
            this.Size = new System.Drawing.Size(578, 532);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurniture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowFurniture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFurniture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddNewFurniture;
        private System.Windows.Forms.NumericUpDown numNumber;
        private System.Windows.Forms.TextBox tbxOfficeID;
        private System.Windows.Forms.TextBox tbxMaterial;
        private System.Windows.Forms.TextBox tbxColour;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.TextBox tbxFurnitureID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPurchaseDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDeleteFurniture;
        private System.Windows.Forms.Button btnDeleteFurniture;
    }
}
