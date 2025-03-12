using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KG
{
    public partial class Form3: Form
    {
        public TextBox[] VectorText; // массив текстовых полей для ввода вектора
        public int n; // размерность вектора

        public Form3()
        {
            InitializeComponent();
        }
        public Form3(int n)
        {
            InitializeComponent();
            this.n = n;
            VectorText = new TextBox[n];
            for (int i = 0; i < n; i++)
            {
                VectorText[i] = new TextBox();
                VectorText[i].Text = "0";
                VectorText[i].Location = new System.Drawing.Point(10, 10 + i * 30);
                VectorText[i].Size = new System.Drawing.Size(100, 20);
                this.Controls.Add(VectorText[i]);
            }
            this.Size = new System.Drawing.Size(150, 50 + n * 30);
        }
    }
}
