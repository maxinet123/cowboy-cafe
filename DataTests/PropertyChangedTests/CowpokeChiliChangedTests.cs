/* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class testing if all the properties of cowpoke chili invoke the INotifyPropertyChanged/PropertyChanged
*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data.Entrees;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowpokeChiliChangedTests
    {
        //Test 1: Cowpoke Chili should implement the INotifyPropertyChanged Interface
        [Fact]
        public void CowpokeChiliShouldImplementINotifyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }
        //Test 2: Changing the "Cheese" property should invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () =>
            {
                chili.Cheese = false;
            });
        }
        //Test 3: Changing the "Cheese" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.Cheese = false;
            });
        }
        //Test 4: Changing the "SourCream" property should invoke PropertyChanged for "SourCream"
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSourCream()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () =>
            {
                chili.SourCream = false;
            });
        }
        //Test 5: Changing the "SourCream" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.SourCream = false;
            });
        }
        //Test 6: Changing the "GreenOnions" property should invoke PropertyChanged for "GreenOnions"
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForGreenOnions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () =>
            {
                chili.GreenOnions = false;
            });
        }
        //Test 7: Changing the "GreenOnions" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.GreenOnions = false;
            });
        }
        //Test 8: Changing the "TortillaStrips" property should invoke PropertyChanged for "TortillaStrips"
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForTortillaStrips()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "TortillaStrips", () =>
            {
                chili.TortillaStrips = false;
            });
        }
        //Test 9: Changing the "Cheese" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.TortillaStrips = false;
            });
        }
    }
}
