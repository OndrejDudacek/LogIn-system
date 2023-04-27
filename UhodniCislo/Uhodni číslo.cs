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

        public void WriteClues()
        {
            Hint1.Text = GenerateClues();
            do
                Hint2.Text = GenerateClues();
            while (Hint2.Text == Hint1.Text || Hint2.Text == Hint3.Text);
            do
                Hint3.Text = GenerateClues();
            while (Hint3.Text == Hint1.Text || Hint3.Text == Hint2.Text);

        }

        public string GenerateClues()
        {
            Random rnd = new Random();
            int tmp = rnd.Next(1, 5);
            switch (tmp)
            {
               case 1:
                    int biggerThen = 0;
                    if (number > 25)
                        biggerThen = 25;
                    if (number > 50)
                        biggerThen = 50;
                    if (number > 75)
                        biggerThen = 75;
                    return "The number is bigger then " + biggerThen;
                    break;

                case 2:
                    string evenOdd = "ODD";
                    if (number % 2 == 0)
                        evenOdd = "EVEN";
                    return "The number is " + evenOdd;
                    break;

                case 3:
                    bool oneInInt = number.ToString().Contains("1");
                    string oneInString = "NO";
                    if (oneInInt == true)
                        oneInString = "YES";
                    return "Does the number contains 1: " + oneInString;
                    break;

                case 4:
                    int closeTo = 0;
                    do
                        closeTo = rnd.Next(number - 5, number + 5);
                    while (closeTo == number);
                    return "It is close to this number: " + closeTo;
                    break;

                default:
                    return "error";
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInsret.Text = "";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtInsret.Text = "";
            GenerateNumber();
            WriteClues();
            //txtInsret.Text = number.ToString();
        }

        private void txtInsret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtInsret.Text == "")
            {
                MessageBox.Show("Empty field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (number == Int32.Parse(txtInsret.Text))
            {
                MessageBox.Show("Correct", "You Won", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
