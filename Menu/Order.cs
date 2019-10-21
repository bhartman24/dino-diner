using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent a new customer order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Property that represents the items added to order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

        /// <summary>
        /// Property that calculates the total price from the prices of all order items.
        /// </summary>
        public double SubTotalCost
        {
            get
            {
                double subTotal = 0;
                foreach(IOrderItem i in Items)
                {
                    subTotal += i.Price;
                }
                if (subTotal > 0) return subTotal;
                else return 0;
            }
        }

        /// <summary>
        /// Property that returns the Tax rate or sets it.
        /// </summary>
        public double SalesTaxRate { get; protected set; } = 0.50;

        /// <summary>
        /// property that returns the product of the SalesTaxRate and SubTotalCost
        /// </summary>
        public double SalesTaxCost { get => SalesTaxRate * SubTotalCost; }

        /// <summary>
        /// Property that returns the sum of SubTotalCost and SalesTaxCost
        /// </summary>
        public double TotalCost {
            get
            {
                return SubTotalCost + SalesTaxCost;
            }
        }
    }
}
