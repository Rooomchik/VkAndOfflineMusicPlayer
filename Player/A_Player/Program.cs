﻿using System;
using System.Windows.Forms;

namespace A_Player
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AudioPlayer());
           // Application.Run(new VKList());
        }
    }
}
