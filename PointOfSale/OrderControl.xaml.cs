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
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddRustlersRibsButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;

        }
        /// <summary>
        /// Button event for adding Cowpoke Chili
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili());
        }
        /// <summary>
        /// Button event for adding Rustlers ribs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }
        /// <summary>
        /// Button event for adding Pecos Pulled Pork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }
        /// <summary>
        /// Button event for adding Trail Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }
        /// <summary>
        /// Button event for adding Dakota Double Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }
        /// <summary>
        /// Button event for adding Texas Triple Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }
        /// <summary>
        /// Button event for adding Angry Chicken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }
        /// <summary>
        /// Button event for adding Chili Cheese Fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }
        /// <summary>
        /// Button event for adding Corn Dodgers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }
        /// <summary>
        /// Button event for adding Pan de Campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }
        /// <summary>
        /// Button event for adding Baked Beans
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }
        /// <summary>
        /// Button event for adding jerked soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }
        /// <summary>
        /// Button event for adding tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }
        /// <summary>
        /// Button event for adding coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }
        /// <summary>
        /// Button event for adding water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }

    }
}
