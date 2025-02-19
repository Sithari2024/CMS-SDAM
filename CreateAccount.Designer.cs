namespace CMS_SDAM
{
    partial class CreateAccount
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
            txtName = new TextBox();
            txtContactNo = new TextBox();
            txtPass = new TextBox();
            txtUserName = new TextBox();
            txtIdentity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRegister = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(299, 61);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 31);
            txtName.TabIndex = 0;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(299, 330);
            txtContactNo.Margin = new Padding(4, 4, 4, 4);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(155, 31);
            txtContactNo.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(299, 248);
            txtPass.Margin = new Padding(4, 4, 4, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(155, 31);
            txtPass.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(299, 151);
            txtUserName.Margin = new Padding(4, 4, 4, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(155, 31);
            txtUserName.TabIndex = 3;
            // 
            // txtIdentity
            // 
            txtIdentity.Location = new Point(299, 420);
            txtIdentity.Margin = new Padding(4, 4, 4, 4);
            txtIdentity.Name = "txtIdentity";
            txtIdentity.Size = new Size(155, 31);
            txtIdentity.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 160);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 256);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 350);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 8;
            label4.Text = "Contact Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 429);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 9;
            label5.Text = "Identity";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(642, 441);
            btnRegister.Margin = new Padding(4, 4, 4, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(118, 36);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // button1
            // 
            button1.Location = new Point(822, 441);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 11;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdentity);
            Controls.Add(txtUserName);
            Controls.Add(txtPass);
            Controls.Add(txtContactNo);
            Controls.Add(txtName);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CreateAccount";
            Text = "CreateAccount";
            Load += CreateAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtContactNo;
        private TextBox txtPass;
        private TextBox txtUserName;
        private TextBox txtIdentity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRegister;
        private Button button1;
    }
}