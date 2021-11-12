using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Chamada
{
    public partial class Form4 : Form
    {
        MySqlConnection con = new MySqlConnection("server=143.106.241.3;port=3306; User ID=cl200455; database=cl200455; password=cl*02042004; SslMode=none");
        int idPalestra, ra;
        public Form4()
        {
            InitializeComponent();
            try
            {
                con = new MySqlConnection("server=143.106.241.3;port=3306; User ID=cl200455; database=cl200455; password=cl*02042004; SslMode=none");
                //MessageBox.Show("Conectado");
            }
            catch (Exception error)
            {
                MessageBox.Show("Falha na Conexão");
                MessageBox.Show(error.Message);
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void lblMostraNome_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand busca_palestra = new MySqlCommand("Select tituloPalestra from Palestras", con);
                MySqlDataReader resultado = busca_palestra.ExecuteReader();
                while (resultado.Read())
                {
                    comboBox1.Items.Add(resultado["tituloPalestra"].ToString());
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar == Keys.Enter)
            {
                try
                {
                    con.Open();
                    MySqlCommand busca_ra = new MySqlCommand("Select nomeAlunos, idAlunos, fotoAlunos from Alunos" + " where idAlunos=" + textBox2.Text, con);
                    MySqlDataReader resultado = busca_ra.ExecuteReader();

                    if (resultado.Read())
                    {
                        label3.Text = (resultado["nomeAlunos"].ToString());
                        ra = Convert.ToInt32(resultado["idAlunos"].ToString());
                        try
                        {
                            string imagem = Convert.ToString(DateTime.Now.ToFileTime());
                            byte[] bimage = (byte[])resultado["fotoAlunos"];
                            FileStream fs = new FileStream(imagem, FileMode.CreateNew, FileAccess.Write);
                            fs.Write(bimage, 0, bimage.Length - 1);
                            fs.Close();
                            pictureBox1.Image = Image.FromFile(imagem);
                            resultado.Close();
                        } catch
                        {
                            pictureBox1.Image = Image.FromFile("/Users/emill/Documents/Cotil/negado.png");
                        }

                        con.Close();
                        try
                        {
                            con.Open();
                            MySqlCommand insere = new MySqlCommand("insert into Presenca (RA, idPalestra, Hora) values (" + ra + "," + idPalestra + ",'" + DateTime.Now.ToShortTimeString() + "')", con);
                            insere.ExecuteNonQuery();
                            MessageBox.Show("Registrado");
                        } catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        } finally
                        {
                            con.Close();
                            textBox2.Clear();
                            textBox2.Focus();
                            pictureBox1.Image = null;
                            label3.Text = "Aluno";
                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                } finally
                {
                    con.Close();
                }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand busca_palestra = new MySqlCommand("Select tituloPalestra,idPalestras from Palestras where tituloPalestra='" + comboBox1.SelectedItem.ToString()+"'", con);
                MySqlDataReader resultado = busca_palestra.ExecuteReader();
                if (resultado.Read())
                {
                    idPalestra = Convert.ToInt32(resultado["idPalestras"].ToString());
                    MessageBox.Show(idPalestra.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
