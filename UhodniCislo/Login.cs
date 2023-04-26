using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;


namespace UhodniCislo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();
        }

        private void crtAccount_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string projectId = "uhodni-cislo";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "uhodni-cislo-1f419338feb1.json");
            FirestoreDb db = FirestoreDb.Create(projectId);

            if (txtUsername.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Please enter username and password!");
                return;
            }

            DocumentReference docRef = db.Collection("users").Document(txtUsername.Text);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                Dictionary<string, object> data = snapshot.ToDictionary();
                if (data.ContainsKey("password") && (string)data["password"] == txtPassword.Text)
                {
                    MessageBox.Show("Login successful!");
                    new Uhodni_číslo().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid password!");
                }
            }
            else
            {
                MessageBox.Show("Username not found!");
            }
        }
    }
}
