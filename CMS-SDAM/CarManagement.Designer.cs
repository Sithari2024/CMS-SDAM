namespace CMS_SDAM
{
    partial class CarManagement
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtDriverId = new TextBox();
            txtCarId = new TextBox();
            txtPlateNumber = new TextBox();
            btnAddCar = new Button();
            btnRemoveCar = new Button();
            label1 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btnCancel = new Button();
            btnUpdate = new Button();
            txtModel = new TextBox();
            chkAvailable = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(438, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(786, 344);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 103);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Car ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 162);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 4;
            label3.Text = "Plate Number";
            // 
            // txtDriverId
            // 
            txtDriverId.Location = new Point(198, 208);
            txtDriverId.Name = "txtDriverId";
            txtDriverId.Size = new Size(125, 27);
            txtDriverId.TabIndex = 5;
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(198, 103);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(125, 27);
            txtCarId.TabIndex = 6;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(198, 155);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(125, 27);
            txtPlateNumber.TabIndex = 7;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(15, 351);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(94, 29);
            btnAddCar.TabIndex = 8;
            btnAddCar.Text = "ADD";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += AddCar_Click;
            // 
            // btnRemoveCar
            // 
            btnRemoveCar.Location = new Point(152, 351);
            btnRemoveCar.Name = "btnRemoveCar";
            btnRemoveCar.Size = new Size(94, 29);
            btnRemoveCar.TabIndex = 9;
            btnRemoveCar.Text = "REMOVE";
            btnRemoveCar.UseVisualStyleBackColor = true;
            btnRemoveCar.Click += RemoveCar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 215);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 10;
            label1.Text = "Driver ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(532, 27);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 11;
            label4.Text = "Car Managmen System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1245, 76);
            panel1.TabIndex = 12;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(152, 418);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(306, 351);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(198, 256);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 22;
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Location = new Point(198, 304);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(105, 24);
            chkAvailable.TabIndex = 23;
            chkAvailable.Text = "Availability";
            chkAvailable.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 308);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 24;
            label5.Text = "Availability";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 263);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 25;
            label6.Text = "Model";
            // 
            // CarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 469);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(chkAvailable);
            Controls.Add(txtModel);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnRemoveCar);
            Controls.Add(btnAddCar);
            Controls.Add(txtPlateNumber);
            Controls.Add(txtCarId);
            Controls.Add(txtDriverId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "CarManagement";
            Text = "CarManagement";
            Load += CarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox txtDriverId;
        private TextBox txtCarId;
        private TextBox txtPlateNumber;
        private Button btnAddCar;
        private Button btnRemoveCar;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private Button btnCancel;
        private Button btnUpdate;
        private TextBox txtModel;
        private CheckBox chkAvailable;
        private Label label5;
        private Label label6;
    }
}