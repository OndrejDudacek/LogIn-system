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
    }

    public class Usernam
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
