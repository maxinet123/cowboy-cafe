/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A interface class for orders
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price for this IOrdeItem
        /// </summary>
        double Price { get; }

        /// <summary>
        /// the special instructions for this IOrderItem
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
