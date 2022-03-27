namespace OOP7
{
    partial class OneOperationCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addRadio = new System.Windows.Forms.RadioButton();
            this.divideRadio = new System.Windows.Forms.RadioButton();
            this.multiplyRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "B=";
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(75, 59);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(125, 27);
            this.aBox.TabIndex = 2;
            this.aBox.TextChanged += new System.EventHandler(this.aBox_TextChanged);
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(75, 119);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(125, 27);
            this.bBox.TabIndex = 3;
            this.bBox.TextChanged += new System.EventHandler(this.bBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Данные для расчета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Результат расчета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y=";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(370, 94);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(309, 102);
            this.resultBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Выберите способ расчета";
            // 
            // addRadio
            // 
            this.addRadio.AutoSize = true;
            this.addRadio.Location = new System.Drawing.Point(46, 228);
            this.addRadio.Name = "addRadio";
            this.addRadio.Size = new System.Drawing.Size(77, 24);
            this.addRadio.TabIndex = 9;
            this.addRadio.TabStop = true;
            this.addRadio.Text = "Y=A+B";
            this.addRadio.UseVisualStyleBackColor = true;
            this.addRadio.CheckedChanged += new System.EventHandler(this.addRadio_CheckedChanged);
            // 
            // divideRadio
            // 
            this.divideRadio.AutoSize = true;
            this.divideRadio.Location = new System.Drawing.Point(46, 258);
            this.divideRadio.Name = "divideRadio";
            this.divideRadio.Size = new System.Drawing.Size(73, 24);
            this.divideRadio.TabIndex = 10;
            this.divideRadio.TabStop = true;
            this.divideRadio.Text = "Y=A/B";
            this.divideRadio.UseVisualStyleBackColor = true;
            this.divideRadio.CheckedChanged += new System.EventHandler(this.divideRadio_CheckedChanged);
            // 
            // multiplyRadio
            // 
            this.multiplyRadio.AutoSize = true;
            this.multiplyRadio.Location = new System.Drawing.Point(46, 288);
            this.multiplyRadio.Name = "multiplyRadio";
            this.multiplyRadio.Size = new System.Drawing.Size(73, 24);
            this.multiplyRadio.TabIndex = 11;
            this.multiplyRadio.TabStop = true;
            this.multiplyRadio.Text = "Y=A*B";
            this.multiplyRadio.UseVisualStyleBackColor = true;
            this.multiplyRadio.CheckedChanged += new System.EventHandler(this.multiplyRadio_CheckedChanged);
            // 
            // CurrentCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 322);
            this.Controls.Add(this.multiplyRadio);
            this.Controls.Add(this.divideRadio);
            this.Controls.Add(this.addRadio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CurrentCalculator";
            this.Text = "Задача 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox aBox;
        private TextBox bBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox resultBox;
        private Label label6;
        private RadioButton addRadio;
        private RadioButton divideRadio;
        private RadioButton multiplyRadio;
    }
}