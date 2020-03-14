/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the buttons for the MenuItemSelectionControl.xaml
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
using CowboyCafe.Extension;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// Initializes components and all the button event handlers for the xaml
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            AddCowpokeChiliButton.Click += OnItemAddButtonClicked;
            AddRustlersRibsButton.Click += OnItemAddButtonClicked;
            AddPecosPulledPorkButton.Click += OnItemAddButtonClicked;
            AddTrailBurgerButton.Click += OnItemAddButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnItemAddButtonClicked;
            AddTexasTripleBurgerButton.Click += OnItemAddButtonClicked;
            AddAngryChickenButton.Click += OnItemAddButtonClicked;
            AddChiliCheeseFriesButton.Click += OnItemAddButtonClicked;
            AddCornDodgersButton.Click += OnItemAddButtonClicked;
            AddPanDeCampoButton.Click += OnItemAddButtonClicked;
            AddBakedBeansButton.Click += OnItemAddButtonClicked;
            AddJerkedSodaButton.Click += OnItemAddButtonClicked;
            AddTexasTeaButton.Click += OnItemAddButtonClicked;
            AddCowboyCoffeeButton.Click += OnItemAddButtonClicked;
            AddWaterButton.Click += OnItemAddButtonClicked;
        }
        /// <summary>
        /// Button handler that calls the helper method depending on the item selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            IOrderItem item = null;
            FrameworkElement screen = null;
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            item = new CowpokeChili();
                            screen = new CustomizeCowpokeChili();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "RustlersRibs":
                            item = new RustlersRibs();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "PecosPulledPork":
                            item = new PecosPulledPork();
                            screen = new CustomizePecosPulledPork();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "TrailBurger":
                            item = new TrailBurger();
                            screen = new CustomizeTrailBurger();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "DakotaDouble":
                            item = new DakotaDoubleBurger();
                            screen = new CustomizeDakotaDoubleBurger();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "TexasTriple":
                            item = new TexasTripleBurger();
                            screen = new CustomizeTexasTripleBurger();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "AngryChicken":
                            item = new AngryChicken();
                            screen = new CustomizeAngryChicken();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "ChiliCheeseFries":
                            item = new ChiliCheeseFries();
                            screen = new CustomizeChiliCheeseFries();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "CornDodgers":
                            item = new CornDodgers();
                            screen = new CustomizeCornDodgers();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "PanDeCampo":
                            item = new PanDeCampo();
                            screen = new CustomizePanDeCampo();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "BakedBeans":
                            item = new BakedBeans();
                            screen = new CustomizeBakedBeans();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "JerkedSoda":
                            item = new JerkedSoda();
                            screen = new CustomizeJerkedSoda();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "TexasTea":
                            item = new TexasTea();
                            screen = new CustomizeTexasTea();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "CowboyCoffee":
                            item = new CowboyCoffee();
                            screen = new CustomizeCowboyCoffee();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "Water":
                            item = new Water();
                            screen = new CustomizeWater();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        default:
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                    }
                }
            }

        }
        /// <summary>
        /// Helper method that sets the order and switches screens to the customizations
        /// </summary>
        /// <param name="item"></param>
        /// <param name="screen"></param>
        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null)
            {
                throw new Exception("DataContext expected tp be an Order instance.");
            }

            if (screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) 
                { 
                    throw new Exception("An ancestor of OrderControl not found."); 
                }
                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
            order.Add(item);
        }
    }
}
        