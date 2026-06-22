namespace UniverzalHelper.UserControls
{
    partial class JwtTokenDecoderCtrl
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
            label4 = new Label();
            label3 = new Label();
            tbOutputHeader = new TextBox();
            tbInput = new TextBox();
            label2 = new Label();
            label5 = new Label();
            tbOutputPayload = new TextBox();
            tbOutputSignature = new TextBox();
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
            label1.TabIndex = 6;
            label1.Text = "JwtToken Decoder";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(475, 175);
            label4.Name = "label4";
            label4.Size = new Size(200, 30);
            label4.TabIndex = 10;
            label4.Text = "Output Header";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(475, 100);
            label3.Name = "label3";
            label3.Size = new Size(200, 30);
            label3.TabIndex = 9;
            label3.Text = "Input";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbOutputHeader
            // 
            tbOutputHeader.BackColor = Color.FromArgb(64, 64, 64);
            tbOutputHeader.BorderStyle = BorderStyle.FixedSingle;
            tbOutputHeader.ForeColor = SystemColors.Info;
            tbOutputHeader.Location = new Point(75, 215);
            tbOutputHeader.Name = "tbOutputHeader";
            tbOutputHeader.ReadOnly = true;
            tbOutputHeader.ScrollBars = ScrollBars.Horizontal;
            tbOutputHeader.Size = new Size(1000, 23);
            tbOutputHeader.TabIndex = 8;
            // 
            // tbInput
            // 
            tbInput.BackColor = Color.FromArgb(64, 64, 64);
            tbInput.BorderStyle = BorderStyle.FixedSingle;
            tbInput.ForeColor = SystemColors.Info;
            tbInput.Location = new Point(75, 140);
            tbInput.Name = "tbInput";
            tbInput.ScrollBars = ScrollBars.Horizontal;
            tbInput.Size = new Size(1000, 23);
            tbInput.TabIndex = 7;
            tbInput.TextChanged += tbInput_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(475, 250);
            label2.Name = "label2";
            label2.Size = new Size(200, 30);
            label2.TabIndex = 11;
            label2.Text = "Output Payload";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(475, 325);
            label5.Name = "label5";
            label5.Size = new Size(200, 30);
            label5.TabIndex = 12;
            label5.Text = "Output Signature";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbOutputPayload
            // 
            tbOutputPayload.BackColor = Color.FromArgb(64, 64, 64);
            tbOutputPayload.BorderStyle = BorderStyle.FixedSingle;
            tbOutputPayload.ForeColor = SystemColors.Info;
            tbOutputPayload.Location = new Point(75, 290);
            tbOutputPayload.Name = "tbOutputPayload";
            tbOutputPayload.ReadOnly = true;
            tbOutputPayload.ScrollBars = ScrollBars.Horizontal;
            tbOutputPayload.Size = new Size(1000, 23);
            tbOutputPayload.TabIndex = 13;
            // 
            // tbOutputSignature
            // 
            tbOutputSignature.BackColor = Color.FromArgb(64, 64, 64);
            tbOutputSignature.BorderStyle = BorderStyle.FixedSingle;
            tbOutputSignature.ForeColor = SystemColors.Info;
            tbOutputSignature.Location = new Point(75, 365);
            tbOutputSignature.Name = "tbOutputSignature";
            tbOutputSignature.ReadOnly = true;
            tbOutputSignature.ScrollBars = ScrollBars.Horizontal;
            tbOutputSignature.Size = new Size(1000, 23);
            tbOutputSignature.TabIndex = 14;
            // 
            // JwtTokenDecoderCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(tbOutputSignature);
            Controls.Add(tbOutputPayload);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbOutputHeader);
            Controls.Add(tbInput);
            Controls.Add(label1);
            MaximumSize = new Size(1150, 600);
            MinimumSize = new Size(1150, 600);
            Name = "JwtTokenDecoderCtrl";
            Size = new Size(1150, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox tbOutputHeader;
        private TextBox tbInput;
        private Label label2;
        private Label label5;
        private TextBox tbOutputPayload;
        private TextBox tbOutputSignature;
    }
}
