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
    public partial class Bibliothecaire : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BSM\Documents\GestionBiblio.mdf;Integrated Security=True;Connect Timeout=30");
        public Bibliothecaire()
        {
            InitializeComponent();
        }

        public void listeBibliothecaire()
        {
            Con.Open();
            string query = "select * from Bibliothecaire";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            BibliothecaireDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (biblioId.Text == "" || biblioLogin.Text == "" ||  biblioPhone.Text == "" || biblioMdp.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Bibliothecaire values(" + biblioId.Text + ",'" + biblioLogin.Text +"','" + biblioPhone.Text + "','" + biblioMdp.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bibliothécaire ajouté avec succès");
                Con.Close();
                listeBibliothecaire();
            }
        }

        private void Bibliothecaire_Load(object sender, EventArgs e)
        {
            listeBibliothecaire();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(biblioId.Text == "")
            {
                MessageBox.Show("Entrez l'Id d'un bibliothécaire");
            }
            else
            {
                Con.Open();
                string query = "delete from Bibliothecaire where biblioId="+biblioId.Text+";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bibliothécaire supprimé avec succès");
                Con.Close();
                listeBibliothecaire();
            }
        }
        int bId;
        private void BibliothecaireDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(BibliothecaireDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bId = int.Parse(BibliothecaireDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(BibliothecaireDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            Con.Open();
            string query = "select * from Bibliothecaire where biblioId="+bId+";";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            biblioId.Text = ds.Tables[0].Rows[0][0].ToString();
            biblioLogin.Text = ds.Tables[0].Rows[0][1].ToString();
            biblioPhone.Text = ds.Tables[0].Rows[0][2].ToString();
            biblioMdp.Text = ds.Tables[0].Rows[0][3].ToString();
            Con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (biblioId.Text == "" || biblioLogin.Text == "" || biblioPhone.Text == "" || biblioMdp.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                Con.Open();
                string query= "update  Bibliothecaire set biblioNom='" + biblioLogin.Text + "',biblioPhone='" + biblioPhone.Text + "',biblioPrenom='" + "',biblioMdp='" + biblioMdp.Text + "' where biblioId=" + biblioId.Text + ";";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Informations du Bibliothécaire modifiées avec succès");
                Con.Close();
                listeBibliothecaire();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AccueilForm accueil = new AccueilForm();
            this.Hide();
            accueil.Show();
        }
    }
}
