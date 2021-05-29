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
using AppBank.Forms.Compte;

namespace AppBank.Forms.Compte
{
    public partial class Consulter : Form
    {
        Forms.Compte.Creation Comptes = new Forms.Compte.Creation();
        public Consulter()
        {
            InitializeComponent();
        }
        private void Consulter_Load(object sender, EventArgs e)
        {
            foreach(CompteCourant C in Comptes.LC)
            {
                dataGridView1.Rows.Add(Comptes.user.name(), Comptes.user.surname(), Comptes.CC.money().ToString());
            }
            foreach (CompteEpargne CE in Comptes.LE)
            {
                dataGridView1.Rows.Add(Comptes.user.name(), Comptes.user.surname(), Comptes.CE.money().ToString());
            }
        }

    }
}
