using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniverzalHelper.UserControls
{
    public partial class Base16DecoderCtrl : UserControl
    {
        public Base16DecoderCtrl()
        {
            InitializeComponent();
        }
        private string warning = "Waiting for complet Base16...";
        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string hex = tbInput.Text.Trim();
                hex = hex.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? hex[2..] : hex;
                byte[] Bytes = Convert.FromHexString(hex);
                string result = Encoding.UTF8.GetString(Bytes);

                tbOutput.Text = result;
            }
            catch
            {
                tbOutput.Text = warning;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML file|*.xml|JSON file|*.json|Text file|*.txt|All files|*.*";
            dialog.FileName = "output";
            if (string.IsNullOrEmpty(tbOutput.Text) || tbOutput.Text == warning)
            {
                MessageBox.Show("Output area is empty. You have to write something.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, tbOutput.Text);
                    tbInput.Text = "";
                    MessageBox.Show("The file was successfuly saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbOutput.Text) || tbOutput.Text == warning)
            {               
                MessageBox.Show("Output area is empty. You have to write something.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Clipboard.SetText(tbOutput.Text);
                MessageBox.Show("Output text was copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
