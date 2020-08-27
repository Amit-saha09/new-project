using Business_mannagement_System.Frame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_mannagement_System
{
    public partial class Homepage : MetroFramework.Forms.MetroForm
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var customercontrol = new Customerpanel();
            customercontrol.Dock = DockStyle.Fill ;
            metroPanel3.Controls.Clear();
            metroPanel3.Controls.Add(customercontrol);


        }
    }
}
