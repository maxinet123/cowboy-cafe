/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class to keep track fo specific orders
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing an Order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Property that is triggered when something has changed and updates everything
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Starts the OrderNumber at 1
        /// </summary>
        static private uint lastOrderNumber = 1;
        /// <summary>
        /// Gets the lastOrderNumber and increments it for the next order 
        /// </summary>
        public uint OrderNumber => lastOrderNumber++;
        /// <summary>
        /// List of items from the class of IOrderItems which is Price and SpecialInstructions
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// Allows for the list of items to be found and displayed elsewhere when it is called
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();
        /// <summary>
        /// Keeps track of the subtotal for the order and increases everytime an item is added to the list
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }
        /// <summary>
        /// Prints "Order " with the number that pertains to the order at the top of the ordersummary xaml
        /// </summary>
        public string OrderNumberString => "Order " + OrderNumber.ToString();
        /// <summary>
        /// Adds items to the list and notifies properties that need to update
        /// </summary>
        /// <param name="item">List of IOrderItem</param>
        public void Add(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnPropertyItemChanged;

            }
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));


        }
        /// <summary>
        /// Removes items from the list and notifies properties that need to update
        /// </summary>
        /// <param name="item">List of IOrderItem</param>
        public void Remove(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnPropertyItemChanged;

            }
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        private void OnPropertyItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

    }
}
