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
                textBox1.Text = reader1["nom"].ToString();
                textBox2.Text = reader1["prenom"].ToString();
                textBox3.Text = reader1["adresse"].ToString();
                textBox4.Text = reader1["cp"].ToString();
                textBox5.Text = reader1["ville"].ToString();
            }
            else
            {
                MessageBox.Show("No data found.");
            }
            conn1.Close();
        }
    }
}
