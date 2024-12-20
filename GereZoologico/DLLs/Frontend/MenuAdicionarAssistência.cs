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
using RegrasZoo;
using ObjetosZoo;

namespace Frontend
{
    public partial class MenuAdicionarAssistência : Form
    {
        public MenuAdicionarAssistência()
        {
            InitializeComponent();
        }

        private void registarassistencia_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o habitat está selecionado
                if (comboBoxhabitats.SelectedItem is Habitat habitatSelecionado &&
                    comboBoxanimais.SelectedItem is Animal animalSelecionado)
                {
                    // Obtém a data a partir da TextBox
                    if (DateTime.TryParse(textBoxdata.Text, out DateTime dataTratamento))
                    {
                        // Chama a função para registrar a assistência
                        bool sucesso = RegrasAssistenciasVeterinarias.RegistaAssistenciaVeterinaria(habitatSelecionado, animalSelecionado, dataTratamento);

                        if (sucesso)
                        {
                            MessageBox.Show("Assistência veterinária registada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O animal não está associado ao habitat selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data inválida. Insira uma data válida no formato correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um habitat e um animal válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuAdicionarAssistência_Load(object sender, EventArgs e)
        {
            comboBoxhabitats.DataSource = Habitats.Listahabitats;
            comboBoxhabitats.DisplayMember = "Display";

            comboBoxanimais.DataSource = Animais.Listaanimais;
            comboBoxanimais.DisplayMember = "Display";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
