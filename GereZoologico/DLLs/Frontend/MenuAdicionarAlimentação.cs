using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dados;
using ObjetosZoo;
using RegrasZoo;

namespace Frontend
{
    public partial class MenuAdicionarAlimentação : Form
    {
        public MenuAdicionarAlimentação()
        {
            InitializeComponent();


            comboBoxanimal.DataSource = Animais.Listaanimais;
            comboBoxtipodecomida.DataSource = TiposdeComidas.Listatipodecomidas;


            comboBoxanimal.DisplayMember = "Display2";
            comboBoxtipodecomida.DisplayMember = "Display1";
        }

        private void registaralimentacao_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores das ComboBoxes e TextBoxes
                Animal animalSelecionado = (Animal)comboBoxanimal.SelectedItem;
                TipodeComida comidaSelecionada = (TipodeComida)comboBoxtipodecomida.SelectedItem;
                double quantidade = double.Parse(textBoxquantidade.Text);
                DateTime data = DateTime.Parse(textBoxdata.Text);

                RegrasAlimencoes.RegistraAlimentacao(animalSelecionado, data, quantidade, comidaSelecionada);

                MessageBox.Show("Alimentação registada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registar alimentação: " + ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
