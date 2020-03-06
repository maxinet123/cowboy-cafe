/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the buttons for the MenuItemSelectionControl xaml
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
        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            order.Add(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "RustlersRibs":
                            order.Add(new RustlersRibs());
                            orderControl.SwapScreen(new CustomizeRustlersRibs());
                            break;
                        case "PecosPulledPork":
                            order.Add(new PecosPulledPork());
                            orderControl.SwapScreen(new CustomizePecosPulledPork());
                            break;
                        case "TrailBurger":
                            order.Add(new TrailBurger());
                            orderControl.SwapScreen(new CustomizeTrailBurger());
                            break;
                        case "DakotaDouble":
                            order.Add(new DakotaDoubleBurger());
                            orderControl.SwapScreen(new CustomizeDakotaDoubleBurger());
                            break;
                        case "TexasTriple":
                            order.Add(new TexasTripleBurger());
                            orderControl.SwapScreen(new CustomizeTexasTripleBurger());
                            break;
                        case "AngryChicken":
                            order.Add(new AngryChicken());
                            orderControl.SwapScreen(new CustomizeAngryChicken());
                            break;
                        case "ChiliCheeseFries":
                            order.Add(new ChiliCheeseFries());
                            orderControl.SwapScreen(new CustomizeChiliCheeseFries());
                            break;
                        case "CornDodgers":
                            order.Add(new CornDodgers());
                            orderControl.SwapScreen(new CustomizeCornDodgers());
                            break;
                        case "PanDeCampo":
                            order.Add(new PanDeCampo());
                            orderControl.SwapScreen(new CustomizePanDeCampo());
                            break;
                        case "BakedBeans":
                            order.Add(new BakedBeans());
                            orderControl.SwapScreen(new CustomizeBakedBeans());
                            break;
                        case "JerkedSoda":
                            order.Add(new JerkedSoda());
                            orderControl.SwapScreen(new CustomizeJerkedSoda());
                            break;
                        case "TexasTea":
                            order.Add(new TexasTea());
                            orderControl.SwapScreen(new CustomizeTexasTea());
                            break;
                        case "CowboyCoffee":
                            order.Add(new CowboyCoffee());
                            orderControl.SwapScreen(new CustomizeCowboyCoffee());
                            break;
                        case "Water":
                            order.Add(new Water());
                            orderControl.SwapScreen(new CustomizeWater());
                            break;
                        default:

                            break;
                    }
                }
            }

        }
    }
}
        