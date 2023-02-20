using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;

namespace LogIn_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        OdbcConnection con = new OdbcConnection("Driver={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=F:\\Dokumenty\\Codes\\Uhodni číslo\\LogIn system\\bin\\Debug\\db_users.mdb");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtusername.Text + "' and password= '" + txtpassword.Text + "'";
            cmd = new OdbcCommand(login, con);
            OdbcDataReader dr = cmd.ExecuteReader();
            

            if (dr.Read() == true)
            {
                new MainPage().Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtusername.Text = "";
                txtusername.Focus();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpassword.Text = "";
            txtusername.Text = "";
            txtusername.Focus();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Registrace().Show();
            this.Hide();
        }
    }
}
