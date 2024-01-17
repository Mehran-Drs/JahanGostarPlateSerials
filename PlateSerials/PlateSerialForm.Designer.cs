namespace PlateSerials
{
    partial class PlateSerialForm
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
            plateSerialsListBox = new ListBox();
            groupBox1 = new GroupBox();
            serialLast2Digit = new Label();
            serialSecond3Digit = new Label();
            lastPlatePictureBox = new PictureBox();
            serialLetter = new Label();
            serialFirst2Digit = new Label();
            insertTimeLabel = new Label();
            insertDateTimeLabel = new Label();
            plateSerialLable = new Label();
            timeLabel = new Label();
            dateTimeLabel = new Label();
            cameraPictureBox = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lastPlatePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cameraPictureBox).BeginInit();
            SuspendLayout();
            // 
            // plateSerialsListBox
            // 
            plateSerialsListBox.Dock = DockStyle.Right;
            plateSerialsListBox.FormattingEnabled = true;
            plateSerialsListBox.ItemHeight = 20;
            plateSerialsListBox.Location = new Point(955, 0);
            plateSerialsListBox.Name = "plateSerialsListBox";
            plateSerialsListBox.Size = new Size(252, 692);
            plateSerialsListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(serialLast2Digit);
            groupBox1.Controls.Add(serialSecond3Digit);
            groupBox1.Controls.Add(lastPlatePictureBox);
            groupBox1.Controls.Add(serialLetter);
            groupBox1.Controls.Add(serialFirst2Digit);
            groupBox1.Controls.Add(insertTimeLabel);
            groupBox1.Controls.Add(insertDateTimeLabel);
            groupBox1.Controls.Add(plateSerialLable);
            groupBox1.Controls.Add(timeLabel);
            groupBox1.Controls.Add(dateTimeLabel);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 491);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(955, 201);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "نمایش آخرین پلاک دریافتی";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // serialLast2Digit
            // 
            serialLast2Digit.AutoSize = true;
            serialLast2Digit.BackColor = Color.White;
            serialLast2Digit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            serialLast2Digit.Location = new Point(325, 132);
            serialLast2Digit.Name = "serialLast2Digit";
            serialLast2Digit.Size = new Size(0, 20);
            serialLast2Digit.TabIndex = 8;
            serialLast2Digit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // serialSecond3Digit
            // 
            serialSecond3Digit.AutoSize = true;
            serialSecond3Digit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            serialSecond3Digit.Location = new Point(291, 132);
            serialSecond3Digit.Name = "serialSecond3Digit";
            serialSecond3Digit.Size = new Size(0, 20);
            serialSecond3Digit.TabIndex = 7;
            serialSecond3Digit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastPlatePictureBox
            // 
            lastPlatePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            lastPlatePictureBox.Location = new Point(479, 37);
            lastPlatePictureBox.Name = "lastPlatePictureBox";
            lastPlatePictureBox.Size = new Size(457, 152);
            lastPlatePictureBox.TabIndex = 0;
            lastPlatePictureBox.TabStop = false;
            // 
            // serialLetter
            // 
            serialLetter.AutoSize = true;
            serialLetter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            serialLetter.Location = new Point(255, 132);
            serialLetter.Name = "serialLetter";
            serialLetter.Size = new Size(0, 20);
            serialLetter.TabIndex = 6;
            serialLetter.TextAlign = ContentAlignment.MiddleCenter;
            serialLetter.Click += label2_Click;
            // 
            // serialFirst2Digit
            // 
            serialFirst2Digit.AutoSize = true;
            serialFirst2Digit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            serialFirst2Digit.Location = new Point(219, 132);
            serialFirst2Digit.Name = "serialFirst2Digit";
            serialFirst2Digit.Size = new Size(0, 20);
            serialFirst2Digit.TabIndex = 5;
            serialFirst2Digit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // insertTimeLabel
            // 
            insertTimeLabel.AutoSize = true;
            insertTimeLabel.Location = new Point(255, 99);
            insertTimeLabel.Name = "insertTimeLabel";
            insertTimeLabel.Size = new Size(0, 20);
            insertTimeLabel.TabIndex = 4;
            // 
            // insertDateTimeLabel
            // 
            insertDateTimeLabel.AutoSize = true;
            insertDateTimeLabel.Location = new Point(255, 69);
            insertDateTimeLabel.Name = "insertDateTimeLabel";
            insertDateTimeLabel.Size = new Size(0, 20);
            insertDateTimeLabel.TabIndex = 2;
            // 
            // plateSerialLable
            // 
            plateSerialLable.AutoSize = true;
            plateSerialLable.Location = new Point(365, 132);
            plateSerialLable.Name = "plateSerialLable";
            plateSerialLable.Size = new Size(91, 20);
            plateSerialLable.TabIndex = 3;
            plateSerialLable.Text = "شماره پلاک : ";
            plateSerialLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(396, 99);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(60, 20);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "ساعت : ";
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Location = new Point(406, 69);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(50, 20);
            dateTimeLabel.TabIndex = 1;
            dateTimeLabel.Text = "تاریخ : ";
            dateTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cameraPictureBox
            // 
            cameraPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            cameraPictureBox.Location = new Point(0, 0);
            cameraPictureBox.Name = "cameraPictureBox";
            cameraPictureBox.Size = new Size(955, 490);
            cameraPictureBox.TabIndex = 2;
            cameraPictureBox.TabStop = false;
            // 
            // PlateSerialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1207, 692);
            Controls.Add(cameraPictureBox);
            Controls.Add(groupBox1);
            Controls.Add(plateSerialsListBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "PlateSerialForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نمایش پلاک ها";
            Load += PlateSerialForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lastPlatePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cameraPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox plateSerialsListBox;
        private GroupBox groupBox1;
        private Label plateSerialLable;
        private Label timeLabel;
        private Label dateTimeLabel;
        private PictureBox lastPlatePictureBox;
        private Label insertTimeLabel;
        private Label insertDateTimeLabel;
        private Label serialLast2Digit;
        private Label serialSecond3Digit;
        private Label serialLetter;
        private Label serialFirst2Digit;
        private PictureBox cameraPictureBox;
    }
}