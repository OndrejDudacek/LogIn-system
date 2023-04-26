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

        public void WriteClues()
        {
            Hint1.Text = GenerateClues();
            do
               Hint2.Text = GenerateClues();
            while (Hint2.Text != Hint1.Text);
            do
               Hint3.Text = GenerateClues();
            while (Hint3.Text != Hint1.Text || Hint2.Text != Hint3.Text);
            
        }

        public string GenerateClues()
        {
            Random rnd = new Random();
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
                        closeTo = rnd.Next(number + 5, number - 5);
                    while (closeTo != number);
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
            GenerateNumber();
            WriteClues();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Int32.Parse(txtInsret.Text);

            if (number == txtInsret.Text)
            {

            }
        }
    }
}
