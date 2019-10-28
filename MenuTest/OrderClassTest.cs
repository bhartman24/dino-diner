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
            Order o = new Order();
            o.Add(new NegativeMockEntree());
            Assert.Equal<double>(0, Math.Round(o.SubTotalCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectSubTotalCostForMockDrink()
        {
            Order o = new Order();
            o.Add(new MockDrink());
            Assert.Equal<double>(5.55,o.SubTotalCost);
        }

        [Fact]
        public void ShouldHaveCorrectSubTotalCostForMockEntree()
        {
            Order o = new Order();
            o.Add(new MockEntree());
            Assert.Equal<double>(15.50, Math.Round(o.SubTotalCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectSubTotalCostForMockSide()
        {
            Order o = new Order();
            o.Add(new MockSide());
            Assert.Equal<double>(7.77, Math.Round(o.SubTotalCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectSubTotalCostForAllItems()
        {
            Order o = new Order();
            o.Add(new MockDrink());
            o.Add(new MockSide());
            o.Add(new MockEntree());
            Assert.Equal<double>(28.82, o.SubTotalCost);
        }

        [Fact]
        public void TestThatTotalCostCantBeNegative()
        {
            Order o = new Order();
            o.Add(new NegativeMockEntree());
            Assert.Equal<double>(0, Math.Round(o.SalesTaxCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectSalesTaxCostForMockDrink()
        {
            Order o = new Order();
            o.Add(new MockDrink());
            Assert.Equal<double>(2.78, Math.Round(o.SalesTaxCost,2));
        }

        [Fact]
        public void ShouldHaveCorrectSalesTaxCostForMockEntree()
        {
            Order o = new Order();
            o.Add(new MockEntree());
            Assert.Equal<double>(7.75, Math.Round(o.SalesTaxCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectSalesTaxCostForNegativeMockEntree()
        {
            Order o = new Order();
            o.Add(new NegativeMockEntree());
            Assert.Equal<double>(0, o.SalesTaxCost);
        }

        [Fact]
        public void ShouldHaveCorrectSalesTaxCostForMockSide()
        {
            Order o = new Order();
            o.Add(new MockSide());
            Assert.Equal<double>(3.88, Math.Round(o.SalesTaxCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectTotalCostForMockDrink()
        {
            Order o = new Order();
            o.Add(new MockDrink());
            Assert.Equal<double>(8.32, Math.Round(o.TotalCost,2));
        }
        [Fact]
        public void ShouldHaveCorrectTotalCostForMockEntree()
        {
            Order o = new Order();
            o.Add(new MockEntree());
            Assert.Equal<double>(23.25, Math.Round(o.TotalCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectTotalCostForNegativeMockEntree()
        {
            Order o = new Order();
            o.Add(new NegativeMockEntree());
            Assert.Equal<double>(0, o.TotalCost);
        }

        [Fact]
        public void ShouldHaveCorrectTotalCostForMockSide()
        {
            Order o = new Order();
            o.Add(new MockSide());
            Assert.Equal<double>(11.66, Math.Round(o.TotalCost,2));
        }
    }
}
