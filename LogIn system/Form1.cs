namespace LogIn_system
{
    public partial class Registrace : Form
    {
        public Registrace()
        {
            InitializeComponent();

        }

        OdbcConnection con = new OdbcConnection("Driver={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=F:\\Dokumenty\\Codes\\Uhodni èíslo\\LogIn system\\bin\\Debug\\db_users.mdb");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" && txtpassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpassword.Text == txtComPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES('" + txtusername.Text + "','" + txtpassword.Text + "')";
                cmd = new OdbcCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your Account has been created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtpassword.Text = "";
                txtusername.Text = "";
                txtComPassword.Text = "";
            }

            else
            {
                MessageBox.Show("Passwords does not match, please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtpassword.Focus();
                txtComPassword.Text = "";

            }
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';  
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpassword.Text = "";
            txtusername.Text = "";
            txtComPassword.Text = "";
            txtusername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}