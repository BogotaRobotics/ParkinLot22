﻿using ParkinApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using SQLite;

namespace ParkinApp.ViewModel
{
    public class ParkingLotViewModel
    {
        public ObservableCollection<Car> cars = new ObservableCollection<Car>();
        public ParkingLotViewModel()
        {
            DateTime x = new DateTime(1995, 10, 11, 11, 10, 2);
            Car a = new Car { LicensePlate = "axfs5456", InputTime = x };
            cars.Add(a);
            cars.Add(a);
            cars.Add(a);
            cars.Add(a);
            cars.Add(a);
            cars.Add(a);
            cars.Add(a);
            cars.Add(a);
            cars.Add(a);
            CarSignUp = new Command<Car>(async (Car) => await CarRegister(Car));
            CarLeaving = new Command<Car>(async (Car) => await TakeCarOut(Car));
            CalculateTime = new Command<Car>(async (Car) => await CalcTime(Car));
        }
        public ObservableCollection<Car> Cars = new ObservableCollection<Car>();
        public ICommand CarSignUp { private set; get; }
        public ICommand CarLeaving { private set; get; }
        public ICommand CalculateTime { private set; get; }
        /// <summary>
        /// Register the car which is getting into the parkinglot, it is saved in cars collection
        /// </summary>
        /// <returns></returns>
        private async Task CarRegister(Car c)
        {

        }
        private async Task TakeCarOut(Car c)
        {

        }
        private async Task CalcTime(Car c)
        {

        }

    }
}
