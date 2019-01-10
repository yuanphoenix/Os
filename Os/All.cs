using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Os
{
    public partial class All : Form
    {

        public All()
        {
            InitializeComponent();  
        }
        Thread a = null;
        Thread b = null;
        Thread c = null;
        public static Series FIFO =null;
        public static Series LRU = null;
        public static Series OPT = null;

        private void All_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            chart1.Series.Clear();
            FIFO = new Series("FIFO");
            LRU = new Series("LRU");
            OPT = new Series("OPT");
            FIFO.ChartType = SeriesChartType.Line;
            LRU.ChartType = SeriesChartType.Line;
            OPT.ChartType = SeriesChartType.Line;
            chart1.ChartAreas[0].AxisX.Maximum = 20;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.Series.Add(FIFO);
            chart1.Series.Add(OPT);
            chart1.Series.Add(LRU);
            a = new Thread(setFIFO);
            b = new Thread(setLRU);
            c = new Thread(setOPT)
;            a.Start();
           b.Start();
            c.Start();

        }


        private void FrmMain_FormClosing(object sender, FormClosedEventArgs e)
        {
         a.Abort();
            b.Abort();
            c.Abort();
            //System.Environment.Exit(0);
        }
        public static void setFIFO()
        {
            int i = 0;
            while(true)
            {
                if (i<Request.test_FIFO.Count)
                {    
                    FIFO.Points.AddY(Request.test_FIFO[i++]);
                }
               
            }
        }
        public static void setLRU()
        {
            int i = 0;
            while (true)
            {
                if (i < Request.test_LRU.Count)
                {
                    LRU.Points.AddY(Request.test_LRU[i++]);
                }

            }
        }
        public static void setOPT()
        {
            int i = 0;
            while (true)
            {
                if (i < Request.test_OPT.Count)
                {
                    OPT.Points.AddY(Request.test_OPT[i++]);
                }

            }
        }
    }
}
