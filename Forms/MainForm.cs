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
    public partial class MainForm : Form
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
            btnBase64.BackColor = SystemColors.HotTrack;
        }
        private void ShowUserControl(UserControl control)
        {
            panelUserControl.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelUserControl.Controls.Add(control);
        }

        private void btnBase64_Click(object sender, EventArgs e)
        {
            btnBase64.BackColor = SystemColors.HotTrack;
            btnBase64Gzip.BackColor = SystemColors.ActiveCaption;
            btnHashGenerator.BackColor = SystemColors.ActiveCaption;
            btnJwtToken.BackColor = SystemColors.ActiveCaption;
            Base64DecoderCtrl control = _serviceProvider.GetRequiredService<Base64DecoderCtrl>();
            ShowUserControl(control);
        }

        private void btnBase64Gzip_Click(object sender, EventArgs e)
        {
            btnBase64.BackColor = SystemColors.ActiveCaption;
            btnBase64Gzip.BackColor = SystemColors.HotTrack;
            btnHashGenerator.BackColor = SystemColors.ActiveCaption;
            btnJwtToken.BackColor = SystemColors.ActiveCaption;
            Base64GzipDecoderCtrl control = _serviceProvider.GetRequiredService<Base64GzipDecoderCtrl>();
            ShowUserControl(control);
        }

        private void btnHashGenerator_Click(object sender, EventArgs e)
        {
            btnBase64.BackColor = SystemColors.ActiveCaption;
            btnBase64Gzip.BackColor = SystemColors.ActiveCaption;
            btnHashGenerator.BackColor = SystemColors.HotTrack;
            btnJwtToken.BackColor = SystemColors.ActiveCaption;
            HashGeneratorCtrl control = _serviceProvider.GetRequiredService<HashGeneratorCtrl>();
            ShowUserControl(control);
        }

        private void btnJwtToken_Click(object sender, EventArgs e)
        {
            btnBase64.BackColor = SystemColors.ActiveCaption;
            btnBase64Gzip.BackColor = SystemColors.ActiveCaption;
            btnHashGenerator.BackColor = SystemColors.ActiveCaption;
            btnJwtToken.BackColor = SystemColors.HotTrack;
            JwtTokenDecoderCtrl control = _serviceProvider.GetRequiredService<JwtTokenDecoderCtrl>();
            ShowUserControl(control);
        }
    }
}
