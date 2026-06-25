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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelUserControl = new Panel();
            btnBase64 = new Button();
            btnBase64Gzip = new Button();
            btnHashGenerator = new Button();
            btnJwtToken = new Button();
            btnColor = new Button();
            SuspendLayout();
            // 
            // panelUserControl
            // 
            panelUserControl.Location = new Point(25, 199);
            panelUserControl.MaximumSize = new Size(1150, 600);
            panelUserControl.MinimumSize = new Size(1150, 600);
            panelUserControl.Name = "panelUserControl";
            panelUserControl.Size = new Size(1150, 600);
            panelUserControl.TabIndex = 0;
            // 
            // btnBase64
            // 
            btnBase64.BackColor = Color.FromArgb(64, 64, 64);
            btnBase64.FlatAppearance.BorderSize = 0;
            btnBase64.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnBase64.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBase64.FlatStyle = FlatStyle.Flat;
            btnBase64.Font = new Font("Candara", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBase64.ForeColor = SystemColors.Info;
            btnBase64.Location = new Point(25, 93);
            btnBase64.Name = "btnBase64";
            btnBase64.Size = new Size(152, 63);
            btnBase64.TabIndex = 2;
            btnBase64.Text = "Base64";
            btnBase64.UseVisualStyleBackColor = false;
            btnBase64.Click += btnBase64_Click;
            // 
            // btnBase64Gzip
            // 
            btnBase64Gzip.BackColor = Color.FromArgb(64, 64, 64);
            btnBase64Gzip.FlatAppearance.BorderSize = 0;
            btnBase64Gzip.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnBase64Gzip.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBase64Gzip.FlatStyle = FlatStyle.Flat;
            btnBase64Gzip.Font = new Font("Candara", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBase64Gzip.ForeColor = SystemColors.Info;
            btnBase64Gzip.Location = new Point(183, 93);
            btnBase64Gzip.Name = "btnBase64Gzip";
            btnBase64Gzip.Size = new Size(152, 63);
            btnBase64Gzip.TabIndex = 3;
            btnBase64Gzip.Text = "Base64Gzip";
            btnBase64Gzip.UseVisualStyleBackColor = false;
            btnBase64Gzip.Click += btnBase64Gzip_Click;
            // 
            // btnHashGenerator
            // 
            btnHashGenerator.BackColor = Color.FromArgb(64, 64, 64);
            btnHashGenerator.FlatAppearance.BorderSize = 0;
            btnHashGenerator.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnHashGenerator.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnHashGenerator.FlatStyle = FlatStyle.Flat;
            btnHashGenerator.Font = new Font("Candara", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHashGenerator.ForeColor = SystemColors.Info;
            btnHashGenerator.Location = new Point(341, 93);
            btnHashGenerator.Name = "btnHashGenerator";
            btnHashGenerator.Size = new Size(189, 63);
            btnHashGenerator.TabIndex = 4;
            btnHashGenerator.Text = "HashGenerator";
            btnHashGenerator.UseVisualStyleBackColor = false;
            btnHashGenerator.Click += btnHashGenerator_Click;
            // 
            // btnJwtToken
            // 
            btnJwtToken.BackColor = Color.FromArgb(64, 64, 64);
            btnJwtToken.FlatAppearance.BorderSize = 0;
            btnJwtToken.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnJwtToken.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnJwtToken.FlatStyle = FlatStyle.Flat;
            btnJwtToken.Font = new Font("Candara", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnJwtToken.ForeColor = SystemColors.Info;
            btnJwtToken.Location = new Point(536, 93);
            btnJwtToken.Name = "btnJwtToken";
            btnJwtToken.Size = new Size(189, 63);
            btnJwtToken.TabIndex = 5;
            btnJwtToken.Text = "JwtToken";
            btnJwtToken.UseVisualStyleBackColor = false;
            btnJwtToken.Click += btnJwtToken_Click;
            // 
            // btnColor
            // 
            btnColor.BackColor = Color.FromArgb(64, 64, 64);
            btnColor.FlatAppearance.BorderSize = 0;
            btnColor.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnColor.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnColor.FlatStyle = FlatStyle.Flat;
            btnColor.Font = new Font("Candara", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnColor.ForeColor = SystemColors.Info;
            btnColor.Location = new Point(731, 93);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(189, 63);
            btnColor.TabIndex = 6;
            btnColor.Text = "Color Converter";
            btnColor.UseVisualStyleBackColor = false;
            btnColor.Click += btnColor_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1200, 850);
            Controls.Add(btnColor);
            Controls.Add(btnJwtToken);
            Controls.Add(btnHashGenerator);
            Controls.Add(btnBase64Gzip);
            Controls.Add(btnBase64);
            Controls.Add(panelUserControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1200, 850);
            MinimumSize = new Size(1200, 850);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UH";
            Controls.SetChildIndex(panelUserControl, 0);
            Controls.SetChildIndex(btnBase64, 0);
            Controls.SetChildIndex(btnBase64Gzip, 0);
            Controls.SetChildIndex(btnHashGenerator, 0);
            Controls.SetChildIndex(btnJwtToken, 0);
            Controls.SetChildIndex(btnColor, 0);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUserControl;
        private Button btnBase64;
        private Button btnBase64Gzip;
        private Button btnHashGenerator;
        private Button btnJwtToken;
        private Button btnColor;
    }
}