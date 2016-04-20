using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelAssignment
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            lblData.TextAlign = ContentAlignment.MiddleLeft;
            EnableButtons((Button)sender);
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            lblData.TextAlign = ContentAlignment.MiddleCenter;
            EnableButtons((Button)sender);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            lblData.TextAlign = ContentAlignment.MiddleRight;
            EnableButtons((Button)sender);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            EnableButtons(btnLeft);
        }

        private void EnableButtons(Button sender)
        {
            btnLeft.Enabled = true;
            btnCenter.Enabled = true;
            btnRight.Enabled = true;
            sender.Enabled = false;
        }
    }
}
