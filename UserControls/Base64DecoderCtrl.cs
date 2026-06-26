using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniverzalHelper.UserControls
{
    public partial class Base64DecoderCtrl : UserControl
    {
        public Base64DecoderCtrl()
        {
            InitializeComponent();
        }
        private string warning = "Waiting for complet Base64...";

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] Bytes = Convert.FromBase64String(tbInput.Text);
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
