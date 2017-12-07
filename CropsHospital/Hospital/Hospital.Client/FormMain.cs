using System;
using System.Windows.Forms;

namespace Hospital.Client
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://m.bjszhgx.com");
            webBrowser1.ObjectForScripting = new FormMain();
        }
    }
}
