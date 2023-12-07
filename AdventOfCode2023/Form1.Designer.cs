namespace AdventOfCode2023
{
    partial class Form1
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
            BtnDay1 = new Button();
            LblDay1Pt1 = new Label();
            LblDay1Pt2 = new Label();
            LblDay2Pt2 = new Label();
            LblDay2Pt1 = new Label();
            btnDay2 = new Button();
            LblDay3Pt2 = new Label();
            LblDay3Pt1 = new Label();
            BtnDay3 = new Button();
            SuspendLayout();
            // 
            // BtnDay1
            // 
            BtnDay1.Location = new Point(29, 23);
            BtnDay1.Name = "BtnDay1";
            BtnDay1.Size = new Size(75, 23);
            BtnDay1.TabIndex = 0;
            BtnDay1.Text = "Day1";
            BtnDay1.UseVisualStyleBackColor = true;
            BtnDay1.Click += BtnDay1_Click;
            // 
            // LblDay1Pt1
            // 
            LblDay1Pt1.AutoSize = true;
            LblDay1Pt1.Location = new Point(123, 27);
            LblDay1Pt1.Name = "LblDay1Pt1";
            LblDay1Pt1.Size = new Size(88, 15);
            LblDay1Pt1.TabIndex = 1;
            LblDay1Pt1.Text = "Day 1 pt1 result";
            // 
            // LblDay1Pt2
            // 
            LblDay1Pt2.AutoSize = true;
            LblDay1Pt2.Location = new Point(271, 27);
            LblDay1Pt2.Name = "LblDay1Pt2";
            LblDay1Pt2.Size = new Size(88, 15);
            LblDay1Pt2.TabIndex = 2;
            LblDay1Pt2.Text = "Day 1 pt2 result";
            // 
            // LblDay2Pt2
            // 
            LblDay2Pt2.AutoSize = true;
            LblDay2Pt2.Location = new Point(271, 63);
            LblDay2Pt2.Name = "LblDay2Pt2";
            LblDay2Pt2.Size = new Size(88, 15);
            LblDay2Pt2.TabIndex = 5;
            LblDay2Pt2.Text = "Day 2 pt2 result";
            // 
            // LblDay2Pt1
            // 
            LblDay2Pt1.AutoSize = true;
            LblDay2Pt1.Location = new Point(123, 63);
            LblDay2Pt1.Name = "LblDay2Pt1";
            LblDay2Pt1.Size = new Size(88, 15);
            LblDay2Pt1.TabIndex = 4;
            LblDay2Pt1.Text = "Day 2 pt1 result";
            // 
            // btnDay2
            // 
            btnDay2.Location = new Point(29, 59);
            btnDay2.Name = "btnDay2";
            btnDay2.Size = new Size(75, 23);
            btnDay2.TabIndex = 3;
            btnDay2.Text = "Day2";
            btnDay2.UseVisualStyleBackColor = true;
            btnDay2.Click += btnDay2_Click;
            // 
            // LblDay3Pt2
            // 
            LblDay3Pt2.AutoSize = true;
            LblDay3Pt2.Location = new Point(271, 92);
            LblDay3Pt2.Name = "LblDay3Pt2";
            LblDay3Pt2.Size = new Size(88, 15);
            LblDay3Pt2.TabIndex = 8;
            LblDay3Pt2.Text = "Day 3 pt2 result";
            // 
            // LblDay3Pt1
            // 
            LblDay3Pt1.AutoSize = true;
            LblDay3Pt1.Location = new Point(123, 92);
            LblDay3Pt1.Name = "LblDay3Pt1";
            LblDay3Pt1.Size = new Size(88, 15);
            LblDay3Pt1.TabIndex = 7;
            LblDay3Pt1.Text = "Day 3 pt1 result";
            // 
            // BtnDay3
            // 
            BtnDay3.Location = new Point(29, 88);
            BtnDay3.Name = "BtnDay3";
            BtnDay3.Size = new Size(75, 23);
            BtnDay3.TabIndex = 6;
            BtnDay3.Text = "Day3";
            BtnDay3.UseVisualStyleBackColor = true;
            BtnDay3.Click += BtnDay3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblDay3Pt2);
            Controls.Add(LblDay3Pt1);
            Controls.Add(BtnDay3);
            Controls.Add(LblDay2Pt2);
            Controls.Add(LblDay2Pt1);
            Controls.Add(btnDay2);
            Controls.Add(LblDay1Pt2);
            Controls.Add(LblDay1Pt1);
            Controls.Add(BtnDay1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDay1;
        private Label LblDay1Pt1;
        private Label LblDay1Pt2;
        private Label LblDay2Pt2;
        private Label LblDay2Pt1;
        private Button btnDay2;
        private Label LblDay3Pt2;
        private Label LblDay3Pt1;
        private Button BtnDay3;
    }
}
