namespace WinFormsDemo
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
            lblShowInfo = new Label();
            lblAppName = new Label();
            lblShow = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivision = new Button();
            buttonEquals = new Button();
            button0 = new Button();
            lblResult = new Label();
            lblShowCalculation = new Label();
            btnReset = new Button();
            btnPoint = new Button();
            SuspendLayout();
            // 
            // lblShowInfo
            // 
            lblShowInfo.Font = new Font("Segoe UI", 10F);
            lblShowInfo.Location = new Point(479, 94);
            lblShowInfo.Name = "lblShowInfo";
            lblShowInfo.Size = new Size(216, 127);
            lblShowInfo.TabIndex = 10;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Segoe UI", 12F);
            lblAppName.Location = new Point(0, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(408, 36);
            lblAppName.TabIndex = 11;
            lblAppName.Text = "MY CULCULATOR";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.FixedSingle;
            lblShow.Font = new Font("Segoe UI", 25F);
            lblShow.Location = new Point(12, 50);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(386, 114);
            lblShow.TabIndex = 12;
            lblShow.TextAlign = ContentAlignment.BottomLeft;
            // 
            // button1
            // 
            button1.Location = new Point(12, 222);
            button1.Name = "button1";
            button1.Size = new Size(77, 70);
            button1.TabIndex = 13;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(110, 222);
            button2.Name = "button2";
            button2.Size = new Size(77, 70);
            button2.TabIndex = 14;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(208, 222);
            button3.Name = "button3";
            button3.Size = new Size(77, 70);
            button3.TabIndex = 15;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 308);
            button4.Name = "button4";
            button4.Size = new Size(77, 70);
            button4.TabIndex = 16;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(110, 308);
            button5.Name = "button5";
            button5.Size = new Size(77, 70);
            button5.TabIndex = 17;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(208, 308);
            button6.Name = "button6";
            button6.Size = new Size(77, 70);
            button6.TabIndex = 18;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 396);
            button7.Name = "button7";
            button7.Size = new Size(77, 70);
            button7.TabIndex = 19;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(110, 396);
            button8.Name = "button8";
            button8.Size = new Size(77, 70);
            button8.TabIndex = 20;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(208, 396);
            button9.Name = "button9";
            button9.Size = new Size(77, 70);
            button9.TabIndex = 21;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(307, 179);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(91, 31);
            buttonPlus.TabIndex = 22;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(307, 216);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(91, 31);
            buttonMinus.TabIndex = 23;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(307, 253);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(91, 33);
            buttonMultiply.TabIndex = 24;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.Location = new Point(307, 292);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(91, 33);
            buttonDivision.TabIndex = 25;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(307, 331);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(91, 33);
            buttonEquals.TabIndex = 26;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // button0
            // 
            button0.Location = new Point(307, 407);
            button0.Name = "button0";
            button0.Size = new Size(91, 59);
            button0.TabIndex = 27;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 25F);
            lblResult.Location = new Point(130, 106);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(258, 54);
            lblResult.TabIndex = 28;
            lblResult.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblShowCalculation
            // 
            lblShowCalculation.Font = new Font("Segoe UI", 25F);
            lblShowCalculation.Location = new Point(23, 106);
            lblShowCalculation.Name = "lblShowCalculation";
            lblShowCalculation.Size = new Size(315, 54);
            lblShowCalculation.TabIndex = 29;
            lblShowCalculation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(12, 179);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(273, 29);
            btnReset.TabIndex = 30;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(307, 368);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(91, 33);
            btnPoint.TabIndex = 31;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 493);
            Controls.Add(btnPoint);
            Controls.Add(btnReset);
            Controls.Add(lblShowCalculation);
            Controls.Add(lblResult);
            Controls.Add(button0);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDivision);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblShow);
            Controls.Add(lblAppName);
            Controls.Add(lblShowInfo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Culculator";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label lblShowInfo;
        private Label lblAppName;
        private Label lblShow;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivision;
        private Button buttonEquals;
        private Button button0;
        private Label lblResult;
        private Label lblShowCalculation;
        private Button btnReset;
        private Button btnPoint;
    }
}
