using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFteste
{
    /// <summary>
    /// Lógica interna para JanelaMenu.xaml
    /// </summary>
    public partial class JanelaMenu : Window
    {
        public JanelaMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RetanguloLista.Visibility = Visibility.Hidden;
        }

        private void Click_Personagens(object sender, RoutedEventArgs e)
        {
            if(RetanguloLista.Visibility == Visibility.Hidden)
            {
                RetanguloLista.Visibility = Visibility.Visible;
                ListaPersonagens.Visibility = Visibility.Visible;
            }
            else
            {
                RetanguloLista.Visibility = Visibility.Hidden;
                ListaPersonagens.Visibility = Visibility.Hidden;
            }
            
        }
        private void Click_Conta(object sender, RoutedEventArgs e)
        {
            if(RetanguloOpcoes.Visibility == Visibility.Hidden)
            {
                RetanguloOpcoes.Visibility = Visibility.Visible;
                TextoOpcoes.Visibility = Visibility.Visible;
                BotaoTrocaConta.Visibility = Visibility.Visible;
            }
            else
            {
                RetanguloOpcoes.Visibility = Visibility.Hidden;
                TextoOpcoes.Visibility = Visibility.Hidden;
                BotaoTrocaConta.Visibility = Visibility.Hidden;
            }
        }

        private void Click_TrocaDeConta(object sender, RoutedEventArgs e)
        {
            MainWindow JanelaPrincipal = new MainWindow();
            JanelaPrincipal.Show();
            this.Close();
        }
    }
}
