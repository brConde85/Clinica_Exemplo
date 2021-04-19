
namespace Clínica_Exemplo
{
    partial class UC_site
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_linkedin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Powered by Bruno Marciano";
            // 
            // btn_linkedin
            // 
            this.btn_linkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_linkedin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_linkedin.Location = new System.Drawing.Point(59, 46);
            this.btn_linkedin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_linkedin.Name = "btn_linkedin";
            this.btn_linkedin.Size = new System.Drawing.Size(206, 32);
            this.btn_linkedin.TabIndex = 1;
            this.btn_linkedin.Text = "Visitar Linkedin";
            this.btn_linkedin.UseVisualStyleBackColor = true;
            this.btn_linkedin.Click += new System.EventHandler(this.btn_linkedin_Click);
            // 
            // UC_site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_linkedin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_site";
            this.Size = new System.Drawing.Size(334, 99);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_linkedin;
    }
}
