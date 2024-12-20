using Dados;
using ObjetosZoo;
using RegrasZoo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Frontend
{
    public partial class MenuBilhete : Form
    {


        public MenuBilhete()
        {
            InitializeComponent();
        }

        private void comboBoxZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecionado = (ZONA)comboBoxZona.SelectedItem;
        }

        private void comboBoxTipobilhete_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtem o valor selecionado do tipo de bilhete
            var selecionado = (TIPOBILHETE)comboBoxTipobilhete.SelectedItem;

            // Obtem o preço do bilhete usando a classe Bilhetes
            decimal preco = Bilhetes.ObterPreco(selecionado);

            // Exibe o preço do bilhete na TextBox
            textBox1.Text = preco.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuBilhete_Load(object sender, EventArgs e)
        {
            // Preenche as ComboBoxes com os valores dos enums
            comboBoxZona.DataSource = Enum.GetValues(typeof(ZONA));
            comboBoxTipobilhete.DataSource = Enum.GetValues(typeof(TIPOBILHETE));

            comboBoxZona.SelectedIndexChanged += comboBoxZona_SelectedIndexChanged;
            comboBoxTipobilhete.SelectedIndexChanged += comboBoxTipobilhete_SelectedIndexChanged;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comprarbilhete_Click(object sender, EventArgs e)
        {
            if (comboBoxZona.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione a zona.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxTipobilhete.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione o tipo de bilhete.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém os valores selecionados nas ComboBoxes
            ZONA zonaSelecionada = (ZONA)comboBoxZona.SelectedItem;
            TIPOBILHETE tipoBilheteSelecionado = (TIPOBILHETE)comboBoxTipobilhete.SelectedItem;

            // Verifica se o preço na TextBox é um número válido
            if (decimal.TryParse(textBox1.Text, out decimal preco))
            {
                // Chama a função para comprar o bilhete
                bool sucesso = Bilhetes.ComprarBilhete(zonaSelecionada, tipoBilheteSelecionado, (double)preco);

                if (sucesso)
                {
                    MessageBox.Show("Bilhete comprado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao comprar o bilhete.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Caso o preço seja inválido
                MessageBox.Show("Preço inválido. Por favor, verifique o valor exibido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

    }
}

