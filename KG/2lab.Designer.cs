namespace WindowsFormsApplication1
{
    partial class _2lab
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
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
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(464, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 440);
            panel1.TabIndex = 0;
            // 
            // numericUpDownLineWidth
            // 
            numericUpDownLineWidth.Location = new Point(8, 143);
            numericUpDownLineWidth.Name = "numericUpDownLineWidth";
            numericUpDownLineWidth.Size = new Size(150, 27);
            numericUpDownLineWidth.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(8, 321);
            button4.Name = "button4";
            button4.Size = new Size(143, 31);
            button4.TabIndex = 4;
            button4.Text = "Цвет заливки";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(8, 358);
            button3.Name = "button3";
            button3.Size = new Size(143, 31);
            button3.TabIndex = 3;
            button3.Text = "Цвет линии";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(121, 395);
            button2.Name = "button2";
            button2.Size = new Size(111, 38);
            button2.TabIndex = 2;
            button2.Text = "Выполнить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 395);
            button1.Name = "button1";
            button1.Size = new Size(113, 38);
            button1.TabIndex = 1;
            button1.Text = "Очистить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(3, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 129);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите алгоритм";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(15, 86);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Заливка";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(133, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Обычный ЦДА";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(457, 440);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // _2lab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 449);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "_2lab";
            Text = "_2lab";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Button button4;
        private NumericUpDown numericUpDownLineWidth;
    }
}