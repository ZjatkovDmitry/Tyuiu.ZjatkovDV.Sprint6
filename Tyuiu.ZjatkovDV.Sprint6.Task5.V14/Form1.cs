using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ZjatkovDV.Sprint6.Task5.V14.Lib;

namespace Tyuiu.ZjatkovDV.Sprint6.Task5.V14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var result = new DataService();

            double[] resultValues = result.LoadFromDataFile("C:\\DataSprint6\\InPutFileTask5V14.txt");

            Series series = new Series();

            series.ChartType = SeriesChartType.Line;

            for (int i = 0; i < resultValues.Length; i++)
            {
                dataGridView1.Rows.Add(resultValues[i]);
                series.Points.AddXY(i+1, resultValues[i]);
            }

            Chart mc = (Chart)groupBox2.Controls[0];
            mc.Series.Add(series);

            mc.Legends[0].Enabled = false;

        }
    }
}
