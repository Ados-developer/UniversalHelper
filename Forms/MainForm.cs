using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UniverzalHelper.UserControls;

namespace UniverzalHelper.Forms
{
    public partial class MainForm : BaseForm
    {
        private readonly IServiceProvider _serviceProvider;
        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Base64DecoderCtrl base64DecoderCtrl = _serviceProvider.GetRequiredService<Base64DecoderCtrl>();
            ShowUserControl(base64DecoderCtrl);
            btnBase64.BackColor = Color.Gray;
        }
        private void ShowUserControl(UserControl control)
        {
            panelUserControl.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelUserControl.Controls.Add(control);
        }

        private void btnBase64_Click(object sender, EventArgs e)
        {
            btnBase64.BackColor = Color.Gray;
            btnBase64Gzip.BackColor = Color.FromArgb(64, 64, 64);
            btnHashGenerator.BackColor = Color.FromArgb(64, 64, 64);
            btnJwtToken.BackColor = Color.FromArgb(64, 64, 64);
            btnColor.BackColor = Color.FromArgb(64, 64, 64);
            Base64DecoderCtrl control = _serviceProvider.GetRequiredService<Base64DecoderCtrl>();
            ShowUserControl(control);
        }

        private void btnBase64Gzip_Click(object sender, EventArgs e)
        {
            btnBase64.BackColor = Color.FromArgb(64, 64, 64);
            btnBase64Gzip.BackColor = Color.Gray;
            btnHashGenerator.BackColor = Color.FromArgb(64, 64, 64);
            btnJwtToken.BackColor = Color.FromArgb(64, 64, 64);
            btnColor.BackColor = Color.FromArgb(64, 64, 64);
            Base64GzipDecoderCtrl control = _serviceProvider.GetRequiredService<Base64GzipDecoderCtrl>();
            ShowUserControl(control);
        }

        private void btnHashGenerator_Click(object sender, EventArgs e)
        {
            btnBase64.BackColor = Color.FromArgb(64, 64, 64);
            btnBase64Gzip.BackColor = Color.FromArgb(64, 64, 64);
            btnHashGenerator.BackColor = Color.Gray;
            btnJwtToken.BackColor = Color.FromArgb(64, 64, 64);
            btnColor.BackColor = Color.FromArgb(64, 64, 64);
            HashGeneratorCtrl control = _serviceProvider.GetRequiredService<HashGeneratorCtrl>();
            ShowUserControl(control);
        }

        private void btnJwtToken_Click(object sender, EventArgs e)
        {
            btnBase64.BackColor = Color.FromArgb(64, 64, 64);
            btnBase64Gzip.BackColor = Color.FromArgb(64, 64, 64);
            btnHashGenerator.BackColor = Color.FromArgb(64, 64, 64);
            btnJwtToken.BackColor = Color.Gray;
            btnColor.BackColor = Color.FromArgb(64, 64, 64);
            JwtTokenDecoderCtrl control = _serviceProvider.GetRequiredService<JwtTokenDecoderCtrl>();
            ShowUserControl(control);
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            btnBase64.BackColor = Color.FromArgb(64, 64, 64);
            btnBase64Gzip.BackColor = Color.FromArgb(64, 64, 64);
            btnHashGenerator.BackColor = Color.FromArgb(64, 64, 64);
            btnJwtToken.BackColor = Color.FromArgb(64, 64, 64);
            btnColor.BackColor = Color.Gray;
            ColorCtrl control = _serviceProvider.GetRequiredService<ColorCtrl>();
            ShowUserControl(control);
        }
    }
}
