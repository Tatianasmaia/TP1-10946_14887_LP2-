using BR;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for VoltarAdd.xaml
    /// </summary>
    public partial class VoltarAdd : Page
    {
        public VoltarAdd()
        {
            InitializeComponent();
        }

        private void bt_VoltarAdd_Click(object sender, RoutedEventArgs e)
        {
            int num;

            if (string.IsNullOrEmpty(tb_num.Text))
            {
                MessageBox.Show("É necessário inserir um número!");
                Menu voltar = new Menu();
                this.NavigationService.Navigate(voltar);
            }
            
            try
            {
                num = Int32.Parse(tb_num.Text);
            }
            catch
            {
                throw new Exception("Cadeia de caracteres invalida");
            }
            

            int aux = Rules.EditPatient2(num);

            if (aux == 0)
            {
                MessageBox.Show("Não existe nenhum utente registado!");
               
            }
            else if (aux == 1)
            {
                MessageBox.Show("Não existe nenhum utente com esse número de utente!");
            }
            else if (aux == 2)
            {
                MessageBox.Show("Utente Adicionado com sucesso aos utentes infetados!");
            }

            //Voltar ao menu
            Menu expenseReportPage = new Menu();
            this.NavigationService.Navigate(expenseReportPage);
        }
    }
}
