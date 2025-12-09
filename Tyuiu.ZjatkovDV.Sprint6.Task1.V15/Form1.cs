using Tyuiu.ZjatkovDV.Sprint6.Task1.V15.Lib;

namespace Tyuiu.ZjatkovDV.Sprint6.Task1.V15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var result = new DataService();
            int x1 = -5, x2 = 5;

            int[] xValues = new int[x2 - x1 + 1];
            double[] resultValues = result.GetMassFunction(x1, x2);

            int x3 = x1;
            for (int i = 0; i < xValues.Length; i++)
            {
                xValues[i] = x3;
                x3 += 1;
            }

            textBox1.AppendText("+----------+-------------+" + Environment.NewLine);
            textBox1.AppendText("|        X        |        F(x)        |" + Environment.NewLine);
            textBox1.AppendText("+----------+-------------+" + Environment.NewLine);
                                
            string strLine;

            for (int i = 0; i < xValues.Length; i++)
            {
                strLine = String.Format("|     {0,5:d}        |    {1,5:f2}         |", xValues[i], resultValues[i]);
                textBox1.AppendText(strLine + Environment.NewLine);
            }

            textBox1.AppendText("+----------+-------------+");
        }
    }
}
