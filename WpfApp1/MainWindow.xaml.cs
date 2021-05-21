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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long w;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Suma_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float a = float.Parse(textBoxa.Text);
                float b = float.Parse(textBoxb.Text);
                
                TextBoxw.Text = (a+b).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("podaj liczby");
                throw;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float a = float.Parse(textBoxa.Text);
                float b = float.Parse(textBoxb.Text);

                TextBoxw.Text = (a - b).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("podaj liczby");
                throw;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                float a = float.Parse(textBoxa.Text);
                float b = float.Parse(textBoxb.Text);

                TextBoxw.Text = (a * b).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("podaj liczby");
                throw;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            try
            {
                double a = float.Parse(textBoxa.Text);
                double b = float.Parse(textBoxb.Text);
                if (b == 0)
                {
                    TextBoxw.Text = ("nie dzielimy przez 0");

                }
                else
                TextBoxw.Text = (a / b).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("podaj liczby");
                throw;
            }
        }
    }
}
