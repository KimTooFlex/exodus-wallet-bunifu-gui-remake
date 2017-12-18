using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXODUS_WALLET_UI_1._5._4
{
    public partial class TAB2 : UserControl
    {
        List<Color> cryptoCOlors = new List<Color>();
        public TAB2()
        {
            InitializeComponent();
            cryptoCOlors.Add(Color.FromArgb(255, 153, 0));
            cryptoCOlors.Add(Color.FromArgb(70, 184, 252));
            cryptoCOlors.Add(Color.FromArgb(240, 240, 240));
            cryptoCOlors.Add(Color.FromArgb(255, 255, 255));
            cryptoCOlors.Add(Color.FromArgb(44, 222, 225));
            cryptoCOlors.Add(Color.FromArgb(44, 222, 225));
        }


        private void tabIndexChange(object sender, EventArgs e)
        {


            separator.Left = ((Control)sender).Left;
            lbl.ForeColor = separator.LineColor = cryptoCOlors[int.Parse(((Control)sender).Tag.ToString())];
            lblname.Text = ((Control)sender).Text;
            lbldesc.Text = "No " + lblname.Text + " Transactions";
        }
    }
}
