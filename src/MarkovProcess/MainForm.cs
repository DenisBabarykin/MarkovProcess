using GaussNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarkovProcess
{
    public partial class MainForm : Form
    {
        int MatrixSize { get; set; }
        double[,] Matr { get; set; }
        double[] FinalProbs { get; set; }

        public MainForm()
        {
            InitializeComponent();

            MatrixSize = 0;
            MatrixSize = 0;
        }

        private void btnSizeOk_Click(object sender, EventArgs e)
        {
            try
            {
                MatrixSize = int.Parse(edtRows.Text);
                tblCDS.ColumnCount = MatrixSize;
                tblCDS.RowCount = MatrixSize;

                for (int i = 0; i < MatrixSize; ++i)
                {
                    tblCDS.Columns[i].Name = "S" + (i + 1).ToString();
                    tblCDS.Columns[i].Width = 70;
                    tblCDS.Columns[i].DefaultCellStyle.Format = "F4";
                }

                for (int i = 0; i < MatrixSize; ++i)
                {
                    tblCDS.Rows[i].HeaderCell.Value = "S" + (i + 1).ToString();                    
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double GetCellValue(int i, int j)
        {
            double res;
            object val = tblCDS[j, i].Value;
            if (val == null)
                res = 0;
            else
                res = double.Parse(val.ToString());

            if (res < 0)
                throw new Exception("Интенсивность не может быть отрицательной");

            return res;
        }

        private void bntSolve_Click(object sender, EventArgs e)
        {
            try
            {
                Matr = new double[MatrixSize, MatrixSize];
                FinalProbs = new double[MatrixSize];

                for (int i = 0; i < MatrixSize - 1; ++i)
                {
                    FinalProbs[i] = 0;
                    for (int j = 0; j < MatrixSize; ++j)
                    {
                        Matr[i, i] -= GetCellValue(i, j);
                        Matr[MatrixSize - 1, j] = 1;
                    }
                    for (int k = 0; k < MatrixSize; ++k)
                        Matr[i, k] += GetCellValue(k, i);
                }
                FinalProbs[MatrixSize - 1] = 1;

                Gauss gauss = new Gauss(Matr, FinalProbs, MatrixSize);

                if (!gauss.Solve())
                    throw new Exception("Нет решений");

                for (int i = 0; i < MatrixSize; ++i)
                {
                    FinalProbs[i] = gauss.GetX(i);
                }

                tblCDS.RowCount = MatrixSize;
                tblCDS.Rows.Add(FinalProbs.Select(x => (object) x).ToArray());
                tblCDS.Rows[MatrixSize].HeaderCell.Value = "t";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < tblCDS.ColumnCount; ++j)
                for (int i = 0; i < MatrixSize; ++i)
                    tblCDS[j, i].Value = "";

        }


    }
}
