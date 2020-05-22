/*
 * Trabalho Prático - Linguagem de Programação II
 * 
 * Realizado por: Joana Jesus (nrº 10946) e Tatiana Maia (nrº 14887)
 * 
 * 
 * Este trabalho tem como objetivo gerir pessoas infetadas numa situação de crise de saúde pública. 
 * Deste modo, o sistema irá permitir inserir novos casos, editar e remover casos já existentes, assim como a consulta dos mesmos através dos vários tipos de informação do utente.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Pessoas
    {

        //Atributos da classe

        #region Constantes


        #endregion

        #region Variáveis

        //Quando tiver por camadas tem de ser private
        public static List<Pessoa> listaUtentes;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor default da classe
        /// Cria a lista ao executar o programa
        /// </summary>
        static Pessoas()
        {

            listaUtentes = new List<Pessoa>();

        }

        #endregion


        #region Metodos_Da_Classe

       

        /// <summary>
        /// Recebe uma pessoa(p) do tipo Pessoa.
        /// Caso a pessoa já estiver inserida na lista irá retornar true.
        /// Caso a pessoa tenha sido adicionada com sucesso é retornado true;
        /// </summary>
        /// <param name="p"></param>
        /// <returns>false-> Caso o utente já tenha sido inserido
        ///           true-> Caso o utente tenha sido inserido com sucesso</returns>
        public static bool InsereUtente(Pessoa p)
        {
            //Caso o utente já tenha sido inserido
            if (listaUtentes.Contains(p)) return false;


            listaUtentes.Add(p);
            return true;
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool RemoveUtente(Pessoa p)
        {

            listaUtentes.First(d => d == p).Infetado = false;


            //if (listaUtentes.Equals(p)){

            //    p.Infetado = false;
            //}
            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param =""></param>
        /// <returns></returns>
        //public static int Editar()
        //{

        //}


        #endregion

        #region Metodos_Auxiliares

        
        /// <summary>
        /// Procura a ficha de determinada pessoa pelo seu nif, visto que é único
        /// </summary>
        /// <param nif="nif"></param>
        /// <returns></returns>
        //public static Pessoa GetPessoa(int nif)
        //{
        //
        //}

        #endregion

    }
}
