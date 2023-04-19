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
    public partial class Uhodni_číslo : Form
    {
        private int number;
        private int length;

        public Uhodni_číslo()
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
                        int closeTo = rnd.Next(number + 5, number - 5);
                        Console.WriteLine("It is close to this number: " + closeTo);
                        break;
                }
            }
        }
    }
}
