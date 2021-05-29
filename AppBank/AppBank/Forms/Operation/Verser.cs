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

namespace AppBank.Forms.Operation
{
    public partial class Verser : Form
    {
        public Verser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.Compte.Creation Comptes = new Forms.Compte.Creation();
            if (Comptes.CC.verser(Comptes.CC,new MAD(Double.Parse(textBox1.Text))))
                MessageBox.Show("Vous venez d'effectuer un versement d'un montant de " + textBox1.Text, "SUCCES!");
            else
                MessageBox.Show("Opération echoué!", "ECHEC!");
        }
    }
}
