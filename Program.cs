using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

// using DBConn;

namespace Trial_IT_03
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Debug.WriteLine($"Access Name : {ConfigurationManager.AppSettings["access_name"]}");
            Debug.WriteLine($"Access Credential : {ConfigurationManager.AppSettings["access_credential"]}");
            Debug.WriteLine($"Server : {ConfigurationManager.AppSettings["server_location"]}");
            Debug.WriteLine($"Database : {ConfigurationManager.AppSettings["database_name"]}");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_IT_03());
        }
    }
}
