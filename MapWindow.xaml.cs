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
    /// Lógica interna para MapWindow.xaml
    /// </summary>
    public partial class MapWindow : Window
    {
        public MapWindow()
        {
            InitializeComponent();
        }


        private void Botao_Voltar(object sender, RoutedEventArgs e)
        {
            JanelaMenu janela = new JanelaMenu();
            janela.Show();
            this.Close();
        }

        private void Botao_d100(object sender, RoutedEventArgs e)
        {
            Random roll = new Random(); 
            int currentRoll = roll.Next(1, 101);
            string stringCurrentRoll = currentRoll.ToString();
            MessageBox.Show(string.Format("Rolagem D100: {0}", stringCurrentRoll));
        }

        private void Botao_d20(object sender, RoutedEventArgs e)
        {
            Random roll = new Random();
            int currentRoll = roll.Next(1, 21);
            string stringCurrentRoll = currentRoll.ToString();
            MessageBox.Show(string.Format("Rolagem D20: {0}", stringCurrentRoll));
        }

        private void Botao_d12(object sender, RoutedEventArgs e)
        {
            Random roll = new Random();
            int currentRoll = roll.Next(1, 13);
            string stringCurrentRoll = currentRoll.ToString();
            MessageBox.Show(string.Format("Rolagem D12: {0}", stringCurrentRoll));
        }

        private void Botao_d10(object sender, RoutedEventArgs e)
        {
            Random roll = new Random();
            int currentRoll = roll.Next(1, 11);
            string stringCurrentRoll = currentRoll.ToString();
            MessageBox.Show(string.Format("Rolagem D10: {0}", stringCurrentRoll));
        }

        private void Botao_d8(object sender, RoutedEventArgs e)
        {
            Random roll = new Random();
            int currentRoll = roll.Next(1, 9);
            string stringCurrentRoll = currentRoll.ToString();
            MessageBox.Show(string.Format("Rolagem D8: {0}", stringCurrentRoll));
        }

        private void Botao_d6(object sender, RoutedEventArgs e)
        {
            Random roll = new Random();
            int currentRoll = roll.Next(1, 7);
            string stringCurrentRoll = currentRoll.ToString();
            MessageBox.Show(string.Format("Rolagem D6: {0}", stringCurrentRoll));
        }

        private void Botao_d4(object sender, RoutedEventArgs e)
        {
            Random roll = new Random();
            int currentRoll = roll.Next(1, 5);
            string stringCurrentRoll = currentRoll.ToString();
            MessageBox.Show(string.Format("Rolagem D4: {0}", stringCurrentRoll));
        }


        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter =
                "Image Files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if ((bool)dialog.ShowDialog())
            {
                var bitmap = new BitmapImage(new Uri(dialog.FileName));
                var image = new Image { Source = bitmap };
                Canvas.SetLeft(image, 0);
                Canvas.SetTop(image, 0);
                canvas.Children.Add(image);
            }
        }

        private Image draggedImage;
        private Point mousePosition;

        private void CanvasMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var image = e.Source as Image;

            if (image != null && canvas.CaptureMouse())
            {
                mousePosition = e.GetPosition(canvas);
                draggedImage = image;
                Panel.SetZIndex(draggedImage, 1); // in case of multiple images
            }
        }

        private void CanvasMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (draggedImage != null)
            {
                canvas.ReleaseMouseCapture();
                Panel.SetZIndex(draggedImage, 0);
                draggedImage = null;
            }
        }

        private void CanvasMouseMove(object sender, MouseEventArgs e)
        {
            if (draggedImage != null)
            {
                var position = e.GetPosition(canvas);
                var offset = position - mousePosition;
                mousePosition = position;
                Canvas.SetLeft(draggedImage, Canvas.GetLeft(draggedImage) + offset.X);
                Canvas.SetTop(draggedImage, Canvas.GetTop(draggedImage) + offset.Y);
            }
        }

        private void Botao_AddMapa_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
