using WindowsFormsApplication1;

namespace KG
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _2lab lab2 = new _2lab();
            lab2.Show();
        }
    }
}