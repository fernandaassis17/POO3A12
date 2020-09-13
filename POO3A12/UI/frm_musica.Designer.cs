namespace POO3A12
{
    partial class frm_musica
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_musica));
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_listar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idmusica = new System.Windows.Forms.TextBox();
            this.txt_nomeautor = new System.Windows.Forms.TextBox();
            this.txt_idcd = new System.Windows.Forms.TextBox();
            this.txt_idgravadora = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(498, 47);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(110, 41);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_listar
            // 
            this.dgv_listar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_listar.Location = new System.Drawing.Point(12, 126);
            this.dgv_listar.Name = "dgv_listar";
            this.dgv_listar.Size = new System.Drawing.Size(449, 172);
            this.dgv_listar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id Música:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id CD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id Gravadora:";
            // 
            // txt_idmusica
            // 
            this.txt_idmusica.Location = new System.Drawing.Point(94, 12);
            this.txt_idmusica.Name = "txt_idmusica";
            this.txt_idmusica.Size = new System.Drawing.Size(126, 20);
            this.txt_idmusica.TabIndex = 13;
            // 
            // txt_nomeautor
            // 
            this.txt_nomeautor.Location = new System.Drawing.Point(108, 82);
            this.txt_nomeautor.Name = "txt_nomeautor";
            this.txt_nomeautor.Size = new System.Drawing.Size(112, 20);
            this.txt_nomeautor.TabIndex = 14;
            // 
            // txt_idcd
            // 
            this.txt_idcd.Location = new System.Drawing.Point(311, 47);
            this.txt_idcd.Name = "txt_idcd";
            this.txt_idcd.Size = new System.Drawing.Size(150, 20);
            this.txt_idcd.TabIndex = 15;
            // 
            // txt_idgravadora
            // 
            this.txt_idgravadora.Location = new System.Drawing.Point(369, 15);
            this.txt_idgravadora.Name = "txt_idgravadora";
            this.txt_idgravadora.Size = new System.Drawing.Size(92, 20);
            this.txt_idgravadora.TabIndex = 16;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(77, 47);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(143, 20);
            this.txt_nome.TabIndex = 17;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(498, 106);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(110, 41);
            this.btn_alterar.TabIndex = 18;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.Image")));
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(498, 163);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(110, 41);
            this.btn_novo.TabIndex = 19;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(498, 221);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(110, 41);
            this.btn_excluir.TabIndex = 20;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // frm_musica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(641, 309);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_idgravadora);
            this.Controls.Add(this.txt_idcd);
            this.Controls.Add(this.txt_nomeautor);
            this.Controls.Add(this.txt_idmusica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_listar);
            this.Controls.Add(this.btn_buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_musica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musica";
            this.Load += new System.EventHandler(this.frmMusica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_listar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idmusica;
        private System.Windows.Forms.TextBox txt_nomeautor;
        private System.Windows.Forms.TextBox txt_idcd;
        private System.Windows.Forms.TextBox txt_idgravadora;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_excluir;
    }
}

