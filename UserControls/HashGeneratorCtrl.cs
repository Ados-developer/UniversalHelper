using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniverzalHelper.UserControls
{
    public partial class HashGeneratorCtrl : UserControl
    {
        public HashGeneratorCtrl()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbOutput.Text))
            {
                Clipboard.SetText(tbOutput.Text);
                MessageBox.Show("Output text was copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Output area is empty. You have to write something.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            string input = tbInput.Text;
            string inputHash = BitConverter.ToString(
                System.Security.Cryptography.SHA256.Create()
                .ComputeHash(Encoding.UTF8.GetBytes(input)))
                .Replace("-", "").ToLower();
            tbOutput.Text = inputHash;
        }
    }
}
