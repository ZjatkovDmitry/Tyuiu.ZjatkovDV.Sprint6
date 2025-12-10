using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Tyuiu.ZjatkovDV.Sprint6.Task7.V19.Lib;

namespace Tyuiu.ZjatkovDV.Sprint6.Task7.V19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialog1.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialog1.FileName = $"OutPutFileTask7.csv";
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Зятьков Д.В.\nГруппа ПИНб-25-1\n\nПрограмма разработа в рамках изучения языка C#\n\nТюменский индустриальный университет (c) 2025\nВысшая школа цифровых технологий (c) 2025\n\nВнутреннее имя: Tyuiu.ZjatkovDV.Sprint6.Task7.V19", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        int[,] dataToSave;

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                string[] lines = File.ReadAllLines(filePath);

                int rowCount = lines.Length;

                string[] firstLineValues = lines[0].Split(';');
                int colCount = firstLineValues.Length;

                int[,] matrix = new int[rowCount, colCount];

                for (int i = 0; i < rowCount; i++)
                {
                    string[] values = lines[i].Split(';');

                    for (int j = 0; j < colCount; j++)
                    {
                        if (int.TryParse(values[j], out int number))
                        {
                            matrix[i, j] = number;
                        }
                    }
                }

                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int col = 0; col < cols; col++)
                {
                    DataGridViewColumn column = new DataGridViewTextBoxColumn();
                    column.Name = $"Column{col}";
                    column.HeaderText = "";

                    dataGridViewIn.Columns.Add(column);
                }

                for (int row = 0; row < rows; row++)
                {
                    object[] rowData = new object[cols];

                    for (int col = 0; col < cols; col++)
                    {
                        rowData[col] = matrix[row, col];
                    }

                    dataGridViewIn.Rows.Add(rowData);
                }



                DataService result = new DataService();
                matrix = result.GetMatrix(filePath);

                rows = matrix.GetLength(0);
                cols = matrix.GetLength(1);

                for (int col = 0; col < cols; col++)
                {
                    DataGridViewColumn column = new DataGridViewTextBoxColumn();
                    column.Name = $"Column{col}";
                    column.HeaderText = "";

                    dataGridViewOut.Columns.Add(column);
                }

                for (int row = 0; row < rows; row++)
                {
                    object[] rowData = new object[cols];

                    for (int col = 0; col < cols; col++)
                    {
                        rowData[col] = matrix[row, col];
                    }

                    dataGridViewOut.Rows.Add(rowData);
                }

                dataToSave = matrix;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int rows = dataToSave.GetLength(0);
                int cols = dataToSave.GetLength(1);
                string filePath = saveFileDialog1.FileName;

                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    for (int i = 0; i < rows; i++)
                    {
                        string[] stringValues = new string[cols];

                        for (int j = 0; j < cols; j++)
                        {
                            stringValues[j] = dataToSave[i, j].ToString();
                        }

                        string line = string.Join(";", stringValues);

                        writer.WriteLine(line);
                    }
                }

                MessageBox.Show($"Матрица успешно сохранена в файл:\n{saveFileDialog1.FileName}",
                                "Сохранение завершено",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
