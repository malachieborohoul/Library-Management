using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibiothèque
{
    public partial class AccueilForm : Form
    {
        public AccueilForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Etudiants_Click(object sender, EventArgs e)
        {
            EtudiantForm etudiant = new EtudiantForm();
            this.Hide();
            etudiant.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Livre livre = new Livre();
            this.Hide();
            livre.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpruntLivre empLivre = new EmpruntLivre();
            this.Hide();
            empLivre.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bibliothecaire biblio = new Bibliothecaire();
            this.Hide();
            biblio.Show();

        }

        private void button3_Click(object sender, EventArgs e) { 
        
            
            RetourLivre retour = new RetourLivre();
            this.Hide();
            retour.Show();
        }
    }
}
