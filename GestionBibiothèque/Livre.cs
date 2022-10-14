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
    public partial class Livre : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BSM\Documents\GestionBiblio.mdf;Integrated Security=True;Connect Timeout=30");

        public Livre()
        {
            InitializeComponent();
        }
        public void listeLivre()
        {
            Con.Open();
            string query = "select * from Livre";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LivreDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void livreId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Livre_Load(object sender, EventArgs e)
        {
            listeLivre();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (livreId.Text == "" ||livreNom.Text == "" || livreAuteur.Text == "" || livreEditeur.Text == "" || livreQuantite.Text == "" )
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Livre values(" + livreId.Text + ",'" + livreNom.Text + "','" + livreAuteur.Text + "','" + livreEditeur.Text + "','" + livreQuantite.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livre ajouté avec succès");
                Con.Close();
                listeLivre();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (livreId.Text == "")
            {
                MessageBox.Show("Entrez l'Id du livre)");
            }
            else
            {
                Con.Open();
                string query = "delete from Livre where livreId=" + livreId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livre supprimé avec succès");
                Con.Close();
                listeLivre();
            }
        }
        int bId;
        private void LivreDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LivreDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bId = int.Parse(LivreDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(BibliothecaireDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            Con.Open();
            string query = "select * from Livre where livreId=" + bId + ";";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            livreId.Text = ds.Tables[0].Rows[0][0].ToString();
            livreNom.Text = ds.Tables[0].Rows[0][1].ToString();
            livreAuteur.Text = ds.Tables[0].Rows[0][2].ToString();
            livreEditeur.Text = ds.Tables[0].Rows[0][3].ToString();
            livreQuantite.Text = ds.Tables[0].Rows[0][4].ToString();
            Con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (livreId.Text == "" || livreNom.Text == "" || livreAuteur.Text == "" || livreEditeur.Text == "" || livreQuantite.Text == "")

            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                Con.Open();
                string query = "update  Livre set livreNom='" + livreNom.Text + "',livreAuteur='" + livreAuteur.Text + "',livreEditeur='" + livreEditeur.Text + "',livreQuantite='" + livreQuantite.Text + "' where livreId=" + livreId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Informations du livre modifiées avec succès");
                Con.Close();
                listeLivre();
            }
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
    }
}
