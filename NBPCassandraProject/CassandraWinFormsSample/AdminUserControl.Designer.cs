namespace CassandraWinFormsSample
{
    partial class AdminUserControl
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPassword1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Username";
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxPassword.Location = new System.Drawing.Point(303, 174);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(177, 26);
            this.tbxPassword.TabIndex = 15;
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxUsername.Location = new System.Drawing.Point(303, 114);
            this.tbxUsername.Multiline = true;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(177, 26);
            this.tbxUsername.TabIndex = 14;
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAdmin.Location = new System.Drawing.Point(326, 286);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(136, 37);
            this.btnAddAdmin.TabIndex = 18;
            this.btnAddAdmin.Text = "Add new admin";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Repeat password";
            // 
            // tbxPassword1
            // 
            this.tbxPassword1.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxPassword1.Location = new System.Drawing.Point(303, 235);
            this.tbxPassword1.Multiline = true;
            this.tbxPassword1.Name = "tbxPassword1";
            this.tbxPassword1.PasswordChar = '*';
            this.tbxPassword1.Size = new System.Drawing.Size(177, 26);
            this.tbxPassword1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label2.Location = new System.Drawing.Point(94, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Add admin";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CassandraWinFormsSample.Properties.Resources.admin_1246350;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(72, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 178);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddAdmin);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbxUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbxPassword);
            this.panel2.Controls.Add(this.tbxPassword1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 532);
            this.panel2.TabIndex = 23;
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel2);
            this.Name = "AdminUserControl";
            this.Size = new System.Drawing.Size(578, 532);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPassword1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}
