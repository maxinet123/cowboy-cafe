/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class that controls for the CashRegister on the frontend
*/
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
using CashRegister;
using CowboyCafe;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        public ReceiptPrinter receiptprinter = new ReceiptPrinter();
        
        private Order order;
        public CashRegisterControl(Order order)
        {
            InitializeComponent();
            this.DataContext = new UsersMoneyGivenModelView();
            this.order = order;
        }
        ///
        /// <summary>
        /// Button event for Cancelling an order. Sets DataContext to a new instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            var screen = new TransactionControl();
            this.Content = screen;
        }
        /// <summary>
        /// Button event for Cancelling an order. Sets DataContext to a new instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is UsersMoneyGivenModelView view)
            {
                view.TotalOwed = order.Total;
                receiptprinter.Print(order.Receipt(true, view.TotalValue, view.TotalOwed));
                double change = Math.Round(view.TotalValue - view.TotalOwed, 2);
                var screen = new ChangeControl(change);
                this.Content = screen;
            }
        }
       
    }
}
