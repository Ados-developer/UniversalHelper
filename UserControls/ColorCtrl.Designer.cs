namespace UniverzalHelper.UserControls
{
    partial class ColorCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnPick = new Button();
            tbHex = new TextBox();
            pnlPreview = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbRgb = new TextBox();
            tbRgba = new TextBox();
            btnCopyHex = new Button();
            btnCopyRgb = new Button();
            btnCopyRgba = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Candara", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(410, 56);
            label1.Name = "label1";
            label1.Size = new Size(350, 50);
            label1.TabIndex = 1;
            label1.Text = "Color Converter";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPick
            // 
            btnPick.BackColor = Color.FromArgb(64, 64, 64);
            btnPick.FlatAppearance.BorderSize = 0;
            btnPick.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnPick.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnPick.FlatStyle = FlatStyle.Flat;
            btnPick.Font = new Font("Candara", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPick.ForeColor = SystemColors.Info;
            btnPick.Location = new Point(485, 120);
            btnPick.Name = "btnPick";
            btnPick.Size = new Size(200, 40);
            btnPick.TabIndex = 13;
            btnPick.Text = "Pick a Color";
            btnPick.UseVisualStyleBackColor = false;
            btnPick.Click += btnPick_Click;
            // 
            // tbHex
            // 
            tbHex.BackColor = Color.FromArgb(64, 64, 64);
            tbHex.BorderStyle = BorderStyle.FixedSingle;
            tbHex.ForeColor = SystemColors.Info;
            tbHex.Location = new Point(485, 180);
            tbHex.Name = "tbHex";
            tbHex.ScrollBars = ScrollBars.Horizontal;
            tbHex.Size = new Size(200, 23);
            tbHex.TabIndex = 14;
            // 
            // pnlPreview
            // 
            pnlPreview.Location = new Point(485, 347);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(200, 150);
            pnlPreview.TabIndex = 15;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(355, 180);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 16;
            label2.Text = "HEX";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(355, 228);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 17;
            label3.Text = "RGB";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(64, 64, 64);
            label4.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(355, 274);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 18;
            label4.Text = "RGBA";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbRgb
            // 
            tbRgb.BackColor = Color.FromArgb(64, 64, 64);
            tbRgb.BorderStyle = BorderStyle.FixedSingle;
            tbRgb.ForeColor = SystemColors.Info;
            tbRgb.Location = new Point(485, 228);
            tbRgb.Name = "tbRgb";
            tbRgb.ScrollBars = ScrollBars.Horizontal;
            tbRgb.Size = new Size(200, 23);
            tbRgb.TabIndex = 19;
            // 
            // tbRgba
            // 
            tbRgba.BackColor = Color.FromArgb(64, 64, 64);
            tbRgba.BorderStyle = BorderStyle.FixedSingle;
            tbRgba.ForeColor = SystemColors.Info;
            tbRgba.Location = new Point(485, 274);
            tbRgba.Name = "tbRgba";
            tbRgba.ScrollBars = ScrollBars.Horizontal;
            tbRgba.Size = new Size(200, 23);
            tbRgba.TabIndex = 20;
            // 
            // btnCopyHex
            // 
            btnCopyHex.BackColor = Color.FromArgb(64, 64, 64);
            btnCopyHex.FlatAppearance.BorderSize = 0;
            btnCopyHex.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCopyHex.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCopyHex.FlatStyle = FlatStyle.Flat;
            btnCopyHex.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnCopyHex.ForeColor = SystemColors.Info;
            btnCopyHex.Location = new Point(706, 180);
            btnCopyHex.Name = "btnCopyHex";
            btnCopyHex.Size = new Size(110, 23);
            btnCopyHex.TabIndex = 21;
            btnCopyHex.Text = "Copy";
            btnCopyHex.TextAlign = ContentAlignment.TopCenter;
            btnCopyHex.UseVisualStyleBackColor = false;
            btnCopyHex.Click += btnCopyHex_Click;
            // 
            // btnCopyRgb
            // 
            btnCopyRgb.BackColor = Color.FromArgb(64, 64, 64);
            btnCopyRgb.FlatAppearance.BorderSize = 0;
            btnCopyRgb.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCopyRgb.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCopyRgb.FlatStyle = FlatStyle.Flat;
            btnCopyRgb.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnCopyRgb.ForeColor = SystemColors.Info;
            btnCopyRgb.Location = new Point(706, 228);
            btnCopyRgb.Name = "btnCopyRgb";
            btnCopyRgb.Size = new Size(110, 23);
            btnCopyRgb.TabIndex = 22;
            btnCopyRgb.Text = "Copy";
            btnCopyRgb.TextAlign = ContentAlignment.TopCenter;
            btnCopyRgb.UseVisualStyleBackColor = false;
            btnCopyRgb.Click += btnCopyRgb_Click;
            // 
            // btnCopyRgba
            // 
            btnCopyRgba.BackColor = Color.FromArgb(64, 64, 64);
            btnCopyRgba.FlatAppearance.BorderSize = 0;
            btnCopyRgba.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCopyRgba.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCopyRgba.FlatStyle = FlatStyle.Flat;
            btnCopyRgba.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnCopyRgba.ForeColor = SystemColors.Info;
            btnCopyRgba.Location = new Point(706, 274);
            btnCopyRgba.Name = "btnCopyRgba";
            btnCopyRgba.Size = new Size(110, 23);
            btnCopyRgba.TabIndex = 23;
            btnCopyRgba.Text = "Copy";
            btnCopyRgba.TextAlign = ContentAlignment.TopCenter;
            btnCopyRgba.UseVisualStyleBackColor = false;
            btnCopyRgba.Click += btnCopyRgba_Click;
            // 
            // ColorCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(btnCopyRgba);
            Controls.Add(btnCopyRgb);
            Controls.Add(btnCopyHex);
            Controls.Add(tbRgba);
            Controls.Add(tbRgb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnlPreview);
            Controls.Add(tbHex);
            Controls.Add(btnPick);
            Controls.Add(label1);
            MaximumSize = new Size(1150, 600);
            MinimumSize = new Size(1150, 600);
            Name = "ColorCtrl";
            Size = new Size(1150, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPick;
        private TextBox tbHex;
        private Panel pnlPreview;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbRgb;
        private TextBox tbRgba;
        private Button btnCopyHex;
        private Button btnCopyRgb;
        private Button btnCopyRgba;
    }
}
