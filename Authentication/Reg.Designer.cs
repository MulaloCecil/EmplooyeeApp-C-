namespace Authentication
{
    partial class Reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Clear = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.ShowPass = new System.Windows.Forms.CheckBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ConfirmPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.Register);
            this.panel1.Controls.Add(this.ShowPass);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(384, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 430);
            this.panel1.TabIndex = 1;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.BackColor = System.Drawing.Color.Silver;
            this.ConfirmPassword.Location = new System.Drawing.Point(61, 235);
            this.ConfirmPassword.Multiline = true;
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(262, 39);
            this.ConfirmPassword.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm Password";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Silver;
            this.Password.Location = new System.Drawing.Point(61, 161);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(262, 39);
            this.Password.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(78, 401);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(204, 16);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an account?  Login.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(61, 356);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(262, 42);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "CLEAR";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Blue;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.SystemColors.Control;
            this.Register.Location = new System.Drawing.Point(61, 308);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(262, 42);
            this.Register.TabIndex = 6;
            this.Register.Text = "SIGNUP";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Login_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.Location = new System.Drawing.Point(198, 282);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(125, 20);
            this.ShowPass.TabIndex = 5;
            this.ShowPass.Text = "Show Password";
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Silver;
            this.Username.Location = new System.Drawing.Point(61, 87);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(262, 39);
            this.Username.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Reg";
            this.Text = "Reg";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.CheckBox ShowPass;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Label label4;
    }
}