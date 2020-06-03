using System.Windows;
using System.Windows.Controls;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for MenuEditar.xaml
    /// </summary>
    public partial class MenuEditar : Page
    {
        public MenuEditar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão de editar um utente infetado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditarUtente_Click(object sender, RoutedEventArgs e)
        {
            EditarInformacao expenseReportPage = new EditarInformacao();
            this.NavigationService.Navigate(expenseReportPage);
        }

        /// <summary>
        /// Botão para voltar a adicionar um cliente não infetado aos infetados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VoltaAdd_Click(object sender, RoutedEventArgs e)
        {
            VoltarAdd expenseReportPage = new VoltarAdd();
            this.NavigationService.Navigate(expenseReportPage);
        }
    }
}
