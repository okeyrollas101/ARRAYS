using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
          // An array is a collection of similar data types,it is zero based index type
        //   string [] students = new string [4];
        //   students[0] = "elijah";
        //   students[1] = "okey";
        //   students[2] = "bernice";
        //   students[3] = "precious";
           //Console.WriteLine(students[0]); to call elijah

          // another way
        //   string [] students = {"elijah","okey","bernice","precious"};
        //   foreach(string i in students)
        //   {
        //       Console.WriteLine(i);// prints out the whole array names
        //   }

        //  string [] students = {"precious","okey","bernice","mubarak","segun","chisom","nonso","sarah","joy"};
        //   for(int i = 0; i < 9; i += 2)// skips one name to the next name
        //   {
        //       Console.WriteLine(students[i]);//used for the for loop
        //   }

        // multidimensional arrays maybe initialized by specifiying bracketed
        // value for each row. The following array is with 3 rows and each row has 4 columns
          int [,] goodNumbers = new int [4,4] {{0, 1, 2, 3},
                                     {4, 5, 6, 7},
                                     {8, 9, 10, 11},
                                     {8, 9, 10, 11} };
          for(int i = 0; i < 4; i++)
          {
             Console.WriteLine();
             Console.WriteLine($"This is row {i}");
              for(int j = 0; j < 4; j++)
              {
                  Console.WriteLine(goodNumbers[i,j]);
              }
          }
        }
    }
}
