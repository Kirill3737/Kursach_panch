using System;
using System.Windows.Forms;

namespace КурсачРпм
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int M;
        int N;

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            numericUpDown2_ValueChanged(sender, e);
        } 
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            N = dataGridView1.RowCount = dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            if (random_radioButton1.Checked) random_radioButton1_CheckedChange(sender, e);
            dataGridView3.DataSource = null;
        }
        
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
             M = dataGridView2.RowCount = dataGridView2.ColumnCount = (int)numericUpDown2.Value;
            if (random_radioButton2.Checked) random_radioButton2_CheckedChange(sender, e);
            dataGridView3.DataSource = null;

        }
        
        private void random_radioButton1_CheckedChange(object sender, EventArgs e) //Первая матрица
        {
            if(random_radioButton1.Checked)
            {
                Random ran = new Random();

                for (int i = 0; i < N; i++) 
                {
                    for(int j=0;j<N;j++)
                    {
                        dataGridView1[j, i].Value = Math.Round(ran.NextDouble() * (99 + 99) - 99, 1);
                    }
                }

                dataGridView1.ReadOnly = true;
            }

            if(manual_radioButton1.Checked)
            {
                for (int i = 0; i < N; i++) 
                {
                    for (int j = 0; j < N; j++)
                    {
                        dataGridView1[j, i].Value = null;
                    }
                }

                dataGridView1.ReadOnly = false;
            }

            dataGridView3.DataSource = null;
        }

        private void random_radioButton2_CheckedChange(object sender, EventArgs e) //Вторая матрица
        {
            if (random_radioButton2.Checked)
            {
                Random ran1 = new Random();

                for (int k = 0; k < N; k++)
                {
                    for (int l = 0; l < N; l++)
                    {
                        dataGridView2[l, k].Value = Math.Round(ran1.NextDouble() * (99 + 99) - 99, 1);
                    }
                }

                dataGridView2.ReadOnly = true;
            }

            if (manual_radioButton2.Checked)
            {
                for (int k = 0; k < N; k++)
                {
                    for (int l = 0; l < N; l++)
                    {
                        dataGridView2[l, k].Value = null;
                    }
                }

                dataGridView2.ReadOnly = false;
            }

            dataGridView3.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e) //кнопка вычислить
        {
            Matrix mx = new Matrix(N);

            try
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (dataGridView1[j, i].Value == null) dataGridView1[j, i].Value = 0;
                        mx[i, j] = Convert.ToDouble(dataGridView1[j, i].Value);
                    }
                }

                //label3.Text=$"Произведение матриц равно"
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Matrix1 mx1 = new Matrix1(M);

            //try
            //{
            //    for (int k = 0; k < M; k++)
            //    {
            //        for (int l = 0; l < M; l++)
            //        {
            //            if (dataGridView2[l, k].Value == null) dataGridView2[l, k].Value = 0;
            //            mx1[l, k] = Convert.ToDouble(dataGridView2[l, k].Value);
            //        }
            //    }
            //}

            //catch(Exception ex1)
            //{
            //    MessageBox.Show(ex1.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string t = ((TextBox)sender).Text;
            char a = e.KeyChar;

            e.Handled = !(char.IsDigit(a)|| a== ',' && !t.Contains(",")|| a == '-' && !t.Contains("-")|| a==(char)Keys.Back);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.DataSource = null;
        }


        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(dataGridView2_KeyPress);
        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string t = ((TextBox)sender).Text;
            char a = e.KeyChar;

            e.Handled = !(char.IsDigit(a) || a == ',' && !t.Contains(",") || a == '-' && !t.Contains("-") || a == (char)Keys.Back);
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.DataSource = null;
        }
    }

    class Matrix //первая матрица
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

            for(int i=0; i<N-1; i++)
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
    }

    class Matrix1 //Вторая матрица
    {
        readonly int M;
        readonly double[,] Data1;

        public Matrix1(int m)
        {
            M = m;
            Data1 = new double[M, M];
        }

        public double this[int x, int y]
        {
            get => Data1[x, y];
            set => Data1[x, y] = value;
        }

        Matrix1 Exclude1(int row, int col)
        {
            Matrix res1 = new Matrix(M);

            for (int k = 0; k < M - 1; k++)
            {
                for (int l = 0; l < M; l++)
                {
                    res1[k, l] = k < row ? this[k, l] : this[k + 1, l];
                }
            }

            for (int k = 0; k < M; k++)
            {
                for (int l = 0; l < M - 1; l++)
                {
                    res1[k, l] = l < col ? res1[k, l] : res1[k, l + 1];
                }
            }

            Matrix1 resized1 = new Matrix1(M - 1);

            for (int k = 0; k < M - 1; k++)
            {
                for (int l = 0; l < M - 1; l++)
                {
                    resized1[k, l] = res1[k, l];
                }
            }

            return resized1;
        }
    }
}
