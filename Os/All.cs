using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Threading.Thread;
namespace Os
{
    public partial class All : Form
    {
        private Thread Afifo = null;
        private Thread Alru = null;
        private Thread Aopt = null;
        public All()
        {
            InitializeComponent();
            
        }

        private void All_Load(object sender, EventArgs e)
        {
            
          
        }
    }
}
