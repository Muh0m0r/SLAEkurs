using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace SLAEkurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal Solver Solver
        {
            get => default;
            set
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericEquationSize.Minimum = 2;
            numericEquationSize.Maximum = 10; //Change if needed
            comboMethod.Items.AddRange(new[] { "Метод Крамера", "LUP - метод", "Метод Гауса з вибором головного елементу" });
            comboMethod.SelectedIndex = 0;
            buttonGraph.Enabled = false;

            InitializeMatrixGrids((int)numericEquationSize.Value);
        }

        private void InitializeMatrixGrids(int n)
        {
            dataGridA.ColumnCount = n;
            dataGridA.RowCount = n;
            dataGridB.ColumnCount = 1;
            dataGridB.RowCount = n;

            dataGridB.Columns[0].HeaderText = "B";
            for (int i = 0; i < n; i++) 
            {
                dataGridA.Columns[i].HeaderText = $"x{i + 1}";
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)numericEquationSize.Value;

                // Валідація меж генерації
                if (!int.TryParse(textBoxMinRand.Text, out int minRand) ||
                    !int.TryParse(textBoxMaxRand.Text, out int maxRand))
                {
                    MessageBox.Show("Введіть ціле число для позначення меж генерації.");
                    return;
                }

                if (minRand < -1000 || maxRand > 1000 || minRand > maxRand)//Change if needed
                {
                    MessageBox.Show("Межі генерації повинні знаходитися в проміжку [-1000; 1000], де мінімум < максимум.");
                    return;
                }

                Random rnd = new Random();

                // Очистити старі дані та створити нову структуру
                dataGridA.Columns.Clear();
                dataGridA.Rows.Clear();
                dataGridB.Columns.Clear();
                dataGridB.Rows.Clear();

                // Створити стовпці
                for (int j = 0; j < n; j++)
                {
                    dataGridA.Columns.Add($"col{j}", $"x{j + 1}");
                }
                dataGridB.Columns.Add("colB", "b");

                // Додати рядки
                for (int i = 0; i < n; i++)
                {
                    dataGridA.Rows.Add();
                    dataGridB.Rows.Add();
                }

                // Заповнити рандомними значеннями
                for (int i = 0; i < n; i++)
                {
                    dataGridB.Rows[i].Cells[0].Value = rnd.Next(minRand, maxRand + 1);
                    for (int j = 0; j < n; j++)
                    {
                        dataGridA.Rows[i].Cells[j].Value = rnd.Next(minRand, maxRand + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час генерації: " + ex.Message);
            }
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)numericEquationSize.Value;
                double[,] A = new double[n, n];
                double[] b = new double[n];

                for (int i = 0; i < n; i++)
                {
                    if (dataGridB[0, i].Value == null || string.IsNullOrWhiteSpace(dataGridB[0, i].Value.ToString()))
                        throw new Exception($"Порожнє або некоректне значення у стовпці B, рядок {i + 1}");

                    b[i] = Convert.ToDouble(dataGridB[0, i].Value.ToString());

                    for (int j = 0; j < 2; j++)
                    {
                        if (dataGridA[j, i].Value == null || string.IsNullOrWhiteSpace(dataGridA[j, i].Value.ToString()))
                            throw new Exception($"Порожнє або некоректне значення у матриці A, рядок {i + 1}, стовпець {j + 1}");

                        A[i, j] = Convert.ToDouble(dataGridA[j, i].Value.ToString());
                    }
                }

                string method = comboMethod.SelectedItem?.ToString();

                double[] result = null;

                long before = GC.GetTotalMemory(true);
                Stopwatch sw = Stopwatch.StartNew();

                switch (method)
                {
                    case "Метод Крамера":
                        result = Solver.SolveCramer(A, b);
                        break;
                    case "Метод Гауса з вибором головного елементу":
                        result = Solver.SolveGauss(A, b);
                        break;
                    case "LUP - метод":
                        result = Solver.SolveLUP(A, b);
                        break;
                    default:
                        throw new Exception("Метод не обрано або невідомий.");
                }

                sw.Stop();
                long after = GC.GetTotalMemory(true);
                long memoryUsed = after - before;
                double elapsedMicrosec = sw.Elapsed.TotalMilliseconds * 1000;

                StringBuilder sb = new StringBuilder("Розв’язок:\n");
                for (int i = 0; i < result.Length; i++)
                {
                    sb.AppendLine($"x{i + 1} = {result[i]:F4}");
                }

                labelResult.Text = sb.ToString();
                labelComplexity.Text = $"Час виконання: {elapsedMicrosec:F0} мкс\n Використано пам'яті: {memoryUsed} байт";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, labelResult.Text);
                MessageBox.Show("Результат збережено.");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridA.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Value = "0";

            foreach (DataGridViewRow row in dataGridB.Rows)
                row.Cells[0].Value = "0";

            labelResult.Text="Тут буде ваш результат.";
            labelComplexity.Text = "Тут буде практична складність алгоритму.";
            chartGraph.Series.Clear();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)numericEquationSize.Value;
                if (n != 2)
                {
                    MessageBox.Show("Графічний метод доступний лише для системи 2x2.");
                    return;
                }

                double[,] A = new double[2, 2];
                double[] b = new double[2];

                for (int i = 0; i < 2; i++)
                {
                    if (dataGridB[0, i].Value == null || string.IsNullOrWhiteSpace(dataGridB[0, i].Value.ToString()))
                        throw new Exception($"Порожнє або некоректне значення у стовпці B, рядок {i + 1}");

                    b[i] = Convert.ToDouble(dataGridB[0, i].Value.ToString());

                    for (int j = 0; j < 2; j++)
                    {
                        if (dataGridA[j, i].Value == null || string.IsNullOrWhiteSpace(dataGridA[j, i].Value.ToString()))
                            throw new Exception($"Порожнє або некоректне значення у матриці A, рядок {i + 1}, стовпець {j + 1}");

                        A[i, j] = Convert.ToDouble(dataGridA[j, i].Value.ToString());
                    }
                }

                double[] result = Solver.SolveCramer(A, b);

                BuildGraph(A, b, result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка побудови графіка: " + ex.Message);
            }
        }

        private void BuildGraph(double[,] A, double[] b, double[] solution)
        {
            chartGraph.Series.Clear();
            chartGraph.ChartAreas.Clear();
            chartGraph.ChartAreas.Add(new ChartArea("MainArea"));

            AddLine("Пряма 1", A[0, 0], A[0, 1], b[0], Color.Blue);
            AddLine("Пряма 2", A[1, 0], A[1, 1], b[1], Color.Red);

            if (solution != null)
            {
                Series point = new Series("Точка перетину")
                {
                    ChartType = SeriesChartType.Point,
                    Color = Color.Black,
                    MarkerSize = 8
                };
                point.Points.AddXY(solution[0], solution[1]);
                chartGraph.Series.Add(point);
            }
        }

        private void AddLine(string name, double a, double b, double c, Color color)
        {
            Series series = new Series(name)
            {
                ChartType = SeriesChartType.Line,
                Color = color
            };

            double x1 = -10, x2 = 10;
            double y1 = (c - a * x1) / b;
            double y2 = (c - a * x2) / b;

            series.Points.AddXY(x1, y1);
            series.Points.AddXY(x2, y2);

            chartGraph.Series.Add(series);
        }

        private void numericEquationSize_ValueChanged(object sender, EventArgs e)
        {

            buttonGraph.Enabled = ((int)numericEquationSize.Value == 2);
            InitializeMatrixGrids((int)numericEquationSize.Value);
        }
    }
}
