namespace UniverzalHelper.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelUserControl = new Panel();
            label1 = new Label();
            btnBase64 = new Button();
            btnBase64Gzip = new Button();
            btnHashGenerator = new Button();
            btnJwtToken = new Button();
            SuspendLayout();
            // 
            // panelUserControl
            // 
            panelUserControl.Location = new Point(22, 199);
            panelUserControl.MaximumSize = new Size(1150, 600);
            panelUserControl.MinimumSize = new Size(1150, 600);
            panelUserControl.Name = "panelUserControl";
            panelUserControl.Size = new Size(1150, 600);
            panelUserControl.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(1150, 55);
            label1.TabIndex = 1;
            label1.Text = "Universal Helper";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBase64
            // 
            btnBase64.BackColor = SystemColors.ActiveCaption;
            btnBase64.Font = new Font("Snap ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBase64.Location = new Point(22, 87);
            btnBase64.Name = "btnBase64";
            btnBase64.Size = new Size(152, 63);
            btnBase64.TabIndex = 2;
            btnBase64.Text = "Base64";
            btnBase64.UseVisualStyleBackColor = false;
            btnBase64.Click += btnBase64_Click;
            // 
            // btnBase64Gzip
            // 
            btnBase64Gzip.BackColor = SystemColors.ActiveCaption;
            btnBase64Gzip.Font = new Font("Snap ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBase64Gzip.Location = new Point(180, 87);
            btnBase64Gzip.Name = "btnBase64Gzip";
            btnBase64Gzip.Size = new Size(152, 63);
            btnBase64Gzip.TabIndex = 3;
            btnBase64Gzip.Text = "Base64Gzip";
            btnBase64Gzip.UseVisualStyleBackColor = false;
            btnBase64Gzip.Click += btnBase64Gzip_Click;
            // 
            // btnHashGenerator
            // 
            btnHashGenerator.BackColor = SystemColors.ActiveCaption;
            btnHashGenerator.Font = new Font("Snap ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHashGenerator.Location = new Point(338, 87);
            btnHashGenerator.Name = "btnHashGenerator";
            btnHashGenerator.Size = new Size(189, 63);
            btnHashGenerator.TabIndex = 4;
            btnHashGenerator.Text = "HashGenerator";
            btnHashGenerator.UseVisualStyleBackColor = false;
            btnHashGenerator.Click += btnHashGenerator_Click;
            // 
            // btnJwtToken
            // 
            btnJwtToken.BackColor = SystemColors.ActiveCaption;
            btnJwtToken.Font = new Font("Snap ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnJwtToken.Location = new Point(533, 87);
            btnJwtToken.Name = "btnJwtToken";
            btnJwtToken.Size = new Size(189, 63);
            btnJwtToken.TabIndex = 5;
            btnJwtToken.Text = "JwtToken";
            btnJwtToken.UseVisualStyleBackColor = false;
            btnJwtToken.Click += btnJwtToken_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1184, 811);
            Controls.Add(btnJwtToken);
            Controls.Add(btnHashGenerator);
            Controls.Add(btnBase64Gzip);
            Controls.Add(btnBase64);
            Controls.Add(label1);
            Controls.Add(panelUserControl);
            MaximumSize = new Size(1200, 850);
            MinimumSize = new Size(1200, 850);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UH";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUserControl;
        private Label label1;
        private Button btnBase64;
        private Button btnBase64Gzip;
        private Button btnHashGenerator;
        private Button btnJwtToken;
    }
}