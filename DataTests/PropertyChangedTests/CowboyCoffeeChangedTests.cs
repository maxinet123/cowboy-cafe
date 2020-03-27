/* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class testing if all the properties of cowboy coffee invoke the INotifyPropertyChanged/PropertyChanged
*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowboyCoffeeChangedTests
    {
        //Test 1: Cowboy Coffee should implement the INotifyPropertyChanged Interface
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }

        //Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void CanChangeSize()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Small; //Checks if size is able to switch to small
            });
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Medium; //Checks if size is able to switch to medium

            });
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Large; //Checks if size is able to switch to large
            });
        }
        //Test 3: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeChangesCalories()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Small; //Checks if calories is able to switch when size changes to small
            });
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Medium; //Checks if calories is able to switch when size changes to medium

            });
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Large; //Checks if calories is able to switch when size changes to large
            });
        }
        //Test 4: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeChangesPrice()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Small; //Checks if price is able to switch when size changes to small
            });
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Medium; //Checks if price is able to switch when size changes to medium
            });
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Large; //Checks if price is able to switch when size changes to large
            });
        }
        //Test 5: Changing the "RoomForCream" property should invoke PropertyChanged for "RoomForCream"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForRoomForCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = true;
            });
        }
        //Test 6: Changing the "RoomForCream" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.RoomForCream = true;
            });
        }
        //Test 7: Changing the "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () =>
            {
                coffee.Ice = true;
            });
        }
        //Test 8: Changing the "Ice" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Ice = true;
            });
        }
        //Test 5: Changing the "Decaf" property should invoke PropertyChanged for "Decaf"
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSweet()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = true;
            });
        }
        //Test 6: Changing the "Decaf" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Decaf = true;
            });
        }
    }
}
