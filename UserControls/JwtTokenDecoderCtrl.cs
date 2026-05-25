using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniverzalHelper.UserControls
{
    public partial class JwtTokenDecoderCtrl : UserControl
    {
        public JwtTokenDecoderCtrl()
        {
            InitializeComponent();
        }
        private string Base64UrlDecode(string input)
        {
            string padded = input.Replace('-', '+').Replace('_', '/');
            switch (padded.Length % 4)
            {
                case 2: padded += "=="; break;
                case 3: padded += "="; break;
            }
            byte[] bytes = Convert.FromBase64String(padded);
            return Encoding.UTF8.GetString(bytes);
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                string[] s = tbInput.Text.Split(".");
                tbOutputHeader.Text = Base64UrlDecode(s[0]);
                tbOutputPayload.Text = Base64UrlDecode(s[1]);
                tbOutputSignature.Text = s[2];
            }
            catch
            {
                tbOutputHeader.Text = "Waiting for complet JwtToken...";
                tbOutputPayload.Text = "Waiting for complet JwtToken...";
                tbOutputSignature.Text = "Waiting for complet JwtToken...";
            }
        }
    }
}
