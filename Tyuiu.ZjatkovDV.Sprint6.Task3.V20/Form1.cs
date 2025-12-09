using Tyuiu.ZjatkovDV.Sprint6.Task3.V20.Lib;

namespace Tyuiu.ZjatkovDV.Sprint6.Task3.V20
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

            int[,] x = { { -14, 17, -19, 3, 2 }, { -4, -14, -19, -9, -1 }, { 1, 0, 13, 14, 8 }, { 13, 7, 8, -3, -15 }, { 2, -20, 12, -14, 4 } };

            x = result.Calculate(x);

            for (int i = 0; i < x.GetLength(0); i++)
            {
                dataGridView1.Rows.Add(x[i, 0], x[i, 1], x[i, 2], x[i, 3], x[i, 4]);
            }
        }
    }
}
