using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireTabs;

namespace TestTabs
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContainer container = new AppContainer();

            container.Tabs.Add(
                new FireTitleTab(container)
                {
                    Content = new WebContainer
                    {
                        Text = "Browser"
                    }
                }
            );

            container.SelectedTabIndex = 0;

            FireTitleApplicationContext applicationContext = new FireTitleApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
