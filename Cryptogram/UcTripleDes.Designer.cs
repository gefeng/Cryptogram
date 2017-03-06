namespace Cryptogram
{
    partial class UcTripleDes
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
            this.lbDataBlock = new System.Windows.Forms.Label();
            this.lbKey = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.tbDataBlock = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lbDataBlockHint = new System.Windows.Forms.Label();
            this.lbKeyHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDataBlock
            // 
            this.lbDataBlock.AutoSize = true;
            this.lbDataBlock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataBlock.ForeColor = System.Drawing.Color.Black;
            this.lbDataBlock.Location = new System.Drawing.Point(27, 70);
            this.lbDataBlock.Name = "lbDataBlock";
            this.lbDataBlock.Size = new System.Drawing.Size(79, 19);
            this.lbDataBlock.TabIndex = 0;
            this.lbDataBlock.Text = "Data Block";
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKey.ForeColor = System.Drawing.Color.Black;
            this.lbKey.Location = new System.Drawing.Point(27, 145);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(32, 19);
            this.lbKey.TabIndex = 1;
            this.lbKey.Text = "Key";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.ForeColor = System.Drawing.Color.Black;
            this.lbOutput.Location = new System.Drawing.Point(27, 275);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(54, 19);
            this.lbOutput.TabIndex = 2;
            this.lbOutput.Text = "Output";
            // 
            // tbDataBlock
            // 
            this.tbDataBlock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataBlock.ForeColor = System.Drawing.Color.Black;
            this.tbDataBlock.Location = new System.Drawing.Point(31, 92);
            this.tbDataBlock.Name = "tbDataBlock";
            this.tbDataBlock.Size = new System.Drawing.Size(300, 27);
            this.tbDataBlock.TabIndex = 3;
            this.tbDataBlock.TextChanged += new System.EventHandler(this.tbDataBlock_TextChanged);
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKey.ForeColor = System.Drawing.Color.Black;
            this.tbKey.Location = new System.Drawing.Point(31, 167);
            this.tbKey.MaxLength = 100;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(300, 27);
            this.tbKey.TabIndex = 4;
            this.tbKey.TextChanged += new System.EventHandler(this.tbKey_TextChanged);
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.ForeColor = System.Drawing.Color.Black;
            this.tbOutput.Location = new System.Drawing.Point(31, 297);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(300, 27);
            this.tbOutput.TabIndex = 5;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.Black;
            this.btnEncrypt.Location = new System.Drawing.Point(31, 220);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(140, 35);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.Black;
            this.btnDecrypt.Location = new System.Drawing.Point(191, 220);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(140, 35);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lbDataBlockHint
            // 
            this.lbDataBlockHint.AutoSize = true;
            this.lbDataBlockHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataBlockHint.ForeColor = System.Drawing.Color.Black;
            this.lbDataBlockHint.Location = new System.Drawing.Point(337, 95);
            this.lbDataBlockHint.Name = "lbDataBlockHint";
            this.lbDataBlockHint.Size = new System.Drawing.Size(0, 19);
            this.lbDataBlockHint.TabIndex = 8;
            // 
            // lbKeyHint
            // 
            this.lbKeyHint.AutoSize = true;
            this.lbKeyHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKeyHint.ForeColor = System.Drawing.Color.Black;
            this.lbKeyHint.Location = new System.Drawing.Point(337, 170);
            this.lbKeyHint.Name = "lbKeyHint";
            this.lbKeyHint.Size = new System.Drawing.Size(0, 19);
            this.lbKeyHint.TabIndex = 9;
            // 
            // UcTripleDes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lbKeyHint);
            this.Controls.Add(this.lbDataBlockHint);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbDataBlock);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.lbDataBlock);
            this.Name = "UcTripleDes";
            this.Size = new System.Drawing.Size(610, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDataBlock;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.TextBox tbDataBlock;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lbDataBlockHint;
        private System.Windows.Forms.Label lbKeyHint;
    }
}
