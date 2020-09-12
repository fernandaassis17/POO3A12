using System;
using System.Collections.Generic;
using POO3A12.DAL;
using POO3A12.BLL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3A12.DTO
{
    class TBL_MusicaDTO
    {

        private int idMusica, idCD, idGravadora;
        private string nome, nomeAutor;

        public int IdMusica { get => idMusica; set => idMusica = value; }
        public string NomeAutor { get => nomeAutor; set => nomeAutor = value; }


        public int IdCD
        {
            set
            {
                if (value !=  0)
                {
                    this.idCD = value;
                }
                else
                {
                    throw new Exception("O campo id CD é obrigatório!!");
                }

            }
            get { return this.idCD; }
        }

        public int IdGravadora
        {
            set
            {
                if (value !=  0)
                {
                    this.idGravadora = value;
                }
                else
                {
                    throw new Exception("O campo id Gravadora é obrigatório!!");
                }

            }
            get { return this.idGravadora; }
        }

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo nome é obrigatório!!");
                }

            }
            get { return this.nome; }
        }
    }
}