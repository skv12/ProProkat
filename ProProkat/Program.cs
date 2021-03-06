﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace ProProkat
{
    static class Program
    {
        static public bool db = false;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connStr = File.ReadAllText("conn.txt").ToString();
            try
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    conn.Close();
                    MySqlConnection conn_ = new MySqlConnection(connStr + "database=pp_db");
                    conn_.Open();
                    conn_.Close();
                }
                catch (Exception ex)
                {
                    Application.Run(new CreateDBForm());
                }

                connStr = "";
                Application.Run(new MainForm());
                return;
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
