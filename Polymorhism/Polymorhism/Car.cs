using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorhism
{
    class Car
    {
        public int HorsePower { get; set; }
        public string Color { get; set; }

        //has a relationship
        protected CarIdInfo carIdInfo = new CarIdInfo();

        public void SetCarIdInfo(int idNum, string owner)
        {
            carIdInfo.IdNum = idNum;
            carIdInfo.Owner = owner;
        }

        public void GetCarIdInfo()
        {
            Console.WriteLine("The car has the Id of {0} nad is owned by {1}", carIdInfo.IdNum, carIdInfo.Owner);
        }

        public Car(int horsePower, string color)
        {
            this.HorsePower = horsePower;
            this.Color = color;
        }
        // default constructor
        public Car()
        {

        }

       
        public void ShowDetails()
        {
            Console.WriteLine("Car details, this car has {0} horse power and {1} color paint" , HorsePower, Color);

        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
