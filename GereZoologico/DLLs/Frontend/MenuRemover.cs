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

namespace Frontend
{
    public partial class MenuRemover : Form
    {
        public MenuRemover()
        {
            InitializeComponent();
        }

        private void comboBoxSelecionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtém a seleção da ComboBox
            string listaEscolhida = comboBoxSelecionar.SelectedItem.ToString();

            // Atualiza a ListBox com a lista correspondente
            AtualizarListBox(listaEscolhida);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void remover_Click(object sender, EventArgs e)
        {
            // Verifica se há um item selecionado
            if (listBox1.SelectedItem != null)
            {
                // Obtém o nome da lista selecionada no ComboBox
                string listaEscolhida = comboBoxSelecionar.SelectedItem.ToString();

                // Remove o item da lista correspondente
                switch (listaEscolhida)
                {
                    case "Animais":
                        RegrasAnimais.ApagarAnimal(((Animal)listBox1.SelectedItem).Id);
                        break;
                    case "Alimentações":
                        RegrasAlimencoes.ApagarAlimentacao(((Alimentacao)listBox1.SelectedItem).Id);
                        break;
                    case "Bilhetes":
                        RegrasBilhetes.ApagarBilhete((Bilhete)listBox1.SelectedItem);
                        break;
                    case "Limpezas":
                        if (listBox1.SelectedItem is LimpezaHabitat limpeza)
                        {
                            RegrasLimpezaHabitats.ApagarRegistoLimpeza(limpeza.Habitat.IdHabitat);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao identificar a limpeza selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case "Assistências Veterinárias":
                        if (listBox1.SelectedItem is AssistenciaVeterinaria assistencia)
                        {
                            RegrasAssistenciasVeterinarias.RemoveAssistenciaVeterinaria(assistencia.Habitat.IdHabitat);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao identificar a assistência veterinária selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "Utilizadores":
                        RegrasUtilizadores.RemoverUtilizador(((Utilizador)listBox1.SelectedItem).Id);
                        break;
                    case "Espetáculos":
                        RegrasEspetaculos.ApagarEspetaculo((Espetaculo)listBox1.SelectedItem);
                        break;

                }

                // Atualiza a ListBox após a remoção
                AtualizarListBox(listaEscolhida);

                // Mensagem de confirmação
                MessageBox.Show("Item removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarListBox(string listaEscolhida)
        {
            switch (listaEscolhida)
            {
                case "Animais":
                    listBox1.DataSource = RegrasAnimais.MostraAnimais();
                    listBox1.DisplayMember = "Display";
                    break;
                case "Alimentações":
                    listBox1.DataSource = RegrasAlimencoes.MostraTodasAlimentacoes();
                    listBox1.DisplayMember = "Display";
                    break;
                case "Bilhetes":
                    listBox1.DataSource = RegrasBilhetes.VerTodosBilhetes();
                    listBox1.DisplayMember = "Display";
                    break;
                case "Limpezas":
                    listBox1.DataSource = RegrasLimpezaHabitats.MostraTodosHabitatsLimpos();
                    listBox1.DisplayMember = "Display";
                    break;
                case "Assistências Veterinárias":
                    listBox1.DataSource = RegrasAssistenciasVeterinarias.MostraTodosRegistosAssistenciaVeterinaria();
                    listBox1.DisplayMember = "Display";
                    break;
                case "Utilizadores":
                    listBox1.DataSource = RegrasUtilizadores.MostrarTodosUtilizadores();
                    listBox1.DisplayMember = "Display";
                    break;
                case "Espetáculos":
                    listBox1.DataSource = RegrasEspetaculos.MostrarTodosEspetaculos();
                    listBox1.DisplayMember = "Display";
                    break;
            }
            
        }

        private void MenuRemover_Load(object sender, EventArgs e)
        {
            comboBoxSelecionar.Items.Add("Animais");
            comboBoxSelecionar.Items.Add("Alimentações");
            comboBoxSelecionar.Items.Add("Bilhetes");
            comboBoxSelecionar.Items.Add("Limpezas");
            comboBoxSelecionar.Items.Add("Assistências Veterinárias");
            comboBoxSelecionar.Items.Add("Utilizadores");
            comboBoxSelecionar.Items.Add("Espetáculos");

            // Define a seleção padrão
            comboBoxSelecionar.SelectedIndex = 0;

            AtualizarListBox("Animais");
        }
    }
}
