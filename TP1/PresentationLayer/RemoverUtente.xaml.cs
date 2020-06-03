using System;
using System.Windows;
using System.Windows.Controls;
using BR;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for RemoverUtente.xaml
    /// </summary>
    public partial class RemoverUtente : Page
    {
        public RemoverUtente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão Remover Utente de Infetados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remover_Click(object sender, RoutedEventArgs e)
        {
            //Declaração de Variáveis
            int num;

            try
            {
                num = Int32.Parse(tb_Num.Text);
            }
            catch
            {
                throw new Exception("Cadeia de caracteres invalida!");
            }

            //Envia o número de utente inserido para a função RemovePatient para que, se possíel, seja removido o utente da lista de utentes infetados
            int aux = Rules.RemovePatient(num);

            if (aux == 0)
            {
                MessageBox.Show("Não existe nenhum utente registado!");
                Menu registar = new Menu();
            }
            else if (aux == 1)
            {
                MessageBox.Show("Não existe nenhum utente com esse número de utente!");
            }
            else if (aux == 2)
            {
                MessageBox.Show("Utente removido com sucesso!");
            }

            //Voltar ao menu
            Menu expenseReportPage = new Menu();
            this.NavigationService.Navigate(expenseReportPage);
        }
    }
}
