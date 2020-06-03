using BO;
using BR;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for ConsultarInfetados.xaml
    /// </summary>
    public partial class ConsultarInfetados : Page
    {
        public ConsultarInfetados()
        {
            InitializeComponent();
        }


        private void Consultar_Click(object sender, RoutedEventArgs e)
        {
            List<Utente> listaAuxiliar = new List<Utente>();

            listaAuxiliar = Rules.ListInfected();

            if (listaAuxiliar.Count == 0)
            {
                MessageBox.Show("Nao existe nenhum utente registado!");
                Menu expenseReportPage = new Menu();
                this.NavigationService.Navigate(expenseReportPage);
            }
            else
            {
                dataGridInfetados.ItemsSource = listaAuxiliar;
            }
        }
    }
}
