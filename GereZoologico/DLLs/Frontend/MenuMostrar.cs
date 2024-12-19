﻿using RegrasZoo;
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
    public partial class MenuMostrar : Form
    {
        public MenuMostrar()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxSelecionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtém a seleção da ComboBox
            string listaEscolhida = comboBoxSelecionar.SelectedItem.ToString();

            // Atualiza a ListBox com a lista correspondente
            AtualizarListBox(listaEscolhida);
        }

        private void MenuMostrar_Load(object sender, EventArgs e)
        {
            // Popula a ComboBox com as opções
            comboBoxSelecionar.Items.Add("Animais");
            comboBoxSelecionar.Items.Add("Tipos de Comida");
            comboBoxSelecionar.Items.Add("Habitats");

            // Define a seleção padrão
            comboBoxSelecionar.SelectedIndex = 0;

            // Exibe a lista de Animais ao iniciar
            AtualizarListBox("Animais");
        }

        private void AtualizarListBox(string listaEscolhida)
        {
            switch (listaEscolhida)
            {
                case "Animais":
                    listBox1.DataSource = RegrasAnimais.MostraAnimais();
                    listBox1.DisplayMember = "Display";
                    break;
                case "Tipos de Comida":
                    listBox1.DataSource = RegrasTiposdeComidas.MostraTodosTipodeComida();
                    listBox1.DisplayMember = "Display";
                    break;
                case "Habitats":
                    listBox1.DataSource = RegrasHabitats.MostraHabitats();
                    listBox1.DisplayMember = "Display";
                    break;
            }
        }
    }
}
