using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApplicaion_SimpleCalculator1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int pierwszy;
        int drugi;
        char op;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TxtWynik.Text += btn.Content.ToString();
            drugi = Int32.Parse(TxtWynik.Text);
        }

        private void Podzielic_Click(object sender, RoutedEventArgs e)
        {
            pierwszy = Int32.Parse(TxtWynik.Text);
            op = '/';
            TxtWynik.Clear();
        }

        private void Mnozenie_Click(object sender, RoutedEventArgs e)
        {
            pierwszy = Int32.Parse(TxtWynik.Text);
            op = 'x';
            TxtWynik.Clear();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            pierwszy = Int32.Parse(TxtWynik.Text);
            op = '+';
            TxtWynik.Clear();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            pierwszy = Int32.Parse(TxtWynik.Text);
            op = '-';
            TxtWynik.Clear();
        }

        private void Rowna_sie_Click(object sender, RoutedEventArgs e)
        {
            drugi = Int32.Parse(TxtWynik.Text);
            int result = 0;
            if (op == '+')
            {
                result = pierwszy + drugi;
            }
            else if (op == '-')
            {
                result = pierwszy - drugi;
            }
            else if (op == 'X')
            {
                result = pierwszy * drugi;
            }
            else if (op == '/')
            {
                result = pierwszy / drugi;
            }
            if (TxtWynik.Text == "0") ;
            {
                TxtWynik.Clear();
            }
            TxtWynik.Text = result.ToString();
            

        }
    }
}
