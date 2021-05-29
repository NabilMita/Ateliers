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
using DeviseLibraries;

namespace AppBank.Forms.Compte
{
    public partial class Creation : Form
    {
        public Client user;
        public CompteCourant CC;
        public CompteEpargne CE;
        public List<CompteCourant> LC = new List<CompteCourant>();
        public List<CompteEpargne> LE = new List<CompteEpargne>();
        public List<Client> Users = new List<Client>();
        public Creation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nomtextBox.Text = "";
            prenomtextBox.Text = "";
            addrtextBox.Text = "";
            courantradBtn.Checked = false;
            epargneradBtn.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nomtextBox.Text.Length > 0 && prenomtextBox.Text.Length > 0 && addrtextBox.Text.Length > 0 && soldetextBox.Text.Length > 0)
            {
                user = new Client(nomtextBox.Text, prenomtextBox.Text, addrtextBox.Text);
                Users.Add(user);
                if (courantradBtn.Checked)
                {
                   CC = new CompteCourant(user, new MAD(Double.Parse(soldetextBox.Text)));
                   LC.Add(CC);
                }
                else if (epargneradBtn.Checked)
                {
                    CE = new CompteEpargne(user, new MAD(Double.Parse(soldetextBox.Text)));
                    LE.Add(CE);
                }             
                else
                {
                    MessageBox.Show("Veuillez précisez le type du compte!", "ECHEC!");
                }
                MessageBox.Show("Bienvenue parmis nous " + nomtextBox.Text + "!", "SUCCESS!");
            }
            else
            {
                MessageBox.Show("Veuillez saisir vos données!", "ECHEC!");
            }     
        }
        public void afficher()
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
