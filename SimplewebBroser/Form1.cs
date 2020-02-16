using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplewebBroser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // posistion the web browser control
            webBrowser1.Top = 35;
            webBrowser1.Left = 0;
            // size the web browser control
            webBrowser1.Width = this.Width -3;
            webBrowser1.Height = this.Height;

            // navigate to home page 
            webBrowser1.Navigate("https://google.com");

            // Supress script errors
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // posistion the web browser control
            webBrowser1.Top = 35;
            webBrowser1.Left = 0;
            // size the web browser control
            webBrowser1.Width = this.Width -3;
            webBrowser1.Height = this.Height;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // home button
            // navigate to home page 
            webBrowser1.Navigate("https://google.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // forward a page
            webBrowser1.GoForward();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // back a page
            webBrowser1.GoBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }
    }
}
