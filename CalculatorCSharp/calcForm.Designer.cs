
namespace CalculatorCSharp
{
    partial class calcForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.tallyBox = new System.Windows.Forms.TextBox();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonSquared = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonFlip = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonNegate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 102);
            this.inputBox.Name = "inputBox";
            this.inputBox.ReadOnly = true;
            this.inputBox.Size = new System.Drawing.Size(293, 20);
            this.inputBox.TabIndex = 2;
            this.inputBox.Text = "0";
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(216, 204);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(89, 32);
            this.buttonMultiply.TabIndex = 4;
            this.buttonMultiply.Text = "X";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // tallyBox
            // 
            this.tallyBox.Location = new System.Drawing.Point(12, 12);
            this.tallyBox.Multiline = true;
            this.tallyBox.Name = "tallyBox";
            this.tallyBox.ReadOnly = true;
            this.tallyBox.Size = new System.Drawing.Size(293, 84);
            this.tallyBox.TabIndex = 5;
            this.tallyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tallyBox.TextChanged += new System.EventHandler(this.tallyBox_TextChanged);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(216, 318);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(89, 32);
            this.buttonEquals.TabIndex = 6;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(216, 166);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(89, 32);
            this.buttonDivide.TabIndex = 7;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(216, 280);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 32);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(216, 242);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(89, 32);
            this.buttonSubtract.TabIndex = 9;
            this.buttonSubtract.Text = "--";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // buttonSquared
            // 
            this.buttonSquared.Location = new System.Drawing.Point(12, 166);
            this.buttonSquared.Name = "buttonSquared";
            this.buttonSquared.Size = new System.Drawing.Size(62, 32);
            this.buttonSquared.TabIndex = 10;
            this.buttonSquared.Text = "x^2";
            this.buttonSquared.UseVisualStyleBackColor = true;
            this.buttonSquared.Click += new System.EventHandler(this.buttonSquared_Click);
            // 
            // buttonPower
            // 
            this.buttonPower.Location = new System.Drawing.Point(80, 166);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(62, 32);
            this.buttonPower.TabIndex = 11;
            this.buttonPower.Text = "x^y";
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.buttonPower_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Location = new System.Drawing.Point(148, 166);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(62, 32);
            this.buttonSqrt.TabIndex = 12;
            this.buttonSqrt.Text = "Sqrt";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonFlip
            // 
            this.buttonFlip.Location = new System.Drawing.Point(13, 128);
            this.buttonFlip.Name = "buttonFlip";
            this.buttonFlip.Size = new System.Drawing.Size(61, 32);
            this.buttonFlip.TabIndex = 13;
            this.buttonFlip.Text = "1/x";
            this.buttonFlip.UseVisualStyleBackColor = true;
            this.buttonFlip.Click += new System.EventHandler(this.buttonFlip_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 32);
            this.button4.TabIndex = 14;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(80, 241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 33);
            this.button5.TabIndex = 15;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(148, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 33);
            this.button6.TabIndex = 16;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 279);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 32);
            this.button7.TabIndex = 17;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(80, 279);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 32);
            this.button8.TabIndex = 18;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(148, 279);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(62, 32);
            this.button9.TabIndex = 19;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(80, 317);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(62, 33);
            this.button0.TabIndex = 20;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Location = new System.Drawing.Point(149, 317);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(61, 33);
            this.buttonDecimal.TabIndex = 21;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.buttonDecimal_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Location = new System.Drawing.Point(216, 128);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(89, 32);
            this.buttonBackspace.TabIndex = 22;
            this.buttonBackspace.Text = "<---";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(148, 129);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(62, 31);
            this.buttonC.TabIndex = 23;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(80, 128);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(62, 32);
            this.buttonCE.TabIndex = 24;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonNegate
            // 
            this.buttonNegate.Location = new System.Drawing.Point(13, 318);
            this.buttonNegate.Name = "buttonNegate";
            this.buttonNegate.Size = new System.Drawing.Size(61, 32);
            this.buttonNegate.TabIndex = 25;
            this.buttonNegate.Text = "-/+";
            this.buttonNegate.UseVisualStyleBackColor = true;
            this.buttonNegate.Click += new System.EventHandler(this.buttonNegate_Click);
            // 
            // calcForm
            // 
            this.AcceptButton = this.buttonEquals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 360);
            this.Controls.Add(this.buttonNegate);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonFlip);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.buttonSquared);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.tallyBox);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "calcForm";
            this.Text = "calcForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.TextBox tallyBox;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonSquared;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonFlip;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonNegate;
    }
}

