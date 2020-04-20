/* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class testing if all the properties of pecos pulled pork invoke the INotifyPropertyChanged/PropertyChanged
*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data.Entrees;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PecosPulledPorkChangedTests
    {
        //Test 1: Pecos Pulled Pork should implement the INotifyPropertyChanged Interface
        [Fact]
        public void PecosPulledPorkShouldImplementINotifyPropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);
        }
        //Test 2: Changing the "Bread" property should invoke PropertyChanged for "Bread"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () =>
            {
                pork.Bread = false;
            });
        }
        //Test 3: Changing the "Bread" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Bread = false;
            });
        }
        //Test 4: Changing the "Pickle" property should invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () =>
            {
                pork.Pickle = false;
            });
        }
        //Test 5: Changing the "Pickle" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Pickle = false;
            });
        }
    }
}
