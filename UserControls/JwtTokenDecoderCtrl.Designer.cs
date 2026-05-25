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
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(376, 20);
            label1.Name = "label1";
            label1.Size = new Size(420, 44);
            label1.TabIndex = 6;
            label1.Text = "JwtToken Decoder";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(332, 185);
            label4.Name = "label4";
            label4.Size = new Size(511, 38);
            label4.TabIndex = 10;
            label4.Text = "Output Header";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(310, 94);
            label3.Name = "label3";
            label3.Size = new Size(533, 38);
            label3.TabIndex = 9;
            label3.Text = "Input";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbOutputHeader
            // 
            tbOutputHeader.BorderStyle = BorderStyle.FixedSingle;
            tbOutputHeader.Location = new Point(40, 226);
            tbOutputHeader.Name = "tbOutputHeader";
            tbOutputHeader.ReadOnly = true;
            tbOutputHeader.Size = new Size(1081, 23);
            tbOutputHeader.TabIndex = 8;
            // 
            // tbInput
            // 
            tbInput.BorderStyle = BorderStyle.FixedSingle;
            tbInput.Location = new Point(40, 135);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(1081, 23);
            tbInput.TabIndex = 7;
            tbInput.TextChanged += tbInput_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(332, 252);
            label2.Name = "label2";
            label2.Size = new Size(511, 38);
            label2.TabIndex = 11;
            label2.Text = "Output Payload";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(332, 315);
            label5.Name = "label5";
            label5.Size = new Size(511, 38);
            label5.TabIndex = 12;
            label5.Text = "Output Signature";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbOutputPayload
            // 
            tbOutputPayload.BorderStyle = BorderStyle.FixedSingle;
            tbOutputPayload.Location = new Point(35, 289);
            tbOutputPayload.Name = "tbOutputPayload";
            tbOutputPayload.ReadOnly = true;
            tbOutputPayload.Size = new Size(1081, 23);
            tbOutputPayload.TabIndex = 13;
            // 
            // tbOutputSignature
            // 
            tbOutputSignature.BorderStyle = BorderStyle.FixedSingle;
            tbOutputSignature.Location = new Point(35, 347);
            tbOutputSignature.Name = "tbOutputSignature";
            tbOutputSignature.ReadOnly = true;
            tbOutputSignature.Size = new Size(1081, 23);
            tbOutputSignature.TabIndex = 14;
            // 
            // JwtTokenDecoderCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
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
