using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Os
{
    
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
       private char[] letter = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z','0','1','2','3','4','5','6','7','8','9' };

        private void Setting_Load(object sender, EventArgs e)
        {
            kuaibiaoshijian.Text = Request.TimeOfkuaibiao.ToString();
            neicunshijian.Text = Request.TimeOfneicun.ToString();
            neiucnshuliang.Text = Request.NumsOfwulikuai.ToString();
            yemianshuliang.Text = Request.NumsOfneicun.ToString();
            queyeshijian.Text = Request.TimeOfqueye.ToString();
            xuliedizhi.Text = Request.xulie;
        }

        private String rand()
        {
            string result = "";
            Random rd = new Random();
            int n = letter.Length;
            int NumsAddress = Convert.ToInt32(yemianshuliang.Text);
            for (int i = 0; i <NumsAddress-1 ; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int num = rd.Next(0, n);
                    result += letter[num];
                }
                result += "H,";
            }
            for (int j = 0; j < 4; j++)
            {
                int num = rd.Next(0, n);
                result += letter[num];
            }
            result += "H";
            return result;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Request.kuaibiao = !Request.kuaibiao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Request.TimeOfkuaibiao = Convert.ToInt32(kuaibiaoshijian.Text);
            Request.TimeOfneicun = Convert.ToInt32(neicunshijian.Text);
            Request.TimeOfqueye = Convert.ToInt32(queyeshijian.Text);
            Request.NumsOfneicun = Convert.ToInt32(yemianshuliang.Text);//页面数量比较大
            Request.NumsOfwulikuai = Convert.ToInt32(neiucnshuliang.Text);//内存块的数量
                                                                          /* MessageBox.Show(Request.TimeOfkuaibiao.ToString());
                                                                           MessageBox.Show(Request.TimeOfneicun.ToString());
                                                                           MessageBox.Show(Request.TimeOfqueye.ToString());
                                                                           MessageBox.Show(Request.NumsOfneicun.ToString());
                                                                           MessageBox.Show(Request.NumsOfwulikuai.ToString());
                                                                           if(Request.kuaibiao)
                                                                           {
                                                                               MessageBox.Show("选");
                                                                           }
                                                                           else { MessageBox.Show("没选"); }*/

            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            xuliedizhi.Text = rand();

        }
    }
}
