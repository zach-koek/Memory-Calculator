
namespace Calculator
{
    partial class frmMemoryCalculator
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
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPositiveOrNegative = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtbxDisplay = new System.Windows.Forms.TextBox();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.btnMemoryRecall = new System.Windows.Forms.Button();
            this.btnMemoryStore = new System.Windows.Forms.Button();
            this.btnMemoryPlus = new System.Windows.Forms.Button();
            this.txtbxMemoryActive = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.AutoSize = true;
            this.btnSquareRoot.Location = new System.Drawing.Point(246, 100);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(49, 50);
            this.btnSquareRoot.TabIndex = 0;
            this.btnSquareRoot.Text = "SQRT";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.Location = new System.Drawing.Point(150, 100);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(42, 50);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Digit_Clicked_EventHandler);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.Location = new System.Drawing.Point(150, 156);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(42, 50);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Digit_Clicked_EventHandler);
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.Location = new System.Drawing.Point(102, 100);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(42, 50);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Digit_Clicked_EventHandler);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.Location = new System.Drawing.Point(102, 156);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 50);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Digit_Clicked_EventHandler);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(102, 213);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 50);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Digit_Clicked_EventHandler);
            // 
            // btnEquals
            // 
            this.btnEquals.AutoSize = true;
            this.btnEquals.Location = new System.Drawing.Point(246, 213);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(49, 107);
            this.btnEquals.TabIndex = 6;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.Location = new System.Drawing.Point(54, 100);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(42, 50);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Digit_Clicked_EventHandler);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.Location = new System.Drawing.Point(54, 156);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(42, 50);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Digit_Clicked_EventHandler);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(54, 213);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 50);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Digit_Clicked_EventHandler);
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.Location = new System.Drawing.Point(54, 269);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(42, 50);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPositiveOrNegative
            // 
            this.btnPositiveOrNegative.AutoSize = true;
            this.btnPositiveOrNegative.Location = new System.Drawing.Point(102, 270);
            this.btnPositiveOrNegative.Name = "btnPositiveOrNegative";
            this.btnPositiveOrNegative.Size = new System.Drawing.Size(42, 50);
            this.btnPositiveOrNegative.TabIndex = 11;
            this.btnPositiveOrNegative.Text = "+/-";
            this.btnPositiveOrNegative.UseVisualStyleBackColor = true;
            this.btnPositiveOrNegative.Click += new System.EventHandler(this.btnPositiveOrNegative_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.AutoSize = true;
            this.btnPeriod.Location = new System.Drawing.Point(150, 270);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(42, 50);
            this.btnPeriod.TabIndex = 12;
            this.btnPeriod.Tag = ".";
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.AutoSize = true;
            this.btnDivision.Location = new System.Drawing.Point(198, 100);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(42, 50);
            this.btnDivision.TabIndex = 13;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.Operator_Clicked_EventHandler);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.AutoSize = true;
            this.btnReciprocal.Location = new System.Drawing.Point(246, 156);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(49, 50);
            this.btnReciprocal.TabIndex = 14;
            this.btnReciprocal.Text = "1/X";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.AutoSize = true;
            this.btnMultiplication.Location = new System.Drawing.Point(198, 156);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(42, 50);
            this.btnMultiplication.TabIndex = 15;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.Operator_Clicked_EventHandler);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.AutoSize = true;
            this.btnSubtraction.Location = new System.Drawing.Point(198, 213);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(42, 50);
            this.btnSubtraction.TabIndex = 16;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.Operator_Clicked_EventHandler);
            // 
            // btnAddition
            // 
            this.btnAddition.AutoSize = true;
            this.btnAddition.Location = new System.Drawing.Point(198, 270);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(42, 50);
            this.btnAddition.TabIndex = 17;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.Operator_Clicked_EventHandler);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Location = new System.Drawing.Point(150, 213);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 50);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Digit_Clicked_EventHandler);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(150, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 40);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Location = new System.Drawing.Point(54, 53);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtbxDisplay
            // 
            this.txtbxDisplay.Location = new System.Drawing.Point(6, 7);
            this.txtbxDisplay.Name = "txtbxDisplay";
            this.txtbxDisplay.ReadOnly = true;
            this.txtbxDisplay.Size = new System.Drawing.Size(282, 25);
            this.txtbxDisplay.TabIndex = 21;
            this.txtbxDisplay.TabStop = false;
            this.txtbxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.Location = new System.Drawing.Point(6, 100);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(42, 50);
            this.btnMemoryClear.TabIndex = 22;
            this.btnMemoryClear.Text = "MC";
            this.btnMemoryClear.UseVisualStyleBackColor = true;
            this.btnMemoryClear.Click += new System.EventHandler(this.btnMemoryClear_Click);
            // 
            // btnMemoryRecall
            // 
            this.btnMemoryRecall.Location = new System.Drawing.Point(6, 156);
            this.btnMemoryRecall.Name = "btnMemoryRecall";
            this.btnMemoryRecall.Size = new System.Drawing.Size(42, 50);
            this.btnMemoryRecall.TabIndex = 23;
            this.btnMemoryRecall.Text = "MR";
            this.btnMemoryRecall.UseVisualStyleBackColor = true;
            this.btnMemoryRecall.Click += new System.EventHandler(this.btnMemoryRecall_Click);
            // 
            // btnMemoryStore
            // 
            this.btnMemoryStore.Location = new System.Drawing.Point(6, 213);
            this.btnMemoryStore.Name = "btnMemoryStore";
            this.btnMemoryStore.Size = new System.Drawing.Size(42, 50);
            this.btnMemoryStore.TabIndex = 24;
            this.btnMemoryStore.Text = "MS";
            this.btnMemoryStore.UseVisualStyleBackColor = true;
            this.btnMemoryStore.Click += new System.EventHandler(this.btnMemoryStore_Click);
            // 
            // btnMemoryPlus
            // 
            this.btnMemoryPlus.Location = new System.Drawing.Point(6, 269);
            this.btnMemoryPlus.Name = "btnMemoryPlus";
            this.btnMemoryPlus.Size = new System.Drawing.Size(42, 50);
            this.btnMemoryPlus.TabIndex = 25;
            this.btnMemoryPlus.Text = "M+";
            this.btnMemoryPlus.UseVisualStyleBackColor = true;
            this.btnMemoryPlus.Click += new System.EventHandler(this.btnMemoryPlus_Click);
            // 
            // txtbxMemoryActive
            // 
            this.txtbxMemoryActive.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxMemoryActive.Location = new System.Drawing.Point(6, 53);
            this.txtbxMemoryActive.Multiline = true;
            this.txtbxMemoryActive.Name = "txtbxMemoryActive";
            this.txtbxMemoryActive.ReadOnly = true;
            this.txtbxMemoryActive.Size = new System.Drawing.Size(42, 40);
            this.txtbxMemoryActive.TabIndex = 26;
            this.txtbxMemoryActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 325);
            this.Controls.Add(this.txtbxMemoryActive);
            this.Controls.Add(this.btnMemoryPlus);
            this.Controls.Add(this.btnMemoryStore);
            this.Controls.Add(this.btnMemoryRecall);
            this.Controls.Add(this.btnMemoryClear);
            this.Controls.Add(this.txtbxDisplay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.btnPositiveOrNegative);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnSquareRoot);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPositiveOrNegative;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtbxDisplay;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button btnMemoryRecall;
        private System.Windows.Forms.Button btnMemoryStore;
        private System.Windows.Forms.Button btnMemoryPlus;
        private System.Windows.Forms.TextBox txtbxMemoryActive;
    }
}

