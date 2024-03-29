﻿using System;
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
            textBoxID.Enabled = false;
            
            servidor = "Server=localhost;Database=cadastro_produtos;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

            atualizar_dataGRID();
        }
        private void atualizar_dataGRID()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_produtos;";

                MySqlDataAdapter adaptadorPRODUTOS = new MySqlDataAdapter(comando);

                DataTable tabelaPRODUTOS = new DataTable();
                adaptadorPRODUTOS.Fill(tabelaPRODUTOS);

                dataGridViewPRODUTOS.DataSource = tabelaPRODUTOS;
                dataGridViewPRODUTOS.Columns["id"].HeaderText = "código";
                dataGridViewPRODUTOS.Columns["descricao_produto"].HeaderText = "Descrição";
                dataGridViewPRODUTOS.Columns["Categoria_Produto"].HeaderText = "Categoria";
                dataGridViewPRODUTOS.Columns["Preco"].HeaderText = "Preço";


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

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            bool novo_produto = true;

            if (textBoxDESCRICAO.Text != "" && textBoxCATEGORIA.Text != "" && textBoxPRECO.Text != "")
            {
                

              
                
                try
                {
                    conexao.Open();
                    comando.CommandText = "SELECT descricao_produto FROM tbl_produtos WHERE descricao_produto = '" + textBoxDESCRICAO.Text + "';";

                    MySqlDataReader valida_produto = comando.ExecuteReader();

                    if (valida_produto.Read())
                    {
                        novo_produto = false;
                        MessageBox.Show("Produto já cadastrado");
                    }
                }
                catch (Exception erro)
                {
                    // MessageBox.Show(erro.Message);
                    MessageBox.Show("Erro ao cadastrar novo produto. Fale com o administrador do sistema");
                }
                finally
                {
                    conexao.Close();
                }

                //------//

                if (novo_produto) {

                    try
                    {
                        conexao.Open();
                        comando.CommandText = "INSERT INTO tbl_produtos (descricao_produto, Categoria_Produto, Preco) VALUES ('" + textBoxDESCRICAO.Text + "', '" + textBoxCATEGORIA.Text + "','" + textBoxPRECO.Text.Replace(",", ".") + "');";
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Produto cadastrado com sucesso!");
                    }
                    catch (Exception erro)
                    {
                        //MessageBox.Show(erro.Message);
                        MessageBox.Show("Erro ao cadastrar produto!");
                    }
                    finally
                    {
                        conexao.Close();
                    }
                    
                    atualizar_dataGRID();
                }
            }
            else
            {
                MessageBox.Show("preencha os campos em branco!");
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

        private void buttonEXCLUIR_Click(object sender, EventArgs e)
        {
           try
            {
                
               conexao.Open();
               comando.CommandText = "DELETE FROM tbl_produtos WHERE id = '" + textBoxID.Text + "';";
               comando.ExecuteNonQuery();
                MessageBox.Show("Produto excluido com sucesso!");
               

            }
            catch(Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao excluir produto. Tente Novamente");
            }
            finally
            {
                conexao.Close();
            }
            atualizar_dataGRID();
        }

        private void buttonATUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_produtos;";

                MySqlDataAdapter adaptadorPRODUTOS = new MySqlDataAdapter(comando);

                DataTable tabelaPRODUTOS = new DataTable();
                adaptadorPRODUTOS.Fill(tabelaPRODUTOS);

                dataGridViewPRODUTOS.DataSource = tabelaPRODUTOS;
                dataGridViewPRODUTOS.Columns["id"].HeaderText = "código";
                dataGridViewPRODUTOS.Columns["descricao_produto"].HeaderText = "Descrição";
                dataGridViewPRODUTOS.Columns["Categoria_Produto"].HeaderText = "Categoria";
                dataGridViewPRODUTOS.Columns["Preco"].HeaderText = "Preço";


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
 
        private void dataGridViewPRODUTOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // textBoxID.Text = dataGridViewPRODUTOS.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridViewPRODUTOS_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxID.Text = dataGridViewPRODUTOS.CurrentRow.Cells[0].Value.ToString();
            textBoxDESCRICAO.Text = dataGridViewPRODUTOS.CurrentRow.Cells[1].Value.ToString();
            textBoxCATEGORIA.Text = dataGridViewPRODUTOS.CurrentRow.Cells[2].Value.ToString();
            textBoxPRECO.Text = dataGridViewPRODUTOS.CurrentRow.Cells[3].Value.ToString().Replace(".",",");
        }

        private void buttonALTERAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE tbl_produtos SET descricao_produto = '" + textBoxDESCRICAO.Text + "', categoria_produto = '" + textBoxCATEGORIA.Text + "', preco = " + textBoxPRECO.Text.Replace(",",".") + " WHERE id = " + textBoxID.Text + ";"; 
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto atualizado com sucesso!");
            }
            catch (Exception erro)
            {
               // MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao atualizar produto!");
            }
            finally
            {
                conexao.Close();
            }
            atualizar_dataGRID();
        }
    }
}
