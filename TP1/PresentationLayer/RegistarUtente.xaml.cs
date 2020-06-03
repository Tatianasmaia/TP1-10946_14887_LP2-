using System;
using System.Windows;
using System.Windows.Controls;
using BO;
using BR;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for RegistarUtente.xaml
    /// </summary>
    public partial class RegistarUtente : Page
    {
        public RegistarUtente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão Registar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Registar_Click(object sender, RoutedEventArgs e)
        {
            Utente u = new Utente();
            int aux;

            //Verificar se todos os campos estão preenchidos
            if(string.IsNullOrEmpty(tb_Nome.Text)|| string.IsNullOrEmpty(tb_Idade.Text)|| string.IsNullOrEmpty(tb_Nif.Text)|| string.IsNullOrEmpty(tb_Regiao.Text)|| string.IsNullOrEmpty(tb_Sexo.Text))
            {
                MessageBox.Show("Não pode deixar espacos em branco!");

                //Código para parar esta page e voltar ao menu  ?
                Menu menu = new Menu();
                this.NavigationService.Navigate(menu);

            }

            //Atribuir dados inseridos pelo utilizador ao utente auxiliar
            u.Nome = tb_Nome.Text;

            try
            {
                u.Idade = Int32.Parse(tb_Idade.Text);
            }
            catch(Exception e1)
            {
                MessageBox.Show("Cadeia de caracteres inválida!");
            }

            try
            {
                u.Nif = Int32.Parse(tb_Nif.Text);
            }
            catch(Exception e1)
            {
                MessageBox.Show("Cadeia de caracteres inválida!");
            }
            
            u.Regiao = tb_Regiao.Text;
            u.Sexo = tb_Sexo.Text;

            //Envia o utente auxiliar com a informação que o utilizador inseriu para a função VerifyPatient que verifica se todos os dados inseridos são válidos
            aux = Rules.VerifyPatient(u);

            if (aux == 0)
            {
                MessageBox.Show("Idade inserida não válida!");
            }
            else if (aux == 1)
            {
                MessageBox.Show("O nif que inseriu não possui o número de dígitos correto!");
            }
            else if (aux == 2)
            {
                MessageBox.Show("O nif já foi registado por outro utente!");
            }
            else if (aux == 3)
            {
                MessageBox.Show("O sexo que inseriu não é valido!");
            }
            else if (aux == 4)
            {
                MessageBox.Show("O utente foi registado com sucesso!");
            }

            //Voltar ao menu
            Menu expenseReportPage = new Menu();
            this.NavigationService.Navigate(expenseReportPage);
        }

    }
}
