namespace Gestor_de_Expedicions_Espacials
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            chkShowPassword = new CheckBox();
            tbConfirmPassword = new TextBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            btnSignUP = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelSignUp = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(823, 505);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(tbConfirmPassword);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(btnSignUP);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelSignUp);
            panel1.Location = new Point(67, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 444);
            panel1.TabIndex = 1;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(401, 224);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(134, 24);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged_1;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(265, 254);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(270, 27);
            tbConfirmPassword.TabIndex = 7;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(265, 188);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(270, 27);
            tbPassword.TabIndex = 6;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(265, 118);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(270, 27);
            tbUsername.TabIndex = 5;
            // 
            // btnSignUP
            // 
            btnSignUP.BackColor = SystemColors.HotTrack;
            btnSignUP.Font = new Font("Tw Cen MT Condensed Extra Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUP.ForeColor = SystemColors.ControlLightLight;
            btnSignUP.Location = new Point(295, 357);
            btnSignUP.Name = "btnSignUP";
            btnSignUP.Size = new Size(137, 44);
            btnSignUP.TabIndex = 4;
            btnSignUP.Text = "Sign up";
            btnSignUP.UseVisualStyleBackColor = false;
            btnSignUP.Click += btnSignUP_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 252);
            label3.Name = "label3";
            label3.Size = new Size(206, 25);
            label3.TabIndex = 3;
            label3.Text = "Repeat password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.Location = new Point(38, 186);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 2;
            label2.Text = "New password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.Location = new Point(37, 116);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 1;
            label1.Text = "New username";
            // 
            // labelSignUp
            // 
            labelSignUp.AutoSize = true;
            labelSignUp.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSignUp.ForeColor = SystemColors.HotTrack;
            labelSignUp.Location = new Point(265, 34);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(137, 34);
            labelSignUp.TabIndex = 0;
            labelSignUp.Text = "SIGN UP";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 502);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Signup";
            Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label labelSignUp;
        private Button btnSignUP;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbConfirmPassword;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private CheckBox chkShowPassword;
    }
}