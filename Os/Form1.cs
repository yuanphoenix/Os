using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Os
{
    public partial class Form1 : Form
    {
        private int yemianshu = 0;
        private ArrayList list = new ArrayList(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "页面访问序列：" + change();
          //  Controls.Add(btn);
        }
        private string change()
        {
            string result = "";
            string a = Request.xulie;
            /*
            这个for循环是一个实验性质的，存在问题。比如默认了第一个字母为页面号；


            */
            int max = Request.NumsOfneicun;
            int i;
            for (i = 0; i <max-1; i++)
            {
                result += a[i * 6];
                list.Add(a[i * 6]);
                result += ",";
            }
            result += a[i*6];
            return result;
        }
        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting set = new Setting();
            set.Show();
            
        }


        private void restart()
        {
            int kuaishu = Request.NumsOfwulikuai;
            list.Clear();
            change();



        }
        private void button1_Click(object sender, EventArgs e)
        {
            //FIFO的代码
            FIFOPanel.BringToFront();

        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            LRUPanel.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OPT_Click(object sender, EventArgs e)
        {
            OPTPanel.BringToFront();
        }
    }
}
