using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale
{
    public interface IOrderItem
    {
        public double Price { get; }

        public IEnumerable<string> SpecialInstructions { get; }
    }
}
