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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
                MySqlCommand insere = new MySqlCommand("insert into Palestras (tituloPalestra, nomePalestrante, diaPalestra, horaPalestra) values ('" + textBox2.Text.ToString() + "', '" +
                textBox3.Text + "', '" + textBox1.Text + "', '" + comboBox1.SelectedItem.ToString() + "')", con);
                insere.ExecuteNonQuery();
                MessageBox.Show("Gravação realizada com sucesso");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy");
        }
    }
}
