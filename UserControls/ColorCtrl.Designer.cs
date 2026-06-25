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
            tbOutput = new TextBox();
            pnlPreview = new Panel();
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
            // tbOutput
            // 
            tbOutput.BackColor = Color.FromArgb(64, 64, 64);
            tbOutput.BorderStyle = BorderStyle.FixedSingle;
            tbOutput.ForeColor = SystemColors.Info;
            tbOutput.Location = new Point(76, 183);
            tbOutput.Name = "tbOutput";
            tbOutput.ScrollBars = ScrollBars.Horizontal;
            tbOutput.Size = new Size(1000, 23);
            tbOutput.TabIndex = 14;
            // 
            // pnlPreview
            // 
            pnlPreview.Location = new Point(485, 232);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(200, 150);
            pnlPreview.TabIndex = 15;
            // 
            // ColorCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(pnlPreview);
            Controls.Add(tbOutput);
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
        private TextBox tbOutput;
        private Panel pnlPreview;
    }
}
