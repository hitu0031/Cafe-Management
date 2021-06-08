using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(string user)
        {
            InitializeComponent();
    
            if (user == "Guest")
            {
                btnAddItem.Hide();
                btnUpdateItem.Hide();
                btnRemoveItem.Hide();
            }
            else if (user == "Admin")
            {
                btnAddItem.Show();
                btnUpdateItem.Show();
                btnRemoveItem.Show();
            }
    }
        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(uC_AddItems1);
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }
   
        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItem1.Visible = false;
            uC_RemoveItem1.Visible = false;
            
           
        }

        private void uC_Welcome1_Load(object sender, EventArgs e)
        {

        }

        private void uC_AddItems1_Load(object sender, EventArgs e)
        {

        }

        private void uC_AddItems1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnPlaceorder_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
          
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            uC_UpdateItem1.Visible = true;
            uC_UpdateItem1.BringToFront();

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
        }

        private void uC_RemoveItem1_Load(object sender, EventArgs e)
        {

        }
    }
}
