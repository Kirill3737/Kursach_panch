using System;
using System.Windows.Forms;

namespace Determinant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int N;

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            N = initial_DGV.RowCount = initial_DGV.ColumnCount = (int)numericUpDown1.Value;
            if (random_radioButton.Checked) random_radioButton_CheckedChanged(sender, e);

            label2.Text = string.Empty;
        }

        private void random_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (random_radioButton.Checked)
            {
                Random ran = new Random();

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        initial_DGV[j, i].Value = Math.Round(ran.NextDouble() * (99 + 99) - 99, 1);
                    }
                }

                initial_DGV.ReadOnly = true;
            }

            if (manual_radioButton.Checked)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        initial_DGV[j, i].Value = null;
                    }
                }

                initial_DGV.ReadOnly = false;
            }

            label2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrix mx = new Matrix(N);

            try
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (initial_DGV[j, i].Value == null) initial_DGV[j, i].Value = 0;
                        mx[i, j] = Convert.ToDouble(initial_DGV[j, i].Value);
                    }
                }

                label2.Text = $"Определитель = {mx.CalculateDeterminant()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void initial_DGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(initial_DGV_KeyPress);
        }

        private void initial_DGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            string t = ((TextBox)sender).Text;
            char k = e.KeyChar;

            e.Handled = !(char.IsDigit(k) || k == ',' && !t.Contains(",") || k == '-' && !t.Contains("-") || k == (char)Keys.Back);
        }

        private void initial_DGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = string.Empty;
        }
    }

    class Matrix
    {
        readonly int N;
        readonly double[,] Data;

        public Matrix(int n)
        {
            N = n;
            Data = new double[N, N];
        }

        public double this[int x, int y]
        {
            get => Data[x, y];
            set => Data[x, y] = value;
        }

        Matrix Exclude(int row, int col)
        {
            Matrix res = new Matrix(N);

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    res[i, j] = i < row ? this[i, j] : this[i + 1, j];
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    res[i, j] = j < col ? res[i, j] : res[i, j + 1];
                }
            }
             
            Matrix resized = new Matrix(N - 1);

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    resized[i, j] = res[i, j];
                }
            }

            return resized;
        }

        public double CalculateDeterminant()
        {
            if (N == 1) return this[0, 0];
            if (N == 2) return this[0, 0] * this[1, 1] - this[0, 1] * this[1, 0];

            double res = 0;

            for (int j = 0; j < N; j++)
            {
                res += (j % 2 == 1 ? 1 : -1) * this[1, j] * Exclude(1, j).CalculateDeterminant();
            }

            return res;
        }
    }
}