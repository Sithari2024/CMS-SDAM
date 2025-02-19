namespace CMS_SDAM
{
    partial class EditProfile
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
            txtContactNo = new TextBox();
            txtId = new TextBox();
            txtUserName = new TextBox();
            txtIdentity = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(394, 350);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(125, 27);
            txtContactNo.TabIndex = 24;
            // 
            // txtId
            // 
            txtId.Location = new Point(394, 73);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 23;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(394, 120);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 22;
            // 
            // txtIdentity
            // 
            txtIdentity.Location = new Point(394, 177);
            txtIdentity.Name = "txtIdentity";
            txtIdentity.ReadOnly = true;
            txtIdentity.Size = new Size(125, 27);
            txtIdentity.TabIndex = 21;
            // 
            // txtName
            // 
            txtName.Location = new Point(394, 223);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 357);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 19;
            label6.Text = "Contact Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 280);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 18;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 223);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 17;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 177);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 16;
            label3.Text = "Identity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 120);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 15;
            label2.Text = "UserName";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(394, 277);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 73);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 13;
            label1.Text = "ID";
            // 
            // button1
            // 
            button1.Location = new Point(348, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 25;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtContactNo);
            Controls.Add(txtId);
            Controls.Add(txtUserName);
            Controls.Add(txtIdentity);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Name = "EditProfile";
            Text = "EditProfile";
            Load += EditProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContactNo;
        private TextBox txtId;
        private TextBox txtUserName;
        private TextBox txtIdentity;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private Button button1;
    }
}