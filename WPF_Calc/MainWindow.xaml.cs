using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClassLibrary2;
using Library2;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            double value;
            if (!double.TryParse(e.Text, out value) && e.Text != ",")
            {
                e.Handled = true;
            }
        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            int value;
            if (!Int32.TryParse(e.Text, out value) && e.Text != ",")
            {
                e.Handled = true;
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Minus min = new Minus(a.Text, b.Text);
            lbl.Content = min.getMinus(a.Text, b.Text);
        }

        private void b_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }


        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Plus sum = new Plus(a.Text, b.Text);
            lbl.Content = sum.GetSum(a.Text, b.Text);
        }

        private void BtnT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}