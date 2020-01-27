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

namespace Kalkulacka
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum Operator{plus, minus, krat, deleno }
        Operator ope;
        double pCislo;
        double dCislo;
        double vysledek;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (Result.Content.ToString() == "0")
            {
                Result.Content = "";
                Result.Content = btn.Content;
            }
            else
            {
                Result.Content = Result.Content + "" + btn.Content;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Result.Content = "0";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Content.ToString() == "+")
            {
                pCislo = Convert.ToDouble(Result.Content);
                Result.Content = "0";
                ope = Operator.plus;
            }
            else if (btn.Content.ToString() == "-")
            {
                pCislo = Convert.ToDouble(Result.Content);
                Result.Content = "0";
                ope = Operator.minus;
            }
            else if (btn.Content.ToString() == "*")
            {
                pCislo = Convert.ToDouble(Result.Content);
                Result.Content = "0";
                ope = Operator.krat;
            }
            else if (btn.Content.ToString() == "/")
            {
                pCislo = Convert.ToDouble(Result.Content);
                Result.Content = "0";
                ope = Operator.deleno;
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ope == Operator.plus)
            {
                dCislo = Convert.ToDouble(Result.Content);
                vysledek = pCislo + dCislo;
                Result.Content = vysledek;
            }
            else if (ope == Operator.minus)
            {
                dCislo = Convert.ToDouble(Result.Content);
                vysledek = pCislo - dCislo;
                Result.Content = vysledek;
            }
            else if (ope == Operator.krat)
            {
                dCislo = Convert.ToDouble(Result.Content);
                vysledek = pCislo * dCislo;
                Result.Content = vysledek;
            }
            else if (ope == Operator.deleno)
            {
                dCislo = Convert.ToDouble(Result.Content);
                vysledek = pCislo / dCislo;
                Result.Content = vysledek;
            }

        }
    }
}
