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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WPFteste
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection conexaosql = new SqlConnection("Server=labsoft.pcs.usp.br; Initial Catalog=db_25; User id=usuario_25; pwd=61266348379;");

            try
            {
                if (conexaosql.State == System.Data.ConnectionState.Closed)
                    conexaosql.Open();
                string pesquisa = "SELECT COUNT (1) FROM TabelaJogoCteds WHERE userName=@usuario AND userPassword=@senha";
                SqlCommand sqlCmd = new SqlCommand(pesquisa, conexaosql);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@usuario", TextBox_Usuario.Text);
                sqlCmd.Parameters.AddWithValue("@senha", TextBox_Senha.Text);

                int x = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (x == 1)
                {
                    MessageBox.Show("autorizado");
                    JanelaMenu janela = new JanelaMenu();
                    janela.Show();
                    this.Close();
                }
                    
                else
                    MessageBox.Show("nao autorizado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                conexaosql.Close();
            }
        }

        private void TextBox_Senha_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
