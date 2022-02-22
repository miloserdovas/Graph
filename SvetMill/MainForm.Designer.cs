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
            DevExpress.XtraCharts.XYDiagram xyDiagram4 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series22 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView22 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series23 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView23 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series24 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView24 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series25 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView25 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series26 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView26 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series27 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView27 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series28 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView28 = new DevExpress.XtraCharts.LineSeriesView();
            this.LoadPipesBut = new System.Windows.Forms.Button();
            this.PipeListDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.PipeListDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartIDNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightOffsetNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftOffsetNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView28)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadPipesBut
            // 
            this.LoadPipesBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadPipesBut.Location = new System.Drawing.Point(28, 548);
            this.LoadPipesBut.Name = "LoadPipesBut";
            this.LoadPipesBut.Size = new System.Drawing.Size(153, 23);
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
            this.Column2});
            this.PipeListDGV.Location = new System.Drawing.Point(9, 12);
            this.PipeListDGV.Name = "PipeListDGV";
            this.PipeListDGV.ReadOnly = true;
            this.PipeListDGV.RowHeadersVisible = false;
            this.PipeListDGV.RowHeadersWidth = 51;
            this.PipeListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PipeListDGV.Size = new System.Drawing.Size(186, 504);
            this.PipeListDGV.TabIndex = 3;
            this.PipeListDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PipeListDGV_RowEnter);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.ApplyAreaSearchBut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StepNum);
            this.groupBox1.Controls.Add(this.StartIDNum);
            this.groupBox1.Location = new System.Drawing.Point(237, 522);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Область поиска";
            // 
            // ApplyAreaSearchBut
            // 
            this.ApplyAreaSearchBut.Location = new System.Drawing.Point(402, 26);
            this.ApplyAreaSearchBut.Name = "ApplyAreaSearchBut";
            this.ApplyAreaSearchBut.Size = new System.Drawing.Size(99, 23);
            this.ApplyAreaSearchBut.TabIndex = 6;
            this.ApplyAreaSearchBut.Text = "Применить";
            this.ApplyAreaSearchBut.UseVisualStyleBackColor = true;
            this.ApplyAreaSearchBut.Click += new System.EventHandler(this.ApplyAreaSearchBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шаг:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начальный ID:";
            // 
            // StepNum
            // 
            this.StepNum.Location = new System.Drawing.Point(262, 28);
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
            this.StepNum.Size = new System.Drawing.Size(120, 21);
            this.StepNum.TabIndex = 1;
            this.StepNum.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // StartIDNum
            // 
            this.StartIDNum.Location = new System.Drawing.Point(99, 28);
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
            this.StartIDNum.Size = new System.Drawing.Size(120, 21);
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
            this.groupBox2.Location = new System.Drawing.Point(755, 522);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 63);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выравнивание графиков";
            // 
            // ApplyOffsetBut
            // 
            this.ApplyOffsetBut.Location = new System.Drawing.Point(456, 26);
            this.ApplyOffsetBut.Name = "ApplyOffsetBut";
            this.ApplyOffsetBut.Size = new System.Drawing.Size(99, 23);
            this.ApplyOffsetBut.TabIndex = 11;
            this.ApplyOffsetBut.Text = "Применить";
            this.ApplyOffsetBut.UseVisualStyleBackColor = true;
            this.ApplyOffsetBut.Click += new System.EventHandler(this.ApplyOffsetBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Правый сдвиг:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Левый сдвиг:";
            // 
            // RightOffsetNum
            // 
            this.RightOffsetNum.Location = new System.Drawing.Point(318, 28);
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
            this.RightOffsetNum.Size = new System.Drawing.Size(120, 21);
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
            this.LeftOffsetNum.Location = new System.Drawing.Point(92, 28);
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
            this.LeftOffsetNum.Size = new System.Drawing.Size(120, 21);
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
            xyDiagram4.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram4.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram4.EnableAxisXScrolling = true;
            xyDiagram4.EnableAxisXZooming = true;
            xyDiagram4.EnableAxisYScrolling = true;
            xyDiagram4.EnableAxisYZooming = true;
            this.PipeChart.Diagram = xyDiagram4;
            this.PipeChart.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBox;
            this.PipeChart.Location = new System.Drawing.Point(201, 12);
            this.PipeChart.Name = "PipeChart";
            series22.Name = "Клеть 1";
            series22.View = lineSeriesView22;
            series23.Name = "Клеть 2";
            series23.View = lineSeriesView23;
            series24.Name = "Клеть 3";
            series24.View = lineSeriesView24;
            series25.Name = "Клеть 4";
            series25.View = lineSeriesView25;
            series26.Name = "Клеть 5";
            series26.View = lineSeriesView26;
            series27.Name = "Клеть 6";
            series27.View = lineSeriesView27;
            series28.Name = "Клеть 7";
            series28.View = lineSeriesView28;
            this.PipeChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series22,
        series23,
        series24,
        series25,
        series26,
        series27,
        series28};
            this.PipeChart.Size = new System.Drawing.Size(1119, 504);
            this.PipeChart.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 597);
            this.Controls.Add(this.PipeChart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PipeListDGV);
            this.Controls.Add(this.LoadPipesBut);
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
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series28)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private DevExpress.XtraCharts.ChartControl PipeChart;
    }
}

