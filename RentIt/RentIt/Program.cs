﻿using RentIt.View.Facility_Page;
using RentIt.View.Menu;
using RentIt.View.Pembatalan_1;
using RentIt.View.Pembayaran_2;
using RentIt.View.RentPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt
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
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new MainPageView());
        }
    }
}
