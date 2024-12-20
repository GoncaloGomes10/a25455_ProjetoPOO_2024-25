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
    public partial class MenuAdicionarLimpeza : Form
    {
        public MenuAdicionarLimpeza()
        {
            InitializeComponent();

            comboBoxhabitats.DataSource = Habitats.Listahabitats;
            comboBoxhabitats.DisplayMember = "Display";
        }

        private void resgistarlimpeza_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores da ComboBox e TextBox
                Habitat habitatSelecionado = (Habitat)comboBoxhabitats.SelectedItem;
                DateTime horaLimpeza = DateTime.Parse(textboxdata.Text);

                // Registrar a limpeza
                bool sucesso = RegrasLimpezaHabitats.RegistarHabitatLimpo(habitatSelecionado, horaLimpeza);

                if (sucesso)
                {
                    MessageBox.Show("Limpeza registada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registar a limpeza: " + ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textboxdata_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
