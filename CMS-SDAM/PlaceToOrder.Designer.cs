namespace CMS_SDAM
{
    partial class PlaceToOrder
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
            btnOrderClear = new Button();
            btnConfirmOrder = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCarId = new TextBox();
            txtDriverID = new TextBox();
            txtPickupLocation = new TextBox();
            txtDestination = new TextBox();
            datePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnOrderClear
            // 
            btnOrderClear.Location = new Point(857, 396);
            btnOrderClear.Name = "btnOrderClear";
            btnOrderClear.Size = new Size(94, 29);
            btnOrderClear.TabIndex = 10;
            btnOrderClear.Text = "Clear";
            btnOrderClear.UseVisualStyleBackColor = true;
            btnOrderClear.Click += btnOrderClear_Click;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Location = new Point(640, 390);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(113, 35);
            btnConfirmOrder.TabIndex = 9;
            btnConfirmOrder.Text = "Confirm Order";
            btnConfirmOrder.UseVisualStyleBackColor = true;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(521, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(677, 269);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 29);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 7;
            label1.Text = "Place to Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 81);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 11;
            label2.Text = "Car ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 258);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 12;
            label3.Text = "Pickup Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 194);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 13;
            label4.Text = "Order Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 136);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 14;
            label5.Text = "Driver ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 320);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 15;
            label6.Text = "Destination";
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(241, 81);
            txtCarId.Name = "txtCarId";
            txtCarId.ReadOnly = true;
            txtCarId.Size = new Size(125, 27);
            txtCarId.TabIndex = 16;
            // 
            // txtDriverID
            // 
            txtDriverID.Location = new Point(241, 136);
            txtDriverID.Name = "txtDriverID";
            txtDriverID.ReadOnly = true;
            txtDriverID.Size = new Size(125, 27);
            txtDriverID.TabIndex = 17;
            // 
            // txtPickupLocation
            // 
            txtPickupLocation.Location = new Point(241, 251);
            txtPickupLocation.Name = "txtPickupLocation";
            txtPickupLocation.Size = new Size(125, 27);
            txtPickupLocation.TabIndex = 19;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(241, 323);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(125, 27);
            txtDestination.TabIndex = 20;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(241, 194);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(241, 27);
            datePicker.TabIndex = 21;
            // 
            // PlaceToOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 450);
            Controls.Add(datePicker);
            Controls.Add(txtDestination);
            Controls.Add(txtPickupLocation);
            Controls.Add(txtDriverID);
            Controls.Add(txtCarId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnOrderClear);
            Controls.Add(btnConfirmOrder);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "PlaceToOrder";
            Text = "PlaceToOrder";
            Load += PlaceToOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrderClear;
        private Button btnConfirmOrder;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCarId;
        private TextBox txtDriverID;
        private TextBox txtPickupLocation;
        private TextBox txtDestination;
        private DateTimePicker datePicker;
    }
}