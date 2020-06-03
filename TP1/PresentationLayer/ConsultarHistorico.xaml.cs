using BO;
using BR;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for ConsultarHistorico.xaml
    /// </summary>
    public partial class ConsultarHistorico : Page
    {
        public ConsultarHistorico()
        {
            InitializeComponent();
        }

      
        /// <summary>
        /// Botão para consultar a lista do historico de utentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Consultar_Click(object sender, RoutedEventArgs e)
        {
            List<Utente> listaAuxiliar = new List<Utente>();

            listaAuxiliar = Rules.ListHistoric();

            if (listaAuxiliar.Count == 0)
            {
                MessageBox.Show("Nao existe nenhum utente no historico!");
                Menu expenseReportPage = new Menu();
                this.NavigationService.Navigate(expenseReportPage);
            }
            else
            {
                dataGridHistorico.ItemsSource = listaAuxiliar;
            }
        }
    }
}
