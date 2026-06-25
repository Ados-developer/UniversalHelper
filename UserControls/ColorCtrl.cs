using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniverzalHelper.UserControls
{
    public partial class ColorCtrl : UserControl
    {
        public ColorCtrl()
        {
         
            InitializeComponent();
        }
        private void btnPick_Click(object sender, EventArgs e)
        {
            using ColorDialog dlg = new ColorDialog
            {
                FullOpen = true,        // hneď otvorí aj vlastné farby
                AnyColor = true
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Color c = dlg.Color;

                pnlPreview.BackColor = c;   // náhľad (ak máš panel)

                string hex = $"#{c.R:X2}{c.G:X2}{c.B:X2}";
                string rgb = $"rgb({c.R}, {c.G}, {c.B})";
                string rgba = $"rgba({c.R}, {c.G}, {c.B}, 1)";

                tbOutput.Text = $"HEX:  {hex}\r\nRGB:  {rgb}\r\nRGBA: {rgba}";
            }
        }
    }
}
