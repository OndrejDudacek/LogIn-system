namespace LogIn_system
{
    public partial class Registrace : Form
    {
        public Registrace()
        {
            InitializeComponent();

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

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
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your Account has been created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Passwords does not match, please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtpassword.Focus();
                txtComPassword.Text = "";

            }
        }
    }
}