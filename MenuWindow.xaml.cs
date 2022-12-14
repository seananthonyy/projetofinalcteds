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

        private void Click_Regras(object sender, RoutedEventArgs e)
        {
            if(RetanguloRegras.Visibility == Visibility.Hidden)
            {
                RetanguloRegras.Visibility = Visibility.Visible;
                TituloAtributos.Visibility = Visibility.Visible;
                TextoAtributos.Visibility = Visibility.Visible;
                TituloComuns.Visibility = Visibility.Visible;
                TextoComuns.Visibility = Visibility.Visible;
                TituloOposto.Visibility = Visibility.Visible;
                TextoOposto.Visibility = Visibility.Visible;
                TituloPericia.Visibility = Visibility.Visible;
                TextoPericias.Visibility = Visibility.Visible;
                TextoRegras.Visibility = Visibility.Visible;
                ListaRegras.Visibility = Visibility.Visible;
            }
            else
            {
                RetanguloRegras.Visibility = Visibility.Hidden;
                TituloAtributos.Visibility = Visibility.Hidden;
                TextoAtributos.Visibility = Visibility.Hidden;
                TituloComuns.Visibility = Visibility.Hidden;
                TextoComuns.Visibility = Visibility.Hidden;
                TituloOposto.Visibility = Visibility.Hidden;
                TextoOposto.Visibility = Visibility.Hidden;
                TituloPericia.Visibility = Visibility.Hidden;
                TextoPericias.Visibility = Visibility.Hidden;
                TextoRegras.Visibility = Visibility.Hidden;
                ListaRegras.Visibility = Visibility.Hidden;
            }
        }

    }
}
