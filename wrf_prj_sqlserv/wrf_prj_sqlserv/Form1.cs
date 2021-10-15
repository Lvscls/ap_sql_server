using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wrf_prj_sqlserv
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=BTS2020-29\SQLEXPRESS;Initial Catalog=SEG_V1;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_liste_client lafenetre = new frm_liste_client();
            lafenetre.Show();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection(@"Data Source=BTS2020-29\SQLEXPRESS;Initial Catalog=SEG_V1;Integrated Security=True");
            conn1.Open();
            SqlCommand cmd1 = new SqlCommand("select id,nom,prenom,adresse,cp,ville from CLIENT where id=@id", conn1);
            cmd1.Parameters.AddWithValue("id", tbID.Text);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                lvListeClient.Items.Clear();



                ListViewItem colonne = new ListViewItem();
                colonne.Text = reader1["nom"].ToString(); //1ère colonne
                colonne.SubItems.Add(reader1["prenom"].ToString()); //2ème
                colonne.SubItems.Add(reader1["adresse"].ToString()); //3ème
                colonne.SubItems.Add(reader1["cp"].ToString());
                colonne.SubItems.Add(reader1["ville"].ToString());

                //ajout de la ligne dans la liste
                lvListeClient.Items.Add(colonne);
            }
            else
            {
                MessageBox.Show("No data found.");
            }
            conn1.Close();

        }

        private void btAjout_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btAjout.Text == "Ajouter")
                {
                    SqlCommand sqlCmd = new SqlCommand("ClientAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@id", tbIdAdd.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@nom", tbNom.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@prenom", tbPrenom.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@adresse", tbAdresse.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@cp", tbCP.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ville", tbVille.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved successfully");
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }

        }
    }
}
