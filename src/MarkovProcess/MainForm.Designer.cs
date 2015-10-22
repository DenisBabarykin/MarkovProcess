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
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSizeOk = new System.Windows.Forms.Button();
            this.edtRows = new System.Windows.Forms.TextBox();
            this.bntSolve = new System.Windows.Forms.Button();
            this.txtBxTime = new System.Windows.Forms.TextBox();
            this.chbxOscillation = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxEps = new System.Windows.Forms.TextBox();
            this.txtbxInertion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxDeltaTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblCDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tblCDS.Size = new System.Drawing.Size(390, 275);
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
            this.groupBox1.Controls.Add(this.btnRandom);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSizeOk);
            this.groupBox1.Controls.Add(this.edtRows);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры системы";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(25, 54);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(214, 26);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "Случайное заполнение";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
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
            this.bntSolve.Location = new System.Drawing.Point(12, 529);
            this.bntSolve.Name = "bntSolve";
            this.bntSolve.Size = new System.Drawing.Size(390, 33);
            this.bntSolve.TabIndex = 4;
            this.bntSolve.Text = "Рассчитать время";
            this.bntSolve.UseVisualStyleBackColor = true;
            this.bntSolve.Click += new System.EventHandler(this.bntSolve_Click);
            // 
            // txtBxTime
            // 
            this.txtBxTime.Location = new System.Drawing.Point(327, 502);
            this.txtBxTime.Name = "txtBxTime";
            this.txtBxTime.ReadOnly = true;
            this.txtBxTime.Size = new System.Drawing.Size(75, 20);
            this.txtBxTime.TabIndex = 6;
            // 
            // chbxOscillation
            // 
            this.chbxOscillation.AutoSize = true;
            this.chbxOscillation.Checked = true;
            this.chbxOscillation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxOscillation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxOscillation.Location = new System.Drawing.Point(12, 500);
            this.chbxOscillation.Name = "chbxOscillation";
            this.chbxOscillation.Size = new System.Drawing.Size(316, 23);
            this.chbxOscillation.TabIndex = 7;
            this.chbxOscillation.Text = "Время прихода в стационарное состояние:";
            this.chbxOscillation.UseVisualStyleBackColor = true;
            this.chbxOscillation.CheckedChanged += new System.EventHandler(this.chbxOscillation_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbxDeltaTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbxInertion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbxEps);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 109);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры итерационного процесса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Точность сравнения вещественных чисел:";
            // 
            // txtbxEps
            // 
            this.txtbxEps.Location = new System.Drawing.Point(321, 19);
            this.txtbxEps.Name = "txtbxEps";
            this.txtbxEps.Size = new System.Drawing.Size(54, 26);
            this.txtbxEps.TabIndex = 4;
            this.txtbxEps.Text = "0,001";
            // 
            // txtbxInertion
            // 
            this.txtbxInertion.Location = new System.Drawing.Point(321, 46);
            this.txtbxInertion.Name = "txtbxInertion";
            this.txtbxInertion.Size = new System.Drawing.Size(54, 26);
            this.txtbxInertion.TabIndex = 6;
            this.txtbxInertion.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Минимальный лимит успешных итераций:";
            // 
            // txtbxDeltaTime
            // 
            this.txtbxDeltaTime.Location = new System.Drawing.Point(321, 75);
            this.txtbxDeltaTime.Name = "txtbxDeltaTime";
            this.txtbxDeltaTime.Size = new System.Drawing.Size(54, 26);
            this.txtbxDeltaTime.TabIndex = 8;
            this.txtbxDeltaTime.Text = "0,0001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Приращение времени ∆t:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtBxTime);
            this.Controls.Add(this.chbxOscillation);
            this.Controls.Add(this.bntSolve);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tblCDS);
            this.Name = "MainForm";
            this.Text = "Моделирование марковского процесса";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblCDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSizeOk;
        private System.Windows.Forms.TextBox edtRows;
        private System.Windows.Forms.Button bntSolve;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBxTime;
        private System.Windows.Forms.CheckBox chbxOscillation;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbxInertion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxEps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxDeltaTime;
        private System.Windows.Forms.Label label4;
    }
}

