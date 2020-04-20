/* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class testing if all the properties of texas tea invoke the INotifyPropertyChanged/PropertyChanged
*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using CowboyCafe.Data.Drinks;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTeaChangedTests
    {
        //Test 1: Texas Tea should implement the INotifyPropertyChanged Interface
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }

        //Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void CanChangeSize()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Small; //Checks if size is able to switch to small
            });
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Medium; //Checks if size is able to switch to medium

            });
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Large; //Checks if size is able to switch to large
            });
        }
        //Test 3: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeChangesCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Small; //Checks if calories is able to switch when size changes to small
            });
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Medium; //Checks if calories is able to switch when size changes to medium

            });
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Large; //Checks if calories is able to switch when size changes to large
            });
        }
        //Test 4: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeChangesPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Small; //Checks if price is able to switch when size changes to small
            });
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Medium; //Checks if price is able to switch when size changes to medium
            });
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Large; //Checks if price is able to switch when size changes to large
            });
        }
        //Test 5: Changing the "Lemon" property should invoke PropertyChanged for "Lemon"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = true;
            });
        }
        //Test 6: Changing the "Lemon" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = true;
            });
        }
        //Test 7: Changing the "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () =>
            {
                tea.Ice = false;
            });
        }
        //Test 8: Changing the "Ice" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Ice = false;
            });
        }
        //Test 5: Changing the "Sweet" property should invoke PropertyChanged for "Sweet"
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = false;
            });
        }
        //Test 6: Changing the "Lemon" property should invoke PropertyChanged for "Special Instruction"
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Sweet = false;
            });
        }
    }
}
