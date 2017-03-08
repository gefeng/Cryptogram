namespace Cryptogram
{
    partial class FormMain
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbMinimize = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.btnXor = new System.Windows.Forms.Button();
            this.btnTripleDes = new System.Windows.Forms.Button();
            this.btnPinBlock = new System.Windows.Forms.Button();
            this.btnPvv = new System.Windows.Forms.Button();
            this.btnCvv = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.panelTitleBar.Controls.Add(this.lbMinimize);
            this.panelTitleBar.Controls.Add(this.lbClose);
            this.panelTitleBar.Controls.Add(this.lbTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(1, 1);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(758, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseMove);
            this.panelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseUp);
            // 
            // lbMinimize
            // 
            this.lbMinimize.AutoSize = true;
            this.lbMinimize.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinimize.ForeColor = System.Drawing.Color.White;
            this.lbMinimize.Location = new System.Drawing.Point(700, 9);
            this.lbMinimize.Name = "lbMinimize";
            this.lbMinimize.Size = new System.Drawing.Size(22, 26);
            this.lbMinimize.TabIndex = 2;
            this.lbMinimize.Text = "_";
            this.lbMinimize.Click += new System.EventHandler(this.lbMinimize_Click);
            this.lbMinimize.MouseEnter += new System.EventHandler(this.lbMinimize_MouseEnter);
            this.lbMinimize.MouseLeave += new System.EventHandler(this.lbMinimize_MouseLeave);
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.Transparent;
            this.lbClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.White;
            this.lbClose.Location = new System.Drawing.Point(728, 12);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(24, 26);
            this.lbClose.TabIndex = 1;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            this.lbClose.MouseEnter += new System.EventHandler(this.lbClose_MouseEnter);
            this.lbClose.MouseLeave += new System.EventHandler(this.lbClose_MouseLeave);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(138, 27);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Cryptogram";
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.panelSideBar.Controls.Add(this.btnXor);
            this.panelSideBar.Controls.Add(this.btnTripleDes);
            this.panelSideBar.Controls.Add(this.btnPinBlock);
            this.panelSideBar.Controls.Add(this.btnPvv);
            this.panelSideBar.Controls.Add(this.btnCvv);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(1, 51);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(150, 428);
            this.panelSideBar.TabIndex = 1;
            // 
            // btnXor
            // 
            this.btnXor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXor.FlatAppearance.BorderSize = 0;
            this.btnXor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnXor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnXor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXor.ForeColor = System.Drawing.Color.White;
            this.btnXor.Location = new System.Drawing.Point(0, 200);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(150, 50);
            this.btnXor.TabIndex = 4;
            this.btnXor.Text = "XOR";
            this.btnXor.UseVisualStyleBackColor = true;
            this.btnXor.Click += new System.EventHandler(this.btnXor_Click);
            this.btnXor.MouseEnter += new System.EventHandler(this.btnXor_MouseOver);
            this.btnXor.MouseLeave += new System.EventHandler(this.btnXor_MouseLeave);
            // 
            // btnTripleDes
            // 
            this.btnTripleDes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTripleDes.FlatAppearance.BorderSize = 0;
            this.btnTripleDes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnTripleDes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnTripleDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTripleDes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTripleDes.ForeColor = System.Drawing.Color.White;
            this.btnTripleDes.Location = new System.Drawing.Point(0, 150);
            this.btnTripleDes.Name = "btnTripleDes";
            this.btnTripleDes.Size = new System.Drawing.Size(150, 50);
            this.btnTripleDes.TabIndex = 3;
            this.btnTripleDes.Text = "TripleDES";
            this.btnTripleDes.UseVisualStyleBackColor = true;
            this.btnTripleDes.Click += new System.EventHandler(this.btnTripleDes_Click);
            this.btnTripleDes.MouseEnter += new System.EventHandler(this.btnTripleDes_MouseOver);
            this.btnTripleDes.MouseLeave += new System.EventHandler(this.btnTripleDes_MouseLeave);
            // 
            // btnPinBlock
            // 
            this.btnPinBlock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPinBlock.FlatAppearance.BorderSize = 0;
            this.btnPinBlock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnPinBlock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnPinBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPinBlock.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPinBlock.ForeColor = System.Drawing.Color.White;
            this.btnPinBlock.Location = new System.Drawing.Point(0, 100);
            this.btnPinBlock.Name = "btnPinBlock";
            this.btnPinBlock.Size = new System.Drawing.Size(150, 50);
            this.btnPinBlock.TabIndex = 2;
            this.btnPinBlock.Text = "PINBlock";
            this.btnPinBlock.UseVisualStyleBackColor = true;
            this.btnPinBlock.Click += new System.EventHandler(this.btnPinBlock_Click);
            this.btnPinBlock.MouseEnter += new System.EventHandler(this.btnPinBlock_MouseOver);
            this.btnPinBlock.MouseLeave += new System.EventHandler(this.btnPinBlock_MouseLeave);
            // 
            // btnPvv
            // 
            this.btnPvv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPvv.FlatAppearance.BorderSize = 0;
            this.btnPvv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnPvv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnPvv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvv.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvv.ForeColor = System.Drawing.Color.White;
            this.btnPvv.Location = new System.Drawing.Point(0, 50);
            this.btnPvv.Name = "btnPvv";
            this.btnPvv.Size = new System.Drawing.Size(150, 50);
            this.btnPvv.TabIndex = 1;
            this.btnPvv.Text = "PVV";
            this.btnPvv.UseVisualStyleBackColor = true;
            this.btnPvv.Click += new System.EventHandler(this.btnPvv_Click);
            this.btnPvv.MouseEnter += new System.EventHandler(this.btnPvv_MouseOver);
            this.btnPvv.MouseLeave += new System.EventHandler(this.btnPvv_MouseLeave);
            // 
            // btnCvv
            // 
            this.btnCvv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCvv.FlatAppearance.BorderSize = 0;
            this.btnCvv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCvv.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCvv.ForeColor = System.Drawing.Color.White;
            this.btnCvv.Location = new System.Drawing.Point(0, 0);
            this.btnCvv.Name = "btnCvv";
            this.btnCvv.Size = new System.Drawing.Size(150, 50);
            this.btnCvv.TabIndex = 0;
            this.btnCvv.Text = "CVV";
            this.btnCvv.UseVisualStyleBackColor = true;
            this.btnCvv.Click += new System.EventHandler(this.btnCvv_Click);
            this.btnCvv.MouseEnter += new System.EventHandler(this.btnCvv_MouseOver);
            this.btnCvv.MouseLeave += new System.EventHandler(this.btnCvv_MouseLeave);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.ForeColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(151, 51);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(608, 428);
            this.panelMain.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(760, 480);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptogram";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button btnXor;
        private System.Windows.Forms.Button btnTripleDes;
        private System.Windows.Forms.Button btnPinBlock;
        private System.Windows.Forms.Button btnPvv;
        private System.Windows.Forms.Button btnCvv;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbMinimize;
        private System.Windows.Forms.Label lbClose;
    }
}

