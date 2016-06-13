using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emotion.Apps
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            string fileLoc = @"session.pur";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (File.Exists(fileLoc))
            {
                using (TextReader tr = new StreamReader(fileLoc))
                {    
                   Application.Run(new TestingView(tr.ReadLine()));
                    tr.Close();
                }
            }else
            {
                Application.Run(new LoginView());
            }
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestingView());
        }
    }
}
