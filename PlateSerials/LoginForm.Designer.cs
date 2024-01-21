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
            userNameTxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            loginBtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userNameTxtBox
            // 
            userNameTxtBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userNameTxtBox.Location = new Point(45, 135);
            userNameTxtBox.Name = "userNameTxtBox";
            userNameTxtBox.Size = new Size(307, 32);
            userNameTxtBox.TabIndex = 0;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxtBox.Location = new Point(45, 250);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '*';
            passwordTxtBox.Size = new Size(307, 32);
            passwordTxtBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.CornflowerBlue;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(143, 352);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(103, 48);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "ورود";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.jahan_gostar;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 279);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(279, 98);
            label1.Name = "label1";
            label1.Size = new Size(73, 24);
            label1.TabIndex = 4;
            label1.Text = "نام کاربری";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(282, 213);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 5;
            label2.Text = "رمز عبور";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(396, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 453);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(139, 359);
            label4.Name = "label4";
            label4.Size = new Size(126, 28);
            label4.TabIndex = 7;
            label4.Text = "تشخیص پلاک";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label3.Location = new Point(167, 312);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 4;
            label3.Text = "نرم افزار";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(802, 453);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(passwordTxtBox);
            Controls.Add(userNameTxtBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label4;
        private Label label3;
    }
}
