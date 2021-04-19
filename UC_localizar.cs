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
    public partial class UC_localizar : UserControl
    {
        Dono dono = new Dono();
        Animal animal = new Animal();
        //SqlConnection conexao = new SqlConnection("Data Source=BRCONDE\\SQLEXPRESS;Initial Catalog=clinica_exemplo;Integrated Security=True");
        public UC_localizar()
        {
            InitializeComponent();
        }

        private void UC_localizar_Load(object sender, EventArgs e)
        {            
            try
            {                   
                var proprietario = dono.Nome;
                var lista = animal.ListarPet();
                for(var i = 0; i < lista.Count; i++ )
                {
                    
                    dataGrid_pet.Rows[i].Cells["animal_id"].Value = Convert.ToString(lista[i].Id_pet);                    
                    dataGrid_pet.Rows[i].Cells["nome"].Value = Convert.ToString(lista[i].Nome_pet);
                    dataGrid_pet.Rows[i].Cells["sexo"].Value = Convert.ToString(lista[i].Sexo);
                    dataGrid_pet.Rows[i].Cells["quilos"].Value = Convert.ToString(lista[i].Peso);
                    dataGrid_pet.Rows[i].Cells["raca"].Value = Convert.ToString(lista[i].Raca);
                    dataGrid_pet.Rows[i].Cells["especie"].Value = Convert.ToString(lista[i].Especie);
                    dataGrid_pet.Rows[i].Cells["temperamento"].Value = Convert.ToString(lista[i].Temperamento);
                    dataGrid_pet.Rows[i].Cells["observacao"].Value = Convert.ToString(lista[i].Observacao);
                    dataGrid_pet.Rows[i].Cells["dono_id"].Value = Convert.ToString(lista[i].Id_dono);                    
                }
                           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar animais", "Erro" + MessageBoxButtons.OK
                    + MessageBoxIcon.Error + ex.Message);
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja remover o registro "+ dataGrid_pet.CurrentRow.Cells[1].Value + "?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int codigo = Convert.ToInt32(dataGrid_pet.CurrentRow.Cells[0].Value);

                animal.Remover(codigo);
            }
        }
    }
}
