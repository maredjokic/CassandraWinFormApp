namespace CassandraWinFormsSample
{
    partial class CompanyRecordsForm
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
            this.btnRefreshAll = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFurniture = new System.Windows.Forms.Button();
            this.btnDevices = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnComputers = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnOffices = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminUserControl = new CassandraWinFormsSample.AdminUserControl();
            this.devicesUserControl = new CassandraWinFormsSample.DevicesUserControl();
            this.furnitureUserControl = new CassandraWinFormsSample.FurnitureUserControl();
            this.contractUserControl = new CassandraWinFormsSample.ContractUserControl();
            this.vehiclesUserControl = new CassandraWinFormsSample.VehiclesUserControl();
            this.computersUserControl1 = new CassandraWinFormsSample.ComputersUserControl();
            this.workersUserControl = new CassandraWinFormsSample.WorkersUserControl();
            this.officesUserControle = new CassandraWinFormsSample.OfficesUserControle();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRefreshAll);
            this.panel1.Controls.Add(this.adminUserControl);
            this.panel1.Controls.Add(this.btnAddAdmin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.devicesUserControl);
            this.panel1.Controls.Add(this.furnitureUserControl);
            this.panel1.Controls.Add(this.contractUserControl);
            this.panel1.Controls.Add(this.vehiclesUserControl);
            this.panel1.Controls.Add(this.computersUserControl1);
            this.panel1.Controls.Add(this.workersUserControl);
            this.panel1.Controls.Add(this.officesUserControle);
            this.panel1.Controls.Add(this.btnFurniture);
            this.panel1.Controls.Add(this.btnDevices);
            this.panel1.Controls.Add(this.btnContracts);
            this.panel1.Controls.Add(this.btnVehicles);
            this.panel1.Controls.Add(this.btnComputers);
            this.panel1.Controls.Add(this.btnWorkers);
            this.panel1.Controls.Add(this.btnOffices);
            this.panel1.Location = new System.Drawing.Point(57, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 599);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRefreshAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshAll.Image = global::CassandraWinFormsSample.Properties.Resources.refreshhhh;
            this.btnRefreshAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshAll.Location = new System.Drawing.Point(0, 498);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(98, 46);
            this.btnRefreshAll.TabIndex = 33;
            this.btnRefreshAll.Text = "Refresh all";
            this.btnRefreshAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshAll.UseVisualStyleBackColor = true;
            this.btnRefreshAll.Click += new System.EventHandler(this.btnRefreshAll_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdmin.Image = global::CassandraWinFormsSample.Properties.Resources.adminadmin;
            this.btnAddAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAdmin.Location = new System.Drawing.Point(0, 446);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(98, 46);
            this.btnAddAdmin.TabIndex = 31;
            this.btnAddAdmin.Text = "Add admin";
            this.btnAddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Choose an option";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Records and archives of the company";
            // 
            // btnFurniture
            // 
            this.btnFurniture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFurniture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFurniture.Image = global::CassandraWinFormsSample.Properties.Resources.chair;
            this.btnFurniture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFurniture.Location = new System.Drawing.Point(0, 394);
            this.btnFurniture.Name = "btnFurniture";
            this.btnFurniture.Size = new System.Drawing.Size(98, 46);
            this.btnFurniture.TabIndex = 20;
            this.btnFurniture.Text = "Furniture";
            this.btnFurniture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFurniture.UseVisualStyleBackColor = true;
            this.btnFurniture.Click += new System.EventHandler(this.btnFurniture_Click);
            // 
            // btnDevices
            // 
            this.btnDevices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevices.Image = global::CassandraWinFormsSample.Properties.Resources.device;
            this.btnDevices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevices.Location = new System.Drawing.Point(0, 342);
            this.btnDevices.Name = "btnDevices";
            this.btnDevices.Size = new System.Drawing.Size(98, 46);
            this.btnDevices.TabIndex = 19;
            this.btnDevices.Text = "Devices";
            this.btnDevices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevices.UseVisualStyleBackColor = true;
            this.btnDevices.Click += new System.EventHandler(this.btnDevices_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContracts.Image = global::CassandraWinFormsSample.Properties.Resources.contractpic;
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.Location = new System.Drawing.Point(0, 290);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(98, 46);
            this.btnContracts.TabIndex = 18;
            this.btnContracts.Text = "Contracts";
            this.btnContracts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.Image = global::CassandraWinFormsSample.Properties.Resources.vehicldfsd;
            this.btnVehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicles.Location = new System.Drawing.Point(0, 238);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(98, 46);
            this.btnVehicles.TabIndex = 17;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnComputers
            // 
            this.btnComputers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnComputers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputers.Image = global::CassandraWinFormsSample.Properties.Resources.computerdsfsd;
            this.btnComputers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComputers.Location = new System.Drawing.Point(0, 186);
            this.btnComputers.Name = "btnComputers";
            this.btnComputers.Size = new System.Drawing.Size(98, 46);
            this.btnComputers.TabIndex = 16;
            this.btnComputers.Text = "Computers";
            this.btnComputers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComputers.UseVisualStyleBackColor = true;
            this.btnComputers.Click += new System.EventHandler(this.btnComputers_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkers.Image = global::CassandraWinFormsSample.Properties.Resources.Webp_net_resizeimage;
            this.btnWorkers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkers.Location = new System.Drawing.Point(0, 134);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(98, 46);
            this.btnWorkers.TabIndex = 15;
            this.btnWorkers.Text = "Workers";
            this.btnWorkers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnOffices
            // 
            this.btnOffices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOffices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOffices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffices.Image = global::CassandraWinFormsSample.Properties.Resources._12__Company_adress_5aaa1das2;
            this.btnOffices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffices.Location = new System.Drawing.Point(0, 82);
            this.btnOffices.Name = "btnOffices";
            this.btnOffices.Size = new System.Drawing.Size(98, 46);
            this.btnOffices.TabIndex = 14;
            this.btnOffices.Text = "Offices";
            this.btnOffices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOffices.UseVisualStyleBackColor = true;
            this.btnOffices.Click += new System.EventHandler(this.btnOffices_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CassandraWinFormsSample.Properties.Resources.black_close_icon_3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(702, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // adminUserControl
            // 
            this.adminUserControl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adminUserControl.Location = new System.Drawing.Point(121, 41);
            this.adminUserControl.Name = "adminUserControl";
            this.adminUserControl.Size = new System.Drawing.Size(578, 532);
            this.adminUserControl.TabIndex = 32;
            // 
            // devicesUserControl
            // 
            this.devicesUserControl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.devicesUserControl.Location = new System.Drawing.Point(121, 41);
            this.devicesUserControl.Name = "devicesUserControl";
            this.devicesUserControl.Size = new System.Drawing.Size(578, 532);
            this.devicesUserControl.TabIndex = 27;
            // 
            // furnitureUserControl
            // 
            this.furnitureUserControl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.furnitureUserControl.Location = new System.Drawing.Point(121, 41);
            this.furnitureUserControl.Name = "furnitureUserControl";
            this.furnitureUserControl.Size = new System.Drawing.Size(578, 532);
            this.furnitureUserControl.TabIndex = 26;
            // 
            // contractUserControl
            // 
            this.contractUserControl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.contractUserControl.Location = new System.Drawing.Point(121, 41);
            this.contractUserControl.Name = "contractUserControl";
            this.contractUserControl.Size = new System.Drawing.Size(578, 532);
            this.contractUserControl.TabIndex = 25;
            // 
            // vehiclesUserControl
            // 
            this.vehiclesUserControl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.vehiclesUserControl.Location = new System.Drawing.Point(121, 41);
            this.vehiclesUserControl.Name = "vehiclesUserControl";
            this.vehiclesUserControl.Size = new System.Drawing.Size(578, 532);
            this.vehiclesUserControl.TabIndex = 24;
            // 
            // computersUserControl1
            // 
            this.computersUserControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.computersUserControl1.Location = new System.Drawing.Point(121, 41);
            this.computersUserControl1.Name = "computersUserControl1";
            this.computersUserControl1.Size = new System.Drawing.Size(578, 532);
            this.computersUserControl1.TabIndex = 23;
            // 
            // workersUserControl
            // 
            this.workersUserControl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.workersUserControl.Location = new System.Drawing.Point(121, 41);
            this.workersUserControl.Name = "workersUserControl";
            this.workersUserControl.Size = new System.Drawing.Size(578, 532);
            this.workersUserControl.TabIndex = 22;
            // 
            // officesUserControle
            // 
            this.officesUserControle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.officesUserControle.Location = new System.Drawing.Point(121, 41);
            this.officesUserControle.Name = "officesUserControle";
            this.officesUserControle.Size = new System.Drawing.Size(578, 532);
            this.officesUserControle.TabIndex = 21;
            // 
            // CompanyRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::CassandraWinFormsSample.Properties.Resources.wgg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 597);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompanyRecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyRecordsForm";
            this.Load += new System.EventHandler(this.CompanyRecordsForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CompanyRecordsForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CompanyRecordsForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CompanyRecordsForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFurniture;
        private System.Windows.Forms.Button btnDevices;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnComputers;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnOffices;
        private OfficesUserControle officesUserControle;
        private WorkersUserControl workersUserControl;
        private ComputersUserControl computersUserControl1;
        private VehiclesUserControl vehiclesUserControl;
        private ContractUserControl contractUserControl;
        private FurnitureUserControl furnitureUserControl;
        private DevicesUserControl devicesUserControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAdmin;
        private AdminUserControl adminUserControl;
        private System.Windows.Forms.Button btnRefreshAll;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}