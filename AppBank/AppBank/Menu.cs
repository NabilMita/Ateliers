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
using Convertisseur;

namespace AppBank
{
    public partial class Menu : Form
    {
        Forms.Compte.Creation Comptes = new Forms.Compte.Creation();
        public Menu()
        {
            InitializeComponent();     
        }

        private void creationBtn_Click(object sender, EventArgs e)
        {
            Form Creation = new Forms.Compte.Creation();
            Creation.ShowDialog();
        }

        private void consulterBtn_Click(object sender, EventArgs e)
        {
            Form Consult = new Forms.Compte.Consulter();
            Consult.ShowDialog();
        }

        private void nvclientBtn_Click(object sender, EventArgs e)
        {
            Form NewClient = new Forms.Compte.NvClient();
            NewClient.ShowDialog();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            Form Convert = new Convertisseur.Form1();
            Convert.ShowDialog();
        }

        private void crediterBtn_Click(object sender, EventArgs e)
        {
            Form Credit = new Forms.Operation.Crediter();
            Credit.ShowDialog();
        }

        private void debiterBtn_Click(object sender, EventArgs e)
        {
            Form Debit = new Forms.Operation.Debiter();
            Debit.ShowDialog();
        }

        private void verserBtn_Click(object sender, EventArgs e)
        {
            Form Verse = new Forms.Operation.Verser();
            Verse.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nbrClt.Text = Comptes.Users.Count().ToString();
            nbrCpt.Text = (Comptes.LC.Count() + Comptes.LE.Count()).ToString();
        }
    }
}
