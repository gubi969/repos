using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 凹嗚凹嗚
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1;
            MessageBox.Show(x.ToString());
            x++;
            MessageBox.Show(x.ToString());
            Button but = (Button)sender;
            but.Text = "我被按了";
        }
    }
}
