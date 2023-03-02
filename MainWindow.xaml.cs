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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first;
        int second;
        char op;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button) sender;   
            Txtresult.Text += btn.Content.ToString();    
            second = Int32.Parse(Txtresult.Text);   
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Txtresult.Text);
            op = '/';
            Txtresult.Clear();  
        }

        private void mulbotton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Txtresult.Text);
            op = '*';

            Txtresult.Clear();
        }

        private void subbotton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Txtresult.Text);
            op = '-';
            Txtresult.Clear();
        }

        private void addbotton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Txtresult.Text);
            op = '+';
            Txtresult.Clear();
        }

        private void equalto_Click(object sender, RoutedEventArgs e)
        {
            second = Int32.Parse(Txtresult.Text);
            int result = 0;
            if (op == '+')
            {
                result = first + second;
            }
            else if (op == '-')
            {
                result = first - second;
            }
            else if (op == '*')
            {
                result = first * second;
            }
            else if (op == '/')
            {
                result = first / second;
            }
            if (Txtresult.Text == "0")
            {
                Txtresult.Clear();
            }
            Txtresult.Text = result.ToString();


        }
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Txtresult.Clear();
        }
    }
}
