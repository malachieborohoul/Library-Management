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

    public partial class LoginForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BSM\Documents\GestionBiblio.mdf;Integrated Security=True;Connect Timeout=30");

        public LoginForm()
        {
            InitializeComponent();
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        
        

        private void label2_Click_2(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Bibliothecaire where biblioLogin ='" + bunifuMaterialTextbox1.Text + "' and biblioMdp='" + bunifuMaterialTextbox2.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                AccueilForm accueil = new AccueilForm();
                accueil.Show();

            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect");

            }
            Con.Close();
        }
    }
}
