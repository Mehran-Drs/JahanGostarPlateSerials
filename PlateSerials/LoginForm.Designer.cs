namespace PlateSerials
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            userNameTxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            loginBtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userNameTxtBox
            // 
            userNameTxtBox.Location = new Point(50, 282);
            userNameTxtBox.Name = "userNameTxtBox";
            userNameTxtBox.Size = new Size(307, 27);
            userNameTxtBox.TabIndex = 0;
            userNameTxtBox.Text = "mohammadasheri";
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(50, 358);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '*';
            passwordTxtBox.Size = new Size(307, 27);
            passwordTxtBox.TabIndex = 1;
            passwordTxtBox.Text = "OkH9Poa2Dn8Uo";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(149, 416);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(103, 48);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "ورود";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(105, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 184);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 249);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "نام کاربری";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 326);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 5;
            label2.Text = "رمز عبور";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(402, 505);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(loginBtn);
            Controls.Add(passwordTxtBox);
            Controls.Add(userNameTxtBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTxtBox;
        private TextBox passwordTxtBox;
        private Button loginBtn;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
