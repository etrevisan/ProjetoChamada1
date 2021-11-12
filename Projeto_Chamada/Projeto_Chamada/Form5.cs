using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Chamada
{
    public partial class Form5 : Form
    {
        MySqlConnection con = new MySqlConnection("server=143.106.241.3;port=3306; User ID=cl200455; database=cl200455; password=cl*02042004; SslMode=none");
        public Form5(int i)
        {
            InitializeComponent();
            try
            {
                con.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show("Falha na Conexão");
                MessageBox.Show(error.Message);
            }
            this.WindowState = FormWindowState.Maximized;
            if (i == 0) {
                button3.Visible = true;
            }
            else
            {
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand busca_ra = new MySqlCommand("Update Alunos set status = 1 where raAlunos = " + textBox1.Text, con);
                busca_ra.ExecuteNonQuery();

                MessageBox.Show("Aluno Inativado!");

                textBox1.Clear();
                textBox2.Clear();
                label2.Text = "Aluno";
            }//try
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar == Keys.Enter)
            {
                try
                {
                    con.Open();
                    MySqlCommand busca_ra = new MySqlCommand("Select nomeAlunos, raAlunos, emailAlunos, fotoAlunos from Alunos where idAlunos=" + textBox1.Text, con);
                    MySqlDataReader resultado = busca_ra.ExecuteReader();

                    if (resultado.Read())
                    {
                        label2.Text = resultado["nomeAlunos"].ToString();
                        textBox2.Text = resultado["nomeAlunos"].ToString();
                        textBox3.Text = resultado["emailAlunos"].ToString();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: "+erro);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand atualiza_nome = new MySqlCommand("Update Alunos set nomeAlunos = '" + textBox2); 
        }
    }
}
