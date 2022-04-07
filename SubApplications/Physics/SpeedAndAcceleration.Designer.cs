namespace OOP7
{
    partial class SpeedAndAcceleration
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
            this.speedBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accelerationBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultSpeedBox = new System.Windows.Forms.TextBox();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходные данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Начальная скорость";
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(208, 80);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(129, 27);
            this.speedBox.TabIndex = 2;
            this.speedBox.TextChanged += new System.EventHandler(this.speedBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ускорение";
            // 
            // accelerationBox
            // 
            this.accelerationBox.Location = new System.Drawing.Point(208, 113);
            this.accelerationBox.Name = "accelerationBox";
            this.accelerationBox.Size = new System.Drawing.Size(129, 27);
            this.accelerationBox.TabIndex = 4;
            this.accelerationBox.TextChanged += new System.EventHandler(this.accelerationBox_TextChanged);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(208, 146);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(129, 27);
            this.timeBox.TabIndex = 5;
            this.timeBox.TextChanged += new System.EventHandler(this.timeBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Время";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Результаты расчетов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Конечная скорость";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Расстояние";
            // 
            // resultSpeedBox
            // 
            this.resultSpeedBox.Location = new System.Drawing.Point(605, 76);
            this.resultSpeedBox.Name = "resultSpeedBox";
            this.resultSpeedBox.ReadOnly = true;
            this.resultSpeedBox.Size = new System.Drawing.Size(129, 27);
            this.resultSpeedBox.TabIndex = 10;
            // 
            // distanceBox
            // 
            this.distanceBox.Location = new System.Drawing.Point(605, 150);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.ReadOnly = true;
            this.distanceBox.Size = new System.Drawing.Size(129, 27);
            this.distanceBox.TabIndex = 11;
            // 
            // Moving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 218);
            this.Controls.Add(this.distanceBox);
            this.Controls.Add(this.resultSpeedBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.accelerationBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Moving";
            this.Text = "Задача 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox speedBox;
        private Label label3;
        private TextBox accelerationBox;
        private TextBox timeBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox resultSpeedBox;
        private TextBox distanceBox;
    }
}