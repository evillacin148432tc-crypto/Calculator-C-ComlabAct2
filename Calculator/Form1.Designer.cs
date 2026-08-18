namespace Calculator
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
            num1 = new Button();
            num2 = new Button();
            num3 = new Button();
            X = new Button();
            num4 = new Button();
            num5 = new Button();
            num6 = new Button();
            dev = new Button();
            num7 = new Button();
            num8 = new Button();
            num9 = new Button();
            sub = new Button();
            CE = new Button();
            CLEAR = new Button();
            equal = new Button();
            plus = new Button();
            Result = new TextBox();
            SuspendLayout();
            // 
            // num1
            // 
            num1.BackColor = SystemColors.ControlDark;
            num1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num1.Location = new Point(12, 358);
            num1.Name = "num1";
            num1.Size = new Size(59, 66);
            num1.TabIndex = 0;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = false;
            num1.Click += button1_Click;
            // 
            // num2
            // 
            num2.BackColor = SystemColors.ControlDark;
            num2.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num2.Location = new Point(89, 358);
            num2.Name = "num2";
            num2.Size = new Size(59, 66);
            num2.TabIndex = 16;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = false;
            num2.Click += num2_Click;
            // 
            // num3
            // 
            num3.BackColor = SystemColors.ControlDark;
            num3.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num3.Location = new Point(171, 358);
            num3.Name = "num3";
            num3.Size = new Size(59, 66);
            num3.TabIndex = 17;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = false;
            num3.Click += num3_Click;
            // 
            // X
            // 
            X.BackColor = SystemColors.ActiveCaption;
            X.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X.Location = new Point(249, 358);
            X.Name = "X";
            X.Size = new Size(59, 66);
            X.TabIndex = 18;
            X.Text = "X";
            X.UseVisualStyleBackColor = false;
            X.Click += X_Click;
            // 
            // num4
            // 
            num4.BackColor = SystemColors.ControlDark;
            num4.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num4.Location = new Point(12, 277);
            num4.Name = "num4";
            num4.Size = new Size(59, 66);
            num4.TabIndex = 19;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = false;
            num4.Click += num4_Click;
            // 
            // num5
            // 
            num5.BackColor = SystemColors.ControlDark;
            num5.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num5.Location = new Point(89, 277);
            num5.Name = "num5";
            num5.Size = new Size(59, 66);
            num5.TabIndex = 20;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = false;
            num5.Click += num5_Click;
            // 
            // num6
            // 
            num6.BackColor = SystemColors.ControlDark;
            num6.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num6.Location = new Point(171, 277);
            num6.Name = "num6";
            num6.Size = new Size(59, 66);
            num6.TabIndex = 21;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = false;
            num6.Click += num6_Click;
            // 
            // dev
            // 
            dev.BackColor = SystemColors.ActiveCaption;
            dev.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dev.Location = new Point(249, 277);
            dev.Name = "dev";
            dev.Size = new Size(59, 66);
            dev.TabIndex = 22;
            dev.Text = "/";
            dev.UseVisualStyleBackColor = false;
            dev.Click += dev_Click;
            // 
            // num7
            // 
            num7.BackColor = SystemColors.ControlDark;
            num7.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num7.Location = new Point(12, 195);
            num7.Name = "num7";
            num7.Size = new Size(59, 66);
            num7.TabIndex = 23;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = false;
            num7.Click += num7_Click;
            // 
            // num8
            // 
            num8.BackColor = SystemColors.ControlDark;
            num8.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num8.Location = new Point(89, 195);
            num8.Name = "num8";
            num8.Size = new Size(59, 66);
            num8.TabIndex = 24;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = false;
            num8.Click += num8_Click;
            // 
            // num9
            // 
            num9.BackColor = SystemColors.ControlDark;
            num9.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num9.Location = new Point(171, 195);
            num9.Name = "num9";
            num9.Size = new Size(59, 66);
            num9.TabIndex = 25;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = false;
            num9.Click += num9_Click;
            // 
            // sub
            // 
            sub.BackColor = SystemColors.ActiveCaption;
            sub.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sub.Location = new Point(249, 195);
            sub.Name = "sub";
            sub.Size = new Size(59, 66);
            sub.TabIndex = 26;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = false;
            sub.Click += sub_Click;
            // 
            // CE
            // 
            CE.BackColor = SystemColors.ActiveCaption;
            CE.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CE.Location = new Point(12, 109);
            CE.Name = "CE";
            CE.Size = new Size(59, 66);
            CE.TabIndex = 27;
            CE.Text = "CE";
            CE.UseVisualStyleBackColor = false;
            CE.Click += CE_Click;
            // 
            // CLEAR
            // 
            CLEAR.BackColor = SystemColors.ActiveCaption;
            CLEAR.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CLEAR.Location = new Point(89, 109);
            CLEAR.Name = "CLEAR";
            CLEAR.Size = new Size(59, 66);
            CLEAR.TabIndex = 28;
            CLEAR.Text = "C";
            CLEAR.UseVisualStyleBackColor = false;
            CLEAR.Click += CLEAR_Click;
            // 
            // equal
            // 
            equal.BackColor = SystemColors.ActiveCaption;
            equal.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equal.Location = new Point(171, 109);
            equal.Name = "equal";
            equal.Size = new Size(59, 66);
            equal.TabIndex = 29;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // plus
            // 
            plus.BackColor = SystemColors.ActiveCaption;
            plus.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plus.Location = new Point(249, 109);
            plus.Name = "plus";
            plus.Size = new Size(59, 66);
            plus.TabIndex = 30;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // Result
            // 
            Result.BackColor = SystemColors.Info;
            Result.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Result.Location = new Point(12, 46);
            Result.Name = "Result";
            Result.RightToLeft = RightToLeft.Yes;
            Result.Size = new Size(296, 46);
            Result.TabIndex = 31;
            Result.TextChanged += result_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(331, 436);
            Controls.Add(Result);
            Controls.Add(plus);
            Controls.Add(equal);
            Controls.Add(CLEAR);
            Controls.Add(CE);
            Controls.Add(sub);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(dev);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(X);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button num1;
        private Button num2;
        private Button num3;
        private Button X;
        private Button num4;
        private Button num5;
        private Button num6;
        private Button dev;
        private Button num7;
        private Button num8;
        private Button num9;
        private Button sub;
        private Button CE;
        private Button CLEAR;
        private Button equal;
        private Button plus;
        private TextBox Result;
    }
}
