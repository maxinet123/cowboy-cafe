/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class that controls for the CustomizeJerkedSoda.xaml
*/
using CowboyCafe.Data;
using CowboyCafe.Data.Drinks;
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
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        /// <summary>
        /// Initializes components and all the radiobutton event handlers for the xaml
        /// </summary>
        public CustomizeJerkedSoda()
        {
            InitializeComponent();
            DataContextChanged += OnSizeChanged;
            DataContextChanged += OnFlavorChanged;
            SizeSmall.Click += SizeButtonClicked;
            SizeMedium.Click += SizeButtonClicked;
            SizeLarge.Click += SizeButtonClicked;
            BirchBeerFlavor.Click += FlavorButtonClicked;
            CreamSodaFlavor.Click += FlavorButtonClicked;
            OrangeSodaFlavor.Click += FlavorButtonClicked;
            RootBeerFlavor.Click += FlavorButtonClicked;
            SarsparillaFlavor.Click += FlavorButtonClicked;
        }
        /// <summary>
        /// Calls the Size change method to invoke when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSizeChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DrinkSizeChanged();
        }
        /// <summary>
        /// Changes the radio button depending on the enum that the user wants to set the size to.
        /// </summary>
        private void DrinkSizeChanged()
        {
            if (DataContext is Drink drink)
            {
                switch (drink.Size)
                {
                    default:
                    case CowboyCafe.Data.Size.Small:
                        SizeSmall.IsChecked = true;
                        SizeMedium.IsChecked = false;
                        SizeLarge.IsChecked = false;
                        break;
                    case CowboyCafe.Data.Size.Medium:
                        SizeMedium.IsChecked = true;
                        SizeSmall.IsChecked = false;
                        SizeLarge.IsChecked = false;
                        break;
                    case CowboyCafe.Data.Size.Large:
                        SizeLarge.IsChecked = true;
                        SizeSmall.IsChecked = false;
                        SizeMedium.IsChecked = false;
                        break;
                }
            }
        }
        /// <summary>
        /// Manually binds the sizes to the buttons to display elsewhere in the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizeButtonClicked(object sender, EventArgs e)
        {
            if (sender is RadioButton radio)
            {
                if (DataContext is Drink drink)
                {
                    switch (radio.Name)
                    {
                        default:
                        case "SizeSmall":
                            drink.Size = CowboyCafe.Data.Size.Small;
                            DrinkSizeChanged();
                            break;
                        case "SizeMedium":
                            drink.Size = CowboyCafe.Data.Size.Medium;
                            DrinkSizeChanged();
                            break;
                        case "SizeLarge":
                            drink.Size = CowboyCafe.Data.Size.Large;
                            DrinkSizeChanged();
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Calls the Flavor change method to invoke when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFlavorChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DrinkFlavorChanged();
        }
        /// <summary>
        /// Changes the radio button depending on the enum that the user wants to set the flavor to.
        /// </summary>
        private void DrinkFlavorChanged()
        {
            if (DataContext is JerkedSoda soda)
            {
                switch (soda.Flavor)
                {
                    default:
                    case CowboyCafe.Data.SodaFlavor.BirchBeer:
                        BirchBeerFlavor.IsChecked = true;
                        CreamSodaFlavor.IsChecked = false;
                        OrangeSodaFlavor.IsChecked = false;
                        RootBeerFlavor.IsChecked = false;
                        SarsparillaFlavor.IsChecked = false;
                        break;
                    case CowboyCafe.Data.SodaFlavor.CreamSoda:
                        BirchBeerFlavor.IsChecked = false;
                        CreamSodaFlavor.IsChecked = true;
                        OrangeSodaFlavor.IsChecked = false;
                        RootBeerFlavor.IsChecked = false;
                        SarsparillaFlavor.IsChecked = false;
                        break;
                    case CowboyCafe.Data.SodaFlavor.OrangeSoda:
                        BirchBeerFlavor.IsChecked = false;
                        CreamSodaFlavor.IsChecked = false;
                        OrangeSodaFlavor.IsChecked = true;
                        RootBeerFlavor.IsChecked = false;
                        SarsparillaFlavor.IsChecked = false;
                        break;
                    case CowboyCafe.Data.SodaFlavor.RootBeer:
                        BirchBeerFlavor.IsChecked = false;
                        CreamSodaFlavor.IsChecked = false;
                        OrangeSodaFlavor.IsChecked = false;
                        RootBeerFlavor.IsChecked = true;
                        SarsparillaFlavor.IsChecked = false;
                        break;
                    case CowboyCafe.Data.SodaFlavor.Sarsparilla:
                        BirchBeerFlavor.IsChecked = false;
                        CreamSodaFlavor.IsChecked = false;
                        OrangeSodaFlavor.IsChecked = false;
                        RootBeerFlavor.IsChecked = false;
                        SarsparillaFlavor.IsChecked = true;
                        break;
                }
            }
        }
        /// <summary>
        /// Manually binds the flavors to the buttons to display elsewhere in the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlavorButtonClicked(object sender, EventArgs e)
        {
            if (sender is RadioButton radio)
            {
                if (DataContext is JerkedSoda drink)
                {
                    switch (radio.Name)
                    {
                        default:
                        case "BirchBeerFlavor":
                            drink.Flavor = CowboyCafe.Data.SodaFlavor.BirchBeer;
                            DrinkFlavorChanged();
                            break;
                        case "CreamSodaFlavor":
                            drink.Flavor = CowboyCafe.Data.SodaFlavor.CreamSoda;
                            DrinkFlavorChanged();
                            break;
                        case "OrangeSodaFlavor":
                            drink.Flavor = CowboyCafe.Data.SodaFlavor.OrangeSoda;
                            DrinkFlavorChanged();
                            break;
                        case "RootBeerFlavor":
                            drink.Flavor = CowboyCafe.Data.SodaFlavor.RootBeer;
                            DrinkFlavorChanged();
                            break;
                        case "SarsparillaFlavor":
                            drink.Flavor = CowboyCafe.Data.SodaFlavor.Sarsparilla;
                            DrinkFlavorChanged();
                            break;
                    }
                }
            }
        }
    }
}
