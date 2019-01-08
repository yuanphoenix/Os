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

namespace Os
{
    public partial class Form1 : Form
    {

        private Thread Tfifo = null;
        private Thread Tlru = null;
        private ArrayList list = new ArrayList(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "页面访问序列：" + change();
            
        }


        //change意义是更新List和标签
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
            list.Add(a[i * 6]);
            return result;
        }

        //左上角的设置选项。
        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting set = new Setting();
            set.Show();
            
        }

        //每一哥算法开始前，都应该进行一次restart操作。
        private void restart()
        {
            
            list.Clear();
            change();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //FIFO的代码
            FIFOPanel.BringToFront();//将FIFO的Panel送到前台；
            //首先更新ArrayList
            restart();
           
            if (Tfifo==null||Tfifo.ThreadState.ToString()!="Running")
            {
                Tfifo = new Thread(FIFOMethod);
                Tfifo.Start();
            }
            
        }
        private void FIFOMethod()
        {

            //这个q是物理块的队列。
            Queue<int> q = new Queue<int>();

            int wulikuai = Request.NumsOfwulikuai;
            CheckForIllegalCrossThreadCalls = false;
          
            for (int i = 0; i <= list.Count; i++)//列数
            {
                //设置是否缺页的标志
                  bool queye =false;
                if (i != 0)
                {
                    //只能这样转换，否则会产生错误。
                    String a = Convert.ToString(list[i - 1]);
                    int b = Convert.ToInt32(a);
                    if (!q.Contains(b))
                    {
                        q.Enqueue(b);//加入队列
                        queye = true;//设置需要缺页中断的标志。
                    }
                   
                   
                }
                for (int j = 0; j < wulikuai + 2; j++)//行数
                {
                    Label lab = new Label();
                   
                    lab.Left = 50;
                    lab.Top = j * 30;
                    if (i==0)
                    {
                        lab.Width = 60;//如果不声明这个宽度有问题！宽度还需要微调。
                        lab.Left = i * 60 + 50;
                        lab.Top = j * 30;
                        if (j==0)
                        {
                            lab.Text ="访问序列";
                            this.Invoke(new Action(() =>
                            {
                                FIFOPanel.Controls.Add(lab);
                            }
                  ));
                        }
                        else if(j<=wulikuai)
                        {
                            lab.Text = "物理块"+j.ToString();
                            this.Invoke(new Action(() =>
                            {
                                FIFOPanel.Controls.Add(lab);
                            }
                  ));
                        }
                        else
                        {
                            lab.Text = "是否缺页";
                            this.Invoke(new Action(() =>
                            {
                                FIFOPanel.Controls.Add(lab);
                            }
                  ));
                        }
                    }
                    else
                    {
                        lab.Width = 10;
                        lab.Left = i * 60 + 50;
                        lab.Top = j * 30;
   
                        if (q.Count>Request.NumsOfwulikuai)
                        {
                            q.Dequeue();
                        }
                       int []num = q.ToArray();
                    
                        if (j==0)
                        {
                            lab.Text = Convert.ToString(list[i - 1]);
                        }else if(j<=wulikuai)
                        {
                            if (j<=q.Count)
                            {
                                 lab.Text = num[j - 1].ToString();
                            }
                           
                        }
                        else
                        {
                            if (queye)
                            {
                                lab.Text = "√";
                            }
                        }
                        if (IsHandleCreated)
                        {
                        this.Invoke(new Action(() =>
                     {
                          FIFOPanel.Controls.Add(lab);
                       }
                      ));
                        }
                   
                    }
            
                }

                Sleep(TimeSpan.FromSeconds(1));
            }
        }
     
        private void LRUMethod()
        {
            LinkedList<int> q = new LinkedList<int>();
 
            int wulikuai = Request.NumsOfwulikuai;
            for (int i = 0; i <= list.Count; i++)
            {
                bool queye =true;
                if (i!=0)
                {
                    String a =Convert.ToString( list[i - 1]);
                    int b = Convert.ToInt32(a);
                    
                    if (q.Contains(b))
                    {
                        queye =false;
                        q.Remove(b);
                    }
                    q.AddFirst(b);

                }
                for (int j = 0; j < wulikuai+2; j++)
                {
                    Label lab = new Label();
                    lab.Left = 50;
                    lab.Top = j * 30;
                    if (i == 0)
                    {
                        lab.Width = 60;//如果不声明这个宽度有问题！宽度还需要微调。
                        lab.Left = i * 60 + 50;
                        lab.Top = j * 30;
                        if (j == 0)
                        {
                            lab.Text = "访问序列";
                            this.Invoke(new Action(() =>
                            {
                                LRUPanel.Controls.Add(lab);
                            }
                  ));
                        }
                        else if (j <= wulikuai)
                        {
                            lab.Text = "物理块" + j.ToString();
                            this.Invoke(new Action(() =>
                            {
                                LRUPanel.Controls.Add(lab);
                            }
                  ));
                        }
                        else
                        {
                            lab.Text = "是否缺页";
                            this.Invoke(new Action(() =>
                            {
                                LRUPanel.Controls.Add(lab);
                            }
                  ));
                        }
                    }
                    else
                    {
                        lab.Width = 10;
                        lab.Left = i * 60 + 50;
                        lab.Top = j * 30;
                        if (q.Count>wulikuai)
                        {
                            q.RemoveLast();
                        }
                        int[] num = q.ToArray();
                        if (j==0)
                        {
                            lab.Text = Convert.ToString(list[i - 1]);
                        }
                        else if (j <= wulikuai)
                        {
                            if (j <= q.Count)
                            {
                                lab.Text = num[j - 1].ToString();
                            }

                        }
                        else
                        {
                            if (queye)
                            {
                                lab.Text = "√";
                            }
                        }
                        if (IsHandleCreated)
                        {
                            this.Invoke(new Action(() =>
                            {
                                LRUPanel.Controls.Add(lab);
                            }
                          ));
                        }
                    }

                }
            }

        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            LRUPanel.BringToFront();
            restart();
            if (Tlru==null||Tlru.ThreadState.ToString()!="Running")
            {
                Tlru = new Thread(LRUMethod);
                Tlru.Start();
            }
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
