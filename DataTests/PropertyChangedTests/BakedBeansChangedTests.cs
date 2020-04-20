/* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class testing if all the properties of baked beans invoke the INotifyPropertyChanged/PropertyChanged
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
    public class BakedBeansChangedTests
    {
        //Test 1: Baked Beans should implement the INotifyPropertyChanged Interface
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }

        //Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void CanChangeSize()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Small; //Checks if size is able to switch to small
            });
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Medium; //Checks if size is able to switch to medium

            });
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Large; //Checks if size is able to switch to large
            });
        }
        //Test 3: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeChangesCalories()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = Size.Small; //Checks if Calories is able to switch when size changes to small
            });
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = Size.Medium; //Checks if Calories is able to switch when size changes to medium
            });
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = Size.Large; //Checks if Calories is able to switch when size changes to large
            });
        }
        //Test 4: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeChangesPrice()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = Size.Small; //Checks if price is able to switch when size changes to small
            });
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = Size.Medium; //Checks if price is able to switch when size changes to medium
            });
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = Size.Large; //Checks if price is able to switch when size changes to large
            });
        }
    }
}
