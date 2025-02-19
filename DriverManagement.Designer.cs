namespace CMS_SDAM
{
    partial class DriverManagement
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
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtContactNumber = new TextBox();
            dataGridView1 = new DataGridView();
            btnAddDriver = new Button();
            BtnRemoveDriver = new Button();
            btnCancel = new Button();
            chkAvailability = new CheckBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            txtPlateNumber = new TextBox();
            txtId = new TextBox();
            btnUpdate = new Button();
            txtIdentity = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label2 = new Label();
            txtModel = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(446, 23);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "Driver Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 91);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 147);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 3;
            label4.Text = "Contact Number";
            // 
            // txtName
            // 
            txtName.Location = new Point(238, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 6;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(238, 140);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(125, 27);
            txtContactNumber.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(491, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(729, 489);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAddDriver
            // 
            btnAddDriver.Location = new Point(17, 568);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(94, 29);
            btnAddDriver.TabIndex = 10;
            btnAddDriver.Text = "ADD";
            btnAddDriver.UseVisualStyleBackColor = true;
            btnAddDriver.Click += btnAddDriver_Click;
            // 
            // BtnRemoveDriver
            // 
            BtnRemoveDriver.Location = new Point(184, 568);
            BtnRemoveDriver.Name = "BtnRemoveDriver";
            BtnRemoveDriver.Size = new Size(94, 29);
            BtnRemoveDriver.TabIndex = 11;
            BtnRemoveDriver.Text = "REMOVE";
            BtnRemoveDriver.UseVisualStyleBackColor = true;
            BtnRemoveDriver.Click += BtnRemoveDriver_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(184, 613);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkAvailability
            // 
            chkAvailability.AutoSize = true;
            chkAvailability.Location = new Point(238, 520);
            chkAvailability.Name = "chkAvailability";
            chkAvailability.Size = new Size(105, 24);
            chkAvailability.TabIndex = 15;
            chkAvailability.Text = "Availability";
            chkAvailability.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(238, 246);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 16;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(238, 193);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 17;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(238, 352);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(125, 27);
            txtPlateNumber.TabIndex = 18;
            // 
            // txtId
            // 
            txtId.Location = new Point(238, 299);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 19;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(365, 568);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtIdentity
            // 
            txtIdentity.Location = new Point(238, 406);
            txtIdentity.Name = "txtIdentity";
            txtIdentity.Size = new Size(125, 27);
            txtIdentity.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 413);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 24;
            label6.Text = "Identity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 359);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 25;
            label7.Text = "Plate Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 309);
            label8.Name = "label8";
            label8.Size = new Size(24, 20);
            label8.TabIndex = 26;
            label8.Text = "ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 249);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 27;
            label9.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 193);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 28;
            label10.Text = "Username";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 520);
            label11.Name = "label11";
            label11.Size = new Size(83, 20);
            label11.TabIndex = 29;
            label11.Text = "Availability";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 470);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 23;
            label2.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(238, 463);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 21;
            // 
            // DriverManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 652);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtIdentity);
            Controls.Add(txtModel);
            Controls.Add(btnUpdate);
            Controls.Add(txtId);
            Controls.Add(txtPlateNumber);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(chkAvailability);
            Controls.Add(btnCancel);
            Controls.Add(BtnRemoveDriver);
            Controls.Add(btnAddDriver);
            Controls.Add(dataGridView1);
            Controls.Add(txtContactNumber);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "DriverManagement";
            Text = "DriverManagement";
            Load += DriverManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtContactNumber;
        private TextBox txtAvailability;
        private DataGridView dataGridView1;
        private Button btnAddDriver;
        private Button BtnRemoveDriver;
        private Button btnCancel;
        private CheckBox chkAvailability;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtPlateNumber;
        private TextBox txtId;
        private Button btnUpdate;
        private TextBox txtIdentity;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label2;
        private TextBox txtModel;
    }
}