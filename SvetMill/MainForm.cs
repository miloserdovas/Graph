using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraCharts;


namespace SvetMill
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        GraphContext db = new GraphContext();
        List<int> positionStart = new List<int>();

        int trigger = 100;

        int step;
        int startID;
        int endID;
        int leftOffset;
        int rightOffset;
        bool isPipe = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyChanges();
        }
        private void LoadPipesBut_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            LoadPipesFromDB();
            splashScreenManager1.CloseWaitForm();
        }

        private void PipeListDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            DisplayChart(e.RowIndex);
        }


        private void LoadPipesFromDB()
        {
            
            PipeListDGV.Rows.Clear();           
            endID = startID + step;
            var dots = db.IPMPM.Where(p => p.ID > startID && p.ID < endID).ToList();
            foreach (var dot in dots)
            {
                if (dot.F1 > trigger)
                {
                    if (!isPipe)
                    {
                        isPipe = true;
                        positionStart.Add(dot.ID);
                    }

                }

                else
                {
                    isPipe = false;
                }
            }
            foreach (var item in positionStart)
            {

                PipeListDGV.Rows.Add();
                PipeListDGV.Rows[PipeListDGV.RowCount - 2].Cells[0].Value = PipeListDGV.RowCount - 1;
                PipeListDGV.Rows[PipeListDGV.RowCount - 2].Cells[1].Value = item;
            }
            startID += step;
            LoadPipesBut.Text = "Загрузить еще";           
        }

        private void DisplayChart(int rowindex)
        {

            PipeChart.Series[0].Points.Clear();
            PipeChart.Series[1].Points.Clear();
            PipeChart.Series[2].Points.Clear();
            PipeChart.Series[3].Points.Clear();
            PipeChart.Series[4].Points.Clear();
            PipeChart.Series[5].Points.Clear();
            PipeChart.Series[6].Points.Clear();

            int ind = rowindex;
            int start = positionStart[ind] - leftOffset;
            int end = positionStart[ind] + rightOffset;
            var dots = db.IPMPM.Where(p => p.ID > start && p.ID < end).ToList();
            foreach (var dot in dots)
            {
                PipeChart.Series[0].Points.Add(new SeriesPoint(dot.ID, dot.F1));
                PipeChart.Series[1].Points.Add(new SeriesPoint(dot.ID, dot.F2));
                PipeChart.Series[2].Points.Add(new SeriesPoint(dot.ID, dot.F3));
                PipeChart.Series[3].Points.Add(new SeriesPoint(dot.ID, dot.F4));
                PipeChart.Series[4].Points.Add(new SeriesPoint(dot.ID, dot.F5));
                PipeChart.Series[5].Points.Add(new SeriesPoint(dot.ID, dot.F6));
                PipeChart.Series[6].Points.Add(new SeriesPoint(dot.ID, dot.F7));
            }

            
        }

        private void ApplyChanges()
        {
            step = (int)StepNum.Value;
            startID = (int)StartIDNum.Value;
            leftOffset = (int)LeftOffsetNum.Value;
            rightOffset = (int)RightOffsetNum.Value;
        }

        private void ApplyAreaSearchBut_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            ApplyChanges();
            LoadPipesFromDB();
            splashScreenManager1.CloseWaitForm();
        }

        private void ApplyOffsetBut_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            ApplyChanges();
            LoadPipesFromDB();
            splashScreenManager1.CloseWaitForm();
        }
    }
}
