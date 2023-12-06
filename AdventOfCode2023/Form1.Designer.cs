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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
