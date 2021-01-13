using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void cboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(cboLocation.Text);
                      
            }



        }

        private void button_back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button_forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cboLocation.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "MainBrowser" + webBrowser1.Document.Title;
        }
    }
}
