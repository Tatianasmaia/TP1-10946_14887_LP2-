using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using BO;
using BR;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for ConsultarRegiao.xaml
    /// </summary>
    public partial class ConsultarRegiao : Page
    {
        public ConsultarRegiao()
        {
            InitializeComponent();
        }

        private void bt_Consultar_Click(object sender, RoutedEventArgs e)
        {
            List<Utente> listaAuxiliar = new List<Utente>();

            string regiao = tb_Regiao.Text;

            listaAuxiliar = Rules.ConsultRegion(regiao);


            if (listaAuxiliar.Count == 0)
            {
                MessageBox.Show("Nao existe nenhum utente com a regiao que inseriu!");
                Menu expenseReportPage = new Menu();
                this.NavigationService.Navigate(expenseReportPage);
            }
            else
            {
                dataGridRegiao.ItemsSource = listaAuxiliar;

            }
        }
    }
}
