using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atelier1;

namespace AppBank.Forms.Compte
{
    public partial class NvClient : Form
    {
        public NvClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nomtextBox.Text.Length > 0 && prenomtextBox.Text.Length > 0 && addrtextBox.Text.Length > 0)
            {
                Client userX = new Client(nomtextBox.Text, prenomtextBox.Text, addrtextBox.Text);
            }
            else
            {
                MessageBox.Show("Veuillez saisir vos données!", "ECHEC!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nomtextBox.Text = "";
            prenomtextBox.Text = "";
            addrtextBox.Text = "";          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
