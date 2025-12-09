using Tyuiu.ZjatkovDV.Sprint6.Task0.V29.Lib;

namespace Tyuiu.ZjatkovDV.Sprint6.Task0.V29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = new DataService().Calculate(3).ToString();
        }
    }
}
