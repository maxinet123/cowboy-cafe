/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class to keep track fo specific orders
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

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
        static private uint lastOrderNumber = 0;

        /// <summary>
        /// Gets the lastOrderNumber and increments it for the next order 
        /// </summary>
        public uint OrderNumber => lastOrderNumber;

        /// <summary>
        /// List of items from the class of IOrderItems which is Price and SpecialInstructions
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Allows for the list of items to be found and displayed elsewhere when it is called
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// Increments 
        /// </summary>
        public Order()
        {
            lastOrderNumber++;
        }
        /// <summary>
        /// Finds the total of the order plus tax
        /// </summary>
        public double Total
        {
            get
            {
                double tax = 0.16;
                return Subtotal + (Subtotal * tax);
            }
        }

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
        /// Prints order information to a receipt
        /// </summary>
        /// <param name="success"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <returns></returns>
        public string Receipt(bool cash, double money, double owed)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order " + OrderNumber.ToString() + "\n");
            sb.Append(DateTime.Now.ToString() + "\n\n");
            foreach (IOrderItem item in Items)
            {
                sb.Append(item.ToString() + "     " + "$" + String.Format("{0:0.00}", item.Price) + "\n");
                foreach (String instruction in item.SpecialInstructions)
                {
                    sb.Append("     " + instruction.ToString() + "\n");
                }
            }
            sb.Append("\nSubtotal                           $" + String.Format("{0:0.00}", Subtotal));
            double tax = 0.16;
            sb.Append("\nTax                                $" + String.Format("{0:0.00}", Subtotal*tax));
            sb.Append("\nTotal                              $" + String.Format("{0:0.00}", Total));
            if (cash)
            {
                sb.Append("\nCASH                               $" + String.Format("{0:0.00}", money) + "\n");
                sb.Append("Change                             $" + String.Format("{0:0.00}", money - owed) + "\n");
            }
            else
            {
                sb.Append("\nCredit                             $" + String.Format("{0:0.00}", Total) + "\n");
            }

            sb.Append("\n------------------------------------------\n\n");
            return sb.ToString();
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

        /// <summary>
        /// Invokes the property change for the items and subtotal
        /// </summary>
        /// <param name="propertyName"></param>
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
