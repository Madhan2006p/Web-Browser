using FireTabs;
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
    public partial class AppContainer : FireTitle
    {
        public AppContainer()
        {
            InitializeComponent();
            TabRenderer = new FireTabRenderer(this);
        }

        public override FireTitleTab CreateTab()
        {
            return new FireTitleTab(this)
            {
                Content = new WebContainer
                {
                    Text = "Browser"
                }
            };
        }
    }
}
