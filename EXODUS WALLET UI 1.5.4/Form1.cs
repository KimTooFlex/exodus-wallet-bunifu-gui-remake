using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXODUS_WALLET_UI_1._5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            taB11.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            taB21.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            taB31.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            tab41.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
