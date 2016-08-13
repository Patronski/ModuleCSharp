namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonOperatorMinus = new System.Windows.Forms.Button();
            this.buttonOperatorPlus = new System.Windows.Forms.Button();
            this.buttonOperatorMultiply = new System.Windows.Forms.Button();
            this.buttonOperatorDivide = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelOperation = new System.Windows.Forms.Label();
            this.buttonOff = new System.Windows.Forms.Button();
            this.buttonOn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDot.Location = new System.Drawing.Point(12, 211);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(40, 40);
            this.buttonDot.TabIndex = 0;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonDotClick);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZero.Location = new System.Drawing.Point(58, 211);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(40, 40);
            this.buttonZero.TabIndex = 0;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOne.Location = new System.Drawing.Point(12, 165);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(40, 40);
            this.buttonOne.TabIndex = 0;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTwo.Location = new System.Drawing.Point(58, 165);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(40, 40);
            this.buttonTwo.TabIndex = 0;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThree.Location = new System.Drawing.Point(104, 165);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(40, 40);
            this.buttonThree.TabIndex = 0;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSix.Location = new System.Drawing.Point(104, 119);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(40, 40);
            this.buttonSix.TabIndex = 0;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFour.Location = new System.Drawing.Point(12, 119);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(40, 40);
            this.buttonFour.TabIndex = 0;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFive.Location = new System.Drawing.Point(58, 119);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(40, 40);
            this.buttonFive.TabIndex = 0;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNine.Location = new System.Drawing.Point(104, 73);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(40, 40);
            this.buttonNine.TabIndex = 0;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeven.Location = new System.Drawing.Point(12, 73);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(40, 40);
            this.buttonSeven.TabIndex = 0;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEight.Location = new System.Drawing.Point(58, 73);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(40, 40);
            this.buttonEight.TabIndex = 0;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEqual.Location = new System.Drawing.Point(104, 211);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(40, 40);
            this.buttonEqual.TabIndex = 0;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonOperatorMinus
            // 
            this.buttonOperatorMinus.BackColor = System.Drawing.Color.Silver;
            this.buttonOperatorMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperatorMinus.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperatorMinus.Location = new System.Drawing.Point(150, 165);
            this.buttonOperatorMinus.Name = "buttonOperatorMinus";
            this.buttonOperatorMinus.Size = new System.Drawing.Size(40, 40);
            this.buttonOperatorMinus.TabIndex = 0;
            this.buttonOperatorMinus.Text = "-";
            this.buttonOperatorMinus.UseVisualStyleBackColor = false;
            this.buttonOperatorMinus.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonOperatorPlus
            // 
            this.buttonOperatorPlus.BackColor = System.Drawing.Color.Silver;
            this.buttonOperatorPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperatorPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperatorPlus.Location = new System.Drawing.Point(150, 211);
            this.buttonOperatorPlus.Name = "buttonOperatorPlus";
            this.buttonOperatorPlus.Size = new System.Drawing.Size(40, 40);
            this.buttonOperatorPlus.TabIndex = 0;
            this.buttonOperatorPlus.Text = "+";
            this.buttonOperatorPlus.UseVisualStyleBackColor = false;
            this.buttonOperatorPlus.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonOperatorMultiply
            // 
            this.buttonOperatorMultiply.BackColor = System.Drawing.Color.Silver;
            this.buttonOperatorMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperatorMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperatorMultiply.Location = new System.Drawing.Point(150, 119);
            this.buttonOperatorMultiply.Name = "buttonOperatorMultiply";
            this.buttonOperatorMultiply.Size = new System.Drawing.Size(40, 40);
            this.buttonOperatorMultiply.TabIndex = 0;
            this.buttonOperatorMultiply.Text = "×";
            this.buttonOperatorMultiply.UseVisualStyleBackColor = false;
            this.buttonOperatorMultiply.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonOperatorDivide
            // 
            this.buttonOperatorDivide.BackColor = System.Drawing.Color.Silver;
            this.buttonOperatorDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperatorDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperatorDivide.Location = new System.Drawing.Point(150, 73);
            this.buttonOperatorDivide.Name = "buttonOperatorDivide";
            this.buttonOperatorDivide.Size = new System.Drawing.Size(40, 40);
            this.buttonOperatorDivide.TabIndex = 0;
            this.buttonOperatorDivide.Text = "÷";
            this.buttonOperatorDivide.UseVisualStyleBackColor = false;
            this.buttonOperatorDivide.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCE.Location = new System.Drawing.Point(196, 120);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(40, 39);
            this.buttonCE.TabIndex = 0;
            this.buttonCE.Text = "<---";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonC.Location = new System.Drawing.Point(196, 74);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(40, 40);
            this.buttonC.TabIndex = 0;
            this.buttonC.Text = "Clear";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.White;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxResult.Location = new System.Drawing.Point(13, 25);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(224, 29);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.Text = "0";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelOperation
            // 
            this.labelOperation.BackColor = System.Drawing.Color.Transparent;
            this.labelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOperation.Location = new System.Drawing.Point(21, 9);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelOperation.Size = new System.Drawing.Size(197, 13);
            this.labelOperation.TabIndex = 2;
            this.labelOperation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonOff
            // 
            this.buttonOff.BackColor = System.Drawing.Color.Red;
            this.buttonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOff.Location = new System.Drawing.Point(243, 25);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(43, 29);
            this.buttonOff.TabIndex = 3;
            this.buttonOff.Text = "OFF";
            this.buttonOff.UseVisualStyleBackColor = false;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.BackColor = System.Drawing.Color.Lime;
            this.buttonOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOn.Location = new System.Drawing.Point(243, 25);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(43, 29);
            this.buttonOn.TabIndex = 3;
            this.buttonOn.Text = "ON";
            this.buttonOn.UseVisualStyleBackColor = false;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 261);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonOperatorDivide);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonOperatorMultiply);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonOperatorPlus);
            this.Controls.Add(this.buttonOperatorMinus);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonDot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonOperatorMinus;
        private System.Windows.Forms.Button buttonOperatorPlus;
        private System.Windows.Forms.Button buttonOperatorMultiply;
        private System.Windows.Forms.Button buttonOperatorDivide;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Button buttonOn;
    }
}

