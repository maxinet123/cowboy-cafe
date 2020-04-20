/* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class testing if all the properties of pan de campo invoke the INotifyPropertyChanged/PropertyChanged
*/
using System;
using System.Collections.Generic;
using CowboyCafe.Data;
using CowboyCafe.Data.Sides;
using Xunit;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoChangedTests
    {
        //Test 1: Pan De Campo should implement the INotifyPropertyChanged Interface
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var campo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(campo);
        }

        //Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void CanChangeSize()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Size", () =>
            {
                campo.Size = Size.Small; //Checks if size is able to switch to small
            });
            Assert.PropertyChanged(campo, "Size", () =>
            {
                campo.Size = Size.Medium; //Checks if size is able to switch to medium

            });
            Assert.PropertyChanged(campo, "Size", () =>
            {
                campo.Size = Size.Large; //Checks if size is able to switch to large
            });
        }
        //Test 3: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeChangesCalories()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Calories", () =>
            {
                campo.Size = Size.Small; //Checks if calories is able to switch when size changes to small
            });
            Assert.PropertyChanged(campo, "Calories", () =>
            {
                campo.Size = Size.Medium; //Checks if calories is able to switch when size changes to medium

            });
            Assert.PropertyChanged(campo, "Calories", () =>
            {
                campo.Size = Size.Large; //Checks if calories is able to switch when size changes to large
            });
        }
        //Test 4: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeChangesPrice()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Price", () =>
            {
                campo.Size = Size.Small; //Checks if price is able to switch when size changes to small
            });
            Assert.PropertyChanged(campo, "Price", () =>
            {
                campo.Size = Size.Medium; //Checks if price is able to switch when size changes to medium
            });
            Assert.PropertyChanged(campo, "Price", () =>
            {
                campo.Size = Size.Large; //Checks if price is able to switch when size changes to large
            });
        }
    }
}
