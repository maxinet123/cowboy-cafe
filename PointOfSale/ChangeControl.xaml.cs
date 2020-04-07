/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class that controls for the ChangeControl screen
*/
using CashRegister;
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
        /// <summary>
        /// Object for the CashRegisterModelView
        /// </summary>
        CashDrawer view = UsersMoneyGivenModelView.drawer;
        /// <summary>
        /// Contructor for the class
        /// </summary>
        /// <param name="change"></param>
        public ChangeControl(double change)
        {
            InitializeComponent();
            string changeBack = FindChange(change);
            ChangeGiven.Text = changeBack;
        }
        private double change = 0;
        /// <summary>
        /// Property to get the change
        /// </summary>
        public double Change => change;
        /// <summary>
        /// Finds the smallest amout of changed needed to be given and removes bill from register
        /// </summary>
        /// <param name="totalOwed"></param>
        /// <returns></returns>
        public string FindChange(double change)
        {
            int give = 0;
            StringBuilder sb = new StringBuilder();
            if (change == 0.00)
            {
                sb.Append("Exact amount given. No Change.");
            }
            else
            {
                give = (int)change / 100;
                if (view.Hundreds > 0 && change > 100)
                {
                    if (give <= view.Hundreds)
                    {
                        sb.Append(give + "x     Hundred Dollar Bill(s)\n");
                        change = change % 100;
                        view.RemoveBill(Bills.Hundred, give);
                    }
                }
                give = (int)change / 50;
                if (view.Fifties > 0 && change > 50)
                {
                    if (give <= view.Fifties)
                    {
                        sb.Append(give + "x     Fifty Dollar Bill(s)\n");
                        change = change % 50;
                        view.RemoveBill(Bills.Fifty, give);
                    }
                }
                give = (int)change / 20;
                if (view.Twenties > 0 && change > 20)
                {
                    if (give <= view.Twenties)
                    {
                        sb.Append(give + "x     Twenty Dollar Bill(s)n");
                        change = change % 20;
                        view.RemoveBill(Bills.Twenty, give);
                    }
                }
                give = (int)change / 10;
                if (view.Tens > 0 && change > 10)
                {
                    if (give <= view.Tens)
                    {
                        sb.Append(give + "x     Ten Dollar Bill(s)\n");
                        change = change % 10;
                        view.RemoveBill(Bills.Ten, give);
                    }
                }
                give = (int)change / 5;
                if (view.Fives > 0 && change > 5)
                {
                    if (give <= view.Fives)
                    {
                        sb.Append(give + "x     Five Dollar Bill(s)\n");
                        change = change % 5;
                        view.RemoveBill(Bills.Five, give);
                    }
                }
                give = (int)change / 2;
                if (view.Twos > 0 && change > 2)
                {
                    if (give <= view.Twos)
                    {
                        sb.Append(give + "x     Two Dollar Bill(s)\n");
                        change = change % 2;
                        view.RemoveBill(Bills.Two, give);
                    }

                }
                give = (int)change / 1;
                if (view.Ones > 0 && change > 1)
                {
                    if (give <= view.Ones)
                    {
                        sb.Append(give + "x     One Dollar Bill(s)\n");
                        change = change % 1;
                        view.RemoveBill(Bills.One, give);
                    }
                }
                give = (int)change / 1;
                if (view.Dollars > 0 && change > 1)
                {
                    if (give <= view.Dollars)
                    {
                        sb.Append(give + "x     One Dollar Coin(s)\n");
                        change = change % 1;
                        view.RemoveCoin(Coins.Dollar, give);
                    }

                }
                give = (int)(change / .5);
                if (view.HalfDollars > 0 && change > 0.5)
                {
                    if (give <= view.HalfDollars)
                    {
                        sb.Append(give + "x     Half Dollar Coin(s)\n");
                        change = change % .5;
                        view.RemoveCoin(Coins.HalfDollar, give);
                    }
                }
                give = (int)(change / .25);
                if (view.Quarters > 0 && change > 0.25)
                {
                    if (give <= view.Quarters)
                    {
                        sb.Append(give + "x     Quarter(s)\n");
                        change = change % .25;
                        view.RemoveCoin(Coins.Quarter, give);
                    }
                }
                give = (int)(change / .10);
                if (view.Dimes > 0 && change > 0.10)
                {
                    if (give <= view.Dimes)
                    {
                        sb.Append(give + "x     Dime(s)\n");
                        change = change % .10;
                        view.RemoveCoin(Coins.Dime, give);
                    }
                }
                give = (int)(change / .05);
                if (view.Nickels > 0 && change > 0.05)
                {
                    if (give <= view.Nickels)
                    {
                        sb.Append(give + "x     Nickel(s)\n");
                        change = change % .05;
                        view.RemoveCoin(Coins.Nickel, give);
                    }
                }
                give = (int)(change / .01);
                if (view.Pennies > 0 && change > 0.01)
                {
                    if (give <= view.Pennies)
                    {
                        sb.Append(give + "x     Penny(s)\n");
                        change = change % .01;
                        view.RemoveCoin(Coins.Penny, give);
                    }
                }

                if (view.Hundreds == 0 && view.Fifties == 0 && view.Twenties == 0 && view.Tens == 0 && view.Fives == 0 && view.Twos == 0 & view.Ones == 0 && view.Dollars == 0 && view.HalfDollars == 0 && view.Quarters == 0 && view.Dimes == 0 && view.Nickels == 0 && view.Pennies == 0)
                {
                    sb.Append("Cannot give change. Please restock register cash amount and restart order.");
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// Allows the employee to enter a new order after one is complete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteClicked(object sender, RoutedEventArgs e)
        {
            var screen = new OrderControl();
            this.Content = screen;
        }
    }
}
