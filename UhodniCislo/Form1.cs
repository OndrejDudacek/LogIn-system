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

        private async Task btnRegister_ClickAsync(object sender, EventArgs e)
        {
            string projectId = "your-project-id";
            FirestoreDb db = FirestoreDb.Create(projectId);

            if (txtPassword.Text == txtConfPassword.Text)
            {
                DocumentReference docRef = db.Collection("users").Document(txtUsername.Text);
                Dictionary<string, object> user = new Dictionary<string, object>
                {
                     { "username", txtUsername.Text },
                     { "password", txtPassword.Text },
                };
                await docRef.SetAsync(user);
            }

        }
    }
}

