namespace Frontend.Windows
{
    partial class Evaluator
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
            txtDisplay = new TextBox();
            btn8 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnIqual = new Button();
            btnDivide = new Button();
            btnPlus = new Button();
            btnMulty = new Button();
            btnrest = new Button();
            btnClear = new Button();
            btnLeft = new Button();
            btnright = new Button();
            btnExpo = new Button();
            btnDot = new Button();
            btn7 = new Button();
            btn2 = new Button();
            btn9 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = SystemColors.InactiveCaption;
            txtDisplay.Location = new Point(23, 22);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(618, 23);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btn8
            // 
            btn8.Location = new Point(139, 80);
            btn8.Name = "btn8";
            btn8.Size = new Size(71, 64);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(37, 170);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 60);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(135, 170);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 60);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(239, 170);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 60);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(37, 257);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 54);
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(239, 257);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 54);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(135, 336);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 55);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += T0_Click;
            // 
            // btnIqual
            // 
            btnIqual.BackColor = SystemColors.ActiveCaption;
            btnIqual.Location = new Point(239, 336);
            btnIqual.Name = "btnIqual";
            btnIqual.Size = new Size(75, 55);
            btnIqual.TabIndex = 12;
            btnIqual.Text = "=";
            btnIqual.UseVisualStyleBackColor = false;
            btnIqual.Click += btnIqual_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ActiveCaption;
            btnDivide.Location = new Point(429, 166);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 64);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ActiveCaption;
            btnPlus.Location = new Point(429, 247);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 64);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMulty
            // 
            btnMulty.BackColor = SystemColors.ActiveCaption;
            btnMulty.Location = new Point(526, 247);
            btnMulty.Name = "btnMulty";
            btnMulty.Size = new Size(75, 64);
            btnMulty.TabIndex = 15;
            btnMulty.Text = "X";
            btnMulty.UseVisualStyleBackColor = false;
            btnMulty.Click += btnMulty_Click;
            // 
            // btnrest
            // 
            btnrest.BackColor = SystemColors.ActiveCaption;
            btnrest.Location = new Point(429, 80);
            btnrest.Name = "btnrest";
            btnrest.Size = new Size(75, 64);
            btnrest.TabIndex = 16;
            btnrest.Text = "-";
            btnrest.UseVisualStyleBackColor = false;
            btnrest.Click += btnrest_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(37, 336);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 55);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = SystemColors.ActiveCaption;
            btnLeft.Location = new Point(526, 80);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(75, 64);
            btnLeft.TabIndex = 18;
            btnLeft.Text = "(";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnright
            // 
            btnright.BackColor = SystemColors.ActiveCaption;
            btnright.Location = new Point(526, 166);
            btnright.Name = "btnright";
            btnright.Size = new Size(75, 64);
            btnright.TabIndex = 19;
            btnright.Text = ")";
            btnright.UseVisualStyleBackColor = false;
            btnright.Click += btnright_Click;
            // 
            // btnExpo
            // 
            btnExpo.BackColor = SystemColors.ActiveCaption;
            btnExpo.Location = new Point(429, 327);
            btnExpo.Name = "btnExpo";
            btnExpo.Size = new Size(75, 55);
            btnExpo.TabIndex = 20;
            btnExpo.Text = "^";
            btnExpo.UseVisualStyleBackColor = false;
            btnExpo.Click += btnExpo_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ActiveCaption;
            btnDot.Location = new Point(526, 327);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(75, 55);
            btnDot.TabIndex = 21;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(41, 80);
            btn7.Name = "btn7";
            btn7.Size = new Size(71, 64);
            btn7.TabIndex = 22;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(135, 252);
            btn2.Name = "btn2";
            btn2.Size = new Size(71, 64);
            btn2.TabIndex = 24;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click_1;
            // 
            // btn9
            // 
            btn9.Location = new Point(239, 80);
            btn9.Name = "btn9";
            btn9.Size = new Size(71, 64);
            btn9.TabIndex = 25;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click_1;
            // 
            // Evaluator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn7);
            Controls.Add(btnDot);
            Controls.Add(btnExpo);
            Controls.Add(btnright);
            Controls.Add(btnLeft);
            Controls.Add(btnClear);
            Controls.Add(btnrest);
            Controls.Add(btnMulty);
            Controls.Add(btnPlus);
            Controls.Add(btnDivide);
            Controls.Add(btnIqual);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(txtDisplay);
            Name = "Evaluator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn8;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn3;
        private Button btn0;
        private Button btnIqual;
        private Button btnDivide;
        private Button btnPlus;
        private Button btnMulty;
        private Button btnrest;
        private Button btnClear;
        private Button btnLeft;
        private Button btnright;
        private Button btnExpo;
        private Button btnDot;
        private Button btn7;
        private Button btn2;
        private Button btn9;
    }
}
