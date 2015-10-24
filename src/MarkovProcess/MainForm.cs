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
            if (val == null || val == "")
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

                ClearMatrix(Matr, MatrixSize, MatrixSize);
                ClearArray(FinalProbs);
                FinalProbs[MatrixSize - 1] = 1;

                for (int i = 0; i < MatrixSize; ++i)
                {
                    for (int j = 0; j < MatrixSize; ++j)
                        Matr[i, i] -= GetCellValue(i, j);

                    for (int j = 0; j < MatrixSize; ++j)
                        Matr[i, j] += GetCellValue(j, i);
                }

                double[,] A = (double[,])Matr.Clone();
                for (int i = 0; i < MatrixSize; ++i)
                    A[MatrixSize - 1, i] = 1;

                Gauss gauss = new Gauss(A, FinalProbs, MatrixSize);

                if (!gauss.Solve())
                    throw new Exception("Нет решений");

                for (int i = 0; i < MatrixSize; ++i)
                {
                    FinalProbs[i] = gauss.GetX(i);
                }

                tblCDS.RowCount = MatrixSize;
                tblCDS.Rows.Add(FinalProbs.Select(x => (object)x).ToArray());
                tblCDS.Rows[MatrixSize].HeaderCell.Value = "t";

                if (chbxOscillation.Checked)
                {
                    Compare.EPS = double.Parse(txtbxEps.Text);
                    SuccesIterationsLimit = double.Parse(txtbxInertion.Text);
                    DeltaT = double.Parse(txtbxDeltaTime.Text);
                    txtBxTime.Text = CalcOscillationTime().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        double SuccesIterationsLimit { get; set; }
        double DeltaT { get; set; }

        private double CalcOscillationTime()
        {
            double[] curProbs = new double[MatrixSize];
            double[] prevProbs = new double[MatrixSize];

            ClearArray(curProbs);
            curProbs[0] = 1;

            double t = 0, prevT = 0, resT = 0;
            int succesIterations = 0;
            do
            {
                for (t = prevT; !Compare.Equal(curProbs, FinalProbs); t += DeltaT)
                {
                    CalcProbabilities(DeltaT, curProbs, prevProbs);
                }
                if (succesIterations == 0)
                {
                    resT = t;
                    succesIterations++;
                }
                else if (t - prevT > 0.5 * DeltaT)
                {
                    resT = t;
                    succesIterations = 1;
                }
                else
                    succesIterations++;

                prevT = t + DeltaT;
            }
            while (succesIterations < SuccesIterationsLimit);

            return resT;
        }

        private void CalcProbabilities(double deltaT, double[] curProbs, double[] prevProbs)
        {
            prevProbs = (double[])curProbs.Clone();
            for (int i = 0; i < MatrixSize; ++i)
            {
                double densitySum = 0;
                for (int j = 0; j < MatrixSize; ++j)
                    densitySum += Matr[i, j] * prevProbs[j];
                curProbs[i] = prevProbs[i] + densitySum * deltaT;
            }
        }

        private void ClearMatrix(double[,] matrix, int rowCount, int colCount)
        {
            for (int i = 0; i < rowCount; ++i)
                for (int j = 0; j < colCount; ++j)
                    matrix[i, j] = 0;
        }

        private void ClearArray(double[] array)
        {
            for (int i = 0; i < array.Length; ++i)
                array[i] = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < tblCDS.ColumnCount; ++j)
                for (int i = 0; i < MatrixSize; ++i)
                    tblCDS[j, i].Value = "";

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnSizeOk_Click(this, new EventArgs());
        }

        private void chbxOscillation_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxOscillation.Checked)
            {
                txtBxTime.Enabled = true;
                groupBox2.Enabled = true;
            }
            else
            {
                txtBxTime.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            btnClear_Click(this, new EventArgs());
            Random rnd = new Random();
            for (int i = 0; i < MatrixSize; ++i)
                for (int j = 0; j < MatrixSize; ++j)
                {
                    int fill = rnd.Next(3);
                    if (fill == 0)
                        continue;
                    tblCDS[j, i].Value = rnd.Next(1, 8).ToString();
                }

        }


    }
}
