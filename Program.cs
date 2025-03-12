namespace task_praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* #region task1
             int rslt = 55;
             if (rslt >= 91)
             {
                 Console.WriteLine("A");
             }
             else if (rslt >= 81)
             {
                 Console.WriteLine("B");
             }
             else if (rslt>=71)
             { 
                 Console.WriteLine("C");
             }
             else
             {
                 Console.WriteLine("D");
             }
             #endregion*/

            //#region task2
            //int num = 287;
            //int sum = 0;
            //while (num > 0) 
            //{
            //    sum = sum + num % 10;
            //    num = num / 10;
            //}
            //Console.WriteLine(sum);
            //#endregion

            /* #region task3
             int[] numbers = { 1, 5, 14, 2, 7, 86 };
             int num= 0;

             for(int i=0; i<numbers.Length; i++)
             { 
                 num = numbers[i];
                 if(num%2==0)
                 { Console.WriteLine(num); 

                 } 
             } 
             #endregion    */


            int[] numbers = { 2, 4, 3, 2, 5, 7, 2 };
            int searchNumber = 4;
            int saygac = 0;

            foreach (int i in numbers)
            {
                if (i == searchNumber)
                    Console.WriteLine(saygac++);      

            }


        }
            }


        }
    
        
    

