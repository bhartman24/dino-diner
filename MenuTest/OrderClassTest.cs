using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using System.Collections.ObjectModel;

namespace MenuTest
{
    public class OrderClassTest
    {
        class NegativeMockEntree: Entree
        {
            public NegativeMockEntree()
            {
                this.Price = -2.50;
                
            }
            public override string ToString()
            {
                return "Entree";
            }
        }

        class MockEntree: Entree
        {
            public MockEntree()
            {
                this.Price = 15.50;
            }

            public override string ToString()
            {
                return "Entree";
            }
        }

        class MockDrink: Drink
        {
            public MockDrink()
            {
                this.Price = 5.55;
            }
            public override string ToString()
            {
                return "Drink";
            }
        }

        class MockSide: Side
        {
            public MockSide()
            {
                this.Price = 7.77;
            }
            public override string ToString()
            {
                return "Side";
            }
        }

        [Fact]
        public void ShouldNotAllowNegativeSubTotalForNegativeMockEntree()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new NegativeMockEntree());
            o.Items = order;
            Assert.Equal<double>(0, Math.Round(o.SubTotalCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectSubTotalCostForMockDrink()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new MockDrink());
            o.Items = order;
            Assert.Equal<double>(5.55,o.SubTotalCost);
        }

        [Fact]
        public void ShouldHaveCorrectSubTotalCostForMockEntree()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new MockEntree());
            o.Items = order;
            Assert.Equal<double>(15.50, Math.Round(o.SubTotalCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectSubTotalCostForMockSide()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new MockSide());
            o.Items = order;
            Assert.Equal<double>(7.77, Math.Round(o.SubTotalCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectSubTotalCostForAllItems()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new MockDrink());
            order.Add(new MockSide());
            order.Add(new MockEntree());
            o.Items = order;
            Assert.Equal<double>(28.82, o.SubTotalCost);
        }

        [Fact]
        public void TestThatTotalCostCantBeNegative()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new NegativeMockEntree());
            o.Items = order;
            Assert.Equal<double>(0, Math.Round(o.SalesTaxCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectSalesTaxCostForMockDrink()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new MockDrink());
            o.Items = order;
            Assert.Equal<double>(2.78, Math.Round(o.SalesTaxCost,2));
        }

        [Fact]
        public void ShouldHaveCorrectSalesTaxCostForMockEntree()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new MockEntree());
            o.Items = order;
            Assert.Equal<double>(7.75, Math.Round(o.SalesTaxCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectSalesTaxCostForNegativeMockEntree()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new NegativeMockEntree());
            o.Items = order;
            Assert.Equal<double>(0, o.SalesTaxCost);
        }

        [Fact]
        public void ShouldHaveCorrectSalesTaxCostForMockSide()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new MockSide());
            o.Items = order;
            Assert.Equal<double>(3.88, Math.Round(o.SalesTaxCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectTotalCostForMockDrink()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new MockDrink());
            o.Items = order;
            Assert.Equal<double>(8.32, Math.Round(o.TotalCost,2));
        }
        [Fact]
        public void ShouldHaveCorrectTotalCostForMockEntree()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new MockEntree());
            o.Items = order;
            Assert.Equal<double>(23.25, Math.Round(o.TotalCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectTotalCostForNegativeMockEntree()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new NegativeMockEntree());
            o.Items = order;
            Assert.Equal<double>(0, o.TotalCost);
        }

        [Fact]
        public void ShouldHaveCorrectTotalCostForMockSide()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            order.Add(new MockSide());
            o.Items = order;
            Assert.Equal<double>(11.66, Math.Round(o.TotalCost,2));
        }
    }
}
