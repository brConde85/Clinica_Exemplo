
namespace Clínica_Exemplo
{
    partial class UC_registrar
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.nomePet_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.raca_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.peso_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nome_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sexo_txt = new System.Windows.Forms.ComboBox();
            this.especie_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.temp_txt = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.obs_txt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do Pet";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.Location = new System.Drawing.Point(1034, 734);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(120, 50);
            this.btn_registrar.TabIndex = 8;
            this.btn_registrar.Text = "Cadastrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // nomePet_txt
            // 
            this.nomePet_txt.Location = new System.Drawing.Point(50, 108);
            this.nomePet_txt.Name = "nomePet_txt";
            this.nomePet_txt.Size = new System.Drawing.Size(351, 31);
            this.nomePet_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(978, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sexo do Pet";
            // 
            // raca_txt
            // 
            this.raca_txt.Location = new System.Drawing.Point(52, 205);
            this.raca_txt.Name = "raca_txt";
            this.raca_txt.Size = new System.Drawing.Size(349, 31);
            this.raca_txt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Raça";
            // 
            // peso_txt
            // 
            this.peso_txt.Location = new System.Drawing.Point(531, 109);
            this.peso_txt.Name = "peso_txt";
            this.peso_txt.Size = new System.Drawing.Size(224, 31);
            this.peso_txt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(532, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Peso (Kg)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1224, 289);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox6.Image = global::Clínica_Exemplo.Properties.Resources.pata;
            this.pictureBox6.Location = new System.Drawing.Point(655, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 17);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(515, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registrar Pet";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 471);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1230, 47);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(441, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Dados do Proprietário";
            // 
            // nome_txt
            // 
            this.nome_txt.Location = new System.Drawing.Point(51, 625);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(1103, 31);
            this.nome_txt.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(51, 584);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nome";
            // 
            // sexo_txt
            // 
            this.sexo_txt.FormattingEnabled = true;
            this.sexo_txt.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.sexo_txt.Location = new System.Drawing.Point(978, 106);
            this.sexo_txt.Name = "sexo_txt";
            this.sexo_txt.Size = new System.Drawing.Size(176, 33);
            this.sexo_txt.TabIndex = 3;
            // 
            // especie_txt
            // 
            this.especie_txt.Location = new System.Drawing.Point(531, 209);
            this.especie_txt.Name = "especie_txt";
            this.especie_txt.Size = new System.Drawing.Size(224, 31);
            this.especie_txt.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(531, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Espécie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(978, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Temperamento";
            // 
            // temp_txt
            // 
            this.temp_txt.FormattingEnabled = true;
            this.temp_txt.Items.AddRange(new object[] {
            "Dócil",
            "Nervoso"});
            this.temp_txt.Location = new System.Drawing.Point(978, 205);
            this.temp_txt.Name = "temp_txt";
            this.temp_txt.Size = new System.Drawing.Size(176, 33);
            this.temp_txt.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(50, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Observações";
            // 
            // obs_txt
            // 
            this.obs_txt.Location = new System.Drawing.Point(50, 307);
            this.obs_txt.Name = "obs_txt";
            this.obs_txt.Size = new System.Drawing.Size(1104, 109);
            this.obs_txt.TabIndex = 29;
            this.obs_txt.Text = "";
            // 
            // UC_registrar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BackgroundImage = global::Clínica_Exemplo.Properties.Resources.pet_food_scaled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.obs_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.temp_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.especie_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sexo_txt);
            this.Controls.Add(this.nome_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.peso_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.raca_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomePet_txt);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label2);
            this.Name = "UC_registrar";
            this.Size = new System.Drawing.Size(1220, 813);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox nomePet_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox raca_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox peso_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nome_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sexo_txt;
        private System.Windows.Forms.TextBox especie_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox temp_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox obs_txt;
    }
}
