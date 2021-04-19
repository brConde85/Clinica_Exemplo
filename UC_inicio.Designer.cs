
namespace Clínica_Exemplo
{
    partial class UC_inicio
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_texto1 = new System.Windows.Forms.Label();
            this.pan_inicial = new System.Windows.Forms.Panel();
            this.uC_site1 = new Clínica_Exemplo.UC_site();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_inicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_texto1
            // 
            this.label_texto1.AutoSize = true;
            this.label_texto1.BackColor = System.Drawing.Color.Transparent;
            this.label_texto1.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_texto1.ForeColor = System.Drawing.Color.Teal;
            this.label_texto1.Location = new System.Drawing.Point(51, 184);
            this.label_texto1.Name = "label_texto1";
            this.label_texto1.Size = new System.Drawing.Size(392, 50);
            this.label_texto1.TabIndex = 2;
            this.label_texto1.Text = "a Clínica Exemplo";
            // 
            // pan_inicial
            // 
            this.pan_inicial.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pan_inicial.BackgroundImage = global::Clínica_Exemplo.Properties.Resources.pet_food_scaled;
            this.pan_inicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_inicial.Controls.Add(this.uC_site1);
            this.pan_inicial.Controls.Add(this.label1);
            this.pan_inicial.Controls.Add(this.label_texto1);
            this.pan_inicial.Location = new System.Drawing.Point(0, -1);
            this.pan_inicial.Name = "pan_inicial";
            this.pan_inicial.Size = new System.Drawing.Size(1220, 813);
            this.pan_inicial.TabIndex = 8;
            // 
            // uC_site1
            // 
            this.uC_site1.Location = new System.Drawing.Point(800, 649);
            this.uC_site1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_site1.Name = "uC_site1";
            this.uC_site1.Size = new System.Drawing.Size(336, 104);
            this.uC_site1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 106);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem-Vindo";
            // 
            // UC_inicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pan_inicial);
            this.Location = new System.Drawing.Point(303, 2);
            this.Name = "UC_inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1220, 813);
            this.pan_inicial.ResumeLayout(false);
            this.pan_inicial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_texto1;
        private System.Windows.Forms.Panel pan_inicial;
        private System.Windows.Forms.Label label1;
        private UC_site uC_site1;
    }
}
