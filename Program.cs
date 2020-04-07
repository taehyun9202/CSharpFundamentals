using System;
using System.Collections.Generic;

namespace basic13
{
     class Program
    {
        //Basic 13
        static void Print1To255() 
        {
            for(int i=0; i<256; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Even1000()
        {
            for(int j=0; j<1001; j+=2)
            {
                Console.WriteLine(j);
            }
        }

        static void SubOdd5000()
        {   
            int sum = 0;
            for(int i=1; i<5001; i+=2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        static void IterateArray(int[] array)
        {
            int sum = 0;
            for(int i=0; i< array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }

        static void FindMax(int[] array)
        {
            int max = array[0];
            for (int i=0; i< array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }


        
        // static void ArrayOdd() ********************
        // {
        //     {
        //         int[] array = new int[50];
        //         for(int i=1; i<50; i++)
        //             array[i] = i;
        //     }
        //     Console.WriteLine();
        // }

        static void GreaterY(int[] array, int Y)
        {
            int count = 0;
            for(int i=0; i< array.Length; i++)
            {
                if(array[i] > Y)
                count ++;
            }
            Console.WriteLine(count);
        }

        static void Squares(int[] array)
        {
            for (int i=0; i<array.Length; i++)
            {
                array[i] *= array[i];
            }
            Console.WriteLine(string.Join(",", array));
        }

        static void Negatives(int[] array)
        {
            for(int i=0; i<array.Length;i++)
            {
                if(array[i]<0)
                {
                    array[i] = 0;
                }
            }
            Console.WriteLine(string.Join(",", array));
        }

        static void MinMaxAvg(int[] array)
        {
            int max = array[0];
            int min = array[0];
            int sum = 0;
            for (var i=0; i<array.Length; i++)
            {
                sum = sum + array[i];
                if(array[i] > max)
                {
                    max = array[i];
                }
                else if (array[i] < min)
                {
                    min = array[i];
                }
            }
            var avg = sum/array.Length;
            Console.WriteLine($"{max},{min},{avg}");
        }

        static void SwapValues(int[] array)
        {
            int temp = array[0];
            array[0] = array[array.Length - 1];
            array[array.Length - 1] = temp;
            Console.WriteLine(String.Join(",",array));
        }

        static void NumtoString(int[] array)
        {
            int[] newArray = new int[]{};
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] < 0) 
                {
                    string numi = array[i].ToString();
                    numi = "Dojo";                
                    Console.WriteLine(String.Join(",",numi));
                }
                else
                {
                    string numi = array[i].ToString();
                    Console.WriteLine(String.Join(",",numi));
                }
                
            }
            
        }

        //Fundamentals 1

        static void Divisible()
        {
            for(int i=0; i<101; i++)
                if(i % 3 == 0 || i % 5 ==0)
                {
                    Console.WriteLine(i);
                }
        }

        static void DivisibletoStr()
        {
            for (int i=1; i<101; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    string stri = i.ToString();
                    stri = "FizzBuzz";   
                    Console.WriteLine(stri);
                }
                else if(i % 3 == 0)
                {
                    string stri = i.ToString();
                    stri = "Fizz";   
                    Console.WriteLine(stri);
                }
                else if(i % 5 == 0)
                {
                    string stri = i.ToString();
                    stri = "Buzz";   
                    Console.WriteLine(stri);
                }
            }
        }

        // Collection Practice
        static List<object> ZerotoNine()
        {
            List<object> newObject = new List<object>();
            for(int i=0;i<10;i++)
            {
                newObject.Add(i);
            }
            Console.WriteLine(string.Join(",", newObject));
            return newObject;
        }

        static List<string> Names()
        { 
            List<string> names = new List<string>()
            {
                "Tim",
                "Martin",
                "Nikke",
                "Sara"
            };
            Console.WriteLine(string.Join(",", names));
            return names;
        }

        static List<string> Icecreams()
        { 
            List<string> icecreams = new List<string>()
            {
                "Vanilla",
                "Choco",
                "Strawberry",
                "Mango",
                "C&C"
            };
            int count = 0;
            foreach (string item in icecreams)
            {
                count ++;
            }
            Console.WriteLine(count);
            Console.WriteLine(icecreams[2]);
            icecreams.RemoveAt(2);
            int secondcount = 0;
            foreach (string item in icecreams)
            {
                secondcount ++;
            }
            Console.WriteLine(secondcount);
            return icecreams;
        }


        // Boxing/Unboxing
        static List<object> BoxingUnBoxing()
        {
            List<object> newObject = new List<object>();
            newObject.Add(7);
            newObject.Add(28);
            newObject.Add(-1);
            newObject.Add(true);
            newObject.Add("chair");
            int sum = 0;
            foreach (object item in newObject)
            {
                Console.WriteLine(string.Join(",", item));
                if (item is int)
                {
                    sum += (int)item;
                }
            }
            Console.WriteLine(sum);
            return newObject;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] {1,2,8,-6,2,-5};
            // int Y = 2;
            // Print1To255();
            // Even1000();
            // SubOdd5000();
            // IterateArray(array);
            // FindMax(array);
            // ArrayOdd();
            // GreaterY(array, Y);
            // Squares(array);
            // Negatives(array);
            // MinMaxAvg(array);
            // SwapValues(array);
            // NumtoString(array);
            // Divisible();
            // DivisibletoStr();
            // ZerotoNine();
            // Names();
            // Icecreams();
            // BoxingUnBoxing();
        }   
    }
}