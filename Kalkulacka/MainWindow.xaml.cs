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
        enum Operator { plus, minus, krat, deleno }
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
            pCislo = 0;
            dCislo = 0;
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
                lbReuslts.Items.Add(pCislo + " + " + dCislo + " = " + vysledek); 
            }
            else if (ope == Operator.minus)
            {
                dCislo = Convert.ToDouble(Result.Content);
                vysledek = pCislo - dCislo;
                Result.Content = vysledek;
                lbReuslts.Items.Add(pCislo + " - " + dCislo + " = " + vysledek);
            }
            else if (ope == Operator.krat)
            {
                dCislo = Convert.ToDouble(Result.Content);
                vysledek = pCislo * dCislo;
                Result.Content = vysledek;
                lbReuslts.Items.Add(pCislo + " * " + dCislo + " = " + vysledek);
            }
            else if (ope == Operator.deleno)
            {
                dCislo = Convert.ToDouble(Result.Content);
                vysledek = pCislo / dCislo;
                Result.Content = vysledek;
                lbReuslts.Items.Add(pCislo + " / " + dCislo + " = " + vysledek);
            }

        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (Result.Content.ToString() == "0")
            {
                if (e.Key == Key.NumPad0) Result.Content = "0";
                if (e.Key == Key.NumPad1) Result.Content = "1";
                if (e.Key == Key.NumPad2) Result.Content = "2";
                if (e.Key == Key.NumPad3) Result.Content = "3";
                if (e.Key == Key.NumPad4) Result.Content = "4";
                if (e.Key == Key.NumPad5) Result.Content = "5";
                if (e.Key == Key.NumPad6) Result.Content = "6";
                if (e.Key == Key.NumPad7) Result.Content = "7";
                if (e.Key == Key.NumPad8) Result.Content = "8";
                if (e.Key == Key.NumPad9) Result.Content = "9";
            }
            else
            {
                if (e.Key == Key.NumPad0) Result.Content = Result.Content + "0";
                if (e.Key == Key.NumPad1) Result.Content = Result.Content + "1";
                if (e.Key == Key.NumPad2) Result.Content = Result.Content + "2";
                if (e.Key == Key.NumPad3) Result.Content = Result.Content + "3";
                if (e.Key == Key.NumPad4) Result.Content = Result.Content + "4";
                if (e.Key == Key.NumPad5) Result.Content = Result.Content + "5";
                if (e.Key == Key.NumPad6) Result.Content = Result.Content + "6";
                if (e.Key == Key.NumPad7) Result.Content = Result.Content + "7";
                if (e.Key == Key.NumPad8) Result.Content = Result.Content + "8";
                if (e.Key == Key.NumPad9) Result.Content = Result.Content + "9";
                if (e.Key == Key.Decimal) Result.Content = Result.Content + ",";
                if (e.Key == Key.Subtract)
                {
                    pCislo = Convert.ToDouble(Result.Content);
                    Result.Content = "0";
                    ope = Operator.minus;
                }
                if (e.Key == Key.Add)
                {
                    pCislo = Convert.ToDouble(Result.Content);
                    Result.Content = "0";
                    ope = Operator.plus;
                }
                if (e.Key == Key.Divide)
                {
                    pCislo = Convert.ToDouble(Result.Content);
                    Result.Content = "0";
                    ope = Operator.deleno;
                }
                if (e.Key == Key.Multiply)
                {
                    pCislo = Convert.ToDouble(Result.Content);
                    Result.Content = "0";
                    ope = Operator.krat;
                }
                if (e.Key == Key.Enter)
                {
                    Button_Click_3(sender, e);
                }
                if (e.Key == Key.Escape)
                {
                    pCislo = 0;
                    dCislo = 0;
                    Result.Content = "0";
                }
            }
            
        }
    }
}
