namespace CMS_SDAM
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            panel1 = new Panel();
            label1 = new Label();
            btnAvailableCars = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 86);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(319, 28);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "User Dashboard";
            // 
            // btnAvailableCars
            // 
            btnAvailableCars.BackColor = Color.Gray;
            btnAvailableCars.Location = new Point(83, 105);
            btnAvailableCars.Name = "btnAvailableCars";
            btnAvailableCars.Size = new Size(94, 49);
            btnAvailableCars.TabIndex = 1;
            btnAvailableCars.Text = "Place Order";
            btnAvailableCars.UseVisualStyleBackColor = false;
            btnAvailableCars.Click += btnAvailableCars_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Gray;
            btnLogout.Location = new Point(329, 395);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Location = new Point(634, 105);
            button1.Name = "button1";
            button1.Size = new Size(94, 49);
            button1.TabIndex = 7;
            button1.Text = "Edit Profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnAvailableCars);
            Controls.Add(panel1);
            Name = "UserDashboard";
            Text = "UserDashboard";
            Load += UserDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnAvailableCars;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private Button button1;
    }
}