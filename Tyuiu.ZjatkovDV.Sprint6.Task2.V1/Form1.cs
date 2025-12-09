using Tyuiu.ZjatkovDV.Sprint6.Task2.V1.Lib;

namespace Tyuiu.ZjatkovDV.Sprint6.Task2.V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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

            string strLine;

            for (int i = 0; i < xValues.Length; i++)
            {
                dataGridView1.Rows.Add(xValues[i], resultValues[i]);
            }
        }
    }
}
