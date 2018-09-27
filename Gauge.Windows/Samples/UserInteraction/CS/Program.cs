﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.Licensing;

namespace UserInteractionDemo_2013
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
