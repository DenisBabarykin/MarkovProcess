namespace MarkovProcess
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblCDS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSizeOk = new System.Windows.Forms.Button();
            this.edtRows = new System.Windows.Forms.TextBox();
            this.bntSolve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblCDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCDS
            // 
            this.tblCDS.AllowUserToAddRows = false;
            this.tblCDS.AllowUserToDeleteRows = false;
            this.tblCDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tblCDS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.tblCDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCDS.Location = new System.Drawing.Point(12, 12);
            this.tblCDS.Name = "tblCDS";
            this.tblCDS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tblCDS.Size = new System.Drawing.Size(390, 349);
            this.tblCDS.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество состояний:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSizeOk);
            this.groupBox1.Controls.Add(this.edtRows);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер матрицы";
            // 
            // btnSizeOk
            // 
            this.btnSizeOk.Location = new System.Drawing.Point(264, 22);
            this.btnSizeOk.Name = "btnSizeOk";
            this.btnSizeOk.Size = new System.Drawing.Size(119, 26);
            this.btnSizeOk.TabIndex = 5;
            this.btnSizeOk.Text = "Сформировать";
            this.btnSizeOk.UseVisualStyleBackColor = true;
            this.btnSizeOk.Click += new System.EventHandler(this.btnSizeOk_Click);
            // 
            // edtRows
            // 
            this.edtRows.Location = new System.Drawing.Point(194, 22);
            this.edtRows.Name = "edtRows";
            this.edtRows.Size = new System.Drawing.Size(45, 26);
            this.edtRows.TabIndex = 3;
            this.edtRows.Text = "4";
            // 
            // bntSolve
            // 
            this.bntSolve.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntSolve.Location = new System.Drawing.Point(12, 480);
            this.bntSolve.Name = "bntSolve";
            this.bntSolve.Size = new System.Drawing.Size(390, 33);
            this.bntSolve.TabIndex = 4;
            this.bntSolve.Text = "Рассчитать время";
            this.bntSolve.UseVisualStyleBackColor = true;
            this.bntSolve.Click += new System.EventHandler(this.bntSolve_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(264, 54);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 26);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 525);
            this.Controls.Add(this.bntSolve);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tblCDS);
            this.Name = "MainForm";
            this.Text = "Моделирование марковского процесса";
            ((System.ComponentModel.ISupportInitialize)(this.tblCDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblCDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSizeOk;
        private System.Windows.Forms.TextBox edtRows;
        private System.Windows.Forms.Button bntSolve;
        private System.Windows.Forms.Button btnClear;
    }
}

