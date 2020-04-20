/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the OrderSummaryControl.xaml
*/
using CowboyCafe.Data;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Sides;
using CowboyCafe.Extension;
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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// Intializes all components of the xaml
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Event handler for the remove button
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">the routed event args</param>
        public void OnRemoveButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    if (button.DataContext is IOrderItem item) 
                    {
                        order.Remove(item);
                    }
                }
            }
        }
        /// <summary>
        /// Event handler to switch the screen to the customization when item in the order is clicked
        /// </summary>
        /// <param name="sender">the item clicked</param>
        /// <param name="e">the selection changed event args</param>
        public void OnMainBoxChangeItem(object sender, SelectionChangedEventArgs e)
        {
            FrameworkElement screen = null;
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is ListBox listbox)
                {
                    if (listbox.SelectedItem is IOrderItem item)
                    {
                        if (item is CowpokeChili)
                        {
                            screen = new CustomizeCowpokeChili();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is PecosPulledPork)
                        {
                            screen = new CustomizePecosPulledPork();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is TrailBurger)
                        {
                            screen = new CustomizeTrailBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is DakotaDoubleBurger)
                        {
                            screen = new CustomizeDakotaDoubleBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is TexasTripleBurger)
                        {
                            screen = new CustomizeTexasTripleBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is AngryChicken)
                        {
                            screen = new CustomizeAngryChicken();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is ChiliCheeseFries)
                        {
                            screen = new CustomizeChiliCheeseFries();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is CornDodgers)
                        {
                            screen = new CustomizeCornDodgers();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is PanDeCampo)
                        {
                            screen = new CustomizePanDeCampo();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is BakedBeans)
                        {
                            screen = new CustomizeBakedBeans();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is JerkedSoda)
                        {
                            screen = new CustomizeJerkedSoda();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is TexasTea)
                        {
                            screen = new CustomizeTexasTea();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is CowboyCoffee)
                        {
                            screen = new CustomizeCowboyCoffee();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is Water)
                        {
                            screen = new CustomizeWater();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                    }
                }
            }
        }
    }
}
