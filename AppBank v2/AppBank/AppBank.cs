using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeviseLibraries;
using Atelier1;
using Convertisseur;

namespace AppBank
{
    public partial class AppBank : Form
    {
        Client user;
        CompteCourant CC;
        CompteEpargne CE;
        List<CompteCourant> LC = new List<CompteCourant>();
        List<CompteEpargne> LE = new List<CompteEpargne>();
        List<Client> Users = new List<Client>();
        string deviseSolde;
        Client tmp = null;
        Devise Dev = null;
        public AppBank()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            Convertisseur.Form1 Convert = new Convertisseur.Form1();
            Convert.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = -1;
            madBtn.Checked = false;
            eurBtn.Checked = false;
            usdBtn.Checked = false;
            courantradBtn.Checked = false;
            epargneradBtn.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1 && soldetextBox.Text.Length > 0 && (madBtn.Checked || eurBtn.Checked || usdBtn.Checked))
            {
                foreach(Client X in Users)
                {
                    if (listBox2.SelectedItem.Equals(X.name()))
                    {
                        tmp = X;                         
                        break;
                    }
                }        
                if (courantradBtn.Checked)
                {
                    CC = new CompteCourant(tmp, new MAD(Double.Parse(soldetextBox.Text)));
                    LC.Add(CC);
                }
                else if (epargneradBtn.Checked)
                {
                    CE = new CompteEpargne(tmp, new MAD(Double.Parse(soldetextBox.Text)));
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (nomtextBox.Text.Length > 0 && prenomtextBox.Text.Length > 0 && addrtextBox.Text.Length > 0)
            {
                user = new Client(nomtextBox.Text, prenomtextBox.Text, addrtextBox.Text);
                Users.Add(user);
                button13.PerformClick();
                MessageBox.Show("Bienvenue parmis nous " + nomtextBox.Text + "!", "SUCCESS!");
            }
            else
            {
                MessageBox.Show("Veuillez saisir vos données!", "ECHEC!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CC.crediter(new MAD(Double.Parse(textBox5.Text))))
                MessageBox.Show("Votre compte a été crédité d'un montant de " + textBox5.Text, "SUCCES!");
            else
                MessageBox.Show("Opération echoué!", "ECHEC!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (CC.debiter(new MAD(Double.Parse(textBox4.Text))))
                MessageBox.Show("Votre compte a été débité d'un montant de " + textBox4.Text, "SUCCES!");
            else
                MessageBox.Show("Opération echoué!", "ECHEC!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (CC.verser(CC, new MAD(Double.Parse(textBox6.Text))))
                    MessageBox.Show("Vous venez d'effectuer un versement d'un montant de " + textBox6.Text, "SUCCES!");
                else
                    MessageBox.Show("Opération echoué!", "ECHEC!");    
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (CompteCourant C in LC)
            {
                 dataGridView1.Rows.Add(user.name(), user.surname(), CC.money().ConvertTo("MAD").afficherDevise());
            }
            foreach (CompteEpargne CE in LE)
            {
                 dataGridView1.Rows.Add(user.name(), user.surname(), CE.money().ConvertTo("MAD").ToString());
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (Client X in Users)
            {
                listBox2.Items.Add(X.name());           
            }
        }

        private void radBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton tmpRd = sender as RadioButton;
            if (tmpRd.Checked)
                this.deviseSolde = tmpRd.Text;         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nbrCpt.Text = (LC.Count + LE.Count).ToString();
            nbrClt.Text = Users.Count.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }
    }
}
