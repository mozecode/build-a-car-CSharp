using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyCWK5
{
    class Car
    {
        //attributes
        private int doors;
        private string make;
        private string model;
        private double mpg;


        //Constructors (default and perameterized)

        public Car()
        {
            doors = 2;
            make = "Honda";
            model = "Civic";
            mpg = 35.1;
        }


        public Car(int doors, string make, string model, double mpg)
        {
            if (doors > 0)
            { this.doors = doors; }
            else
            {
                Console.WriteLine("Default set to 2.");
                this.doors = 2;
            }

            if (mpg > 0)
            { this.mpg = mpg; }
            else
            { Console.WriteLine("Default set to 35.1"); this.mpg = 35.1; }

            this.make = make;
            this.model = model;
        }

        //Properties protected doors, mpg

        public int DOORS
        {
            get { return doors; }
            set {
                    if (doors > 0)
                    { doors = value; }
                    else
                    { Console.WriteLine("Error. Default set to 2.");  doors = 2;      }
                }
        }
        public string MAKE
        {
            get { return make; }
            set { this.make = value; }
        }

        public string MODEL
        {
            get { return model;}
            set { this.model =value;}
        }

        public double MPG
        {
            get{return mpg;}

            set{
                    if (mpg > 0)
                        { mpg = value; }

                    else
                    { Console.WriteLine("Error. Default set to 35.1."); mpg=35.1; }
               }

        }

        //methods to perform actions

        public double GetMilesPerGallon()
        {

            Console.WriteLine("This car gets {0} miles per gallon.", mpg);
            return mpg;
        }

        public void PrintMakeAndModel()
        {
            Console.WriteLine("This car is a {0} {1}.", make, model);

        }

        public void PrintDoors()
        {
            Console.WriteLine("This car has {0} doors.", doors);

        }
    }//end of class Car
}



