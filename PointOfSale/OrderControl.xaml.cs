/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the buttons for the OrderControl.xaml
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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Constructor for OrderControl and holds the button instances
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            var order = new Order();
            this.DataContext = order;
            OnCancelOrderButton.Click += OnCancelOrderButtonClicked;
            OnCompleteOrderButton.Click += OnCompleteOrderButtonClicked;
            OnItemSelectionButton.Click += OnItemSelectionButtonClicked;

        }
        /// <summary>
        /// Button event for Cancelling an order. Sets DataContext to a new instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
        /// <summary>
        /// Button event for completeing an order. Sets DataContext to a new instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            var screen = new TransactionControl();
            if (DataContext is Order order)
            {
                screen.DataContext = order;
                this.Content = screen;
            }
        }
        /// <summary>
        /// Button event swaps back to the MenuItemSelectionControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }
        /// <summary>
        /// Swaps screens into customizations
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }
    }
}
