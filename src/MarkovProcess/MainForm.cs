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
        private int _rowCount;
        private int _colCount;
        private double[,] _s;
        private double[] _t;

        public MainForm()
        {
            InitializeComponent();

            _rowCount = 0;
            _colCount = 0;
        }

        private void btnSizeOk_Click(object sender, EventArgs e)
        {
            try
            {
                _rowCount = int.Parse(edtRows.Text);
                _colCount = int.Parse(edtRows.Text);
                _s = new double[_rowCount, _colCount];
                _t = new double[_colCount];

                tblCDS.ColumnCount = _colCount;
                tblCDS.RowCount = _rowCount;

                for (int i = 0; i < _colCount; ++i)
                {
                    tblCDS.Columns[i].Name = "S" + (i + 1).ToString();
                    tblCDS.Columns[i].Width = 70;
                    tblCDS.Columns[i].DefaultCellStyle.Format = "F4";
                }

                for (int i = 0; i < _rowCount; ++i)
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

            return res;
        }

        private void bntSolve_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < _rowCount - 1; ++i)
                {
                    _t[i] = 0;
                    for (int j = 0; j < _colCount; ++j)
                    {
                        _s[i, i] -= GetCellValue(i, j);
                        _s[_rowCount - 1, j] = 1;
                    }
                    for (int k = 0; k < _rowCount; ++k)
                        _s[i, k] += GetCellValue(k, i);
                }
                _t[_rowCount - 1] = 1;

                Gauss gs = new Gauss(_s, _t, _rowCount);
                if (!gs.Solve())
                    return;
                for (int i = 0; i < _colCount; ++i)
                {
                    _t[i] = gs.GetX(i);
                }

                tblCDS.RowCount = _rowCount;
                tblCDS.Rows.Add(_t.Select(x => (object) x).ToArray());
                tblCDS.Rows[_rowCount].HeaderCell.Value = "t";
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверная матрица переходов");
            }
        }


    }
}
