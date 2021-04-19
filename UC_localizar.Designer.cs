
namespace Clínica_Exemplo
{
    partial class UC_localizar
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_pet = new System.Windows.Forms.DataGridView();
            this.animal_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dono_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_remover = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_pet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1220, 42);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = global::Clínica_Exemplo.Properties.Resources.pata;
            this.pictureBox6.Location = new System.Drawing.Point(713, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 17);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(519, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 41);
            this.label1.TabIndex = 18;
            this.label1.Text = "Localizar Pet";
            // 
            // dataGrid_pet
            // 
            this.dataGrid_pet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_pet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animal_id,
            this.nomeProprietario,
            this.nome,
            this.sexo,
            this.quilos,
            this.raca,
            this.especie,
            this.temperamento,
            this.observacao,
            this.dono_id});
            this.dataGrid_pet.Location = new System.Drawing.Point(53, 147);
            this.dataGrid_pet.Name = "dataGrid_pet";
            this.dataGrid_pet.RowHeadersWidth = 62;
            this.dataGrid_pet.RowTemplate.Height = 25;
            this.dataGrid_pet.Size = new System.Drawing.Size(1132, 471);
            this.dataGrid_pet.TabIndex = 20;
            // 
            // animal_id
            // 
            this.animal_id.HeaderText = "Código Pet";
            this.animal_id.MinimumWidth = 8;
            this.animal_id.Name = "animal_id";
            this.animal_id.Width = 150;
            // 
            // nomeProprietario
            // 
            this.nomeProprietario.HeaderText = "Proprietário";
            this.nomeProprietario.MinimumWidth = 8;
            this.nomeProprietario.Name = "nomeProprietario";
            this.nomeProprietario.Visible = false;
            this.nomeProprietario.Width = 150;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome Pet";
            this.nome.MinimumWidth = 8;
            this.nome.Name = "nome";
            this.nome.Width = 150;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.MinimumWidth = 8;
            this.sexo.Name = "sexo";
            this.sexo.Width = 150;
            // 
            // quilos
            // 
            this.quilos.HeaderText = "Quilos(kg)";
            this.quilos.MinimumWidth = 8;
            this.quilos.Name = "quilos";
            this.quilos.Width = 150;
            // 
            // raca
            // 
            this.raca.HeaderText = "Raça";
            this.raca.MinimumWidth = 8;
            this.raca.Name = "raca";
            this.raca.Width = 150;
            // 
            // especie
            // 
            this.especie.HeaderText = "Espécie";
            this.especie.MinimumWidth = 8;
            this.especie.Name = "especie";
            this.especie.Width = 150;
            // 
            // temperamento
            // 
            this.temperamento.HeaderText = "Temperamento";
            this.temperamento.MinimumWidth = 8;
            this.temperamento.Name = "temperamento";
            this.temperamento.Width = 150;
            // 
            // observacao
            // 
            this.observacao.HeaderText = "Observação";
            this.observacao.MinimumWidth = 8;
            this.observacao.Name = "observacao";
            this.observacao.Width = 150;
            // 
            // dono_id
            // 
            this.dono_id.HeaderText = "Id_dono";
            this.dono_id.MinimumWidth = 8;
            this.dono_id.Name = "dono_id";
            this.dono_id.Width = 150;
            // 
            // btn_remover
            // 
            this.btn_remover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_remover.Location = new System.Drawing.Point(841, 670);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(133, 45);
            this.btn_remover.TabIndex = 21;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1041, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 22;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UC_localizar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.dataGrid_pet);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_localizar";
            this.Size = new System.Drawing.Size(1220, 813);
            this.Load += new System.EventHandler(this.UC_localizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_pet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_pet;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn animal_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProprietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn raca;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dono_id;
    }
}
