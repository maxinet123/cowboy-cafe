/* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class testing if all the properties of jerked soda invoke the INotifyPropertyChanged/PropertyChanged
*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaChangedTests
    {
        //Test 1: Jerked Soda should implement the INotifyPropertyChanged Interface
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }
        //Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void CanChangeSize()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Small; //Checks if size is able to switch to small
            });
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Medium; //Checks if size is able to switch to medium

            });
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Large; //Checks if size is able to switch to large
            });
        }
        //Test 3: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeChangesCalories()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Small; //Checks if calories is able to switch when size changes to small
            });
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Medium; //Checks if calories is able to switch when size changes to medium

            });
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Large; //Checks if calories is able to switch when size changes to large
            });
        }
        //Test 4: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeChangesPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Small; //Checks if price is able to switch when size changes to small
            });
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Medium; //Checks if price is able to switch when size changes to medium
            });
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Large; //Checks if price is able to switch when size changes to large
            });
        }
        //Test 5: Changing the "Flavor" property should invoke PropertyChanged for "Flavor"
        [Fact]
        public void CanChangeFlavor()
        {
            var flavor = new JerkedSoda();
            Assert.PropertyChanged(flavor, "Flavor", () =>
            {
                flavor.Flavor = SodaFlavor.BirchBeer; //Checks if flavor is able to switch to birchbeer
            });
            Assert.PropertyChanged(flavor, "Flavor", () =>
            {
                flavor.Flavor = SodaFlavor.CreamSoda; //Checks if flavor is able to switch to CreamSoda
            });
            Assert.PropertyChanged(flavor, "Flavor", () =>
            {
                flavor.Flavor = SodaFlavor.OrangeSoda; //Checks if flavor is able to switch to OrangeSoda
            });
            Assert.PropertyChanged(flavor, "Flavor", () =>
            {
                flavor.Flavor = SodaFlavor.RootBeer; //Checks if flavor is able to switch to RootBeer
            });
            Assert.PropertyChanged(flavor, "Flavor", () =>
            {
                flavor.Flavor = SodaFlavor.Sarsparilla; //Checks if flavor is able to switch to Sarsparilla
            });
        }
        //Test 6: Changing the "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;
            });
        }
        //Test 7: Changing the "Ice" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;
            });
        }
    }
}
