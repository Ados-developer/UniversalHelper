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
            label4 = new Label();
            label3 = new Label();
            tbOutput = new TextBox();
            tbInput = new TextBox();
            label1 = new Label();
            btnCopy = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(609, 94);
            label4.Name = "label4";
            label4.Size = new Size(511, 36);
            label4.TabIndex = 10;
            label4.Text = "Output";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 94);
            label3.Name = "label3";
            label3.Size = new Size(533, 36);
            label3.TabIndex = 9;
            label3.Text = "Input";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbOutput
            // 
            tbOutput.BorderStyle = BorderStyle.FixedSingle;
            tbOutput.Location = new Point(609, 142);
            tbOutput.Multiline = true;
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.Size = new Size(511, 359);
            tbOutput.TabIndex = 8;
            // 
            // tbInput
            // 
            tbInput.BorderStyle = BorderStyle.FixedSingle;
            tbInput.Location = new Point(40, 142);
            tbInput.Multiline = true;
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(533, 359);
            tbInput.TabIndex = 7;
            tbInput.TextChanged += tbInput_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(369, 36);
            label1.Name = "label1";
            label1.Size = new Size(420, 42);
            label1.TabIndex = 6;
            label1.Text = "Hash Generator";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = SystemColors.ActiveCaption;
            btnCopy.Font = new Font("Snap ITC", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCopy.Location = new Point(486, 525);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(201, 31);
            btnCopy.TabIndex = 11;
            btnCopy.Text = "Copy to clipboard";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // HashGeneratorCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(btnCopy);
            Controls.Add(label4);
            Controls.Add(label3);
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

        private Label label4;
        private Label label3;
        private TextBox tbOutput;
        private TextBox tbInput;
        private Label label1;
        private Button btnCopy;
    }
}
