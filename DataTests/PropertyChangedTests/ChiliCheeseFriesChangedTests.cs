/* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class testing if all the properties of chili cheese fries invoke the INotifyPropertyChanged/PropertyChanged
*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using CowboyCafe.Data.Sides;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class ChiliCheeseFriesChangedTests
    {
        //Test 1: Chili Cheese Fries should implement the INotifyPropertyChanged Interface
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var fries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }

        //Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void CanChangeSize()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Small; //Checks if size is able to switch to small
            });
            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Medium; //Checks if size is able to switch to medium

            });
            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Large; //Checks if size is able to switch to large
            });
        }
        //Test 3: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeChangesCalories()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = Size.Small; //Checks if calories is able to switch when size changes to small
            });
            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = Size.Medium; //Checks if calories is able to switch when size changes to medium

            });
            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = Size.Large; //Checks if calories is able to switch when size changes to large
            });
        }
        //Test 4: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeChangesPrice()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = Size.Small; //Checks if price is able to switch when size changes to small
            });
            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = Size.Medium; //Checks if price is able to switch when size changes to medium
            });
            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = Size.Large; //Checks if price is able to switch when size changes to large
            });
        }
    }
}
