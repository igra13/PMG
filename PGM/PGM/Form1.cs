using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace PGM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string server = "188.166.43.154";
            string database = "pmg";
            string uid = "tina";
            string password = "tina";
            string connectionString;
            connectionString = "SERVER=" + server + "; PORT = 3306 ;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "pmg";
            if (dbCon.IsConnect())
            {
                MessageBox.Show("CONNECTED");
                //hämta
                //string CmdString = "SELECT user_login FROM wp_users";
                //MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, dbCon.Connection);
                //DataSet ds = new DataSet();
                //sda.Fill(ds);
                
                //dataGridView1.DataSource = ds.Tables[0].DefaultView;

                //lägg till
               string ao = "INSERT INTO wp_users (ID, user_login, user_pass, user_nicename, user_email, user_url, user_registered, user_activation_key, user_status, display_name) VALUES (NULL, 'tinasda', 'tinasda', 'tinasda', 'igor@hotmail.com', '', '2017-10-12 00:00:00', '', '0', 'tinada')";
                
                MySqlDataAdapter sd = new MySqlDataAdapter(ao, dbCon.Connection);

                //MySqlCommand insere = new MySqlCommand();

                //insere.Connection = dbCon.Connection;  //<- Set the Commands connection

                //insere.CommandText = "INSERT INTO wp_users (ID, user_login, user_pass, user_nicename, user_email, user_url, user_registered, user_activation_key, user_status, display_name) VALUES (NULL, 'tina', 'tina', 'tina', 'igor@hotmail.com', '', '2017-10-12 00:00:00', '', '0', 'tina')";

               
                ////suppose col0 and col1 are defined as VARCHAR in the DB
                //string query = "SELECT col0,col1 FROM YourTable";
                //var cmd = new MySqlCommand(query, dbCon.Connection);
                //var reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    string someStringFromColumnZero = reader.GetString(0);
                //    string someStringFromColumnOne = reader.GetString(1);
                //    Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
                //}
            }
            else
            {
                MessageBox.Show("NOT CONNECTED");
            }


        }
    }
}
