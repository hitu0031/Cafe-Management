using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management.AllUserControl
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                labelBaanner.Location = new Point(94, 367);
                labelBaanner.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 1)
            {
                labelBaanner.Location = new Point(166, 367);
                labelBaanner.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                labelBaanner.Location = new Point(268, 367);
                labelBaanner.ForeColor = Color.RoyalBlue;
                num = 0;
            }
        }
        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void UC_Welcome_Load_1(object sender, EventArgs e)
        {

        }
    }
}