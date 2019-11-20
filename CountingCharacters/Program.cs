using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)

        {
             string myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc accumsan sem ut ligula scelerisque sollicitudin.Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat.Donec sit amet suscipit metus, non lobortis massa.Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
             Dictionary<char, int> myDict = new Dictionary<char, int>();
           




            foreach (char c in myString)
            {
                

                if (myDict.ContainsKey(c))
                {

                   // my logic here is if the letter is in the dictionary, add the letter +1.
                    
                     myDict[c]++;
                    //myDict.Add(c, (myDict[c]));
                   

                }




                else
                {
                    //here if the letter is not then just add 1
                    myDict.Add(c, 1);
                }



                Console.WriteLine($"{c}:{myDict[c]}");




            }
           

















        }
    }
}
