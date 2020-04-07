/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class that controls for the Transaction controls
*/
using CashRegister;
using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        /// <summary>
        /// Cardterminal object
        /// </summary>
        public CardTerminal cardterminal = new CardTerminal();
        /// <summary>
        /// ReceiptPrinter object
        /// </summary>
        public ReceiptPrinter receiptprinter = new ReceiptPrinter();
        /// <summary>
        /// Initializes all components for the class
        /// </summary>
        public TransactionControl()
        {
            InitializeComponent();
        }
        private double total = 0;
        /// <summary>
        /// Finds the total of the order plus tax
        /// </summary>
        public double Total
        {
            get
            {
                if (DataContext is Order order)
                {
                    double tax = 0.16;
                    total = order.Subtotal + (order.Subtotal * tax);
                    return Math.Round(total, 2);
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// Button event for Cancelling an order. Sets DataContext to a new instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            var screen = new OrderControl();
            this.Content = screen;
        }
        /// <summary>
        /// Button event swaps back to the MenuItemSelectionControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPayWithCashClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var screen = new CashRegisterControl(order);
                screen.DataContext = new UsersMoneyGivenModelView();
                this.Content = screen;
            }
        }
        /// <summary>
        /// Button event swaps back to the MenuItemSelectionControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPayWithCardClicked(object sender, RoutedEventArgs e)
        {
            FrameworkElement screen = null;
            if (DataContext is Order order)
            {
                switch (cardterminal.ProcessTransaction(order.Total))
                {
                    case ResultCode.Success:
                        receiptprinter.Print(order.Receipt(false, 0, 0));
                        screen = new OrderControl();
                        this.Content = screen;
                        break;
                    case ResultCode.InsufficentFunds:
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    case ResultCode.CancelledCard:
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    case ResultCode.ReadError:
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    default:
                    case ResultCode.UnknownErrror:
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                }
            }
        }
    }
}
