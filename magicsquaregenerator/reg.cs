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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void makeReg_Click(object sender, EventArgs e)
        {
            dbManager dbManager = new dbManager("C:\\Users\\Артём\\users.db");
            if (dbManager.AddUser(regLog.Text, regPswrd.Text) == true)
            {
                MessageBox.Show("Успешно");
            }
            else {
                MessageBox.Show("Провал");            
            }
        }
    }
}
