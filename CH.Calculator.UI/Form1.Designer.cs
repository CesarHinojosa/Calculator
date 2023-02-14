namespace CH.Calculator.UI
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
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnPosNeg = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(283, 309);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(44, 43);
            this.btnTwo.TabIndex = 0;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.NumberEntered);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(361, 243);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(44, 43);
            this.btnSix.TabIndex = 0;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.NumberEntered);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(361, 309);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(44, 43);
            this.btnThree.TabIndex = 0;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.NumberEntered);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(202, 177);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(44, 43);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.NumberEntered);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(202, 243);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(44, 43);
            this.btnFour.TabIndex = 0;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.NumberEntered);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(283, 243);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(44, 43);
            this.btnFive.TabIndex = 0;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.NumberEntered);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(202, 374);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(44, 43);
            this.btnZero.TabIndex = 0;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.NumberEntered);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(437, 309);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(44, 43);
            this.btnSubtract.TabIndex = 0;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(437, 177);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(44, 43);
            this.btnDivide.TabIndex = 0;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Location = new System.Drawing.Point(521, 177);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(44, 43);
            this.btnSquareRoot.TabIndex = 0;
            this.btnSquareRoot.Text = "sqrt";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(202, 108);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 52);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(371, 108);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(194, 52);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(202, 309);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(44, 43);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.NumberEntered);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(283, 177);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(44, 43);
            this.btnEight.TabIndex = 0;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.NumberEntered);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(361, 177);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(44, 43);
            this.btnNine.TabIndex = 0;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.NumberEntered);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(437, 243);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(44, 43);
            this.btnMultiply.TabIndex = 0;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(437, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 43);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(521, 309);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(44, 108);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Location = new System.Drawing.Point(521, 243);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(44, 43);
            this.btnReciprocal.TabIndex = 0;
            this.btnReciprocal.Text = "1/X";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            // 
            // btnPosNeg
            // 
            this.btnPosNeg.Location = new System.Drawing.Point(283, 374);
            this.btnPosNeg.Name = "btnPosNeg";
            this.btnPosNeg.Size = new System.Drawing.Size(44, 43);
            this.btnPosNeg.TabIndex = 0;
            this.btnPosNeg.Text = "+/-";
            this.btnPosNeg.UseVisualStyleBackColor = true;
            this.btnPosNeg.Click += new System.EventHandler(this.NumberEntered);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(361, 374);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(44, 43);
            this.btnDecimal.TabIndex = 0;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay.Location = new System.Drawing.Point(207, 43);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(358, 59);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.Text = " ";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 466);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnPosNeg);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnTwo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTwo;
        private Button btnSix;
        private Button btnThree;
        private Button btnSeven;
        private Button btnFour;
        private Button btnFive;
        private Button btnZero;
        private Button btnSubtract;
        private Button btnDivide;
        private Button btnSquareRoot;
        private Button btnBack;
        private Button btnClear;
        private Button btnOne;
        private Button btnEight;
        private Button btnNine;
        private Button btnMultiply;
        private Button btnAdd;
        private Button btnCalculate;
        private Button btnReciprocal;
        private Button btnPosNeg;
        private Button btnDecimal;
        private TextBox txtDisplay;
    }
}