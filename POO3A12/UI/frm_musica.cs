using System;
using System.Collections.Generic;
using System.ComponentModel;
using POO3A12.DAL;
using POO3A12.BLL;
using POO3A12.DTO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POO3A12
{
    public partial class frm_musica : Form
    {

        TBL_MusicaBLL bllMusica = new TBL_MusicaBLL();
        TBL_MusicaDTO dtoMusica = new TBL_MusicaDTO();
        string sql;

        GravadoraBD bd = new GravadoraBD();

        public frm_musica()
        {
            InitializeComponent();

        }

        public void Listar()
        {
            sql = "select * from TBL_Musica";
            dgv_listar.DataSource = bd.ConsultarTabelas(sql);
        }

        public void Limpar()
        {
            txt_idcd.Clear();
            txt_idgravadora.Clear();
            txt_idmusica.Clear();
            txt_nome.Clear();
            txt_nomeautor.Focus();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();

            sql = string.Format("Select * from TBL_Musica where idMusica = '{0}' or nome = '{1}'", txt_idmusica.Text, txt_nome.Text);
            buscar = bd.ConsultarTabelas(sql);

            if (buscar.Rows.Count > 0)
            {
                txt_idmusica.Text = buscar.Rows[0]["idMusica"].ToString();
                txt_nome.Text = buscar.Rows[0]["nome"].ToString();
                txt_nomeautor.Text = buscar.Rows[0]["nomeAutor"].ToString();
                txt_idgravadora.Text = buscar.Rows[0]["idGravadora"].ToString();
                txt_idcd.Text = buscar.Rows[0]["idCD"].ToString();
            }
            else
            {
                MessageBox.Show("Música não cadastrada!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            try
            {

                TBL_MusicaDTO objMusica = new TBL_MusicaDTO();
                objMusica.Nome = txt_nome.Text.Trim();
                objMusica.NomeAutor = txt_nomeautor.Text.Trim();

                if (txt_idmusica.Text != "")
                {
                    MessageBox.Show("Não preencha o campo Id Música!!");
                } else {
                    sql = string.Format("insert into TBL_Musica values(null,'{0}','{1}','{2}','{3}')",
                    txt_idmusica.Text, txt_nome.Text, txt_idgravadora.Text, txt_nomeautor.Text, txt_idcd.Text);

                    bd.AlterarTabelas(sql);
                    MessageBox.Show("Música cadastrada com sucesso!!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    Listar();
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


}

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from TBL_Musica where idMusica = '{0}'", txt_idmusica.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Música exluída com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Limpar();
            Listar();
        }

        private void frmMusica_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            // Passo os dados para o DTO
            dtoMusica.Nome = txt_nome.Text.ToString();
            dtoMusica.NomeAutor = txt_nomeautor.Text.ToString();
            dgv_listar.DataSource = bllMusica.ListarMusica();
        }
    }

}
