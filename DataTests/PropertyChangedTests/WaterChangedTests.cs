/* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class testing if all the properties of water invoke the INotifyPropertyChanged/PropertyChanged
*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class WaterChangedTests
    {
        //Test 1: Water should implement the INotifyPropertyChanged Interface
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        //Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void CanChangeSize()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Small; //Checks if size is able to switch to medium
            });
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Medium; //Checks if size is able to switch to medium

            });
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Large; //Checks if size is able to switch to medium
            });
        }
        //Test 3: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeChangesCalories()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Calories", () =>
            {
                water.Size = Size.Small; //Checks if size is able to switch to small
            });
            Assert.PropertyChanged(water, "Calories", () =>
            {
                water.Size = Size.Medium; //Checks if size is able to switch to medium

            });
            Assert.PropertyChanged(water, "Calories", () =>
            {
                water.Size = Size.Large; //Checks if size is able to switch to large
            });
        }
        //Test 4: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeChangesPrice()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Price", () =>
            {
                water.Size = Size.Small; //Checks if size is able to switch to small
            });
            Assert.PropertyChanged(water, "Price", () =>
            {
                water.Size = Size.Medium; //Checks if size is able to switch to medium

            });
            Assert.PropertyChanged(water, "Price", () =>
            {
                water.Size = Size.Large; //Checks if size is able to switch to large
            });
        }
        //Test 5: Changing the "Lemon" property should invoke PropertyChanged for "Lemon"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = true;
            });
        }
        //Test 6: Changing the "Lemon" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = true;
            });
        }
        //Test 7: Changing the "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });
        }
        //Test 8: Changing the "Lemon" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });
        }
    }
}
