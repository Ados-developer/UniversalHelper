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
                string rgb = $"rgb({c.R},{c.G},{c.B})";
                string rgba = $"rgba({c.R},{c.G},{c.B},1)";

                tbHex.Text = $"{hex}";
                tbRgb.Text = $"{rgb}";
                tbRgba.Text = $"{rgba}";
            }
        }

        private void btnCopyHex_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbHex.Text))
            {
                MessageBox.Show("The Field HEX is empty. You have to write something.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Clipboard.SetText(tbHex.Text);
                MessageBox.Show("The Field HEX was copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCopyRgb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRgb.Text))
            {
                MessageBox.Show("The Field RGB is empty. You have to write something.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Clipboard.SetText(tbRgb.Text);
                MessageBox.Show("The Field RGB was copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCopyRgba_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRgba.Text))
            {
                MessageBox.Show("The Field RGBA is empty. You have to write something.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Clipboard.SetText(tbRgba.Text);
                MessageBox.Show("The Field RGBA was copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
