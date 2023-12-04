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
            LblDay1 = new Label();
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
            // LblDay1
            // 
            LblDay1.AutoSize = true;
            LblDay1.Location = new Point(110, 27);
            LblDay1.Name = "LblDay1";
            LblDay1.Size = new Size(68, 15);
            LblDay1.TabIndex = 1;
            LblDay1.Text = "Day 1 result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblDay1);
            Controls.Add(BtnDay1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDay1;
        private Label LblDay1;
    }
}
