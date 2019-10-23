using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //First I declare the variables
            double area;
            double radius;
            double pi = 3.14;
            string input;

            
                Console.WriteLine("Enter a radius: "); //This line asks user for input


            

                input = Console.ReadLine(); //This line takes the input from user
            while (double.Parse(input) < 0)
            {
                Console.Write("You have to enter a positive number.!");
                Console.ReadLine();
                Console.WriteLine("Enter a radius: ");
                input = Console.ReadLine();




            }
            if (double.Parse(input) > 0)

            {
                
                
                radius = double.Parse(input);//This line parses the input and stores it in the radius variable
                area = (pi * radius * radius);//Calculation of the area is done here
                Console.WriteLine("The area of a circle is: " + area);//This line represents the output
                Console.ReadLine();
            }






        }
    }
}
