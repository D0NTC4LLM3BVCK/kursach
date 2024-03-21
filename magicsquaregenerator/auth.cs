using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magicsquaregenerator
{
    public partial class auth : Form
    {
        private bool _isAunthentificated = false; 
        

        public auth()
        {
            InitializeComponent();
        }

        private void auth_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void goReg_Click(object sender, EventArgs e)
        {
            reg reg_form = new reg();
            reg_form.ShowDialog();
        }

        private void auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isAunthentificated == false) 
            {
                Application.Exit();
            }
        }

        private void makeAuth_Click(object sender, EventArgs e)
        {
            dbManager dbManager = new dbManager("C:\\Users\\Артём\\users.db");
            if (dbManager.CheckUser(authLog.Text, authPswrd.Text) == true)
            {
                _isAunthentificated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Провал");
            }

        }
    }
}
