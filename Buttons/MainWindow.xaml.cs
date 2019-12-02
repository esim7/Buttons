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

namespace Buttons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void firstButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нажата кнопка №1");
        }

        private void secondButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нажата кнопка №2");
        }

        private void thirdButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нажата кнопка №3");
        }
    }
}
