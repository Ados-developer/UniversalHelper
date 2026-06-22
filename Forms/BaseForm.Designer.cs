namespace UniverzalHelper.Forms
{
    partial class BaseForm
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
            panelTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            lblTitle = new Label();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(64, 64, 64);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1200, 50);
            panelTitleBar.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(64, 64, 64);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1152, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 50);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(64, 64, 64);
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1097, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(49, 50);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(64, 64, 64);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1042, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(49, 50);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "🗕";
            btnMinimize.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Snap ITC", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(13, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(261, 31);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Universal Helper";
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 516);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseForm";
            Text = "BaseForm";
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Button btnMinimize;
        private Label lblTitle;
        private Button btnClose;
        private Button btnMaximize;
    }
}