using ParkinApp.Model;
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
        /// <summary>
        /// This collection is used to be a source for a ListView
        /// </summary>
        public ObservableCollection<Car> cars = new ObservableCollection<Car>();
        /// <summary>
        /// Method required to initialize commands and properties that would be used during runtime by the side of View
        /// </summary>
        public ParkingLotViewModel()
        {
            //Data for testing
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
        /// <summary>
        /// Command for saving up cars through the API
        /// </summary>
        public ICommand CarSignUp { private set; get; }
        /// <summary>
        /// Command for registering car departure
        /// </summary>
        public ICommand CarLeaving { private set; get; }
        /// <summary>
        /// Command for Calculating the time car was in parking lot
        /// </summary>
        public ICommand CalculateTime { private set; get; }
        /// <summary>
        /// Register the car which is getting into the parkinglot, it is saved in cars collection
        /// </summary>
        /// <returns></returns>
        private async Task CarRegister(Car c)
        {

        }
        /// <summary>
        /// Remove the car from cars collection and save the time when the car leaves
        /// </summary>
        /// <param name="c"></param> This parameter represents the car that is leaving inherited from listview
        /// <returns></returns>
        private async Task TakeCarOut(Car c)
        {

        }
        /// <summary>
        /// This method calculate the time (Date in - Date out)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private async Task CalcTime(Car c)
        {

        }

    }
}
