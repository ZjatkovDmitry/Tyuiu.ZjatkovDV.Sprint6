using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ZjatkovDV.Sprint6.Task4.V9.Lib;

namespace Tyuiu.ZjatkovDV.Sprint6.Task4.V9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            Series series = new Series();

            series.ChartType = SeriesChartType.Line;

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V9.txt");

            if (new FileInfo(path).Exists)
            {
                File.Delete(path);
            }

            textBox1.AppendText("+----------+-------------+" + Environment.NewLine);
            textBox1.AppendText("|        X        |        F(x)        |" + Environment.NewLine);
            textBox1.AppendText("+----------+-------------+" + Environment.NewLine);

            string strLine;

            for (int i = 0; i < xValues.Length; i++)
            {
                strLine = String.Format("|     {0,5:d}        |    {1,5:f2}         |", xValues[i], resultValues[i]);
                textBox1.AppendText(strLine + Environment.NewLine);
                series.Points.AddXY(xValues[i], resultValues[i]);

                File.AppendAllText(path, resultValues[i] + "\n");
            }

            Chart mc = (Chart)groupBox2.Controls[0];
            mc.Series.Add(series);

            mc.ChartAreas[0].AxisX.Title = "Îñü Õ";
            mc.ChartAreas[0].AxisY.Title = "Îñü Ó";
            mc.Legends[0].Enabled = false;

            textBox1.AppendText("+----------+-------------+");
        }
    }
}
