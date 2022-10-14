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

namespace GestionBibiothèque
{
    public partial class RetourLivre : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BSM\Documents\GestionBiblio.mdf;Integrated Security=True;Connect Timeout=30");

        public RetourLivre()
        {
            InitializeComponent();
        }
        public void listeEmpruntLivre()
        {
            Con.Open();
            string query = "select * from EmpruntLivre";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LivreEmpruntDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        public void listeRetourLivre()
        {
            Con.Open();
            string query = "select * from RetourLivre";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LivreRenduDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void modifierQuantiteLivre()
        {
            int quantite, nQuantite;
            Con.Open();
            string query = "select * from Livre where livreNom='" + livreNom.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                quantite = Convert.ToInt32(dr["livreQuantite"].ToString());
                nQuantite = quantite + 1;
                string query1 = "update Livre set livreQuantite=" + nQuantite + "where livreNom='" + livreNom.Text + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }
            Con.Close();

        }

        private void RetourLivre_Load(object sender, EventArgs e)
        {
            listeEmpruntLivre();
            listeRetourLivre();
        }
        int bId;
        private void LivreEmpruntDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LivreEmpruntDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bId = int.Parse(LivreEmpruntDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(BibliothecaireDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            Con.Open();
            string query = "select * from EmpruntLivre where empId=" + bId + ";";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            idRetour.Text = ds.Tables[0].Rows[0][0].ToString();
            etuMatricule.Text= ds.Tables[0].Rows[0][1].ToString();
            etuNom.Text = ds.Tables[0].Rows[0][2].ToString();
            etuPrenom.Text = ds.Tables[0].Rows[0][3].ToString();
            etuEmail.Text = ds.Tables[0].Rows[0][4].ToString();
            etuPhone.Text = ds.Tables[0].Rows[0][5].ToString();
            livreNom.Text = ds.Tables[0].Rows[0][6].ToString();
            Con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AccueilForm accueil = new AccueilForm();
            this.Hide();
            accueil.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (idRetour.Text == "" || etuNom.Text == "" || etuPrenom.Text == "" || etuPhone.Text == "" || etuEmail.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                string dateEmp = dateEmprunt.Value.Day.ToString() + "/" + dateEmprunt.Value.Month.ToString() + "/" + dateEmprunt.Value.Year.ToString();
                string dateRet = dateRetour.Value.Day.ToString() + "/" + dateRetour.Value.Month.ToString() + "/" + dateRetour.Value.Year.ToString();
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into RetourLivre values(" + idRetour.Text + ",'" + etuMatricule.Text + "','" + etuNom.Text + "','" + etuPrenom.Text + "','" + etuEmail.Text + "','" + etuPhone.Text + "','" + livreNom.Text + "','" + dateEmp + "','"+dateRet + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le livre a été rendu avec succès");
                Con.Close();
                modifierQuantiteLivre();
                listeEmpruntLivre();
                listeRetourLivre();
            }
        }

        private void LivreRenduDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (idRetour.Text == "")
            {
                MessageBox.Show("Entrez l'Id du retour");
            }
            else
            {
                Con.Open();
                string query = "delete from RetourLivre where empId=" + idRetour.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le reour du livre a été annulé avec succès");
                Con.Close();
                //modifierQuantiteLivreAnnule();
                listeEmpruntLivre();
            }
        }
    }
}
