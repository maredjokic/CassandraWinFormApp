namespace CassandraWinFormsSample
{
    partial class ContractUserControl
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
            this.btnShowContracts = new System.Windows.Forms.Button();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDeleteContract = new System.Windows.Forms.TextBox();
            this.btnDeleteContract = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewContract = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.tbxSubject = new System.Windows.Forms.TextBox();
            this.tbxEndTime = new System.Windows.Forms.TextBox();
            this.tbxStartTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.tbxContractID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowContracts
            // 
            this.btnShowContracts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowContracts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowContracts.Location = new System.Drawing.Point(200, 20);
            this.btnShowContracts.Name = "btnShowContracts";
            this.btnShowContracts.Size = new System.Drawing.Size(109, 30);
            this.btnShowContracts.TabIndex = 8;
            this.btnShowContracts.Text = "Show contracts";
            this.btnShowContracts.UseVisualStyleBackColor = true;
            this.btnShowContracts.Click += new System.EventHandler(this.btnShowContracts_Click);
            // 
            // dgvContracts
            // 
            this.dgvContracts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvContracts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContracts.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContracts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContracts.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvContracts.Location = new System.Drawing.Point(18, 66);
            this.dgvContracts.Name = "dgvContracts";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.Size = new System.Drawing.Size(543, 207);
            this.dgvContracts.TabIndex = 6;
            this.dgvContracts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContracts_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID for deletion";
            // 
            // tbxDeleteContract
            // 
            this.tbxDeleteContract.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDeleteContract.Location = new System.Drawing.Point(462, 20);
            this.tbxDeleteContract.Multiline = true;
            this.tbxDeleteContract.Name = "tbxDeleteContract";
            this.tbxDeleteContract.Size = new System.Drawing.Size(99, 30);
            this.tbxDeleteContract.TabIndex = 10;
            // 
            // btnDeleteContract
            // 
            this.btnDeleteContract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteContract.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteContract.Location = new System.Drawing.Point(348, 20);
            this.btnDeleteContract.Name = "btnDeleteContract";
            this.btnDeleteContract.Size = new System.Drawing.Size(98, 30);
            this.btnDeleteContract.TabIndex = 9;
            this.btnDeleteContract.Text = "Delete contract";
            this.btnDeleteContract.UseVisualStyleBackColor = true;
            this.btnDeleteContract.Click += new System.EventHandler(this.btnDeleteContract_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNewContract);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbxValue);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tbxType);
            this.panel1.Controls.Add(this.tbxSubject);
            this.panel1.Controls.Add(this.tbxEndTime);
            this.panel1.Controls.Add(this.tbxStartTime);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxDescription);
            this.panel1.Controls.Add(this.tbxCountry);
            this.panel1.Controls.Add(this.tbxCompanyName);
            this.panel1.Controls.Add(this.tbxContractID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(18, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 260);
            this.panel1.TabIndex = 12;
            // 
            // btnAddNewContract
            // 
            this.btnAddNewContract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddNewContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewContract.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewContract.Location = new System.Drawing.Point(217, 215);
            this.btnAddNewContract.Name = "btnAddNewContract";
            this.btnAddNewContract.Size = new System.Drawing.Size(122, 30);
            this.btnAddNewContract.TabIndex = 10;
            this.btnAddNewContract.Text = "Add new contract";
            this.btnAddNewContract.UseVisualStyleBackColor = true;
            this.btnAddNewContract.Click += new System.EventHandler(this.btnAddNewContract_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Value/Price";
            // 
            // tbxValue
            // 
            this.tbxValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbxValue.Location = new System.Drawing.Point(295, 189);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(219, 20);
            this.tbxValue.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Subject";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "End time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(296, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Start time";
            // 
            // tbxType
            // 
            this.tbxType.BackColor = System.Drawing.SystemColors.Control;
            this.tbxType.Location = new System.Drawing.Point(296, 152);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(219, 20);
            this.tbxType.TabIndex = 29;
            // 
            // tbxSubject
            // 
            this.tbxSubject.BackColor = System.Drawing.SystemColors.Control;
            this.tbxSubject.Location = new System.Drawing.Point(295, 113);
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.Size = new System.Drawing.Size(219, 20);
            this.tbxSubject.TabIndex = 28;
            // 
            // tbxEndTime
            // 
            this.tbxEndTime.BackColor = System.Drawing.SystemColors.Control;
            this.tbxEndTime.Location = new System.Drawing.Point(295, 74);
            this.tbxEndTime.Name = "tbxEndTime";
            this.tbxEndTime.Size = new System.Drawing.Size(219, 20);
            this.tbxEndTime.TabIndex = 27;
            // 
            // tbxStartTime
            // 
            this.tbxStartTime.BackColor = System.Drawing.SystemColors.Control;
            this.tbxStartTime.Location = new System.Drawing.Point(296, 35);
            this.tbxStartTime.Name = "tbxStartTime";
            this.tbxStartTime.Size = new System.Drawing.Size(219, 20);
            this.tbxStartTime.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxName.Location = new System.Drawing.Point(33, 189);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(219, 20);
            this.tbxName.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Company name/Government";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contract ID";
            // 
            // tbxDescription
            // 
            this.tbxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDescription.Location = new System.Drawing.Point(33, 152);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(219, 20);
            this.tbxDescription.TabIndex = 19;
            // 
            // tbxCountry
            // 
            this.tbxCountry.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCountry.Location = new System.Drawing.Point(33, 113);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(219, 20);
            this.tbxCountry.TabIndex = 18;
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCompanyName.Location = new System.Drawing.Point(33, 74);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(219, 20);
            this.tbxCompanyName.TabIndex = 17;
            // 
            // tbxContractID
            // 
            this.tbxContractID.BackColor = System.Drawing.SystemColors.Control;
            this.tbxContractID.Location = new System.Drawing.Point(33, 35);
            this.tbxContractID.Name = "tbxContractID";
            this.tbxContractID.Size = new System.Drawing.Size(219, 20);
            this.tbxContractID.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add new contract";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::CassandraWinFormsSample.Properties.Resources.contractpic;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage contracts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ContractUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDeleteContract);
            this.Controls.Add(this.btnDeleteContract);
            this.Controls.Add(this.btnShowContracts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvContracts);
            this.Name = "ContractUserControl";
            this.Size = new System.Drawing.Size(578, 549);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowContracts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDeleteContract;
        private System.Windows.Forms.Button btnDeleteContract;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNewContract;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.TextBox tbxSubject;
        private System.Windows.Forms.TextBox tbxEndTime;
        private System.Windows.Forms.TextBox tbxStartTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.TextBox tbxContractID;
        private System.Windows.Forms.Label label3;
    }
}
