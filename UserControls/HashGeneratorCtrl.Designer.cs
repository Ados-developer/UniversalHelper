namespace UniverzalHelper.UserControls
{
    partial class HashGeneratorCtrl
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
            tbOutput = new TextBox();
            tbInput = new TextBox();
            label1 = new Label();
            btnCopy = new Button();
            SuspendLayout();
            // 
            // tbOutput
            // 
            tbOutput.BackColor = Color.FromArgb(64, 64, 64);
            tbOutput.BorderStyle = BorderStyle.FixedSingle;
            tbOutput.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbOutput.ForeColor = SystemColors.Info;
            tbOutput.Location = new Point(600, 150);
            tbOutput.Multiline = true;
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.ScrollBars = ScrollBars.Vertical;
            tbOutput.Size = new Size(500, 350);
            tbOutput.TabIndex = 8;
            // 
            // tbInput
            // 
            tbInput.BackColor = Color.FromArgb(64, 64, 64);
            tbInput.BorderStyle = BorderStyle.FixedSingle;
            tbInput.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tbInput.ForeColor = SystemColors.Info;
            tbInput.Location = new Point(50, 150);
            tbInput.Multiline = true;
            tbInput.Name = "tbInput";
            tbInput.ScrollBars = ScrollBars.Vertical;
            tbInput.Size = new Size(500, 350);
            tbInput.TabIndex = 7;
            tbInput.TextChanged += tbInput_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Candara", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(410, 56);
            label1.Name = "label1";
            label1.Size = new Size(350, 50);
            label1.TabIndex = 6;
            label1.Text = "Hash Generator";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.FromArgb(64, 64, 64);
            btnCopy.FlatAppearance.BorderSize = 0;
            btnCopy.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCopy.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Font = new Font("Candara", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCopy.ForeColor = SystemColors.Info;
            btnCopy.Location = new Point(475, 525);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(200, 40);
            btnCopy.TabIndex = 11;
            btnCopy.Text = "Copy to clipboard";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // HashGeneratorCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(btnCopy);
            Controls.Add(tbOutput);
            Controls.Add(tbInput);
            Controls.Add(label1);
            MaximumSize = new Size(1150, 600);
            MinimumSize = new Size(1150, 600);
            Name = "HashGeneratorCtrl";
            Size = new Size(1150, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbOutput;
        private TextBox tbInput;
        private Label label1;
        private Button btnCopy;
    }
}
