using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent a new customer order.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for when an order property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// backing variable for the Items.
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Property that represents the items added to order.
        /// </summary>
        public IOrderItem[] Items { get { return items.ToArray(); } }

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
        /// backing variable for the SalesTaxRate.
        /// </summary>
        private double salesTaxRate = 0.5;

        /// <summary>
        /// Property that returns the Tax rate or sets it.
        /// </summary>
        public double SalesTaxRate
        {
            get { return salesTaxRate; }
            set
            {
                if (value < 0) return;
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesRateTax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

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

        /// <summary>
        /// Creates a new order instance.
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }

        /// <summary>
        /// Event handler for the OnCollectionChagned event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void NotifyAllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        /// <summary>
        /// Method to add an item.
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertiesChanged();
        }

        /// <summary>
        /// Event handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertiesChanged();
        }

        /// <summary>
        /// Method to remove an item.
        /// </summary>
        /// <param name="item"></param>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertiesChanged();
            }
            return removed;
        }
    }
}
