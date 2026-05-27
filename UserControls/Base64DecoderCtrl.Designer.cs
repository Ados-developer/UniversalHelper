namespace UniverzalHelper.UserControls
{
    partial class Base64DecoderCtrl
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
            tbInput = new TextBox();
            tbOutput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
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
            label1.TabIndex = 0;
            label1.Text = "Base64 Decoder";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbInput
            // 
            tbInput.BorderStyle = BorderStyle.FixedSingle;
            tbInput.Location = new Point(50, 150);
            tbInput.Multiline = true;
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(500, 350);
            tbInput.TabIndex = 1;
            tbInput.TextChanged += tbInput_TextChanged;
            // 
            // tbOutput
            // 
            tbOutput.BorderStyle = BorderStyle.FixedSingle;
            tbOutput.Location = new Point(600, 150);
            tbOutput.Multiline = true;
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.Size = new Size(500, 350);
            tbOutput.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 85);
            label3.Name = "label3";
            label3.Size = new Size(500, 40);
            label3.TabIndex = 4;
            label3.Text = "Input";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(600, 85);
            label4.Name = "label4";
            label4.Size = new Size(500, 40);
            label4.TabIndex = 5;
            label4.Text = "Output";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Snap ITC", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(350, 525);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save as file";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            // Base64DecoderCtrl
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
            Name = "Base64DecoderCtrl";
            Size = new Size(1150, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbInput;
        private TextBox tbOutput;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private Button btnCopy;
    }
}
