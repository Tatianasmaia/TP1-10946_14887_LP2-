/*
 * Trabalho Prático - Linguagem de Programação II
 * 
 * Realizado por: Joana Jesus (nrº 10946) e Tatiana Maia (nrº 14887)
 * 
 * 
 * Este trabalho tem como objetivo gerir pessoas infetadas numa situação de crise de saúde pública. 
 * Deste modo, o sistema irá permitir inserir novos casos, editar e remover casos já existentes, assim como a consulta dos mesmos através dos vários tipos de informação do utente.
 * 
 * ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 * 
 * Camada Regras de Negócio
 * Camada que consegue aceder aos métodos da camada de dados (DataLayer)
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using BO;

namespace BR
{
    public class Rules
    {
        /// <summary>
        /// Esta função faz a ligação entre as camadas presentation layer e Data layer
        /// </summary>
        /// <param name="p"></param>
        /// <returns>false-> Caso o utente já tenha sido inserido
        ///           true-> Caso o utente tenha sido inserido com sucesso</returns>
        public static bool InsereUtente(Pessoa p)
        {
            return Pessoas.InsereUtente(p);
        }
    }
}
