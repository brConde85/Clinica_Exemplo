using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clínica_Exemplo
{
    public partial class UC_site : UserControl
    {
        public UC_site()
        {
            InitializeComponent();
        }

        private void btn_linkedin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("edge", "https://www.linkedin.com/in/brunolpmarciano");
        }
    }
}
