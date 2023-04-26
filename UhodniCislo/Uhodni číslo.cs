using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UhodniCislo
{
    public partial class frmUhodniCislo : Form
    {
        private int number;
        private int length;

        public frmUhodniCislo()
        {
            InitializeComponent();
        }
        public int GenerateNumber()
        {
            Random rnd = new Random();
            number = rnd.Next(1, 100);
            return number;
        }

        public void GenerateClues()
        {
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                int tmp = rnd.Next(1, 4);
                switch (tmp)
                {
                    case 1:
                        int biggerThen = 0;
                        if (number > 25)
                            biggerThen = 25;
                        else if (number > 50)
                            biggerThen = 50;
                        else if (number > 75)
                            biggerThen = 75;
                        Console.WriteLine("The number is bigger then " + biggerThen);
                        break;

                    case 2:
                        string evenOdd = "ODD";
                        if (number % 2 == 0)
                            evenOdd = "EVEN";
                        Console.WriteLine("The number is " + evenOdd);
                        break;

                    case 3:
                        bool oneInInt = number.ToString().Contains("1");
                        string oneInString = "NO";
                        if (oneInInt == true)
                            oneInString = "YES";
                        Console.WriteLine("Does the number contains 1: " + oneInString);
                        break;

                    case 4:
                        int closeTo = 0;
                        do
                            closeTo = rnd.Next(number + 5, number - 5);
                        while (closeTo != number);
                        Console.WriteLine("It is close to this number: " + closeTo);
                        break;
                }
            }
        }

        private void InitializeComponent()
        {
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hint1 = new System.Windows.Forms.Label();
            this.Hint2 = new System.Windows.Forms.Label();
            this.Hint3 = new System.Windows.Forms.Label();
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
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnClear.Location = new System.Drawing.Point(272, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(216, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(12, 253);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(476, 25);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hint1
            // 
            this.Hint1.AutoSize = true;
            this.Hint1.Location = new System.Drawing.Point(33, 75);
            this.Hint1.Name = "Hint1";
            this.Hint1.Size = new System.Drawing.Size(42, 17);
            this.Hint1.TabIndex = 14;
            this.Hint1.Text = "Hint1";
            this.Hint1.Click += new System.EventHandler(this.Hint1_Click);
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
            // frmUhodniCislo
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 361);
            this.Controls.Add(this.Hint3);
            this.Controls.Add(this.Hint2);
            this.Controls.Add(this.Hint1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUhodniCislo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gues the Number";
            this.Load += new System.EventHandler(this.frmUhodniCislo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void frmUhodniCislo_Load(object sender, EventArgs e)
        {

        }

        private void Hint1_Click(object sender, EventArgs e)
        {

        }
    }
}
