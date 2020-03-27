/* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class testing if all the properties of corn dodgers invoke the INotifyPropertyChanged/PropertyChanged
*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersChangedTests
    {
        //Test 1: Corn Dodgers should implement the INotifyPropertyChanged Interface
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var dodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dodgers);
        }

        //Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void CanChangeSize()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Size", () =>
            {
                dodgers.Size = Size.Small; //Checks if size is able to switch to small
            });
            Assert.PropertyChanged(dodgers, "Size", () =>
            {
                dodgers.Size = Size.Medium; //Checks if size is able to switch to medium

            });
            Assert.PropertyChanged(dodgers, "Size", () =>
            {
                dodgers.Size = Size.Large; //Checks if size is able to switch to large
            });
        }
        //Test 3: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeChangesCalories()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Calories", () =>
            {
                dodgers.Size = Size.Small; //Checks if calories is able to switch when size changes to small
            });
            Assert.PropertyChanged(dodgers, "Calories", () =>
            {
                dodgers.Size = Size.Medium; //Checks if calories is able to switch when size changes to medium

            });
            Assert.PropertyChanged(dodgers, "Calories", () =>
            {
                dodgers.Size = Size.Large; //Checks if calories is able to switch when size changes to large
            });
        }
        //Test 4: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeChangesPrice()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Price", () =>
            {
                dodgers.Size = Size.Small; //Checks if price is able to switch when size changes to small
            });
            Assert.PropertyChanged(dodgers, "Price", () =>
            {
                dodgers.Size = Size.Medium; //Checks if price is able to switch when size changes to medium
            });
            Assert.PropertyChanged(dodgers, "Price", () =>
            {
                dodgers.Size = Size.Large; //Checks if price is able to switch when size changes to large
            });
        }
    }
}
