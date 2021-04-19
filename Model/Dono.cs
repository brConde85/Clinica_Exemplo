using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Clínica_Exemplo.Model
{
    class Dono
    {
        private int id;
        private string nome;
        private int id_pet;        

        public int Id{ get => id; set => id = value; }
        public string Nome{ get => nome; set => nome = value; }
        public int Id_pet { get => id_pet; set => id_pet = value; }

        
    }
}
