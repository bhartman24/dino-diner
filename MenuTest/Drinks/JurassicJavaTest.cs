using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        //The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(.59, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.SpaceForCream);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<double>(.59, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        //That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldHaveCorrectAddIceResult()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        //That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.

        [Fact]
        public void ShouldHaveCorrectLeaveSpaceForCreamResult()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.SpaceForCream);
        }

        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            List<string> ingredients = java.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
        }

        [Fact]
        public void AddIceShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.AddIce();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }

        [Fact]
        public void SpecialShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void SpecialShouldLeaveSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Leave Space for Cream", item);
            });
        }

        [Fact]
        public void SpecialShouldAddIceAndLeaveSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            java.AddIce();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Leave Space for Cream", item);
            },
            item =>
            {
                Assert.Equal("Add Ice", item);
            }
            );
        }

        [Fact]
        public void ShouldHaveCorrectDescriptionMethod()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal($"{java.Size} Jurassic Java", java.Description);
        }

        [Fact]
        public void ShouldHaveCorrectDescriptionMethodForDecaf()
        {
            JurassicJava java = new JurassicJava();
            java.Decaf = true;
            Assert.Equal($"{java.Size} Decaf Jurassic Java", java.Description);
        }
    }
}
