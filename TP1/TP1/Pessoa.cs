using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{

    /// <summary>
    /// Descrição do que é uma pessoa
    /// </summary>
    public class Pessoa
    {
        //Atributos da classe
        #region Estado

        int idade, nif, numP;
        string nome, regiao, sexo;
        DateTime dataN;
        static int totalP = 0;

        #endregion


        #region Construtor
        //Métodos usados na criação de novos objectos
        /// <summary>
        /// Construtor com valores por defeito
        /// Executado quando fizer new Pessoa
        /// </summary>
        public Pessoa()
        {
            totalP++;
            idade = -1;
            nif = -1;
            nome = "";
            regiao = "";
            sexo = "";
            dataN = DateTime.Today;
            numP = totalP;
        }

        /// <summary>
        /// Construtor que recebe valores externos
        /// Executado quando fizer new Pessoa
        /// </summary>
        /// <param name="n">Nome da Pessoa</param>
        /// <param regiao="r">Regiao da Pessoa</param>
        /// <param sexo="s">Sexo da Pessoa</param>
        /// <param name="i">Idade da Pessoa</param>
        /// <param nif="ni">Nif da Pessoa</param>
        /// <param dataN="d">Data de nascimento da Pessoa</param>


        public Pessoa(string n, string r, string s, int i, int ni, DateTime d)
        {
            totalP++;
            nome = n;
            regiao =r;
            sexo = s;
            idade = i;
            nif = ni;
            dataN = d;
            numP = totalP;
        }

        #endregion


        #region Propriedades

        /// <summary>
        /// Manipula o atributo "idade"
        /// int idade;
        /// </summary>
        public int Idade
        {
            get => idade;
            set => idade = value;
        }

        /// <summary>
        /// Manipula o atributo "nif"
        /// int nif;
        /// </summary>
        public int Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        /// <summary>
        /// Manipula o atributo "nome"
        /// string nome;
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Manipula o atributo "regiao"
        /// string regiao;
        /// </summary>
        public string Regiao
        {
            get { return regiao; }
            set { regiao = value; }
        }

        /// <summary>
        /// Manipula o atributo "sexo"
        /// string sexo;
        /// </summary>
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        /// <summary>
        /// Manipula o atributo "dataN"
        /// DateTime dataN;
        /// </summary>
        public DateTime DataN
        {
            get { return dataN; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    dataN = value;
                }
            }
        }




        #endregion


        #region Metodos_da_classe

        /// <summary>
        /// Função que verifica se uma pessoa já está inserida
        /// Se existir, devolve a informação da pessoa e pergunta se pretende alterar
        /// </summary>
        /// <param nome="nome"></param>
        /// <returns></returns>
        public static bool VerificaPessoa(string nome)
        {

            return true;
        }

        /// <summary>
        /// Regista nova pessoa
        /// </summary>
        /// <returns></returns>
        public static int InserePessoa(Pessoa p)
        {

            return 0;
        }


        /// <summary>
        /// Consultar informação 
        /// </summary>
        /// <returns></returns>
        public static int Consultar(Pessoa p)
        {

            return 0;
        }

        #endregion

    }
}
