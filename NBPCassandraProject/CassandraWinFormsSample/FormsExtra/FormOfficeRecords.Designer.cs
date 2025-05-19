namespace CassandraWinFormsSample.FormsExtra
{
    partial class FormOfficeRecords
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbRecords = new System.Windows.Forms.RichTextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.hgj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.tbxWriteRecord = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.rtbRecords);
            this.panel1.Controls.Add(this.lblComments);
            this.panel1.Controls.Add(this.hgj);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddRecord);
            this.panel1.Controls.Add(this.tbxWriteRecord);
            this.panel1.Location = new System.Drawing.Point(103, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 490);
            this.panel1.TabIndex = 8;
            // 
            // rtbRecords
            // 
            this.rtbRecords.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rtbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rtbRecords.Location = new System.Drawing.Point(41, 35);
            this.rtbRecords.Name = "rtbRecords";
            this.rtbRecords.Size = new System.Drawing.Size(431, 331);
            this.rtbRecords.TabIndex = 11;
            this.rtbRecords.Text = "";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(28, 49);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(0, 13);
            this.lblComments.TabIndex = 10;
            // 
            // hgj
            // 
            this.hgj.AutoSize = true;
            this.hgj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.hgj.Location = new System.Drawing.Point(213, 373);
            this.hgj.Name = "hgj";
            this.hgj.Size = new System.Drawing.Size(102, 20);
            this.hgj.TabIndex = 9;
            this.hgj.Text = "Write record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(58, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Office records";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAddRecord.Location = new System.Drawing.Point(42, 396);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(105, 70);
            this.btnAddRecord.TabIndex = 7;
            this.btnAddRecord.Text = "Add new record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // tbxWriteRecord
            // 
            this.tbxWriteRecord.BackColor = System.Drawing.SystemColors.Control;
            this.tbxWriteRecord.Location = new System.Drawing.Point(172, 396);
            this.tbxWriteRecord.Multiline = true;
            this.tbxWriteRecord.Name = "tbxWriteRecord";
            this.tbxWriteRecord.Size = new System.Drawing.Size(300, 70);
            this.tbxWriteRecord.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.BackgroundImage = global::CassandraWinFormsSample.Properties.Resources._52c91a3ad83f2025fae1cc9755ebc6a2;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Location = new System.Drawing.Point(623, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 74);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormOfficeRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(743, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOfficeRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOfficeRecords";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbRecords;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label hgj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.TextBox tbxWriteRecord;
        private System.Windows.Forms.Button btnExit;
    }
}