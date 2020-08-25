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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 =0;
        long number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Ccclick(string btnContent)
        {
            var num = int.Parse(btnContent);
            if (operation == "")
            {
                number1 = (number1 * 10) + num;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + num;
                txtDisplay.Text = number2.ToString();
            }
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;            
            Ccclick(btn.Content.ToString());
        }
      
        private void btnOperation_Click(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;
            txtDisplay.Text = "0";
            operation = b.Content.ToString();
        }          

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (number1 + number2).ToString();
                    break;
                case "-":   
                    txtDisplay.Text = (number1 - number2).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (number1 / number2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (number1 * number2).ToString();
                    break;
            }
            number1 = 0;
            number2 = 0;
            operation = "";
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            txtDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDisplay.Text = "0";
        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 / 10;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 / 10;
                txtDisplay.Text = number2.ToString();  
            }
        }

        private void btnQuadro_Click(object sender, RoutedEventArgs e)
        {
            number1 *= number1;
            txtDisplay.Text = number1.ToString();
            
        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            number1 /= 100;
            txtDisplay.Text = number1.ToString();
            number1 = 0;
        }

        /*На данынй момент изучаю MVVM и хочу переделать калькулятор под этот шаблон*/
    }
}
