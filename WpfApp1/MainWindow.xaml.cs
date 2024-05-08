using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int currentIndex = 0;
        private string[] imagePaths = { @"C:\Users\vovaa\source\repos\WpfApp1\Materials\бургер1.jpg", @"C:\Users\vovaa\source\repos\WpfApp1\Materials\бургер2.jpg", @"C:\Users\vovaa\source\repos\WpfApp1\Materials\чтоЭтоЖеНеБургерИзвините.jpg", @"C:\Users\vovaa\source\repos\WpfApp1\Materials\мэ.jpg" };

        public MainWindow()
        {
            InitializeComponent();
            UpdateImage();
        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Length;
            UpdateImage();
        }

        private void buttonPrev_Click(object sender, RoutedEventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagePaths.Length) % imagePaths.Length;
            UpdateImage();
        }

        private void UpdateImage()
        {
            BitmapImage bitmap = new BitmapImage(new Uri(imagePaths[currentIndex], UriKind.RelativeOrAbsolute));
            imageControl.Source = bitmap;
        }
    }
}

