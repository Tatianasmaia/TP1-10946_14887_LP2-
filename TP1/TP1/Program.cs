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

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistarCaso();

            //Pessoas.listaUtentes.ForEach(Console.WriteLine);

            
            Console.ReadKey();

        }

    

        /// <summary>
        /// Função que regista novo caso
        /// </summary>
        public static void RegistarCaso()
        {

            Pessoa p = new Pessoa();
            bool aux = false;


            //Pede os dados ao utente
            Console.WriteLine("Introduza o seu primeiro nome: ");
            string nome = Console.ReadLine();
            p.Nome = nome;

            Console.WriteLine("Introduza a sua idade: ");
            int idade = Int32.Parse(Console.ReadLine());
            p.Idade = idade;

            Console.WriteLine("Introduza o NIF: ");
            int nif = Int32.Parse(Console.ReadLine());
            p.Nif = nif;

            Console.WriteLine("Introduza a sua Regiao: ");
            string regiao = Console.ReadLine();
            p.Regiao = regiao;

            //Falta fazer a verificação do sexo
            Console.WriteLine("Introduza o seu sexo: ");
            string sexo = Console.ReadLine();
            p.Sexo = sexo;

            //Envia a pessoa para a função que irá fazer a sua inserção
            aux = Pessoas.InsereUtente(p);


            if (aux == true)
            {
                Console.WriteLine("O utente foi adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("O utente que pretende inserir já existe!");
                Console.Clear();
                RegistarCaso();
            }
            

            Console.ReadKey();
            Console.Clear();

        }

    }
}
