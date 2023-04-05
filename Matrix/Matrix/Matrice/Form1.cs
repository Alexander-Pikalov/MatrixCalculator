using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Matrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            int.TryParse(textBox1.Text, out n);
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Columns[j].Width = 60;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int.TryParse(textBox1.Text, out n);
                dataGridView3.RowCount = n;
                dataGridView3.ColumnCount = n;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dataGridView3[i, j].Value = dataGridView1[j, i].Value;
                        if (j == n - 1)
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите матрицу");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n;
            int.TryParse(textBox2.Text, out n);
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView2.Columns[j].Width = 60;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int.TryParse(textBox2.Text, out n);
                dataGridView3.RowCount = n;
                dataGridView3.ColumnCount = n;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dataGridView3[i, j].Value = dataGridView2[j, i].Value;
                        if (j == n - 1)
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите матрицу");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.RowCount;
            int m = dataGridView1.ColumnCount;
            int x = int.Parse(textBox3.Text);
            dataGridView3.RowCount = n;
            dataGridView3.ColumnCount = m;
            int[,] a = new int[n, m];
            int[,] c = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    c[i, j] = a[i, j] * x;
                    dataGridView3[i, j].Value = c[i, j];
                }


        }
        private void button6_Click(object sender, EventArgs e)
        {
            int n = dataGridView2.RowCount;
            int m = dataGridView2.ColumnCount;
            int x = int.Parse(textBox4.Text);
            dataGridView3.RowCount = n;
            dataGridView3.ColumnCount = m;
            int[,] a = new int[n, m];
            int[,] c = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = Convert.ToInt32(dataGridView2[i, j].Value);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    c[i, j] = a[i, j] * x;
                    dataGridView3[i, j].Value = c[i, j];
                }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == textBox2.Text)
                {
                    int n;
                    int.TryParse(textBox2.Text, out n);
                    dataGridView3.RowCount = n;
                    dataGridView3.ColumnCount = n;
                    int[,] a = new int[n, n];
                    int[,] b = new int[n, n];
                    int[,] c = new int[n, n];
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            b[i, j] = Convert.ToInt32(dataGridView2[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                        {
                            c[i, j] = a[i, j] + b[i, j];
                            dataGridView3[i, j].Value = c[i, j];
                        }
                }
                else
                    MessageBox.Show("Складывать можно только матрицы одинакового размера");
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == textBox2.Text)
                {
                    int n;
                    int.TryParse(textBox2.Text, out n);
                    dataGridView3.RowCount = n;
                    dataGridView3.ColumnCount = n;
                    int[,] a = new int[n, n];
                    int[,] b = new int[n, n];
                    int[,] c = new int[n, n];
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            b[i, j] = Convert.ToInt32(dataGridView2[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                        {
                            c[i, j] = a[i, j] - b[i, j];
                            dataGridView3[i, j].Value = c[i, j];
                        }
                }
                else
                    MessageBox.Show("Ошибка", "Вычитать можно только матрицы одинакового размера");
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == textBox2.Text)
            {
                int n, v;
                int.TryParse(textBox2.Text, out n);
                dataGridView3.RowCount = n;
                dataGridView3.ColumnCount = n;
                int[,] a = new int[n, n];
                int[,] b = new int[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        a[j, i] = Convert.ToInt32(dataGridView1[i, j].Value);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        b[j, i] = Convert.ToInt32(dataGridView2[i, j].Value);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        v = 0;
                        for (int r = 0; r < n; r++)
                            v += a[i, r] * b[r, j];
                        dataGridView3[i, j].Value = v;

                    }
                }
            }

            else
                MessageBox.Show("Ошибка", "Умножать матрицы можно только когда количество столбцов первой матрицы равно количеству строк второй матрицы");
        }

        //private void button10_Click(object sender, EventArgs e)
        //{
        //    int.TryParse(textBox1.Text, out int n);
        //    dataGridView3.RowCount = n;
        //    dataGridView3.ColumnCount = n;
        //    int[,] a = new int[n, n];
        //    int[,] b = new int[n, n];
        //    for (int i = 0; i < n; i++)
        //        for (int j = 0; j < n; j++)
        //        {
        //            a[j, i] = Convert.ToInt32(dataGridView1[i, j].Value);
        //            b[i, j] = a[i, j];
        //        }
        //    int rang = 0;
        //    for (int i = 0; i < n; i++) 
        //        for (int j = 0; j < n; j++)
        //        {
        //            b[i, j] = b[i,j]*a[i, j] + b[i, j];
        //        }
        //    textBox5.Text = Convert.ToString(rang);
        //}

    }
}


