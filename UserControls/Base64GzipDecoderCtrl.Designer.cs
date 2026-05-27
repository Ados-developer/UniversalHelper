namespace UniverzalHelper.UserControls
{
    partial class Base64GzipDecoderCtrl
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
            btnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            tbOutput = new TextBox();
            tbInput = new TextBox();
            btnCopy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(400, 20);
            label1.Name = "label1";
            label1.Size = new Size(350, 50);
            label1.TabIndex = 1;
            label1.Text = "Base64Gzip Decoder";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Snap ITC", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(350, 525);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 40);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save as file";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(600, 85);
            label4.Name = "label4";
            label4.Size = new Size(500, 40);
            label4.TabIndex = 10;
            label4.Text = "Output";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 85);
            label3.Name = "label3";
            label3.Size = new Size(500, 40);
            label3.TabIndex = 9;
            label3.Text = "Input";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbOutput
            // 
            tbOutput.BorderStyle = BorderStyle.FixedSingle;
            tbOutput.Location = new Point(600, 150);
            tbOutput.Multiline = true;
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.Size = new Size(500, 350);
            tbOutput.TabIndex = 8;
            // 
            // tbInput
            // 
            tbInput.BorderStyle = BorderStyle.FixedSingle;
            tbInput.Location = new Point(50, 150);
            tbInput.Multiline = true;
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(500, 350);
            tbInput.TabIndex = 7;
            tbInput.TextChanged += tbInput_TextChanged;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = SystemColors.ActiveCaption;
            btnCopy.Font = new Font("Snap ITC", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCopy.Location = new Point(600, 525);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(200, 40);
            btnCopy.TabIndex = 12;
            btnCopy.Text = "Copy to clipboard";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // Base64GzipDecoderCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(btnCopy);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbOutput);
            Controls.Add(tbInput);
            Controls.Add(label1);
            MaximumSize = new Size(1150, 600);
            MinimumSize = new Size(1150, 600);
            Name = "Base64GzipDecoderCtrl";
            Size = new Size(1150, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private Label label4;
        private Label label3;
        private TextBox tbOutput;
        private TextBox tbInput;
        private Button btnCopy;
    }
}
