namespace SvetMill
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView5 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView6 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView7 = new DevExpress.XtraCharts.LineSeriesView();
            this.LoadPipesBut = new System.Windows.Forms.Button();
            this.PipeListDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApplyAreaSearchBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StepNum = new System.Windows.Forms.NumericUpDown();
            this.StartIDNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ApplyOffsetBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RightOffsetNum = new System.Windows.Forms.NumericUpDown();
            this.LeftOffsetNum = new System.Windows.Forms.NumericUpDown();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SvetMill.WaitForm2), true, true);
            this.PipeChart = new DevExpress.XtraCharts.ChartControl();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PipeListDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartIDNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightOffsetNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftOffsetNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadPipesBut
            // 
            this.LoadPipesBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadPipesBut.Location = new System.Drawing.Point(33, 674);
            this.LoadPipesBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadPipesBut.Name = "LoadPipesBut";
            this.LoadPipesBut.Size = new System.Drawing.Size(178, 28);
            this.LoadPipesBut.TabIndex = 0;
            this.LoadPipesBut.Text = "Загрузить трубы";
            this.LoadPipesBut.UseVisualStyleBackColor = true;
            this.LoadPipesBut.Click += new System.EventHandler(this.LoadPipesBut_Click);
            // 
            // PipeListDGV
            // 
            this.PipeListDGV.AllowUserToDeleteRows = false;
            this.PipeListDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PipeListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PipeListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PipeListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.PipeListDGV.Location = new System.Drawing.Point(10, 15);
            this.PipeListDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PipeListDGV.Name = "PipeListDGV";
            this.PipeListDGV.ReadOnly = true;
            this.PipeListDGV.RowHeadersVisible = false;
            this.PipeListDGV.RowHeadersWidth = 51;
            this.PipeListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PipeListDGV.Size = new System.Drawing.Size(300, 620);
            this.PipeListDGV.TabIndex = 3;
            this.PipeListDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PipeListDGV_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.ApplyAreaSearchBut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StepNum);
            this.groupBox1.Controls.Add(this.StartIDNum);
            this.groupBox1.Location = new System.Drawing.Point(276, 642);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(597, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Область поиска";
            // 
            // ApplyAreaSearchBut
            // 
            this.ApplyAreaSearchBut.Location = new System.Drawing.Point(469, 32);
            this.ApplyAreaSearchBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ApplyAreaSearchBut.Name = "ApplyAreaSearchBut";
            this.ApplyAreaSearchBut.Size = new System.Drawing.Size(115, 28);
            this.ApplyAreaSearchBut.TabIndex = 6;
            this.ApplyAreaSearchBut.Text = "Применить";
            this.ApplyAreaSearchBut.UseVisualStyleBackColor = true;
            this.ApplyAreaSearchBut.Click += new System.EventHandler(this.ApplyAreaSearchBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шаг:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начальный ID:";
            // 
            // StepNum
            // 
            this.StepNum.Location = new System.Drawing.Point(306, 34);
            this.StepNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StepNum.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.StepNum.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.StepNum.Name = "StepNum";
            this.StepNum.Size = new System.Drawing.Size(140, 23);
            this.StepNum.TabIndex = 1;
            this.StepNum.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // StartIDNum
            // 
            this.StartIDNum.Location = new System.Drawing.Point(115, 34);
            this.StartIDNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartIDNum.Maximum = new decimal(new int[] {
            34000000,
            0,
            0,
            0});
            this.StartIDNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartIDNum.Name = "StartIDNum";
            this.StartIDNum.Size = new System.Drawing.Size(140, 23);
            this.StartIDNum.TabIndex = 0;
            this.StartIDNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.ApplyOffsetBut);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.RightOffsetNum);
            this.groupBox2.Controls.Add(this.LeftOffsetNum);
            this.groupBox2.Location = new System.Drawing.Point(881, 642);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(659, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выравнивание графиков";
            // 
            // ApplyOffsetBut
            // 
            this.ApplyOffsetBut.Location = new System.Drawing.Point(532, 32);
            this.ApplyOffsetBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ApplyOffsetBut.Name = "ApplyOffsetBut";
            this.ApplyOffsetBut.Size = new System.Drawing.Size(115, 28);
            this.ApplyOffsetBut.TabIndex = 11;
            this.ApplyOffsetBut.Text = "Применить";
            this.ApplyOffsetBut.UseVisualStyleBackColor = true;
            this.ApplyOffsetBut.Click += new System.EventHandler(this.ApplyOffsetBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Правый сдвиг:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Левый сдвиг:";
            // 
            // RightOffsetNum
            // 
            this.RightOffsetNum.Location = new System.Drawing.Point(371, 34);
            this.RightOffsetNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RightOffsetNum.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.RightOffsetNum.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.RightOffsetNum.Name = "RightOffsetNum";
            this.RightOffsetNum.Size = new System.Drawing.Size(140, 23);
            this.RightOffsetNum.TabIndex = 8;
            this.RightOffsetNum.TabStop = false;
            this.RightOffsetNum.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // LeftOffsetNum
            // 
            this.LeftOffsetNum.Location = new System.Drawing.Point(107, 34);
            this.LeftOffsetNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LeftOffsetNum.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.LeftOffsetNum.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.LeftOffsetNum.Name = "LeftOffsetNum";
            this.LeftOffsetNum.Size = new System.Drawing.Size(140, 23);
            this.LeftOffsetNum.TabIndex = 7;
            this.LeftOffsetNum.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // PipeChart
            // 
            this.PipeChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            xyDiagram1.EnableAxisYScrolling = true;
            xyDiagram1.EnableAxisYZooming = true;
            this.PipeChart.Diagram = xyDiagram1;
            this.PipeChart.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBox;
            this.PipeChart.Location = new System.Drawing.Point(316, 15);
            this.PipeChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PipeChart.Name = "PipeChart";
            series1.Name = "Клеть 1";
            series1.View = lineSeriesView1;
            series2.Name = "Клеть 2";
            series2.View = lineSeriesView2;
            series3.Name = "Клеть 3";
            series3.View = lineSeriesView3;
            series4.Name = "Клеть 4";
            series4.View = lineSeriesView4;
            series5.Name = "Клеть 5";
            series5.View = lineSeriesView5;
            series6.Name = "Клеть 6";
            series6.View = lineSeriesView6;
            series7.Name = "Клеть 7";
            series7.View = lineSeriesView7;
            this.PipeChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4,
        series5,
        series6,
        series7};
            this.PipeChart.Size = new System.Drawing.Size(1223, 620);
            this.PipeChart.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID трубы";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Номер партии";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 735);
            this.Controls.Add(this.PipeChart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PipeListDGV);
            this.Controls.Add(this.LoadPipesBut);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PipeListDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartIDNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightOffsetNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftOffsetNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadPipesBut;
        private System.Windows.Forms.DataGridView PipeListDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ApplyAreaSearchBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown StepNum;
        private System.Windows.Forms.NumericUpDown StartIDNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ApplyOffsetBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RightOffsetNum;
        private System.Windows.Forms.NumericUpDown LeftOffsetNum;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraCharts.ChartControl PipeChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

