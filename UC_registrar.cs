using Clínica_Exemplo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clínica_Exemplo
{
    public partial class UC_registrar : UserControl
    {
        Animal animal = new Animal();
        public UC_registrar()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {            
            animal.Inserir(nomePet_txt.Text, Convert.ToDouble(peso_txt.Text), sexo_txt.Text, raca_txt.Text, especie_txt.Text, temp_txt.Text, obs_txt.Text, nome_txt.Text);
        }
    }
}
