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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)lastPlatePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cameraPictureBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // plateSerialsListBox
            // 
            plateSerialsListBox.BorderStyle = BorderStyle.FixedSingle;
            plateSerialsListBox.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            plateSerialsListBox.FormattingEnabled = true;
            plateSerialsListBox.ItemHeight = 22;
            plateSerialsListBox.Location = new Point(934, 80);
            plateSerialsListBox.Name = "plateSerialsListBox";
            plateSerialsListBox.Size = new Size(271, 398);
            plateSerialsListBox.TabIndex = 0;
            // 
            // serialLast2Digit
            // 
            serialLast2Digit.AutoSize = true;
            serialLast2Digit.BackColor = Color.White;
            serialLast2Digit.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            serialLast2Digit.Location = new Point(599, 629);
            serialLast2Digit.Name = "serialLast2Digit";
            serialLast2Digit.Size = new Size(0, 22);
            serialLast2Digit.TabIndex = 8;
            serialLast2Digit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // serialSecond3Digit
            // 
            serialSecond3Digit.AutoSize = true;
            serialSecond3Digit.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            serialSecond3Digit.Location = new Point(565, 629);
            serialSecond3Digit.Name = "serialSecond3Digit";
            serialSecond3Digit.Size = new Size(0, 22);
            serialSecond3Digit.TabIndex = 7;
            serialSecond3Digit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastPlatePictureBox
            // 
            lastPlatePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            lastPlatePictureBox.Location = new Point(750, 518);
            lastPlatePictureBox.Name = "lastPlatePictureBox";
            lastPlatePictureBox.Size = new Size(464, 175);
            lastPlatePictureBox.TabIndex = 0;
            lastPlatePictureBox.TabStop = false;
            // 
            // serialLetter
            // 
            serialLetter.AutoSize = true;
            serialLetter.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            serialLetter.Location = new Point(529, 629);
            serialLetter.Name = "serialLetter";
            serialLetter.Size = new Size(0, 22);
            serialLetter.TabIndex = 6;
            serialLetter.TextAlign = ContentAlignment.MiddleCenter;
            serialLetter.Click += label2_Click;
            // 
            // serialFirst2Digit
            // 
            serialFirst2Digit.AutoSize = true;
            serialFirst2Digit.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            serialFirst2Digit.Location = new Point(493, 629);
            serialFirst2Digit.Name = "serialFirst2Digit";
            serialFirst2Digit.Size = new Size(0, 22);
            serialFirst2Digit.TabIndex = 5;
            serialFirst2Digit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // insertTimeLabel
            // 
            insertTimeLabel.AutoSize = true;
            insertTimeLabel.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            insertTimeLabel.Location = new Point(529, 596);
            insertTimeLabel.Name = "insertTimeLabel";
            insertTimeLabel.Size = new Size(0, 22);
            insertTimeLabel.TabIndex = 4;
            // 
            // insertDateTimeLabel
            // 
            insertDateTimeLabel.AutoSize = true;
            insertDateTimeLabel.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            insertDateTimeLabel.Location = new Point(529, 566);
            insertDateTimeLabel.Name = "insertDateTimeLabel";
            insertDateTimeLabel.Size = new Size(0, 22);
            insertDateTimeLabel.TabIndex = 2;
            // 
            // plateSerialLable
            // 
            plateSerialLable.AutoSize = true;
            plateSerialLable.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            plateSerialLable.Location = new Point(639, 629);
            plateSerialLable.Name = "plateSerialLable";
            plateSerialLable.Size = new Size(92, 22);
            plateSerialLable.TabIndex = 3;
            plateSerialLable.Text = "شماره پلاک : ";
            plateSerialLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(670, 596);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(62, 22);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "ساعت : ";
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeLabel.Location = new Point(680, 566);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(55, 22);
            dateTimeLabel.TabIndex = 1;
            dateTimeLabel.Text = "تاریخ : ";
            dateTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cameraPictureBox
            // 
            cameraPictureBox.BackColor = Color.White;
            cameraPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            cameraPictureBox.Location = new Point(2, 48);
            cameraPictureBox.Name = "cameraPictureBox";
            cameraPictureBox.Size = new Size(930, 430);
            cameraPictureBox.TabIndex = 2;
            cameraPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1207, 47);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(519, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 24);
            label1.TabIndex = 9;
            label1.Text = "نرم افزار تشخیص پلاک";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(934, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 31);
            panel2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 4);
            label2.Name = "label2";
            label2.Size = new Size(140, 22);
            label2.TabIndex = 9;
            label2.Text = "لیست پلاک های اخیر";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, 480);
            panel3.Name = "panel3";
            panel3.Size = new Size(1207, 42);
            panel3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(534, 10);
            label3.Name = "label3";
            label3.Size = new Size(125, 22);
            label3.TabIndex = 9;
            label3.Text = "آخرین پلاک دریافتی";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlateSerialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1207, 692);
            Controls.Add(panel3);
            Controls.Add(cameraPictureBox);
            Controls.Add(serialLast2Digit);
            Controls.Add(panel2);
            Controls.Add(serialSecond3Digit);
            Controls.Add(panel1);
            Controls.Add(lastPlatePictureBox);
            Controls.Add(serialLetter);
            Controls.Add(serialFirst2Digit);
            Controls.Add(insertTimeLabel);
            Controls.Add(plateSerialsListBox);
            Controls.Add(insertDateTimeLabel);
            Controls.Add(dateTimeLabel);
            Controls.Add(plateSerialLable);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PlateSerialForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نمایش پلاک ها";
            Load += PlateSerialForm_Load;
            ((System.ComponentModel.ISupportInitialize)lastPlatePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cameraPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox plateSerialsListBox;
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
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
    }
}