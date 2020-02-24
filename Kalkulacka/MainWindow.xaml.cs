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
using System.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kalkulacka
{
    public partial class MainWindow : Window
    {
        enum Operator { plus, minus, krat, deleno }
        Operator ope;
        double pCislo;
        double dCislo;
        double vysledek;
        double plCislo = 0.0;
        double bnCislo = 0.0;
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
        public static double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Content.ToString() == "+")
            {
                pCislo = Convert.ToDouble(Result.Content) + plCislo;
                Result.Content = "0";
                ope = Operator.plus;
                plCislo = pCislo - bnCislo;
                bnCislo = Convert.ToDouble(Result.Content);
            }
            else if (btn.Content.ToString() == "-")
            {
                pCislo = plCislo - Convert.ToDouble(Result.Content);
                Result.Content = "0";
                ope = Operator.minus;
                plCislo = pCislo - bnCislo;
                bnCislo = Convert.ToDouble(Result.Content);
            }
            else if (btn.Content.ToString() == "*")
            {
                if (plCislo == 0.0)
                {
                    pCislo = Convert.ToDouble(Result.Content);
                    Result.Content = "0";
                    ope = Operator.krat;
                    plCislo = pCislo;
                }
                else
                {
                    pCislo = Convert.ToDouble(Result.Content) * plCislo;
                    Result.Content = "0";
                    ope = Operator.krat;
                    plCislo = pCislo;
                }
                
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
                bnCislo = 0.0;
                plCislo = 0.0;
            }
            else if (ope == Operator.minus)
            {
                dCislo = Convert.ToDouble(Result.Content);
                vysledek = pCislo - dCislo;
                Result.Content = vysledek;
                lbReuslts.Items.Add(pCislo + " - " + dCislo + " = " + vysledek);
                bnCislo = 0.0;
                plCislo = 0.0;
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
                    Result.Content += "-";
                }
                if (e.Key == Key.Add)
                {
                    Result.Content += "+";
                }
                if (e.Key == Key.Divide)
                {
                    Result.Content += "/";
                }
                if (e.Key == Key.Multiply)
                {
                    Result.Content += "*";
                }
                if (e.Key == Key.Enter)
                {
                    lbReuslts.Items.Add(Result.Content + " = " + Evaluate(Result.Content.ToString()));
                    Result.Content = Evaluate(Result.Content.ToString());
                }
                if (e.Key == Key.Escape)
                {
                    Button_Click_1(sender, e);
                }
                if (e.Key == Key.Back)
                {
                    Button_Click_5(sender, e);
                }
            }
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lbReuslts.Items.Clear();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string s = Result.Content.ToString();
            Result.Content = "";
            char[] ci = s.ToCharArray();
            for (int i = 0; i < ci.Length - 1; i++)
            {
                Result.Content += Convert.ToString(ci[i]);
            }
        }
    }
}
