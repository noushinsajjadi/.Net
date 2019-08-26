using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamrin2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblenteryourname_MouseMove(object sender, MouseEventArgs e)
        {
            lblenteryourname.ForeColor = Color.Red;
        }

        private void lblenteryourname_MouseLeave(object sender, EventArgs e)
        {
            lblenteryourname.ForeColor = Color.Black;
        }

        private void btnsayhello_Click(object sender, EventArgs e)
        {
            string s;
            s = "Hello " + txtname.Text;
            lblresult.Text = s;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            lblresult.Text = "";
            txtname.Focus();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (txtname.Text == "")
                btnsayhello.Enabled = false;
            else
                btnsayhello.Enabled = true;
            btnclear.Enabled = Convert.ToBoolean(txtname.Text.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtname_TextChanged(null, null); 
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
