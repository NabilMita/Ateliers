using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text; 

            try
            {
                 string connectionString = @"Data Source=PREDATOX-PC\SQL_NABEL;Initial Catalog=dbapp;Integrated Security=True;Pooling=False";
                 SqlConnection connection = new SqlConnection(connectionString);

                 connection.Open();      
                 string sql, dbLogin = "", dbpassword = "";
                 sql = "SELECT * FROM Compte WHERE login LIKE '" + username + "' AND password LIKE '" + password+ "'";
                 //MessageBox.Show(sql);
                 SqlCommand commande = new SqlCommand(sql, connection);
                 SqlDataReader reader;
                 reader = commande.ExecuteReader();

                 if (reader.Read())    
                      MessageBox.Show("Connexion réussi!", "SUCCESS");  
                 else
                      MessageBox.Show("Invalid user/pw!", "ERROR!");

                /* while(reader.Read()) // Tant que la méthode read peut lire    
                 {
                   if (reader.GetString(0) == username && reader.GetString(1) == password) 
                       MessageBox.Show("Connexion réussi!", "SUCCESS");  
                 }
                */
                //connection.Dispose();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
