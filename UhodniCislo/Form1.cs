using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using Google.Cloud.Firestore;


namespace UhodniCislo
{  
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConfPassword.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();
        }


        private async void btnRegister_Click(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\dudacek.on.2022\\Desktop\\uhodnicislo\\Uhodni-cislo\\uhodni-cislo-1f419338feb1.json");
            string projectId = "uhodni-cislo";
            FirestoreDb db = FirestoreDb.Create(projectId);
            if(txtConfPassword.Text=="" || txtPassword.Text=="" || txtUsername.Text == "")
            {
                MessageBox.Show("Nějaká políčka jsou prázdná!");
            }

            if (txtPassword.Text == txtConfPassword.Text)
            {
                DocumentReference docRef = db.Collection("users").Document(txtUsername.Text);
                Dictionary<string, object> user = new Dictionary<string, object>
                {
                     { "username", txtUsername.Text },
                     { "password", txtPassword.Text },
                };
                await docRef.SetAsync(user);

                txtConfPassword.Text = "";
                txtPassword.Text = "";
                txtUsername.Text = "";

                MessageBox.Show("Registration successful");
            }
            else
            {
                MessageBox.Show("Passwords do not match!", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfPassword.Text = "";
                txtPassword.Text = "";
                txtUsername.Text = "";
            }

        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas. Checked)
            {
                txtConfPassword.PasswordChar = '\0';
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtConfPassword.PasswordChar = '*';
                txtPassword.PasswordChar = '*';
            }
        }

        private void backLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
