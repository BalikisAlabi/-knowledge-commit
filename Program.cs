using System;

namespace knowledge
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Declare an array of month Jan- Dec");

            string[] month = {"Jan", "feb", "march", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec"};

            Console.WriteLine("Return the number of month in the array");

             Console.WriteLine($"The number of months is : {month.Length}");

              Console.WriteLine("Return the rank of the month");
           for (int index = 0; index < month.Length; index++)
            {
                Console.WriteLine("{1}", index, month[index]);        
            }

            Console.WriteLine("Reverse the month using loop method");
             for (int index = month.Length -1; index >= 0; index--)
             {
                Console.WriteLine("{1}", index, month[index]);
             }

              Console.WriteLine("Reverse the month using array method");
              Array.Reverse(month);
              foreach(string m in month)
              {
                Console.WriteLine(m);
              }

              Console.WriteLine("Array.Sort");

             Array.Sort(month);
             foreach(string m in month)
             {
                Console.WriteLine(m);
             }

              Console.WriteLine("Sort using loops alphabetically");
              string set;
              {
                for (int i = 0; i < month.Length; i++)
                {
                  for (int j = 0; j <month.Length; j++)
                  {
                    if (j ! == month.Length -1)
                    {
                      if (month[j] > month[j+1])
                      {
                        set = month[j];
                        month[j] = month[j+1];
                        month[j+i] = set;
                      }
                    }
                  }
                }
              }

             Console.WriteLine("Copy the first six month to another array");
             string[] firstSixMonth = new string[6];
             Array.Copy(month, 0, firstSixMonth, 0 , 6);
             foreach (string h in firstSixMonth)
             {
               Console.WriteLine(h);
             }
             
             Console.WriteLine("Clone the month using array method");
            string[] monthClone = (string[])month.Clone();
            foreach(string element in monthClone)
            {
              Console.WriteLine(element);
            }
            Console.Read();

            Console.WriteLine("clear month starting from 6");
            Array.Clear(month, 0, 6);
            foreach (string m in month)
            {
              Console.WriteLine(m);
            }
              Console.Read();

            Console.WriteLine("Clear all the month");
            Array.Clear(month, 0, month.Length);
            foreach (string m in month)
            {
              Console.WriteLine(m);
            }



        }

    }  
}    