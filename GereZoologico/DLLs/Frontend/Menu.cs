﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void direcionarmenucriarconta_Click(object sender, EventArgs e)
        {
        
            MenuCriarConta menuCriarConta = new MenuCriarConta();
            menuCriarConta.Show();
        }
    }
}
