using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAEkurs
{
    internal class Solver
    {
        public static double[] SolveCramer(double[,] A, double[] b)
        {
            int n = b.Length;
            double detA = Determinant(A);
            if (Math.Abs(detA) < 1e-10)
                throw new Exception("Система не має єдиного розв’язку");

            double[] x = new double[n];
            for (int i = 0; i < n; i++)
            {
                double[,] Ai = ReplaceColumn(A, b, i);
                x[i] = Determinant(Ai) / detA;
            }
            return x;
        }

        private static double[,] ReplaceColumn(double[,] A, double[] b, int col)
        {
            int n = b.Length;
            double[,] result = (double[,])A.Clone();
            for (int i = 0; i < n; i++)
                result[i, col] = b[i];
            return result;
        }

        public static double Determinant(double[,] A)
        {
            int n = A.GetLength(0);
            double[,] copy = (double[,])A.Clone();
            double det = 1;

            for (int i = 0; i < n; i++)
            {
                int pivot = i;
                for (int j = i + 1; j < n; j++)
                    if (Math.Abs(copy[j, i]) > Math.Abs(copy[pivot, i])) pivot = j;

                if (Math.Abs(copy[pivot, i]) < 1e-10) return 0;

                if (pivot != i)
                {
                    for (int k = 0; k < n; k++)
                    {
                        double temp = copy[i, k];
                        copy[i, k] = copy[pivot, k];
                        copy[pivot, k] = temp;
                    }
                    det *= -1;
                }

                det *= copy[i, i];
                for (int j = i + 1; j < n; j++)
                {
                    double ratio = copy[j, i] / copy[i, i];
                    for (int k = i; k < n; k++)
                        copy[j, k] -= ratio * copy[i, k];
                }
            }
            return det;
        }

        public static double[] SolveGauss(double[,] A, double[] b)
        {
            int n = b.Length;
            double[,] a = (double[,])A.Clone(); // Копіюємо матрицю, щоб не змінювати оригінал
            double[] rhs = (double[])b.Clone();

            for (int k = 0; k < n - 1; k++)
            {
                // Знаходимо індекс головного елемента у k-му стовпці, починаючи з рядка k
                int maxIndex = k;
                double maxValue = Math.Abs(a[k, k]);

                for (int i = k + 1; i < n; i++)
                {
                    if (Math.Abs(a[i, k]) > maxValue)
                    {
                        maxValue = Math.Abs(a[i, k]);
                        maxIndex = i;
                    }
                }

                // Якщо головний елемент не на поточному рядку, міняємо рядки місцями
                if (maxIndex != k)
                {
                    for (int j = 0; j < n; j++)
                    {
                        double temp = a[k, j];
                        a[k, j] = a[maxIndex, j];
                        a[maxIndex, j] = temp;
                    }

                    double tmpB = rhs[k];
                    rhs[k] = rhs[maxIndex];
                    rhs[maxIndex] = tmpB;
                }

                // Перевірка на нульовий головний елемент (щоб уникнути ділення на нуль)
                if (Math.Abs(a[k, k]) < 1e-10)
                    throw new Exception("Система або підсистема вироджена, головний елемент дорівнює нулю.");

                // Елімінація (занулення елементів під головним)
                for (int i = k + 1; i < n; i++)
                {
                    double factor = a[i, k] / a[k, k];

                    for (int j = k; j < n; j++)
                    {
                        a[i, j] -= factor * a[k, j];
                    }

                    rhs[i] -= factor * rhs[k];
                }
            }

            // Зворотна підстановка
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < n; j++)
                {
                    sum += a[i, j] * x[j];
                }

                if (Math.Abs(a[i, i]) < 1e-15)
                    throw new Exception("Система вироджена, ділення на нуль.");

                x[i] = (rhs[i] - sum) / a[i, i];
            }

            return x;
        }
        public static double[] SolveLUP(double[,] A, double[] b)
        {
            int n = A.GetLength(0);
            int[] P;
            double[,] LU = LUPDecomposition(A, out P);

            // Forward substitution (Ly = Pb)
            double[] y = new double[n];
            for (int i = 0; i < n; i++)
            {
                y[i] = b[P[i]];
                for (int j = 0; j < i; j++)
                    y[i] -= LU[i, j] * y[j];
            }

            // Backward substitution (Ux = y)
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                x[i] = y[i];
                for (int j = i + 1; j < n; j++)
                    x[i] -= LU[i, j] * x[j];
                x[i] /= LU[i, i];
            }

            return x;
        }

        private static double[,] LUPDecomposition(double[,] A, out int[] P)
        {
            int n = A.GetLength(0);
            double[,] LU = (double[,])A.Clone();
            P = new int[n];

            for (int i = 0; i < n; i++)
                P[i] = i;

            for (int k = 0; k < n; k++)
            {
                // Пошук головного елемента
                double max = 0.0;
                int pivot = k;
                for (int i = k; i < n; i++)
                {
                    double val = Math.Abs(LU[i, k]);
                    if (val > max)
                    {
                        max = val;
                        pivot = i;
                    }
                }

                if (max < 1e-12)
                    throw new Exception("Матриця вироджена (немає оберненої матриці)");

                // Обмін рядків
                if (pivot != k)
                {
                    int tmp = P[k];
                    P[k] = P[pivot];
                    P[pivot] = tmp;

                    for (int j = 0; j < n; j++)
                    {
                        double temp = LU[k, j];
                        LU[k, j] = LU[pivot, j];
                        LU[pivot, j] = temp;
                    }
                }

                // Обчислення L та U
                for (int i = k + 1; i < n; i++)
                {
                    LU[i, k] /= LU[k, k];
                    for (int j = k + 1; j < n; j++)
                        LU[i, j] -= LU[i, k] * LU[k, j];
                }
            }

            return LU;
        }
    }
}
