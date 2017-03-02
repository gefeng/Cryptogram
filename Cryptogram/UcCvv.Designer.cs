namespace Cryptogram
{
    partial class UcCvv
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
            this.tbCvv = new System.Windows.Forms.TextBox();
            this.lbCvv = new System.Windows.Forms.Label();
            this.btnGenerateCvv = new System.Windows.Forms.Button();
            this.tbPan = new System.Windows.Forms.TextBox();
            this.lbPan = new System.Windows.Forms.Label();
            this.tbServiceCode = new System.Windows.Forms.TextBox();
            this.lbServiceCode = new System.Windows.Forms.Label();
            this.tbExpireDate = new System.Windows.Forms.TextBox();
            this.lbExpireDate = new System.Windows.Forms.Label();
            this.tbClearCvk = new System.Windows.Forms.TextBox();
            this.lbClearCvk = new System.Windows.Forms.Label();
            this.lbClearCvkHint = new System.Windows.Forms.Label();
            this.lbPanHint = new System.Windows.Forms.Label();
            this.lbExpireDateHint = new System.Windows.Forms.Label();
            this.lbServiceCodeHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCvv
            // 
            this.tbCvv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCvv.Location = new System.Drawing.Point(28, 359);
            this.tbCvv.Name = "tbCvv";
            this.tbCvv.ReadOnly = true;
            this.tbCvv.Size = new System.Drawing.Size(99, 27);
            this.tbCvv.TabIndex = 21;
            // 
            // lbCvv
            // 
            this.lbCvv.AutoSize = true;
            this.lbCvv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCvv.ForeColor = System.Drawing.Color.Black;
            this.lbCvv.Location = new System.Drawing.Point(24, 337);
            this.lbCvv.Name = "lbCvv";
            this.lbCvv.Size = new System.Drawing.Size(36, 19);
            this.lbCvv.TabIndex = 20;
            this.lbCvv.Text = "CVV";
            // 
            // btnGenerateCvv
            // 
            this.btnGenerateCvv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerateCvv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerateCvv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCvv.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateCvv.Location = new System.Drawing.Point(28, 287);
            this.btnGenerateCvv.Name = "btnGenerateCvv";
            this.btnGenerateCvv.Size = new System.Drawing.Size(99, 35);
            this.btnGenerateCvv.TabIndex = 19;
            this.btnGenerateCvv.Text = "Generate";
            this.btnGenerateCvv.UseVisualStyleBackColor = false;
            this.btnGenerateCvv.Click += new System.EventHandler(this.btnGenerateCvv_Click);
            // 
            // tbPan
            // 
            this.tbPan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPan.Location = new System.Drawing.Point(28, 103);
            this.tbPan.Name = "tbPan";
            this.tbPan.Size = new System.Drawing.Size(300, 27);
            this.tbPan.TabIndex = 18;
            this.tbPan.TextChanged += new System.EventHandler(this.tbPan_TextChanged);
            // 
            // lbPan
            // 
            this.lbPan.AutoSize = true;
            this.lbPan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPan.ForeColor = System.Drawing.Color.Black;
            this.lbPan.Location = new System.Drawing.Point(24, 81);
            this.lbPan.Name = "lbPan";
            this.lbPan.Size = new System.Drawing.Size(35, 19);
            this.lbPan.TabIndex = 17;
            this.lbPan.Text = "PAN";
            // 
            // tbServiceCode
            // 
            this.tbServiceCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServiceCode.Location = new System.Drawing.Point(28, 231);
            this.tbServiceCode.MaxLength = 3;
            this.tbServiceCode.Name = "tbServiceCode";
            this.tbServiceCode.Size = new System.Drawing.Size(300, 27);
            this.tbServiceCode.TabIndex = 16;
            this.tbServiceCode.TextChanged += new System.EventHandler(this.tbServiceCode_TextChanged);
            // 
            // lbServiceCode
            // 
            this.lbServiceCode.AutoSize = true;
            this.lbServiceCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServiceCode.ForeColor = System.Drawing.Color.Black;
            this.lbServiceCode.Location = new System.Drawing.Point(24, 209);
            this.lbServiceCode.Name = "lbServiceCode";
            this.lbServiceCode.Size = new System.Drawing.Size(92, 19);
            this.lbServiceCode.TabIndex = 15;
            this.lbServiceCode.Text = "Service Code";
            // 
            // tbExpireDate
            // 
            this.tbExpireDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExpireDate.Location = new System.Drawing.Point(28, 167);
            this.tbExpireDate.MaxLength = 4;
            this.tbExpireDate.Name = "tbExpireDate";
            this.tbExpireDate.Size = new System.Drawing.Size(300, 27);
            this.tbExpireDate.TabIndex = 14;
            this.tbExpireDate.TextChanged += new System.EventHandler(this.tbExpireDate_TextChanged);
            // 
            // lbExpireDate
            // 
            this.lbExpireDate.AutoSize = true;
            this.lbExpireDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpireDate.ForeColor = System.Drawing.Color.Black;
            this.lbExpireDate.Location = new System.Drawing.Point(24, 145);
            this.lbExpireDate.Name = "lbExpireDate";
            this.lbExpireDate.Size = new System.Drawing.Size(84, 19);
            this.lbExpireDate.TabIndex = 13;
            this.lbExpireDate.Text = "Expire Date";
            // 
            // tbClearCvk
            // 
            this.tbClearCvk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClearCvk.Location = new System.Drawing.Point(28, 39);
            this.tbClearCvk.Name = "tbClearCvk";
            this.tbClearCvk.Size = new System.Drawing.Size(300, 27);
            this.tbClearCvk.TabIndex = 12;
            this.tbClearCvk.TextChanged += new System.EventHandler(this.tbClearCvk_TextChanged);
            // 
            // lbClearCvk
            // 
            this.lbClearCvk.AutoSize = true;
            this.lbClearCvk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClearCvk.ForeColor = System.Drawing.Color.Black;
            this.lbClearCvk.Location = new System.Drawing.Point(24, 17);
            this.lbClearCvk.Name = "lbClearCvk";
            this.lbClearCvk.Size = new System.Drawing.Size(73, 19);
            this.lbClearCvk.TabIndex = 11;
            this.lbClearCvk.Text = "Clear CVK";
            // 
            // lbClearCvkHint
            // 
            this.lbClearCvkHint.AutoSize = true;
            this.lbClearCvkHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClearCvkHint.Location = new System.Drawing.Point(334, 42);
            this.lbClearCvkHint.Name = "lbClearCvkHint";
            this.lbClearCvkHint.Size = new System.Drawing.Size(0, 19);
            this.lbClearCvkHint.TabIndex = 22;
            // 
            // lbPanHint
            // 
            this.lbPanHint.AutoSize = true;
            this.lbPanHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPanHint.Location = new System.Drawing.Point(334, 106);
            this.lbPanHint.Name = "lbPanHint";
            this.lbPanHint.Size = new System.Drawing.Size(0, 19);
            this.lbPanHint.TabIndex = 23;
            // 
            // lbExpireDateHint
            // 
            this.lbExpireDateHint.AutoSize = true;
            this.lbExpireDateHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpireDateHint.Location = new System.Drawing.Point(334, 170);
            this.lbExpireDateHint.Name = "lbExpireDateHint";
            this.lbExpireDateHint.Size = new System.Drawing.Size(0, 19);
            this.lbExpireDateHint.TabIndex = 24;
            // 
            // lbServiceCodeHint
            // 
            this.lbServiceCodeHint.AutoSize = true;
            this.lbServiceCodeHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServiceCodeHint.Location = new System.Drawing.Point(334, 234);
            this.lbServiceCodeHint.Name = "lbServiceCodeHint";
            this.lbServiceCodeHint.Size = new System.Drawing.Size(0, 19);
            this.lbServiceCodeHint.TabIndex = 25;
            // 
            // UcCvv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lbServiceCodeHint);
            this.Controls.Add(this.lbExpireDateHint);
            this.Controls.Add(this.lbPanHint);
            this.Controls.Add(this.lbClearCvkHint);
            this.Controls.Add(this.tbCvv);
            this.Controls.Add(this.lbCvv);
            this.Controls.Add(this.btnGenerateCvv);
            this.Controls.Add(this.tbPan);
            this.Controls.Add(this.lbPan);
            this.Controls.Add(this.tbServiceCode);
            this.Controls.Add(this.lbServiceCode);
            this.Controls.Add(this.tbExpireDate);
            this.Controls.Add(this.lbExpireDate);
            this.Controls.Add(this.tbClearCvk);
            this.Controls.Add(this.lbClearCvk);
            this.Name = "UcCvv";
            this.Size = new System.Drawing.Size(610, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCvv;
        private System.Windows.Forms.Label lbCvv;
        private System.Windows.Forms.Button btnGenerateCvv;
        private System.Windows.Forms.TextBox tbPan;
        private System.Windows.Forms.Label lbPan;
        private System.Windows.Forms.TextBox tbServiceCode;
        private System.Windows.Forms.Label lbServiceCode;
        private System.Windows.Forms.TextBox tbExpireDate;
        private System.Windows.Forms.Label lbExpireDate;
        private System.Windows.Forms.TextBox tbClearCvk;
        private System.Windows.Forms.Label lbClearCvk;
        private System.Windows.Forms.Label lbClearCvkHint;
        private System.Windows.Forms.Label lbPanHint;
        private System.Windows.Forms.Label lbExpireDateHint;
        private System.Windows.Forms.Label lbServiceCodeHint;
    }
}
