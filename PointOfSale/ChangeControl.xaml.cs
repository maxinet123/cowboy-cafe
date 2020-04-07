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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ChangeControl.xaml
    /// </summary>
    public partial class ChangeControl : UserControl
    {
        CashRegisterModelView view = new CashRegisterModelView();
        public ChangeControl(double totalOwed)
        {
            InitializeComponent();
            string changeBack = FindChange(totalOwed);
            ChangeGiven.Text = changeBack;
        }
        private double change = 0;
        public double Change => change;
        public string FindChange(double totalOwed)
        {
            double give = 0;
            StringBuilder sb = new StringBuilder();
            change = view.TotalValue - view.TotalOwed;
            give = (int) change / 100;
            if (view.Hundreds > 0)
            {
                sb.Append(give + "x     Hundred Dollar Bill(s)\n");
                change = change % 100;
            }
            give = (int)change / 50;
            if (view.Fifties > 0)
            {
                sb.Append(give + "x     Fifty Dollar Bill(s)\n");
                change = change % 50;
            }
            give = (int)change / 20;
            if (view.Twenties > 0)
            {
                sb.Append(give + "x     Twenty Dollar Bill(s)n");
                change = change % 20;
            }
            give = (int)change / 10;
            if (view.Tens > 0)
            {
                sb.Append(give + "x     Ten Dollar Bill(s)\n");
                change = change % 10;
            }
            give = (int)change / 5;
            if (view.Fives > 0)
            {
                sb.Append(give + "x     Five Dollar Bill(s)\n");
                change = change % 5;
            }
            give = (int)change / 2;
            if (view.Twos > 0)
            {
                sb.Append(give + "x     Two Dollar Bill(s)\n");
                change = change % 2;
            }
            give = (int)change / 1;
            if (view.Ones > 0)
            {
                sb.Append(give + "x     One Dollar Bill(s)\n");
                change = change % 1;
            }
            give = (int)change / 1;
            if (view.Dollar > 0)
            {
                sb.Append(give + "x     One Dollar Coin(s)\n");
                change = change % 1;
            }
            give = (int)change / .5;
            if (view.HalfDollars > 0)
            {
                sb.Append(give + "x     Half Dollar Coin(s)\n");
                change = change % .5;
            }
            give = (int)change / .25;
            if (view.Quarters > 0)
            {
                sb.Append(give + "x     Quarter(s)\n");
                change = change % .25;
            }
            give = (int)change / .10;
            if (view.Dimes > 0)
            {
                sb.Append(give + "x     Dime(s)\n");
                change = change % 105;
            }
            give = (int)change / .05;
            if (view.Nickels > 0)
            {
                sb.Append(give + "x     Nickel(s)\n");
                change = change % .05;
            }
            give = (int)change / .01;
            if (view.Pennies > 0)
            {
                sb.Append(give + "x     Penny(s)\n");
                change = change % .01;
            }
            return sb.ToString();
        }
        void OnCompleteClicked(object sender, RoutedEventArgs e)
        {
            var screen = new OrderControl();
            this.Content = screen;
        }
    }
}
