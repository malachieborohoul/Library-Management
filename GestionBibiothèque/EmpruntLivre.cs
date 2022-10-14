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

    public partial class EmpruntLivre : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BSM\Documents\GestionBiblio.mdf;Integrated Security=True;Connect Timeout=30");

        public EmpruntLivre()
        {
            InitializeComponent();
        }

        private void matriculeEtudiant()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select etuMatricule from Etudiant", Con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("etuMatricule", typeof(string));
            dt.Load(dr);
            etuCB.ValueMember = "etuMatricule";
            etuCB.DataSource = dt;

            Con.Close();
        }

        private void rechercherInfoEtudiant()
        {
            Con.Open();
            string query = "select * from Etudiant where etuMatricule='" + etuCB.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                etuNom.Text = dr["etuNom"].ToString(); 
                etuPrenom.Text = dr["etuPrenom"].ToString(); 
                etuEmail.Text = dr["etuEmail"].ToString();
                etuPhone.Text = dr["etuPhone"].ToString();
            }
            Con.Close();

        }

        private void livreNom()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select livreNom from Livre where livreQuantite > "+0+"", Con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("livreNom", typeof(string));
            dt.Load(dr);
            livreCb.ValueMember = "livreNom";
            livreCb.DataSource = dt;

            Con.Close();
        }

        private void modifierQuantiteLivre()
        {
            int quantite, nQuantite;
            Con.Open();
            string query = "select * from Livre where livreNom='" + livreCb.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                quantite = Convert.ToInt32(dr["livreQuantite"].ToString());
                nQuantite = quantite - 1;
                string query1 = "update Livre set livreQuantite=" + nQuantite + "where livreNom='" + livreCb.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }
            Con.Close(); 

        }

        private void modifierQuantiteLivreAnnule()
        {
            int quantite, nQuantite;
            Con.Open();
            string query = "select * from Livre where livreNom='" + livreCb.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                quantite = Convert.ToInt32(dr["livreQuantite"].ToString());
                nQuantite = quantite +1;
                string query1 = "update Livre set livreQuantite=" + nQuantite + "where livreNom='" + livreCb.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }
            Con.Close();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AccueilForm accueil = new AccueilForm();
            this.Hide();
            accueil.Show();
        }

        private void EmpruntLivre_Load(object sender, EventArgs e)
        {
            matriculeEtudiant();
            livreNom();
            listeEmpruntLivre();
        }
        public void listeEmpruntLivre()
        {
            Con.Open();
            string query = "select * from EmpruntLivre";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EmpruntLivreDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void etuCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rechercherInfoEtudiant();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (idEmprunt.Text == ""  || etuNom.Text == "" || etuPrenom.Text == "" || etuPhone.Text == "" || etuEmail.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                string dateEmp = dateEmprunt.Value.Day.ToString() + "/" + dateEmprunt.Value.Month.ToString() + "/" + dateEmprunt.Value.Year.ToString();
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into EmpruntLivre values(" + idEmprunt.Text + ",'" + etuCB.SelectedValue.ToString() + "','" + etuNom.Text + "','" + etuPrenom.Text + "','" + etuEmail.Text + "','" + etuPhone.Text + "','" + livreCb.SelectedValue.ToString() + "','" + dateEmp + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le livre a été emprunté avec succès");
                Con.Close();
                modifierQuantiteLivre();
                listeEmpruntLivre();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (idEmprunt.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                Con.Open();
                string query = "update  EmpruntLivre set etuMatricule='" + etuCB.SelectedValue.ToString() + "',etuNom='" + etuNom.Text + "',etuPrenom='" + etuPrenom.Text + "',etuEmail='" + etuEmail.Text + "',etuPhone='" + etuPhone.Text + "' where empId=" + idEmprunt.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Informations de l'étudiant(e) modifiées avec succès");
                Con.Close();
                listeEmpruntLivre();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (idEmprunt.Text == "")
            {
                MessageBox.Show("Entrez l'Id de l'emprunt");
            }
            else
            {
                Con.Open();
                string query = "delete from EmpruntLivre where empId=" + idEmprunt.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("L'emprunt a été annulé avec succès");
                Con.Close();
                modifierQuantiteLivreAnnule();
                listeEmpruntLivre();
            }
        }
        int bId;
        private void EmpruntLivreDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (EmpruntLivreDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bId = int.Parse(EmpruntLivreDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(BibliothecaireDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            Con.Open();
            string query = "select * from EmpruntLivre where empId=" + bId + ";";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            idEmprunt.Text = ds.Tables[0].Rows[0][0].ToString();
            etuCB.SelectedItem = ds.Tables[0].Rows[0][1].ToString();
            etuNom.Text = ds.Tables[0].Rows[0][2].ToString();
            etuPrenom.Text = ds.Tables[0].Rows[0][3].ToString();
            etuEmail.Text = ds.Tables[0].Rows[0][4].ToString();
            etuPhone.Text = ds.Tables[0].Rows[0][5].ToString();
            livreCb.SelectedItem = ds.Tables[0].Rows[0][6].ToString();
            Con.Close();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idEmprunt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void etuCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void etuPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void etuEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void etuPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void etuNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateEmprunt_onValueChanged(object sender, EventArgs e)
        {

        }

        private void livreCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
