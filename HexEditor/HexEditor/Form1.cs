using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HexEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// caractere que irá separar as linhas. Escolhi '~' (126), mas poderia ser '{' (123)
        /// </summary>
        char char_delimitador = (char)126;
        private void btnBuscarArquivo_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtCaminhoArquivo.Text = openFileDialog1.FileName;

                //Resetando layouts
                textBox1.ResetText();
                dataGridView1.Rows.Clear();

                //Lendo bytes do arquivo
                String texto = File.ReadAllText(openFileDialog1.FileName);
                //Preenchendo textbox
                foreach (char c_caractere in texto)
                {
                    textBox1.Text += c_caractere;
                }

                //Complicando um pouco. "Entendendo" os hex
                String[] s_parametros = texto.Split(char_delimitador);
                foreach (String s_parametro in s_parametros)
                {
                    //Devido ao modo como eu separo as linhas, é necessário remover a linha em branco do tratamento
                    if(s_parametro.Length>0)
                    {
                        //Colunas do DataGridView
                        String s_nome_variavel, s_tipo, s_valor;
                        //Variável para "andar" na string, pegando os valores para por nas variáveis
                        //É necessário verificar se o caractere '~' está presente, para evitar erros
                        int index = 0 + (char_delimitador != '~' ? 1 : 0);

                        //1º passo: Nome da Variável
                        //Tamanho do nome da variável
                        int i_tamanho_nome_variavel = (int)s_parametro[index];

                        //Atribuindo o nome da variável
                        s_nome_variavel = s_parametro.Substring(index + 1, i_tamanho_nome_variavel);

                        //Somando em index o byte de tamanho da variável, mais o tamanho em si
                        index += 1 + i_tamanho_nome_variavel;

                        //2º passo: Valor
                        //Descobrindo o tamanho do valor da variável. Números são salvos de trás pra frente
                        int i_tamanho_valor = 0;
                        for(int n = 0;n<3;n++)
                        {
                            i_tamanho_valor += (((int)Math.Pow(16, n)) * ((int)s_parametro[index + n]));
                        }

                        //Somando em index
                        index += 3;

                        //Pular delimitador nulo
                        index += 1;


                        /*
                         * A variável i_tamanho_valor salva o tamanho do valor da variável, mas inclui o tipo de valor
                         * e o delimitador nulo. É necessário tirar esses dois caracteres do valor, para não dar erro
                         */
                        i_tamanho_valor -= 2;

                        //Tipo do valor
                        switch ((int)s_parametro[index])
                        {
                            case 6://Datas
                                s_tipo = "Data";
                                s_valor = s_parametro.Substring(index + 1, i_tamanho_valor);
                                //Encoding.Default.GetBytes(s_valor).ToString();
                                //DateTime d = DateTime.FromBinary(Convert.ToInt64(s_valor, 16));
                                break;
                            case 9://Booleanos
                                s_tipo = "Booleano";
                                s_valor = (int)s_parametro[index + 1] == 1 ? "True" : "False";
                                break;
                            case 81://Vetores
                                s_tipo = "Vetor";
                                //É outro nível de cálculo
                                s_valor = s_parametro.Substring(index + 1, i_tamanho_valor);
                                break;
                            case 11://Vive puxando 2 indexes além do necessário, dando erro
                                s_tipo = "Index " + 11;
                                s_valor = s_parametro.Substring(index + 1, i_tamanho_valor - 2);
                                break;
                            default:
                                s_tipo = "Desconhecido - Index " + (int)s_parametro[index];
                                s_valor = s_parametro.Substring(index + 1, i_tamanho_valor);    
                                //throw new NotImplementedException("Tipo com index " + s_parametro[index].ToString() + " não conhecido. Necessário implementar");
                                break;
                        }
                        //Somando em index
                        index += 1 + i_tamanho_valor;

                        /*A essa altura, já deve ter chego no final ('{' ou nada, caso o caractere delimitador escolhido tenha sido esse)
                         * Está na hora de jogar esses dados no DataGridView
                         */
                        dataGridView1.Rows.Add(s_nome_variavel, s_tipo, s_valor);
                    }
                }
            }
        }
    }
}
