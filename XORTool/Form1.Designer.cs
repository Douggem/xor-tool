namespace XORTool
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
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.txtBoxKey = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblXORKey = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnBitwiseAnd = new System.Windows.Forms.Button();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblHexEsc = new System.Windows.Forms.Label();
            this.btnBitwiseOr = new System.Windows.Forms.Button();
            this.txtBoxString = new System.Windows.Forms.TextBox();
            this.txtBoxHex = new System.Windows.Forms.TextBox();
            this.txtBoxHexEsc = new System.Windows.Forms.TextBox();
            this.grpBoxInput = new System.Windows.Forms.GroupBox();
            this.radBtnBin = new System.Windows.Forms.RadioButton();
            this.radBtnHex = new System.Windows.Forms.RadioButton();
            this.radBtnNum = new System.Windows.Forms.RadioButton();
            this.radBtnText = new System.Windows.Forms.RadioButton();
            this.txtBoxBinary = new System.Windows.Forms.TextBox();
            this.lblBits = new System.Windows.Forms.Label();
            this.rTxtBoxOutput = new System.Windows.Forms.RichTextBox();
            this.grpBoxOutput = new System.Windows.Forms.GroupBox();
            this.chkBoxNullTerm = new System.Windows.Forms.CheckBox();
            this.grpBoxInput.SuspendLayout();
            this.grpBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(7, 34);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(314, 20);
            this.txtBoxInput.TabIndex = 0;
            // 
            // txtBoxKey
            // 
            this.txtBoxKey.Location = new System.Drawing.Point(7, 73);
            this.txtBoxKey.Name = "txtBoxKey";
            this.txtBoxKey.Size = new System.Drawing.Size(314, 20);
            this.txtBoxKey.TabIndex = 1;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(7, 15);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(61, 13);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Input String";
            // 
            // lblXORKey
            // 
            this.lblXORKey.AutoSize = true;
            this.lblXORKey.Location = new System.Drawing.Point(7, 57);
            this.lblXORKey.Name = "lblXORKey";
            this.lblXORKey.Size = new System.Drawing.Size(25, 13);
            this.lblXORKey.TabIndex = 4;
            this.lblXORKey.Text = "Key";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(10, 16);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(28, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Text";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(6, 100);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "XOR";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnBitwiseAnd
            // 
            this.btnBitwiseAnd.Location = new System.Drawing.Point(87, 99);
            this.btnBitwiseAnd.Name = "btnBitwiseAnd";
            this.btnBitwiseAnd.Size = new System.Drawing.Size(75, 23);
            this.btnBitwiseAnd.TabIndex = 7;
            this.btnBitwiseAnd.Text = "Bitwise AND";
            this.btnBitwiseAnd.UseVisualStyleBackColor = true;
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(10, 55);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(26, 13);
            this.lblHex.TabIndex = 9;
            this.lblHex.Text = "Hex";
            // 
            // lblHexEsc
            // 
            this.lblHexEsc.AutoSize = true;
            this.lblHexEsc.Location = new System.Drawing.Point(10, 94);
            this.lblHexEsc.Name = "lblHexEsc";
            this.lblHexEsc.Size = new System.Drawing.Size(71, 13);
            this.lblHexEsc.TabIndex = 11;
            this.lblHexEsc.Text = "Hex Escaped";
            // 
            // btnBitwiseOr
            // 
            this.btnBitwiseOr.Location = new System.Drawing.Point(168, 99);
            this.btnBitwiseOr.Name = "btnBitwiseOr";
            this.btnBitwiseOr.Size = new System.Drawing.Size(75, 23);
            this.btnBitwiseOr.TabIndex = 12;
            this.btnBitwiseOr.Text = "Bitwise OR";
            this.btnBitwiseOr.UseVisualStyleBackColor = true;
            // 
            // txtBoxString
            // 
            this.txtBoxString.Location = new System.Drawing.Point(6, 32);
            this.txtBoxString.Name = "txtBoxString";
            this.txtBoxString.Size = new System.Drawing.Size(397, 20);
            this.txtBoxString.TabIndex = 13;
            // 
            // txtBoxHex
            // 
            this.txtBoxHex.Location = new System.Drawing.Point(6, 71);
            this.txtBoxHex.Name = "txtBoxHex";
            this.txtBoxHex.Size = new System.Drawing.Size(397, 20);
            this.txtBoxHex.TabIndex = 14;
            // 
            // txtBoxHexEsc
            // 
            this.txtBoxHexEsc.Location = new System.Drawing.Point(6, 110);
            this.txtBoxHexEsc.Name = "txtBoxHexEsc";
            this.txtBoxHexEsc.Size = new System.Drawing.Size(397, 20);
            this.txtBoxHexEsc.TabIndex = 15;
            // 
            // grpBoxInput
            // 
            this.grpBoxInput.Controls.Add(this.chkBoxNullTerm);
            this.grpBoxInput.Controls.Add(this.radBtnBin);
            this.grpBoxInput.Controls.Add(this.radBtnHex);
            this.grpBoxInput.Controls.Add(this.radBtnNum);
            this.grpBoxInput.Controls.Add(this.radBtnText);
            this.grpBoxInput.Controls.Add(this.btnExecute);
            this.grpBoxInput.Controls.Add(this.txtBoxInput);
            this.grpBoxInput.Controls.Add(this.txtBoxKey);
            this.grpBoxInput.Controls.Add(this.lblInput);
            this.grpBoxInput.Controls.Add(this.btnBitwiseOr);
            this.grpBoxInput.Controls.Add(this.lblXORKey);
            this.grpBoxInput.Controls.Add(this.btnBitwiseAnd);
            this.grpBoxInput.Location = new System.Drawing.Point(5, 3);
            this.grpBoxInput.Name = "grpBoxInput";
            this.grpBoxInput.Size = new System.Drawing.Size(408, 126);
            this.grpBoxInput.TabIndex = 16;
            this.grpBoxInput.TabStop = false;
            this.grpBoxInput.Text = "Input";
            this.grpBoxInput.Enter += new System.EventHandler(this.grpBoxInput_Enter);
            // 
            // radBtnBin
            // 
            this.radBtnBin.AutoSize = true;
            this.radBtnBin.Location = new System.Drawing.Point(327, 68);
            this.radBtnBin.Name = "radBtnBin";
            this.radBtnBin.Size = new System.Drawing.Size(54, 17);
            this.radBtnBin.TabIndex = 16;
            this.radBtnBin.TabStop = true;
            this.radBtnBin.Text = "Binary";
            this.radBtnBin.UseVisualStyleBackColor = true;
            // 
            // radBtnHex
            // 
            this.radBtnHex.AutoSize = true;
            this.radBtnHex.Location = new System.Drawing.Point(327, 51);
            this.radBtnHex.Name = "radBtnHex";
            this.radBtnHex.Size = new System.Drawing.Size(44, 17);
            this.radBtnHex.TabIndex = 15;
            this.radBtnHex.TabStop = true;
            this.radBtnHex.Text = "Hex";
            this.radBtnHex.UseVisualStyleBackColor = true;
            // 
            // radBtnNum
            // 
            this.radBtnNum.AutoSize = true;
            this.radBtnNum.Location = new System.Drawing.Point(327, 34);
            this.radBtnNum.Name = "radBtnNum";
            this.radBtnNum.Size = new System.Drawing.Size(64, 17);
            this.radBtnNum.TabIndex = 14;
            this.radBtnNum.Text = "Numeric";
            this.radBtnNum.UseVisualStyleBackColor = true;
            // 
            // radBtnText
            // 
            this.radBtnText.AutoSize = true;
            this.radBtnText.Checked = true;
            this.radBtnText.Location = new System.Drawing.Point(327, 18);
            this.radBtnText.Name = "radBtnText";
            this.radBtnText.Size = new System.Drawing.Size(46, 17);
            this.radBtnText.TabIndex = 13;
            this.radBtnText.TabStop = true;
            this.radBtnText.Text = "Text";
            this.radBtnText.UseVisualStyleBackColor = true;
            // 
            // txtBoxBinary
            // 
            this.txtBoxBinary.Location = new System.Drawing.Point(6, 149);
            this.txtBoxBinary.Name = "txtBoxBinary";
            this.txtBoxBinary.Size = new System.Drawing.Size(397, 20);
            this.txtBoxBinary.TabIndex = 18;
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Location = new System.Drawing.Point(9, 133);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(36, 13);
            this.lblBits.TabIndex = 17;
            this.lblBits.Text = "Binary";
            // 
            // rTxtBoxOutput
            // 
            this.rTxtBoxOutput.Location = new System.Drawing.Point(6, 203);
            this.rTxtBoxOutput.Name = "rTxtBoxOutput";
            this.rTxtBoxOutput.Size = new System.Drawing.Size(397, 96);
            this.rTxtBoxOutput.TabIndex = 19;
            this.rTxtBoxOutput.Text = "";
            // 
            // grpBoxOutput
            // 
            this.grpBoxOutput.Controls.Add(this.txtBoxString);
            this.grpBoxOutput.Controls.Add(this.rTxtBoxOutput);
            this.grpBoxOutput.Controls.Add(this.lblOutput);
            this.grpBoxOutput.Controls.Add(this.txtBoxBinary);
            this.grpBoxOutput.Controls.Add(this.lblHex);
            this.grpBoxOutput.Controls.Add(this.lblBits);
            this.grpBoxOutput.Controls.Add(this.lblHexEsc);
            this.grpBoxOutput.Controls.Add(this.txtBoxHex);
            this.grpBoxOutput.Controls.Add(this.txtBoxHexEsc);
            this.grpBoxOutput.Location = new System.Drawing.Point(5, 135);
            this.grpBoxOutput.Name = "grpBoxOutput";
            this.grpBoxOutput.Size = new System.Drawing.Size(408, 304);
            this.grpBoxOutput.TabIndex = 20;
            this.grpBoxOutput.TabStop = false;
            this.grpBoxOutput.Text = "Output";
            // 
            // chkBoxNullTerm
            // 
            this.chkBoxNullTerm.AutoSize = true;
            this.chkBoxNullTerm.Location = new System.Drawing.Point(327, 92);
            this.chkBoxNullTerm.Name = "chkBoxNullTerm";
            this.chkBoxNullTerm.Size = new System.Drawing.Size(71, 17);
            this.chkBoxNullTerm.TabIndex = 17;
            this.chkBoxNullTerm.Text = "Null Term";
            this.chkBoxNullTerm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 443);
            this.Controls.Add(this.grpBoxOutput);
            this.Controls.Add(this.grpBoxInput);
            this.Name = "Form1";
            this.Text = "Douggem\'s XOR tool";
            this.grpBoxInput.ResumeLayout(false);
            this.grpBoxInput.PerformLayout();
            this.grpBoxOutput.ResumeLayout(false);
            this.grpBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TextBox txtBoxKey;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblXORKey;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnBitwiseAnd;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblHexEsc;
        private System.Windows.Forms.Button btnBitwiseOr;
        private System.Windows.Forms.TextBox txtBoxString;
        private System.Windows.Forms.TextBox txtBoxHex;
        private System.Windows.Forms.TextBox txtBoxHexEsc;
        private System.Windows.Forms.GroupBox grpBoxInput;
        private System.Windows.Forms.TextBox txtBoxBinary;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.RadioButton radBtnNum;
        private System.Windows.Forms.RadioButton radBtnText;
        private System.Windows.Forms.RichTextBox rTxtBoxOutput;
        private System.Windows.Forms.RadioButton radBtnBin;
        private System.Windows.Forms.RadioButton radBtnHex;
        private System.Windows.Forms.GroupBox grpBoxOutput;
        private System.Windows.Forms.CheckBox chkBoxNullTerm;
    }
}

