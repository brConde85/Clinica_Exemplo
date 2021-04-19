using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clínica_Exemplo
{    
    public partial class Form_Principal : Form
    {
        
        static Form_Principal _obj;

        public static Form_Principal Instance
        {
            get
            {
                if (_obj == null)                
                    _obj = new Form_Principal();
                
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return pan_inicial; }
            set { pan_inicial = value; }
        }

        public Button BtnInicio
        {
            get => Btn_home;
            set => Btn_home = value;
        }

        
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            _obj = this;
            UC_inicio uc = new UC_inicio();
            uc.Dock = DockStyle.Fill;
            pan_inicial.Controls.Add(uc);
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            pan_inicial.Controls["UC_inicio"].BringToFront();
        }

        private void Btn_localizar_Click(object sender, EventArgs e)
        {

            if (!Form_Principal.Instance.PnlContainer.Controls.ContainsKey("UC_localizar"))
            {
                UC_localizar uc = new UC_localizar();
                uc.Dock = DockStyle.Fill;
                Form_Principal.Instance.PnlContainer.Controls.Add(uc);
            }
            Form_Principal.Instance.PnlContainer.Controls["UC_localizar"].BringToFront();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            if (!Form_Principal.Instance.PnlContainer.Controls.ContainsKey("UC_registrar"))
            {
                UC_registrar uc = new UC_registrar();
                uc.Dock = DockStyle.Fill;
                Form_Principal.Instance.PnlContainer.Controls.Add(uc);
            }
            Form_Principal.Instance.PnlContainer.Controls["UC_registrar"].BringToFront();
        }
    }
}
