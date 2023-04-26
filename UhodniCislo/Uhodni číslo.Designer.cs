namespace UhodniCislo
{
    partial class frmUhodniCislo
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


        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtInsret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Hint1;
        private System.Windows.Forms.Label Hint2;
        private System.Windows.Forms.Label Hint3;

        private void InitializeComponent()
        {
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtInsret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hint1 = new System.Windows.Forms.Label();
            this.Hint2 = new System.Windows.Forms.Label();
            this.Hint3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(12, 304);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(216, 35);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnClear.Location = new System.Drawing.Point(234, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtInsret
            // 
            this.txtInsret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtInsret.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsret.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsret.Location = new System.Drawing.Point(12, 253);
            this.txtInsret.MaxLength = 30;
            this.txtInsret.Name = "txtInsret";
            this.txtInsret.Size = new System.Drawing.Size(476, 25);
            this.txtInsret.TabIndex = 11;
            this.txtInsret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Guess the Number";
            // 
            // Hint1
            // 
            this.Hint1.AutoSize = true;
            this.Hint1.Location = new System.Drawing.Point(33, 75);
            this.Hint1.Name = "Hint1";
            this.Hint1.Size = new System.Drawing.Size(42, 17);
            this.Hint1.TabIndex = 14;
            this.Hint1.Text = "Hint1";
            // 
            // Hint2
            // 
            this.Hint2.AutoSize = true;
            this.Hint2.Location = new System.Drawing.Point(33, 119);
            this.Hint2.Name = "Hint2";
            this.Hint2.Size = new System.Drawing.Size(42, 17);
            this.Hint2.TabIndex = 15;
            this.Hint2.Text = "Hint2";
            // 
            // Hint3
            // 
            this.Hint3.AutoSize = true;
            this.Hint3.Location = new System.Drawing.Point(33, 170);
            this.Hint3.Name = "Hint3";
            this.Hint3.Size = new System.Drawing.Size(42, 17);
            this.Hint3.TabIndex = 16;
            this.Hint3.Text = "Hint3";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(360, 304);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(128, 35);
            this.btnGenerate.TabIndex = 17;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmUhodniCislo
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 361);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.Hint3);
            this.Controls.Add(this.Hint2);
            this.Controls.Add(this.Hint1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsret);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUhodniCislo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gues the Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnGenerate;
    }
}