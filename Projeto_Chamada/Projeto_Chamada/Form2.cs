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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=143.106.241.3;port=3306; User ID=cl200455; database=cl200455; password=cl*02042004; SslMode=none");
                con.Open();
                MessageBox.Show("Conectado");
                con.Close();
            }
            catch (Exception error)
            {
                //MessageBox.Show("Falha na Conexão");
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=143.106.241.3;port=3306; User ID=cl200455; database=cl200455; password=cl*02042004; SslMode=none");
                con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Alunos (idAlunos, nomeAlunos, emailAlunos, turmaAlunos) values (" + int.Parse(textBox1.Text) + ", '" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedItem.ToString() + "')", con);
                insere.ExecuteNonQuery();
                MessageBox.Show("Gravação realizada com sucesso");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir Foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }
            }
            dialog.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
