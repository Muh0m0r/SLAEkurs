namespace SLAEkurs
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridA = new System.Windows.Forms.DataGridView();
            this.dataGridB = new System.Windows.Forms.DataGridView();
            this.numericEquationSize = new System.Windows.Forms.NumericUpDown();
            this.comboMethod = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelEquationSize = new System.Windows.Forms.Label();
            this.labelMethod = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxMinRand = new System.Windows.Forms.TextBox();
            this.textBoxMaxRand = new System.Windows.Forms.TextBox();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelComplexity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEquationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridA
            // 
            this.dataGridA.AllowUserToAddRows = false;
            this.dataGridA.AllowUserToDeleteRows = false;
            this.dataGridA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridA.Location = new System.Drawing.Point(3, 3);
            this.dataGridA.Name = "dataGridA";
            this.dataGridA.Size = new System.Drawing.Size(1092, 719);
            this.dataGridA.TabIndex = 0;
            // 
            // dataGridB
            // 
            this.dataGridB.AllowUserToAddRows = false;
            this.dataGridB.AllowUserToDeleteRows = false;
            this.dataGridB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridB.Location = new System.Drawing.Point(1101, 3);
            this.dataGridB.Name = "dataGridB";
            this.dataGridB.Size = new System.Drawing.Size(360, 719);
            this.dataGridB.TabIndex = 1;
            // 
            // numericEquationSize
            // 
            this.numericEquationSize.Location = new System.Drawing.Point(12, 40);
            this.numericEquationSize.Name = "numericEquationSize";
            this.numericEquationSize.Size = new System.Drawing.Size(120, 20);
            this.numericEquationSize.TabIndex = 2;
            this.numericEquationSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericEquationSize.ValueChanged += new System.EventHandler(this.numericEquationSize_ValueChanged);
            // 
            // comboMethod
            // 
            this.comboMethod.FormattingEnabled = true;
            this.comboMethod.Location = new System.Drawing.Point(226, 40);
            this.comboMethod.Name = "comboMethod";
            this.comboMethod.Size = new System.Drawing.Size(263, 21);
            this.comboMethod.TabIndex = 3;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Location = new System.Drawing.Point(1763, 900);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(80, 25);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Згенерувати";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonSolve
            // 
            this.buttonSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSolve.Location = new System.Drawing.Point(1669, 900);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(80, 25);
            this.buttonSolve.TabIndex = 5;
            this.buttonSolve.Text = "Розв\'язати";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(1763, 931);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 25);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(1669, 931);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 25);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelEquationSize
            // 
            this.labelEquationSize.AutoSize = true;
            this.labelEquationSize.Location = new System.Drawing.Point(9, 9);
            this.labelEquationSize.Name = "labelEquationSize";
            this.labelEquationSize.Size = new System.Drawing.Size(91, 13);
            this.labelEquationSize.TabIndex = 8;
            this.labelEquationSize.Text = "Розмір системи:";
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(223, 9);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(94, 13);
            this.labelMethod.TabIndex = 9;
            this.labelMethod.Text = "Метод розв\'язку:";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 870);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(129, 13);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "Тут буде ваш розв\'язок.";
            // 
            // textBoxMinRand
            // 
            this.textBoxMinRand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMinRand.Location = new System.Drawing.Point(1743, 41);
            this.textBoxMinRand.Name = "textBoxMinRand";
            this.textBoxMinRand.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinRand.TabIndex = 11;
            this.textBoxMinRand.Text = "-50";
            // 
            // textBoxMaxRand
            // 
            this.textBoxMaxRand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMaxRand.Location = new System.Drawing.Point(1743, 79);
            this.textBoxMaxRand.Name = "textBoxMaxRand";
            this.textBoxMaxRand.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxRand.TabIndex = 12;
            this.textBoxMaxRand.Text = "50";
            // 
            // buttonGraph
            // 
            this.buttonGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGraph.Location = new System.Drawing.Point(1714, 962);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(80, 47);
            this.buttonGraph.TabIndex = 13;
            this.buttonGraph.Text = "Побудувати графік";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // chartGraph
            // 
            this.chartGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartGraph.Legends.Add(legend3);
            this.chartGraph.Location = new System.Drawing.Point(1467, 3);
            this.chartGraph.Name = "chartGraph";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartGraph.Series.Add(series3);
            this.chartGraph.Size = new System.Drawing.Size(361, 719);
            this.chartGraph.TabIndex = 14;
            this.chartGraph.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartGraph, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridB, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 114);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1831, 725);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // labelComplexity
            // 
            this.labelComplexity.AutoSize = true;
            this.labelComplexity.Location = new System.Drawing.Point(549, 870);
            this.labelComplexity.Name = "labelComplexity";
            this.labelComplexity.Size = new System.Drawing.Size(279, 13);
            this.labelComplexity.TabIndex = 16;
            this.labelComplexity.Text = "Тут буде практична складність виконання алгоритму.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1590, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Мінімальна межа генерації:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1576, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Максимальна межа генерації:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelComplexity);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.textBoxMaxRand);
            this.Controls.Add(this.textBoxMinRand);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.labelEquationSize);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.comboMethod);
            this.Controls.Add(this.numericEquationSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEquationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridA;
        private System.Windows.Forms.DataGridView dataGridB;
        private System.Windows.Forms.NumericUpDown numericEquationSize;
        private System.Windows.Forms.ComboBox comboMethod;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelEquationSize;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxMinRand;
        private System.Windows.Forms.TextBox textBoxMaxRand;
        private System.Windows.Forms.Button buttonGraph;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelComplexity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

