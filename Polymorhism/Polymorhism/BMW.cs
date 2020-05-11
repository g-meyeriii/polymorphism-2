using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using System.Linq;

namespace Polymorhism
{
    // a BMW is a car 

    class BMW : Car

    {

        private string Brand = "BMW";

        public string Model { get; set; }

        public BMW()
        {

        }

        public BMW(string model, int horsePower, string color):base(horsePower,color)
            
            {
                this.Model = model;
            }
        public new void ShowDetails()
        {
            Console.WriteLine("Car Details this is an {0} {1} it has {2} horse power and is {3} in color"
                                , "BMW", Model, HorsePower,Color  );
        }

        public sealed override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired", Model);
        }




    }
}
