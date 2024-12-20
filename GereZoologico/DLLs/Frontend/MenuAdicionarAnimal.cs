using ObjetosZoo;
using RegrasZoo;
using Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class MenuAdicionarAnimal : Form
    {
        public MenuAdicionarAnimal()
        {
            InitializeComponent();
        }

        private void criaranimal_Click(object sender, EventArgs e)
        {
            // Obtém os valores dos campos do formulário
            string nome = nometext.Text;
            string especie = comboBoxespecie.SelectedItem.ToString();
            int idade = int.Parse(idadetext.Text);
            double peso = double.Parse(pesotext.Text);

            // Obtém o valor selecionado no ComboBox de dieta e converte para o tipo DIETA
            DIETA dieta = (DIETA)comboBoxdieta.SelectedItem;  // Converte o valor selecionado para o tipo DIETA

            int idHabitat = (int)comboBoxhabitat.SelectedValue; // Obtém o ID do habitat selecionado

            // Cria o animal com a função CriarAnimal
            bool animalCriado = RegrasAnimais.CriarAnimal(nome, especie, idade, peso, dieta);

            // Verifica se o animal foi criado com sucesso
            if (animalCriado)
            {
                // Agora que o animal foi criado, adiciona-o ao habitat
                Animal animalCriadoObj = Animais.Listaanimais.Last(); // Pega o último animal criado (assumindo que você está adicionando à lista de animais)

                bool sucessoAdicaoHabitat = RegrasHabitats.AdicionarAnimal(idHabitat, animalCriadoObj);

                if (sucessoAdicaoHabitat)
                {
                    MessageBox.Show("Animal criado e adicionado ao habitat com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao adicionar o animal ao habitat.");
                }
            }
            else
            {
                MessageBox.Show("Falha ao criar o animal.");
            }
        }

        private void comboBoxdieta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxanimal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuAdicionarAnimal_Load(object sender, EventArgs e)
        {
            PreencherComboBoxHabitat();
            PreencherComboBoxDieta();

            comboBoxespecie.Items.Add("Leão");
            comboBoxespecie.Items.Add("Elefante");
            comboBoxespecie.Items.Add("Camelo");
            comboBoxespecie.Items.Add("Dromedário");
            comboBoxespecie.Items.Add("Golfinho");
            comboBoxespecie.Items.Add("Tubarão Tigre");
            comboBoxespecie.Items.Add("Gorila");
            comboBoxespecie.Items.Add("Panda Vermelho");

        }
        private void PreencherComboBoxHabitat()
        {
            // Preenche o ComboBox com a lista de habitats
            comboBoxhabitat.DataSource = Habitats.Listahabitats;

            // Define o campo a ser exibido no ComboBox (nome do habitat, por exemplo)
            comboBoxhabitat.DisplayMember = "NomeHabitat";

            // Define o valor que será usado internamente (o ID do habitat)
            comboBoxhabitat.ValueMember = "IdHabitat";
        }

        private void PreencherComboBoxDieta()
        {
            // Preenche o ComboBox com os valores do enum DIETA
            comboBoxdieta.DataSource = Enum.GetValues(typeof(DIETA));
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

