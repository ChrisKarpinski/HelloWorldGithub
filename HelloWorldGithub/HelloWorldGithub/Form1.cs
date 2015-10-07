using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldGithub
{
    public partial class frmHelloWorldGithub : Form
    {
        public frmHelloWorldGithub()
        {
            InitializeComponent();
        }

        private void frmHelloWorldGithub_Load(object sender, EventArgs e)
        {

        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {


        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }
    }
}
