using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTabs
{
    public partial class WebContainer : Form
    {
        public WebContainer()
        {
            InitializeComponent();
            webView21.Source = new Uri(TestTabs.Properties.Settings.Default.WebViewUrl.ToString());

        }
        private void WebContainer_Load(object sender, EventArgs e)
        {


        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoBack)
            {
                webView21.GoBack();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoForward)
            {
                webView21.GoForward();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Reload();
        }
    }
}
