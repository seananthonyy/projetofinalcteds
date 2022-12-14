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
using WPFteste.Models;
using WPFteste.Interfaces;
using WPFteste.Repositories;

namespace WPFteste
{
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UsuariosRepository _usuarios = new UsuariosRepository();
            Usuarios usuario = new Usuarios();

            usuario.Nome = Textbox_user.Text;
            usuario.Senha = Textbox_senha.Text;

            _usuarios.CriarUsuario(usuario);

            this.Close();
               


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
