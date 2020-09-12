using System;
using POO3A12.DAL;
using POO3A12.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace POO3A12.BLL
{
    class TBL_MusicaBLL : TBL_MusicaDTO
    {

        private GravadoraBD daoBanco = new GravadoraBD();

        public DataTable ListarMusica()
        {
            string sql = string.Format($@"select * from TBL_Musica");
            return daoBanco.ExecutarConsulta(sql);
        }

        public DataTable PesquisarMusica(string condicao)
        {
            string sql = string.Format($@"select * from TBL_Musica where " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }
        public DataTable PesquisarMusica()
        {
            string sql = string.Format($@"select * from TBL_Musica");
            return daoBanco.ExecutarConsulta(sql);
        }

        public void AlterarMusica(TBL_MusicaBLL DtoMusica)
        {
            string sql = string.Format($@"UPDATE TBL_Musica set idMusica = '{DtoMusica.IdMusica}',
                                                                 idCD = '{DtoMusica.IdCD}',
                                                                 idGravadora = '{DtoMusica.IdGravadora}',
                                                                 nomeAutor = '{DtoMusica.NomeAutor}'
                                                   where nome = '{DtoMusica.Nome}';");
            daoBanco.ExecutarComando(sql);
        }

        public void InserirMusica(TBL_MusicaBLL ObjMusica)
        {
            string sql = string.Format($@"INSERT INTO TBL_Musica VALUES (NULL, '{ObjMusica.IdMusica}',
                                                                                '{ObjMusica.IdCD}',
                                                                                '{ObjMusica.IdGravadora}',
                                                                                '{ObjMusica.NomeAutor}',
                                                                                '{ObjMusica.Nome}');");
            daoBanco.ExecutarComando(sql);
        }


        // Metodo utilizado para excluir Cliente no Banco
        public void ExcluirMusica(TBL_MusicaBLL objMusica)
        {
            string sql = string.Format($@"DELETE FROM TBL_Musica where idMusica = {objMusica.IdMusica};");
            daoBanco.ExecutarComando(sql);
        }

    }
}
