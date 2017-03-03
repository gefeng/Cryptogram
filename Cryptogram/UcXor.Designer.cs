namespace Cryptogram
{
    partial class UcXor
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
            this.lbBlockA = new System.Windows.Forms.Label();
            this.lbBlockB = new System.Windows.Forms.Label();
            this.tbBlockA = new System.Windows.Forms.TextBox();
            this.tbBlockB = new System.Windows.Forms.TextBox();
            this.tbXor = new System.Windows.Forms.TextBox();
            this.lbXor = new System.Windows.Forms.Label();
            this.lbBlockAHint = new System.Windows.Forms.Label();
            this.lbBlockBHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBlockA
            // 
            this.lbBlockA.AutoSize = true;
            this.lbBlockA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbBlockA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlockA.ForeColor = System.Drawing.Color.Black;
            this.lbBlockA.Location = new System.Drawing.Point(27, 80);
            this.lbBlockA.Name = "lbBlockA";
            this.lbBlockA.Size = new System.Drawing.Size(57, 19);
            this.lbBlockA.TabIndex = 0;
            this.lbBlockA.Text = "Block A";
            // 
            // lbBlockB
            // 
            this.lbBlockB.AutoSize = true;
            this.lbBlockB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlockB.ForeColor = System.Drawing.Color.Black;
            this.lbBlockB.Location = new System.Drawing.Point(27, 165);
            this.lbBlockB.Name = "lbBlockB";
            this.lbBlockB.Size = new System.Drawing.Size(57, 19);
            this.lbBlockB.TabIndex = 1;
            this.lbBlockB.Text = "Block B";
            // 
            // tbBlockA
            // 
            this.tbBlockA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBlockA.ForeColor = System.Drawing.Color.Black;
            this.tbBlockA.Location = new System.Drawing.Point(31, 102);
            this.tbBlockA.Name = "tbBlockA";
            this.tbBlockA.Size = new System.Drawing.Size(300, 27);
            this.tbBlockA.TabIndex = 2;
            this.tbBlockA.TextChanged += new System.EventHandler(this.tbBlockA_TextChanged);
            // 
            // tbBlockB
            // 
            this.tbBlockB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBlockB.ForeColor = System.Drawing.Color.Black;
            this.tbBlockB.Location = new System.Drawing.Point(31, 187);
            this.tbBlockB.Name = "tbBlockB";
            this.tbBlockB.Size = new System.Drawing.Size(300, 27);
            this.tbBlockB.TabIndex = 3;
            this.tbBlockB.TextChanged += new System.EventHandler(this.tbBlockB_TextChanged);
            // 
            // tbXor
            // 
            this.tbXor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXor.ForeColor = System.Drawing.Color.Black;
            this.tbXor.Location = new System.Drawing.Point(31, 272);
            this.tbXor.Name = "tbXor";
            this.tbXor.ReadOnly = true;
            this.tbXor.Size = new System.Drawing.Size(300, 27);
            this.tbXor.TabIndex = 4;
            // 
            // lbXor
            // 
            this.lbXor.AutoSize = true;
            this.lbXor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbXor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXor.ForeColor = System.Drawing.Color.Black;
            this.lbXor.Location = new System.Drawing.Point(27, 250);
            this.lbXor.Name = "lbXor";
            this.lbXor.Size = new System.Drawing.Size(37, 19);
            this.lbXor.TabIndex = 5;
            this.lbXor.Text = "XOR";
            // 
            // lbBlockAHint
            // 
            this.lbBlockAHint.AutoSize = true;
            this.lbBlockAHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlockAHint.ForeColor = System.Drawing.Color.Black;
            this.lbBlockAHint.Location = new System.Drawing.Point(337, 105);
            this.lbBlockAHint.Name = "lbBlockAHint";
            this.lbBlockAHint.Size = new System.Drawing.Size(0, 19);
            this.lbBlockAHint.TabIndex = 6;
            // 
            // lbBlockBHint
            // 
            this.lbBlockBHint.AutoSize = true;
            this.lbBlockBHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlockBHint.ForeColor = System.Drawing.Color.Black;
            this.lbBlockBHint.Location = new System.Drawing.Point(337, 190);
            this.lbBlockBHint.Name = "lbBlockBHint";
            this.lbBlockBHint.Size = new System.Drawing.Size(0, 19);
            this.lbBlockBHint.TabIndex = 7;
            // 
            // UcXor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lbBlockBHint);
            this.Controls.Add(this.lbBlockAHint);
            this.Controls.Add(this.lbXor);
            this.Controls.Add(this.tbXor);
            this.Controls.Add(this.tbBlockB);
            this.Controls.Add(this.tbBlockA);
            this.Controls.Add(this.lbBlockB);
            this.Controls.Add(this.lbBlockA);
            this.Name = "UcXor";
            this.Size = new System.Drawing.Size(610, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBlockA;
        private System.Windows.Forms.Label lbBlockB;
        private System.Windows.Forms.TextBox tbBlockA;
        private System.Windows.Forms.TextBox tbBlockB;
        private System.Windows.Forms.TextBox tbXor;
        private System.Windows.Forms.Label lbXor;
        private System.Windows.Forms.Label lbBlockAHint;
        private System.Windows.Forms.Label lbBlockBHint;
    }
}
