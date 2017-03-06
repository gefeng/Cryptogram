namespace Cryptogram
{
    partial class UcPvv
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
            this.lbClearPvk = new System.Windows.Forms.Label();
            this.tbClearPvk = new System.Windows.Forms.TextBox();
            this.lbPan = new System.Windows.Forms.Label();
            this.tbPan = new System.Windows.Forms.TextBox();
            this.lbPvki = new System.Windows.Forms.Label();
            this.tbPvki = new System.Windows.Forms.TextBox();
            this.lbPin = new System.Windows.Forms.Label();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.btnGeneratePvv = new System.Windows.Forms.Button();
            this.tbPvv = new System.Windows.Forms.TextBox();
            this.lbPvv = new System.Windows.Forms.Label();
            this.lbClearPvkHint = new System.Windows.Forms.Label();
            this.lbPanHint = new System.Windows.Forms.Label();
            this.lbPvkiHint = new System.Windows.Forms.Label();
            this.lbPinHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbClearPvk
            // 
            this.lbClearPvk.AutoSize = true;
            this.lbClearPvk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClearPvk.ForeColor = System.Drawing.Color.Black;
            this.lbClearPvk.Location = new System.Drawing.Point(24, 17);
            this.lbClearPvk.Name = "lbClearPvk";
            this.lbClearPvk.Size = new System.Drawing.Size(72, 19);
            this.lbClearPvk.TabIndex = 0;
            this.lbClearPvk.Text = "Clear PVK";
            // 
            // tbClearPvk
            // 
            this.tbClearPvk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClearPvk.Location = new System.Drawing.Point(28, 40);
            this.tbClearPvk.MaxLength = 32;
            this.tbClearPvk.Name = "tbClearPvk";
            this.tbClearPvk.Size = new System.Drawing.Size(300, 27);
            this.tbClearPvk.TabIndex = 1;
            this.tbClearPvk.TextChanged += new System.EventHandler(this.tbClearPvk_TextChanged);
            // 
            // lbPan
            // 
            this.lbPan.AutoSize = true;
            this.lbPan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPan.ForeColor = System.Drawing.Color.Black;
            this.lbPan.Location = new System.Drawing.Point(24, 81);
            this.lbPan.Name = "lbPan";
            this.lbPan.Size = new System.Drawing.Size(35, 19);
            this.lbPan.TabIndex = 2;
            this.lbPan.Text = "PAN";
            // 
            // tbPan
            // 
            this.tbPan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPan.Location = new System.Drawing.Point(28, 103);
            this.tbPan.MaxLength = 19;
            this.tbPan.Name = "tbPan";
            this.tbPan.Size = new System.Drawing.Size(300, 27);
            this.tbPan.TabIndex = 4;
            this.tbPan.TextChanged += new System.EventHandler(this.tbPan_TextChanged);
            // 
            // lbPvki
            // 
            this.lbPvki.AutoSize = true;
            this.lbPvki.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPvki.ForeColor = System.Drawing.Color.Black;
            this.lbPvki.Location = new System.Drawing.Point(24, 145);
            this.lbPvki.Name = "lbPvki";
            this.lbPvki.Size = new System.Drawing.Size(38, 19);
            this.lbPvki.TabIndex = 5;
            this.lbPvki.Text = "PVKI";
            // 
            // tbPvki
            // 
            this.tbPvki.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPvki.Location = new System.Drawing.Point(28, 167);
            this.tbPvki.MaxLength = 1;
            this.tbPvki.Name = "tbPvki";
            this.tbPvki.Size = new System.Drawing.Size(300, 27);
            this.tbPvki.TabIndex = 6;
            this.tbPvki.TextChanged += new System.EventHandler(this.tbPvki_TextChanged);
            // 
            // lbPin
            // 
            this.lbPin.AutoSize = true;
            this.lbPin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPin.ForeColor = System.Drawing.Color.Black;
            this.lbPin.Location = new System.Drawing.Point(24, 209);
            this.lbPin.Name = "lbPin";
            this.lbPin.Size = new System.Drawing.Size(31, 19);
            this.lbPin.TabIndex = 7;
            this.lbPin.Text = "PIN";
            // 
            // tbPin
            // 
            this.tbPin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPin.Location = new System.Drawing.Point(28, 231);
            this.tbPin.MaxLength = 6;
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(300, 27);
            this.tbPin.TabIndex = 8;
            this.tbPin.TextChanged += new System.EventHandler(this.tbPin_TextChanged);
            // 
            // btnGeneratePvv
            // 
            this.btnGeneratePvv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePvv.ForeColor = System.Drawing.Color.Black;
            this.btnGeneratePvv.Location = new System.Drawing.Point(28, 287);
            this.btnGeneratePvv.Name = "btnGeneratePvv";
            this.btnGeneratePvv.Size = new System.Drawing.Size(140, 35);
            this.btnGeneratePvv.TabIndex = 9;
            this.btnGeneratePvv.Text = "Generate";
            this.btnGeneratePvv.UseVisualStyleBackColor = true;
            this.btnGeneratePvv.Click += new System.EventHandler(this.btnGeneratePvv_Click);
            // 
            // tbPvv
            // 
            this.tbPvv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPvv.Location = new System.Drawing.Point(28, 359);
            this.tbPvv.Name = "tbPvv";
            this.tbPvv.ReadOnly = true;
            this.tbPvv.Size = new System.Drawing.Size(140, 27);
            this.tbPvv.TabIndex = 10;
            // 
            // lbPvv
            // 
            this.lbPvv.AutoSize = true;
            this.lbPvv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPvv.ForeColor = System.Drawing.Color.Black;
            this.lbPvv.Location = new System.Drawing.Point(24, 337);
            this.lbPvv.Name = "lbPvv";
            this.lbPvv.Size = new System.Drawing.Size(35, 19);
            this.lbPvv.TabIndex = 11;
            this.lbPvv.Text = "PVV";
            // 
            // lbClearPvkHint
            // 
            this.lbClearPvkHint.AutoSize = true;
            this.lbClearPvkHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClearPvkHint.ForeColor = System.Drawing.Color.Black;
            this.lbClearPvkHint.Location = new System.Drawing.Point(334, 43);
            this.lbClearPvkHint.Name = "lbClearPvkHint";
            this.lbClearPvkHint.Size = new System.Drawing.Size(0, 19);
            this.lbClearPvkHint.TabIndex = 12;
            // 
            // lbPanHint
            // 
            this.lbPanHint.AutoSize = true;
            this.lbPanHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPanHint.ForeColor = System.Drawing.Color.Black;
            this.lbPanHint.Location = new System.Drawing.Point(334, 106);
            this.lbPanHint.Name = "lbPanHint";
            this.lbPanHint.Size = new System.Drawing.Size(0, 19);
            this.lbPanHint.TabIndex = 13;
            // 
            // lbPvkiHint
            // 
            this.lbPvkiHint.AutoSize = true;
            this.lbPvkiHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPvkiHint.ForeColor = System.Drawing.Color.Black;
            this.lbPvkiHint.Location = new System.Drawing.Point(334, 170);
            this.lbPvkiHint.Name = "lbPvkiHint";
            this.lbPvkiHint.Size = new System.Drawing.Size(0, 19);
            this.lbPvkiHint.TabIndex = 14;
            // 
            // lbPinHint
            // 
            this.lbPinHint.AutoSize = true;
            this.lbPinHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPinHint.ForeColor = System.Drawing.Color.Black;
            this.lbPinHint.Location = new System.Drawing.Point(334, 234);
            this.lbPinHint.Name = "lbPinHint";
            this.lbPinHint.Size = new System.Drawing.Size(0, 19);
            this.lbPinHint.TabIndex = 15;
            // 
            // UcPvv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lbPinHint);
            this.Controls.Add(this.lbPvkiHint);
            this.Controls.Add(this.lbPanHint);
            this.Controls.Add(this.lbClearPvkHint);
            this.Controls.Add(this.lbPvv);
            this.Controls.Add(this.tbPvv);
            this.Controls.Add(this.btnGeneratePvv);
            this.Controls.Add(this.tbPin);
            this.Controls.Add(this.lbPin);
            this.Controls.Add(this.tbPvki);
            this.Controls.Add(this.lbPvki);
            this.Controls.Add(this.tbPan);
            this.Controls.Add(this.lbPan);
            this.Controls.Add(this.tbClearPvk);
            this.Controls.Add(this.lbClearPvk);
            this.Name = "UcPvv";
            this.Size = new System.Drawing.Size(610, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClearPvk;
        private System.Windows.Forms.TextBox tbClearPvk;
        private System.Windows.Forms.Label lbPan;
        private System.Windows.Forms.TextBox tbPan;
        private System.Windows.Forms.Label lbPvki;
        private System.Windows.Forms.TextBox tbPvki;
        private System.Windows.Forms.Label lbPin;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Button btnGeneratePvv;
        private System.Windows.Forms.TextBox tbPvv;
        private System.Windows.Forms.Label lbPvv;
        private System.Windows.Forms.Label lbClearPvkHint;
        private System.Windows.Forms.Label lbPanHint;
        private System.Windows.Forms.Label lbPvkiHint;
        private System.Windows.Forms.Label lbPinHint;
    }
}
