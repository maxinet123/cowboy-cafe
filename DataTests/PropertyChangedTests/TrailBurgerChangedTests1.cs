/* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class testing if all the properties of Trail Burger invoke the INotifyPropertyChanged/PropertyChanged
*/
using System;
using System.Collections.Generic;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TrailBurgerChangedTests
    {
        //Test 1: Trail Burger should implement the INotifyPropertyChanged Interface
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var trail = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(trail);
        }
        //Test 2: Changing the "Cheese" property should invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Cheese", () =>
            {
                trail.Cheese = false;
            });
        }
        //Test 3: Changing the "Cheese" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Cheese = false;
            });
        }
        //Test 4: Changing the "Bun" property should invoke PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Bun", () =>
            {
                trail.Bun = false;
            });
        }
        //Test 5: Changing the "Bun" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Bun = false;
            });
        }
        //Test 6: Changing the "GreenOnions" property should invoke PropertyChanged for "GreenOnions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Ketchup", () =>
            {
                trail.Ketchup = false;
            });
        }
        //Test 7: Changing the "Ketchup" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Ketchup = false;
            });
        }
        //Test 8: Changing the "Mustard" property should invoke PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Mustard", () =>
            {
                trail.Mustard = false;
            });
        }
        //Test 9: Changing the "Mustard" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Mustard = false;
            });
        }
        //Test 10: Changing the "Pickle" property should invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Pickle", () =>
            {
                trail.Pickle = false;
            });
        }
        //Test 11: Changing the "Pickle" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Pickle = false;
            });
        }
    }
}
