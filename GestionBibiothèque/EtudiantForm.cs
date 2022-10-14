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
    public partial class EtudiantForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BSM\Documents\GestionBiblio.mdf;Integrated Security=True;Connect Timeout=30");

        public EtudiantForm()
        {
            InitializeComponent();
        }
        public void listeEtuduant()
        {
            Con.Open();
            string query = "select * from Etudiant";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EtudiantDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EtudiantForm_Load(object sender, EventArgs e)
        {
            listeEtuduant();

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (etuId.Text == "" || etuMatricule.Text == "" || etuNom.Text == "" || etuPrenom.Text == "" || etuPhone.Text == "" || etuEmail.Text=="")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Etudiant values(" + etuId.Text + ",'" + etuMatricule.Text + "','" + etuNom.Text + "','" + etuPrenom.Text + "','" + etuPhone.Text + "','" + etuEmail.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Etudiant(e) ajouté(e) avec succès");
                Con.Close();
                listeEtuduant();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (etuId.Text == "")
            {
                MessageBox.Show("Entrez l'Id de l'étudiant(e)");
            }
            else
            {
                Con.Open();
                string query = "delete from Etudiant where etuId=" + etuId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Etudiant supprimé avec succès");
                Con.Close();
                listeEtuduant();
            }
        }
        int bId;
        private void EtudiantDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EtudiantDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bId = int.Parse(EtudiantDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(BibliothecaireDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            Con.Open();
            string query = "select * from Etudiant where etuId=" + bId + ";";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            etuId.Text = ds.Tables[0].Rows[0][0].ToString();
            etuMatricule.Text = ds.Tables[0].Rows[0][1].ToString();
            etuNom.Text = ds.Tables[0].Rows[0][2].ToString();
            etuPrenom.Text = ds.Tables[0].Rows[0][3].ToString();
            etuPhone.Text = ds.Tables[0].Rows[0][4].ToString();
            etuEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            Con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (etuId.Text == "" || etuMatricule.Text == "" || etuNom.Text == "" || etuPrenom.Text == "" || etuPhone.Text == "" || etuEmail.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                Con.Open();
                string query = "update  Etudiant set etuMatricule='" + etuMatricule.Text + "',etuNom='" + etuNom.Text + "',etuPrenom='" + etuPrenom.Text + "',etuPhone='" + etuPhone.Text + "',etuEmail='" + etuEmail.Text + "' where etuId=" + etuId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Informations de l'étudiant(e) modifiées avec succès");
                Con.Close();
                listeEtuduant();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
