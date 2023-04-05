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
        }


        private async Task btnRegister_Click(object sender, EventArgs e)
        {
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

                MessageBox.Show("Úspěšné přihlášení.");
            }
            else
            {
                MessageBox.Show("Hesla se neshodují!");
            }

        }
    }
}
