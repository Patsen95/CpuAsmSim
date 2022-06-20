namespace CpuSim
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
            if(disposing && (components != null))
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
            this.dgv_regs = new System.Windows.Forms.DataGridView();
            this.pg = new System.Windows.Forms.PropertyGrid();
            this.dgv_ram = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.codeBox1 = new CpuSim.CodeBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_regs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ram)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_regs
            // 
            this.dgv_regs.AllowUserToAddRows = false;
            this.dgv_regs.AllowUserToDeleteRows = false;
            this.dgv_regs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_regs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_regs.Location = new System.Drawing.Point(1112, 24);
            this.dgv_regs.Name = "dgv_regs";
            this.dgv_regs.ReadOnly = true;
            this.dgv_regs.Size = new System.Drawing.Size(203, 208);
            this.dgv_regs.TabIndex = 0;
            // 
            // pg
            // 
            this.pg.Location = new System.Drawing.Point(456, 96);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(304, 552);
            this.pg.TabIndex = 1;
            // 
            // dgv_ram
            // 
            this.dgv_ram.AllowUserToAddRows = false;
            this.dgv_ram.AllowUserToDeleteRows = false;
            this.dgv_ram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ram.Location = new System.Drawing.Point(816, 24);
            this.dgv_ram.Name = "dgv_ram";
            this.dgv_ram.ReadOnly = true;
            this.dgv_ram.Size = new System.Drawing.Size(283, 200);
            this.dgv_ram.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(1080, 288);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 248);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "textBox1";
            // 
            // codeBox1
            // 
            this.codeBox1.BackColor = System.Drawing.SystemColors.Window;
            this.codeBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeBox1.DisplayCaret = true;
            this.codeBox1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.codeBox1.Location = new System.Drawing.Point(848, 304);
            this.codeBox1.Name = "codeBox1";
            this.codeBox1.Size = new System.Drawing.Size(184, 150);
            this.codeBox1.TabAsSpaces = false;
            this.codeBox1.TabIndex = 4;
            this.codeBox1.TabSize = 4;
            this.codeBox1.Text = "codeBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 869);
            this.Controls.Add(this.codeBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_regs);
            this.Controls.Add(this.dgv_ram);
            this.Controls.Add(this.pg);
            this.Name = "Form1";
            this.Text = "CustomTextBox Enabled";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_regs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_regs;
        private System.Windows.Forms.PropertyGrid pg;
        private System.Windows.Forms.DataGridView dgv_ram;
        private System.Windows.Forms.TextBox textBox1;
        private CodeBox codeBox1;
    }
}

