/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class that controls for the CashRegister backend
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace PointOfSale
{
    public class UsersMoneyGivenModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies of property changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The CashDrawer this class uses
        /// </summary>
        public static CashDrawer drawer = new CashDrawer();
        /// <summary>
        /// Accesses the TotalOwed
        /// </summary>
        public double TotalOwed { get; set; }
        /// <summary>
        /// Checks to see if there was enough money entered to cover the cost of the order
        /// </summary>
        public bool SufficientFunds
        {
            get
            {
                return TotalValue > TotalOwed;
            }
        }

        private double totalValue = 0;
        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        public double TotalValue => totalValue;
        private int countPenny = 0;
        /// <summary>
        /// Adds or removes pennies depending on quanitity
        /// </summary>
        public int Pennies
        {
            get => countPenny;
            set
            {
                if (countPenny == value || value < 0) return;
                var quantity = value - countPenny;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Penny, quantity);
                    countPenny++;
                    totalValue += 0.01;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                    countPenny--;
                    totalValue -= 0.01;
                }
                InvokePropertyChanged("Pennies");
            }
        }
        private int countNickel = 0;
        /// <summary>
        /// Adds or removes nickels depending on quanitity
        /// </summary>
        public int Nickels
        {
            get => countNickel;
            set
            {
                if (countNickel == value || value < 0) return;
                var quantity = value - countNickel;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Nickel, quantity);
                    countNickel++;
                    totalValue += 0.05;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                    countNickel--;
                    totalValue -= 0.05;
                }
                InvokePropertyChanged("Nickels");

            }
        }
        private int countDime = 0;
        /// <summary>
        /// Adds or removes nickels depending on quanitity
        /// </summary>
        public int Dimes
        {
            get => countDime;
            set
            {
                if (countDime == value || value < 0) return;
                var quantity = value - countDime;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dime, quantity);
                    countDime++;
                    totalValue += 0.10;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                    countDime--;
                    totalValue -= 0.10;
                }
                InvokePropertyChanged("Dimes");

            }
        }
        private int countQuarter = 0;
        /// <summary>
        /// Adds or removes quarters depending on quanitity
        /// </summary>
        public int Quarters
        {
            get => countQuarter;
            set
            {
                if (countQuarter == value || value < 0) return;
                var quantity = value - countQuarter;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Quarter, quantity);
                    countQuarter++;
                    totalValue += 0.25;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                    countQuarter--;
                    totalValue -= 0.25;
                }
                InvokePropertyChanged("Quarters");

            }
        }
        private int countHalfDollar = 0;
        /// <summary>
        /// Adds or removes half dollars depending on quanitity
        /// </summary>
        public int HalfDollars
        {
            get => countHalfDollar;
            set
            {
                if (countHalfDollar == value || value < 0) return;
                var quantity = value - countHalfDollar;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.HalfDollar, quantity);
                    countHalfDollar++;
                    totalValue += 0.50;
                }
                else
                {
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                    countHalfDollar--;
                    totalValue -= 0.50;
                }
                InvokePropertyChanged("HalfDollars");

            }
        }
        private int countDollar = 0;
        /// <summary>
        /// Adds or removes dollar depending on quanitity
        /// </summary>
        public int Dollar
        {
            get => countDollar;
            set
            {
                if (countDollar == value || value < 0) return;
                var quantity = value - countDollar;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dollar, quantity);
                    countDollar++;
                    totalValue += 1;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dollar, -quantity);
                    countDollar--;
                    totalValue -= 1;
                }
                InvokePropertyChanged("Dollars");

            }
        }
        private int countOnes = 0;
        /// <summary>
        /// Adds or removes one dollar bills depending on quanitity
        /// </summary>
        public int Ones
        {
            get => countOnes;
            set
            {
                if (countOnes == value || value < 0) return;
                var quantity = value - countOnes;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.One, quantity);
                    countOnes++;
                    totalValue += 1;
                }
                else
                {
                    drawer.RemoveBill(Bills.One, -quantity);
                    countOnes--;
                    totalValue -= 1;
                }
                InvokePropertyChanged("Ones");
            }
        }
        private int countTwos = 0;
        /// <summary>
        /// Adds or removes two dollar bills depending on quanitity
        /// </summary>
        public int Twos
        {
            get => countTwos;
            set
            {
                if (countTwos == value || value < 0) return;
                var quantity = value - countTwos;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Two, quantity);
                    countTwos++;
                    totalValue += 2;
                }
                else
                {
                    drawer.RemoveBill(Bills.Two, -quantity);
                    countTwos--;
                    totalValue -= 2;
                }
                InvokePropertyChanged("Twos");
            }
        }
        private int countFives = 0;
        /// <summary>
        /// Adds or removes five dollar bills depending on quanitity
        /// </summary>
        public int Fives
        {
            get => countFives;
            set
            {
                if (countFives == value || value < 0) return;
                var quantity = value - countFives;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Five, quantity);
                    countFives++;
                    totalValue += 5;
                }
                else
                {
                    drawer.RemoveBill(Bills.Five, -quantity);
                    countFives--;
                    totalValue -= 5;
                }
                InvokePropertyChanged("Fives");
            }
        }
        private int countTens = 0;
        /// <summary>
        /// Adds or removes ten dollar bills depending on quanitity
        /// </summary>
        public int Tens
        {
            get => countTens;
            set
            {
                if (countTens == value || value < 0) return;
                var quantity = value - countTens;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Ten, quantity);
                    countTens++;
                    totalValue += 10;
                }
                else
                {
                    drawer.RemoveBill(Bills.Ten, -quantity);
                    countTens--;
                    totalValue -= 10;
                }
                InvokePropertyChanged("Tens");
            }
        }
        private int countTwenties = 0;
        /// <summary>
        /// Adds or removes twenty dollar bills depending on quanitity
        /// </summary>
        public int Twenties
        {
            get => countTwenties;
            set
            {
                if (countTwenties == value || value < 0) return;
                var quantity = value - countTwenties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Twenty, quantity);
                    countTwenties++;
                    totalValue += 20;
                }
                else
                {
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                    countTwenties--;
                    totalValue -= 20;
                }
                InvokePropertyChanged("Twenties");
            }
        }
        private int countFifties = 0;
        /// <summary>
        /// Adds or removes fifty dollar bills depending on quanitity
        /// </summary>
        public int Fifties
        {
            get => countFifties;
            set
            {
                if (countFifties == value || value < 0) return;
                var quantity = value - countFifties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Fifty, quantity);
                    countFifties++;
                    totalValue += 50;
                }
                else
                {
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                    countFifties--;
                    totalValue -= 50;
                }
                InvokePropertyChanged("Fifties");
            }
        }
        private int countHundreds = 0;
        /// <summary>
        /// Adds or removes hundreds dollar bills depending on quanitity
        /// </summary>
        public int Hundreds
        {
            get => countHundreds;
            set
            {
                if (countHundreds == value || value < 0) return;
                var quantity = value - countHundreds;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Hundred, quantity);
                    countHundreds++;
                    totalValue += 100;
                }
                else
                {
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                    countHundreds--;
                    totalValue -= 100;
                }
                InvokePropertyChanged("Hundreds");
            }
        }

        /// <summary>
        /// Helper method for triggering PropertyChanged events
        /// </summary>
        /// <param name="denomination">The denomination property that is changing</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientFunds"));
        }
    }
}

