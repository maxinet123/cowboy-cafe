using CowboyCafe.Data;
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
    /// Interaction logic for CustomizePanDeCampo.xaml
    /// </summary>
    public partial class CustomizePanDeCampo : UserControl
    {
        public CustomizePanDeCampo()
        {
            InitializeComponent();
            SizeSmall.Click += SizeButtonClicked;
            SizeMedium.Click += SizeButtonClicked;
            SizeLarge.Click += SizeButtonClicked;
        }
        /// <summary>
        /// Calls the Size change method to invoke when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSizeChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            SideSizeChanged();
        }
        /// <summary>
        /// Changes the radio button depending on the enum that the user wants to set the size to.
        /// </summary>
        private void SideSizeChanged()
        {
            if (DataContext is Side side)
            {
                switch (side.Size)
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
            if (sender is Button button)
            {
                if (DataContext is Side side)
                {
                    switch (button.Name)
                    {
                        default:
                        case "SizeSmall":
                            side.Size = CowboyCafe.Data.Size.Small;
                            SideSizeChanged();
                            break;
                        case "SizeMedium":
                            side.Size = CowboyCafe.Data.Size.Medium;
                            SideSizeChanged();
                            break;
                        case "SizeLarge":
                            side.Size = CowboyCafe.Data.Size.Large;
                            SideSizeChanged();
                            break;
                    }
                }
            }
        }
    }
}
