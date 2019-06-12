using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace ProProkat
{
    public partial class CreateDBForm : Form
    {
        public CreateDBForm()
        {
            InitializeComponent();
        }
        private void CreateTables(MySqlConnection conn_)
        {
            MySqlCommand cmd;
            string s1, s2, s3, s4, s5, s6, s7;
            s7 = "DROP TABLE IF EXISTS `agerating`; DROP TABLE IF EXISTS `clients`; DROP TABLE IF EXISTS `country`; DROP TABLE IF EXISTS `genres`; DROP TABLE IF EXISTS `movies`; DROP TABLE IF EXISTS `orders`;";
            cmd = new MySqlCommand(s7, conn_);
            cmd.ExecuteNonQuery();

            s1 = "CREATE TABLE `agerating` ( `id` int(11) NOT NULL AUTO_INCREMENT, `name` varchar(45) NOT NULL, PRIMARY KEY(`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci";
            cmd = new MySqlCommand(s1, conn_);
            cmd.ExecuteNonQuery();

            s2 = "CREATE TABLE `clients` ( `id` int(11) NOT NULL AUTO_INCREMENT,  `fullname` varchar(60) NOT NULL,  `address` varchar(60) NOT NULL, `contact` varchar(20) NOT NULL,  `blackliststatus` tinyint(4) NOT NULL,  PRIMARY KEY(`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci";
            cmd = new MySqlCommand(s2, conn_);
            cmd.ExecuteNonQuery();

            s3 = "CREATE TABLE  `country` ( `id` int(11) NOT NULL AUTO_INCREMENT,  `name` varchar(45) NOT NULL,  PRIMARY KEY(`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci";
            cmd = new MySqlCommand(s3, conn_);
            cmd.ExecuteNonQuery();


            s4 = "CREATE TABLE `genres` (  `id` int(11) NOT NULL AUTO_INCREMENT,  `name` varchar(45) NOT NULL,  PRIMARY KEY(`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci";
            cmd = new MySqlCommand(s4, conn_);
            cmd.ExecuteNonQuery();

            s5 = "CREATE TABLE `movies` (  `Id` int(11) NOT NULL AUTO_INCREMENT,  `name` varchar(60) NOT NULL,  `count` int(11) NOT NULL,  `price` int(11) NOT NULL,  `synopsis` varchar(100) DEFAULT NULL,  `agerating` varchar(10) DEFAULT NULL,  `genres` varchar(60) DEFAULT NULL,  `year` varchar(4) DEFAULT NULL,  `director` varchar(60) DEFAULT NULL,  `country` varchar(60) DEFAULT NULL,  PRIMARY KEY(`Id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci";
            cmd = new MySqlCommand(s5, conn_);
            cmd.ExecuteNonQuery();

            s6 = "CREATE TABLE `orders` (  `id` int(11) NOT NULL AUTO_INCREMENT,  `client` varchar(60) NOT NULL,  `status` varchar(60) NOT NULL,  `date` date DEFAULT NULL,  `rent` date DEFAULT NULL,  `disklist` varchar(255) NOT NULL,  `deposit` varchar(60) NOT NULL,  `closed_date` date DEFAULT NULL,  `clid` int(11) NOT NULL,  PRIMARY KEY(`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci";
            cmd = new MySqlCommand(s6, conn_);
            cmd.ExecuteNonQuery();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string s0;
                string connStr = "server=" + txtboxServer.Text.ToString() + ";user=" + txtboxName.Text.ToString() + ";port=" + txtboxPort.Text.ToString() + ";password=" + txtboxPassword.Text.ToString() + ";";
                MySqlCommand cmd;
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlConnection conn_ = new MySqlConnection(connStr + "database=pp_db");
                try
                {
                    conn_.Open();
                    CreateTables(conn_);
                    conn_.Close();
                    File.WriteAllText("conn.txt", connStr);
                    MessageBox.Show("Подключение выполнена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.db = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    conn.Open();
                    s0 = "CREATE DATABASE IF NOT EXISTS `pp_db`;";
                    cmd = new MySqlCommand(s0, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    conn_.Open();
                    CreateTables(conn_);
                    conn_.Close();
                    MessageBox.Show("База создана", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.WriteAllText("conn.txt", connStr);
                    Program.db = true;
                    this.Close();
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
 
}
