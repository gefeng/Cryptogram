namespace Cryptogram
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXOR = new System.Windows.Forms.Button();
            this.btnTripleDES = new System.Windows.Forms.Button();
            this.btnPINBlock = new System.Windows.Forms.Button();
            this.btnCVV = new System.Windows.Forms.Button();
            this.btnPVV = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.btnXOR);
            this.panel1.Controls.Add(this.btnTripleDES);
            this.panel1.Controls.Add(this.btnPINBlock);
            this.panel1.Controls.Add(this.btnCVV);
            this.panel1.Controls.Add(this.btnPVV);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(137, 479);
            this.panel1.TabIndex = 0;
            // 
            // btnXOR
            // 
            this.btnXOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnXOR.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnXOR.FlatAppearance.BorderSize = 0;
            this.btnXOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXOR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOR.ForeColor = System.Drawing.Color.White;
            this.btnXOR.Location = new System.Drawing.Point(0, 257);
            this.btnXOR.Name = "btnXOR";
            this.btnXOR.Size = new System.Drawing.Size(137, 45);
            this.btnXOR.TabIndex = 5;
            this.btnXOR.Text = "XOR";
            this.btnXOR.UseVisualStyleBackColor = false;
            // 
            // btnTripleDES
            // 
            this.btnTripleDES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTripleDES.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnTripleDES.FlatAppearance.BorderSize = 0;
            this.btnTripleDES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTripleDES.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTripleDES.ForeColor = System.Drawing.Color.White;
            this.btnTripleDES.Location = new System.Drawing.Point(0, 206);
            this.btnTripleDES.Name = "btnTripleDES";
            this.btnTripleDES.Size = new System.Drawing.Size(137, 45);
            this.btnTripleDES.TabIndex = 4;
            this.btnTripleDES.Text = "Triple DES";
            this.btnTripleDES.UseVisualStyleBackColor = false;
            // 
            // btnPINBlock
            // 
            this.btnPINBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnPINBlock.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnPINBlock.FlatAppearance.BorderSize = 0;
            this.btnPINBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPINBlock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPINBlock.ForeColor = System.Drawing.Color.White;
            this.btnPINBlock.Location = new System.Drawing.Point(0, 155);
            this.btnPINBlock.Name = "btnPINBlock";
            this.btnPINBlock.Size = new System.Drawing.Size(137, 45);
            this.btnPINBlock.TabIndex = 3;
            this.btnPINBlock.Text = "PIN Block";
            this.btnPINBlock.UseVisualStyleBackColor = false;
            // 
            // btnCVV
            // 
            this.btnCVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnCVV.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnCVV.FlatAppearance.BorderSize = 0;
            this.btnCVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCVV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCVV.ForeColor = System.Drawing.Color.White;
            this.btnCVV.Location = new System.Drawing.Point(0, 104);
            this.btnCVV.Name = "btnCVV";
            this.btnCVV.Size = new System.Drawing.Size(137, 45);
            this.btnCVV.TabIndex = 2;
            this.btnCVV.Text = "CVV";
            this.btnCVV.UseVisualStyleBackColor = false;
            // 
            // btnPVV
            // 
            this.btnPVV.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnPVV.FlatAppearance.BorderSize = 0;
            this.btnPVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPVV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPVV.ForeColor = System.Drawing.Color.White;
            this.btnPVV.Location = new System.Drawing.Point(0, 53);
            this.btnPVV.Name = "btnPVV";
            this.btnPVV.Size = new System.Drawing.Size(137, 45);
            this.btnPVV.TabIndex = 1;
            this.btnPVV.Text = "PVV";
            this.btnPVV.UseVisualStyleBackColor = false;
            this.btnPVV.Click += new System.EventHandler(this.btnPVV_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 47);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(137, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 47);
            this.panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(137, 47);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(627, 432);
            this.panelMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(764, 479);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTripleDES;
        private System.Windows.Forms.Button btnPINBlock;
        private System.Windows.Forms.Button btnCVV;
        private System.Windows.Forms.Button btnPVV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXOR;
        private System.Windows.Forms.Panel panelMain;
    }
}

