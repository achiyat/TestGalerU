using automation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGalerU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            testElement test = new testElement();
            test.run("https://blue-field-01c0eaf03.3.azurestaticapps.net/");
        }

        private void button_Continue_Click(object sender, EventArgs e)
        {
            testElement test = new testElement();
            test.run1("https://blue-field-01c0eaf03.3.azurestaticapps.net", textEmail.Text, textPassword.Text);
        }

        private void buttonGoogle_Click(object sender, EventArgs e)
        {
            testElement test = new testElement();
            test.LoginWithGoogle("https://blue-field-01c0eaf03.3.azurestaticapps.net", textEmail.Text, textPassword.Text);
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            testElement test = new testElement();
            test.SignUp("https://blue-field-01c0eaf03.3.azurestaticapps.net", textEmail.Text, textPassword.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
