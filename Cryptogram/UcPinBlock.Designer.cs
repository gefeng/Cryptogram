namespace Cryptogram
{
    partial class UcPinBlock
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
            this.lbClearAwk = new System.Windows.Forms.Label();
            this.lbPinFormat = new System.Windows.Forms.Label();
            this.lbPin = new System.Windows.Forms.Label();
            this.lbPinBlock = new System.Windows.Forms.Label();
            this.lbPinBlockEncrypted = new System.Windows.Forms.Label();
            this.btnCalculatePin = new System.Windows.Forms.Button();
            this.tbClearAwk = new System.Windows.Forms.TextBox();
            this.cbPinFormat = new System.Windows.Forms.ComboBox();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.tbPinBlock = new System.Windows.Forms.TextBox();
            this.tbPinBlockEncrypted = new System.Windows.Forms.TextBox();
            this.btnCalculatePinBlock = new System.Windows.Forms.Button();
            this.lbClearAwkHint = new System.Windows.Forms.Label();
            this.lbPinHint = new System.Windows.Forms.Label();
            this.lbPinBlockEncryptedHint = new System.Windows.Forms.Label();
            this.lbPan = new System.Windows.Forms.Label();
            this.tbPan = new System.Windows.Forms.TextBox();
            this.lbPanHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbClearAwk
            // 
            this.lbClearAwk.AutoSize = true;
            this.lbClearAwk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClearAwk.ForeColor = System.Drawing.Color.Black;
            this.lbClearAwk.Location = new System.Drawing.Point(24, 17);
            this.lbClearAwk.Name = "lbClearAwk";
            this.lbClearAwk.Size = new System.Drawing.Size(150, 19);
            this.lbClearAwk.TabIndex = 0;
            this.lbClearAwk.Text = "Clear AWK (a.k.a TPK)";
            // 
            // lbPinFormat
            // 
            this.lbPinFormat.AutoSize = true;
            this.lbPinFormat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPinFormat.ForeColor = System.Drawing.Color.Black;
            this.lbPinFormat.Location = new System.Drawing.Point(24, 153);
            this.lbPinFormat.Name = "lbPinFormat";
            this.lbPinFormat.Size = new System.Drawing.Size(80, 19);
            this.lbPinFormat.TabIndex = 1;
            this.lbPinFormat.Text = "PIN Format";
            // 
            // lbPin
            // 
            this.lbPin.AutoSize = true;
            this.lbPin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPin.ForeColor = System.Drawing.Color.Black;
            this.lbPin.Location = new System.Drawing.Point(189, 153);
            this.lbPin.Name = "lbPin";
            this.lbPin.Size = new System.Drawing.Size(31, 19);
            this.lbPin.TabIndex = 2;
            this.lbPin.Text = "PIN";
            // 
            // lbPinBlock
            // 
            this.lbPinBlock.AutoSize = true;
            this.lbPinBlock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPinBlock.ForeColor = System.Drawing.Color.Black;
            this.lbPinBlock.Location = new System.Drawing.Point(24, 221);
            this.lbPinBlock.Name = "lbPinBlock";
            this.lbPinBlock.Size = new System.Drawing.Size(70, 19);
            this.lbPinBlock.TabIndex = 3;
            this.lbPinBlock.Text = "PIN Block";
            // 
            // lbPinBlockEncrypted
            // 
            this.lbPinBlockEncrypted.AutoSize = true;
            this.lbPinBlockEncrypted.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPinBlockEncrypted.ForeColor = System.Drawing.Color.Black;
            this.lbPinBlockEncrypted.Location = new System.Drawing.Point(24, 289);
            this.lbPinBlockEncrypted.Name = "lbPinBlockEncrypted";
            this.lbPinBlockEncrypted.Size = new System.Drawing.Size(138, 19);
            this.lbPinBlockEncrypted.TabIndex = 4;
            this.lbPinBlockEncrypted.Text = "PIN Block Encrypted";
            // 
            // btnCalculatePin
            // 
            this.btnCalculatePin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePin.ForeColor = System.Drawing.Color.Black;
            this.btnCalculatePin.Location = new System.Drawing.Point(28, 357);
            this.btnCalculatePin.Name = "btnCalculatePin";
            this.btnCalculatePin.Size = new System.Drawing.Size(99, 35);
            this.btnCalculatePin.TabIndex = 5;
            this.btnCalculatePin.Text = "PIN";
            this.btnCalculatePin.UseVisualStyleBackColor = true;
            this.btnCalculatePin.Click += new System.EventHandler(this.btnCalculatePin_Click);
            // 
            // tbClearAwk
            // 
            this.tbClearAwk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClearAwk.ForeColor = System.Drawing.Color.Black;
            this.tbClearAwk.Location = new System.Drawing.Point(28, 39);
            this.tbClearAwk.Name = "tbClearAwk";
            this.tbClearAwk.Size = new System.Drawing.Size(300, 27);
            this.tbClearAwk.TabIndex = 7;
            this.tbClearAwk.TextChanged += new System.EventHandler(this.tbClearAwk_TextChanged);
            // 
            // cbPinFormat
            // 
            this.cbPinFormat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPinFormat.ForeColor = System.Drawing.Color.Black;
            this.cbPinFormat.FormattingEnabled = true;
            this.cbPinFormat.Items.AddRange(new object[] {
            "ISO-0",
            "VISA-3"});
            this.cbPinFormat.Location = new System.Drawing.Point(28, 175);
            this.cbPinFormat.Name = "cbPinFormat";
            this.cbPinFormat.Size = new System.Drawing.Size(140, 27);
            this.cbPinFormat.TabIndex = 8;
            this.cbPinFormat.SelectedIndex = 0;
            // 
            // tbPin
            // 
            this.tbPin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPin.ForeColor = System.Drawing.Color.Black;
            this.tbPin.Location = new System.Drawing.Point(188, 175);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(140, 27);
            this.tbPin.TabIndex = 9;
            this.tbPin.TextChanged += new System.EventHandler(this.tbPin_TextChanged);
            // 
            // tbPinBlock
            // 
            this.tbPinBlock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPinBlock.ForeColor = System.Drawing.Color.Black;
            this.tbPinBlock.Location = new System.Drawing.Point(28, 243);
            this.tbPinBlock.Name = "tbPinBlock";
            this.tbPinBlock.ReadOnly = true;
            this.tbPinBlock.Size = new System.Drawing.Size(300, 27);
            this.tbPinBlock.TabIndex = 10;
            // 
            // tbPinBlockEncrypted
            // 
            this.tbPinBlockEncrypted.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPinBlockEncrypted.ForeColor = System.Drawing.Color.Black;
            this.tbPinBlockEncrypted.Location = new System.Drawing.Point(28, 311);
            this.tbPinBlockEncrypted.Name = "tbPinBlockEncrypted";
            this.tbPinBlockEncrypted.Size = new System.Drawing.Size(300, 27);
            this.tbPinBlockEncrypted.TabIndex = 11;
            this.tbPinBlockEncrypted.TextChanged += new System.EventHandler(this.tbPinBlockEncrypted_TextChanged);
            // 
            // btnCalculatePinBlock
            // 
            this.btnCalculatePinBlock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePinBlock.ForeColor = System.Drawing.Color.Black;
            this.btnCalculatePinBlock.Location = new System.Drawing.Point(133, 357);
            this.btnCalculatePinBlock.Name = "btnCalculatePinBlock";
            this.btnCalculatePinBlock.Size = new System.Drawing.Size(99, 35);
            this.btnCalculatePinBlock.TabIndex = 12;
            this.btnCalculatePinBlock.Text = "PIN Block";
            this.btnCalculatePinBlock.UseVisualStyleBackColor = true;
            this.btnCalculatePinBlock.Click += new System.EventHandler(this.btnCalculatePinBlock_Click);
            // 
            // lbClearAwkHint
            // 
            this.lbClearAwkHint.AutoSize = true;
            this.lbClearAwkHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClearAwkHint.ForeColor = System.Drawing.Color.Black;
            this.lbClearAwkHint.Location = new System.Drawing.Point(334, 42);
            this.lbClearAwkHint.Name = "lbClearAwkHint";
            this.lbClearAwkHint.Size = new System.Drawing.Size(49, 19);
            this.lbClearAwkHint.TabIndex = 13;
            this.lbClearAwkHint.Text = "label6";
            // 
            // lbPinHint
            // 
            this.lbPinHint.AutoSize = true;
            this.lbPinHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPinHint.ForeColor = System.Drawing.Color.Black;
            this.lbPinHint.Location = new System.Drawing.Point(334, 178);
            this.lbPinHint.Name = "lbPinHint";
            this.lbPinHint.Size = new System.Drawing.Size(49, 19);
            this.lbPinHint.TabIndex = 14;
            this.lbPinHint.Text = "label7";
            // 
            // lbPinBlockEncryptedHint
            // 
            this.lbPinBlockEncryptedHint.AutoSize = true;
            this.lbPinBlockEncryptedHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPinBlockEncryptedHint.ForeColor = System.Drawing.Color.Black;
            this.lbPinBlockEncryptedHint.Location = new System.Drawing.Point(334, 314);
            this.lbPinBlockEncryptedHint.Name = "lbPinBlockEncryptedHint";
            this.lbPinBlockEncryptedHint.Size = new System.Drawing.Size(49, 19);
            this.lbPinBlockEncryptedHint.TabIndex = 16;
            this.lbPinBlockEncryptedHint.Text = "label9";
            // 
            // lbPan
            // 
            this.lbPan.AutoSize = true;
            this.lbPan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPan.ForeColor = System.Drawing.Color.Black;
            this.lbPan.Location = new System.Drawing.Point(24, 85);
            this.lbPan.Name = "lbPan";
            this.lbPan.Size = new System.Drawing.Size(35, 19);
            this.lbPan.TabIndex = 17;
            this.lbPan.Text = "PAN";
            // 
            // tbPan
            // 
            this.tbPan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPan.ForeColor = System.Drawing.Color.Black;
            this.tbPan.Location = new System.Drawing.Point(28, 107);
            this.tbPan.Name = "tbPan";
            this.tbPan.Size = new System.Drawing.Size(300, 27);
            this.tbPan.TabIndex = 18;
            this.tbPan.TextChanged += new System.EventHandler(this.tbPan_TextChanged);
            // 
            // lbPanHint
            // 
            this.lbPanHint.AutoSize = true;
            this.lbPanHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPanHint.ForeColor = System.Drawing.Color.Black;
            this.lbPanHint.Location = new System.Drawing.Point(334, 110);
            this.lbPanHint.Name = "lbPanHint";
            this.lbPanHint.Size = new System.Drawing.Size(49, 19);
            this.lbPanHint.TabIndex = 19;
            this.lbPanHint.Text = "label7";
            // 
            // UcPinBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lbPanHint);
            this.Controls.Add(this.tbPan);
            this.Controls.Add(this.lbPan);
            this.Controls.Add(this.lbPinBlockEncryptedHint);
            this.Controls.Add(this.lbPinHint);
            this.Controls.Add(this.lbClearAwkHint);
            this.Controls.Add(this.btnCalculatePinBlock);
            this.Controls.Add(this.tbPinBlockEncrypted);
            this.Controls.Add(this.tbPinBlock);
            this.Controls.Add(this.tbPin);
            this.Controls.Add(this.cbPinFormat);
            this.Controls.Add(this.tbClearAwk);
            this.Controls.Add(this.btnCalculatePin);
            this.Controls.Add(this.lbPinBlockEncrypted);
            this.Controls.Add(this.lbPinBlock);
            this.Controls.Add(this.lbPin);
            this.Controls.Add(this.lbPinFormat);
            this.Controls.Add(this.lbClearAwk);
            this.Name = "UcPinBlock";
            this.Size = new System.Drawing.Size(610, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClearAwk;
        private System.Windows.Forms.Label lbPinFormat;
        private System.Windows.Forms.Label lbPin;
        private System.Windows.Forms.Label lbPinBlock;
        private System.Windows.Forms.Label lbPinBlockEncrypted;
        private System.Windows.Forms.Button btnCalculatePin;
        private System.Windows.Forms.TextBox tbClearAwk;
        private System.Windows.Forms.ComboBox cbPinFormat;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.TextBox tbPinBlock;
        private System.Windows.Forms.TextBox tbPinBlockEncrypted;
        private System.Windows.Forms.Button btnCalculatePinBlock;
        private System.Windows.Forms.Label lbClearAwkHint;
        private System.Windows.Forms.Label lbPinHint;
        private System.Windows.Forms.Label lbPinBlockEncryptedHint;
        private System.Windows.Forms.Label lbPan;
        private System.Windows.Forms.TextBox tbPan;
        private System.Windows.Forms.Label lbPanHint;
    }
}
