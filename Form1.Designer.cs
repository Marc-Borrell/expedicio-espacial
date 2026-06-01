namespace Gestor_de_Expedicions_Espacials
{
    partial class passwTextBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passwTextBox));
            loginBtn = new Button();
            passTextBox = new TextBox();
            userTextBox = new TextBox();
            usernameLabel = new Label();
            passwLabel = new Label();
            pictureBox1 = new PictureBox();
            singupText = new Label();
            chkShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.HotTrack;
            loginBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(588, 324);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(126, 39);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(550, 222);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(211, 27);
            passTextBox.TabIndex = 1;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(550, 135);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(211, 27);
            userTextBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(452, 138);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(85, 18);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // passwLabel
            // 
            passwLabel.AutoSize = true;
            passwLabel.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwLabel.Location = new Point(452, 229);
            passwLabel.Name = "passwLabel";
            passwLabel.Size = new Size(85, 18);
            passwLabel.TabIndex = 4;
            passwLabel.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 440);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // singupText
            // 
            singupText.AutoSize = true;
            singupText.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            singupText.ForeColor = SystemColors.HotTrack;
            singupText.Location = new Point(469, 377);
            singupText.Name = "singupText";
            singupText.Size = new Size(341, 29);
            singupText.TabIndex = 6;
            singupText.Text = "Not logged yet? Sign up by clicking here";
            singupText.Click += label1_Click_2;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(627, 255);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(134, 24);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // passwTextBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 526);
            Controls.Add(chkShowPassword);
            Controls.Add(singupText);
            Controls.Add(pictureBox1);
            Controls.Add(passwLabel);
            Controls.Add(usernameLabel);
            Controls.Add(userTextBox);
            Controls.Add(passTextBox);
            Controls.Add(loginBtn);
            Name = "passwTextBox";
            Text = "Gestor d'expedicions espacials";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private TextBox passTextBox;
        private TextBox userTextBox;
        private Label usernameLabel;
        private Label passwLabel;
        private PictureBox pictureBox1;
        private Label singupText;
        private CheckBox chkShowPassword;
    }
}
