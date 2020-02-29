﻿using System;
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
        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
        }
        void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
        }
        void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
        }
    }
}
