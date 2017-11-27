using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyCWK5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Build-A-Car App");
            Console.WriteLine();//blank

            //using default constructor
            Car C1 = new Car();

            C1.MAKE = "Honda";
            C1.MODEL = "Civic";
            C1.MPG = 35.1;
            C1.DOORS = 2;

            C1.PrintMakeAndModel();
            C1.GetMilesPerGallon();
            C1.PrintDoors();


            Console.WriteLine();//blank
            Car C2 = new Car(4, "Porsche", "Boxster", 20);

            C2.PrintMakeAndModel();
            C2.PrintDoors();
            C2.GetMilesPerGallon();

            Console.WriteLine();//blank



            //just practicing here to the end
            Car C3 = new Car(4, "Ford", "Pinto", 17);

            C3.PrintMakeAndModel();
            C3.GetMilesPerGallon();
            C3.PrintDoors();

            Console.WriteLine();//blank

            //trying something else for user input practice
            int doors;
            Console.Write("Please enter a make of car: ");
            string make = Console.ReadLine();
            Console.Write("Please enter a model of car: ");
            string model = Console.ReadLine();

            Console.Write("Please enter the number of doors you want: ");

            while(int.TryParse(Console.ReadLine(), out doors)==false)
            { Console.WriteLine("Bad Input.  Please try again:  "); }

            double mpg;
            Console.Write("Please enter the miles per gallon you want: ");

            while (double.TryParse(Console.ReadLine(), out mpg) == false)
            { Console.WriteLine("Bad Input.  Please try again:  "); }


            Car C4 = new Car(doors, make, model, mpg);
            C4.PrintMakeAndModel();
            C4.PrintDoors();
            C4.GetMilesPerGallon();

            Console.ReadKey();
        }
    }
}
