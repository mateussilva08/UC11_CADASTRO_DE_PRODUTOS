using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC11_CADASTRO_DE_PRODUTOS
{
    public partial class Form1 : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public Form1()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=cadastro_produtos;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            if (textBoxDESCRICAO.Text != "" && textBoxCATEGORIA.Text != "" && textBoxPRECO.Text != "")
            {

                try
                {
                    conexao.Open();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conexao.Close();
                }

                try
                {
                    conexao.Open();
                    comando.CommandText = "INSERT INTO tbl_produtos (descricao_produto, Categoria_Produto, Preco) VALUES ('" + textBoxDESCRICAO.Text + "', '" + textBoxCATEGORIA.Text + "','" + textBoxPRECO.Text + "');";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            textBoxPRECO.Text = "";
            textBoxCATEGORIA.Text = "";
            textBoxDESCRICAO.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
