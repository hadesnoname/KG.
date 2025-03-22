namespace KG
{
    partial class Form4
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
            panel1 = new Panel();
            numericUpDownLineWidth = new NumericUpDown();
            btnCountour = new Button();
            btnColorFill = new Button();
            btnColorLine = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLineWidth).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(numericUpDownLineWidth);
            panel1.Controls.Add(btnCountour);
            panel1.Controls.Add(btnColorFill);
            panel1.Controls.Add(btnColorLine);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(638, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 447);
            panel1.TabIndex = 0;
            // 
            // numericUpDownLineWidth
            // 
            numericUpDownLineWidth.Location = new Point(119, 143);
            numericUpDownLineWidth.Name = "numericUpDownLineWidth";
            numericUpDownLineWidth.Size = new Size(143, 27);
            numericUpDownLineWidth.TabIndex = 6;
            // 
            // btnCountour
            // 
            btnCountour.Location = new Point(119, 321);
            btnCountour.Name = "btnCountour";
            btnCountour.Size = new Size(143, 31);
            btnCountour.TabIndex = 5;
            btnCountour.Text = "Обход контура";
            btnCountour.UseVisualStyleBackColor = true;
            btnCountour.Click += btnCountour_Click;
            // 
            // btnColorFill
            // 
            btnColorFill.Location = new Point(196, 358);
            btnColorFill.Name = "btnColorFill";
            btnColorFill.Size = new Size(143, 31);
            btnColorFill.TabIndex = 4;
            btnColorFill.Text = "Цвет заливки";
            btnColorFill.UseVisualStyleBackColor = true;
            btnColorFill.Click += btnColorFill_Click;
            // 
            // btnColorLine
            // 
            btnColorLine.Location = new Point(47, 358);
            btnColorLine.Name = "btnColorLine";
            btnColorLine.Size = new Size(143, 31);
            btnColorLine.TabIndex = 3;
            btnColorLine.Text = "Цвет линии";
            btnColorLine.UseVisualStyleBackColor = true;
            btnColorLine.Click += btnColorLine_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(119, 397);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 38);
            btnClear.TabIndex = 1;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(3, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 129);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите алгоритм";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(15, 70);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(334, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Построчный алгоритм заливки с затравкой";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(191, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Несимметричный ЦДА";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(631, 447);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 547);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Form4";
            Load += _2lab_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownLineWidth).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnColorLine;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private RadioButton radioButton2;
        private ColorDialog colorDialog2;
        private Button btnColorFill;
        private Button btnCountour;
        private NumericUpDown numericUpDownLineWidth;
    }
}