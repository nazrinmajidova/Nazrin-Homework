using System;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Task1();
                Task2();
                Task3();
                Task4(); 
                Task5();
                Task6();
                Task7();
                Task8();
                ForEach();
                WhileTask ();
                DoWhile();
  
        }

        #region Task3
        public static void Task3()
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;
            int remainder = 0;
            while (num > 0)
            {
                remainder = num % 10;
                sum += remainder;
                num = num - remainder;
                num = num / 10;
                count++;

            }
            Console.WriteLine($"The sum of the digits of the number: {sum}");
            Console.WriteLine($"The number of digits of the given number: {count}");
        }
        #endregion

        #region Task1
        public static void Task1()
        {
            int[] arr = { 57, 7, 2, 4, 0, 21, 3, 6, 11 };
            int min = arr[0];
            int max = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            Console.WriteLine($"Minimum element in the array : {min}");
            Console.WriteLine($"Maximum element in the array : {max}");

        }
        #endregion

        #region Task2
        public static void Task2()
        {
            int[] arrayInt = { 5, 8, 23, 13, 76, 7, 14 };
            int even = 0;
            int odd = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] % 2 == 0) even++;
                else odd++;
            }
            Console.WriteLine($"The number of even numbers : {even}");
            Console.WriteLine($"The number of odd numbers : {odd}");
        }
        #endregion

        #region Task4
        public static void Task4()
        {
            Console.WriteLine("Enter a value: ");
            int value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
            }
        }
        #endregion

        #region Task7
        public static void Task7()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int product = i * j;
                    Console.WriteLine($"{i} * {j} = {product}");
                    //Console.WriteLine("{0}x{1} = {2}", j, i, i * j);
                }
                Console.WriteLine(new string('-', 10));
                Console.Write("\n");
            }
        }
        #endregion

        #region Task6
        public static void Task6()
        {
            Console.WriteLine("Enter a value: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.Write("X");
            }

            Console.WriteLine();

            for (int i = 0; i < size - 2; i++)
            {
                Console.Write("X");

                for (int j = 0; j < size - 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("X");
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write("X");
            }

        }
        #endregion

        #region Task5

        public static void Task5()
        {
            Console.WriteLine("Enter a value: ");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("X");
                }

                Console.WriteLine(' ');
            }
        }
        #endregion

        #region ForEach
        public static void ForEach()
        {
            int[] array = { 3, 7, 6, 12, 24, 76, 98, 43, 11 };
            int count = 0;
            foreach (int nums in array)
            {
                if (nums % 2 == 0 && nums % 3 == 0) count++;

            }
            Console.WriteLine($"The amount of numbers which are divided by both 2 and 3: {count}");

            int evenCount = 0;
            int oddCount = 0;

            foreach (int nums in array)
            {
                if (nums % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            int[] evenArray = new int[evenCount];
            int[] oddArray = new int[oddCount];

            int indexI = 0;
            int indexJ = 0;


            int evenSum = 0;
            int oddSum = 0;

            foreach (int nums in array)
            {
                if (nums % 2 == 0)
                {
                    evenArray[indexI++] = nums;
                    evenSum += nums;
                }
                else
                {
                    oddArray[indexJ++] = nums;
                    oddSum += nums;
                }
            }
            Console.WriteLine("Sum of the even numbers: " + evenSum);
            Console.WriteLine("Sum of the odd numbers: " + oddSum);
            Console.WriteLine("Array of the even numbers: " + string.Join(", ", evenArray));
            Console.WriteLine("Array of the odd numbers: " + string.Join(", ", oddArray));
        }
        #endregion

        #region DoWhile
        static void DoWhile()
        {
            string Username = "Code Academy";
            string Password = "RNET104";

            string inputUsername;
            string inputPassword;

            do
            {
                Console.WriteLine("Enter username: ");
                inputUsername = Console.ReadLine();

                Console.WriteLine("Enter password: ");
                inputPassword = Console.ReadLine();

                if (inputUsername == Username && inputPassword == Password)
                {
                    Console.WriteLine("Login is successful");
                }
                else
                {
                    Console.WriteLine("Incorrect password or username, please try again.");
                }


            } while (inputUsername != Username || inputPassword != Password);
        }
        #endregion

        #region While
        public static void WhileTask()
        {
            Console.WriteLine("Please enter a number between 1 and 6:");
            int value = Convert.ToInt32(Console.ReadLine());
            while (value > 6 || value < 1)
            {
                Console.WriteLine("The number should be between 1 and 6.");
                value = Convert.ToInt32(Console.ReadLine());
            }
            Random random = new Random();
            int size = value * value;
            int[] array = new int[size];
            int i = 0;

            while (i != size)
            {
                array[i++] = random.Next(1, 50);
            }

            int lengArray = value;
            int j = 0;
            int check = 0;
            while (lengArray >= 0 && j != value * value - 1)
            {
                check = array[j];
                if (Array.IndexOf(array, check) == Array.LastIndexOf(array, check))
                {
                    j++;
                }
                else
                {
                    array[j] = random.Next(1, 50);
                    j = 0;
                }
                if (lengArray == 0)
                {
                    lengArray = 6;
                }
            }
            int index = 0;
            int[,] matrix = new int[value, value];
            for (int n = 0; n < value;  n++)
            {
                for (int m = 0; m < value; m++)
                {
                    matrix[n, m] = array[index];
                    Console.Write(array[index] + " ");
                    index++;
                }
                Console.WriteLine();

            }
        }
            #endregion

        #region Task8
            public static void Task8()
            {
                Random rndm = new Random();
                int ranNum = rndm.Next(10000000, 99999999);
                Console.WriteLine($"Randomly generated number: {ranNum}");

                int attempt = 3;

                for (int i = 0; i < attempt; i++)
                {
                    Console.WriteLine("Enter the randomly generated number above: ");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == ranNum)
                    {
                        Console.WriteLine("Correctly logged in");
                        return;

                    }
                    else
                    {
                        int remained = attempt - (i + 1);
                        if (remained > 0)
                        {
                            Console.WriteLine($"Wrong input. You have {remained} attempts left.");
                        }
                        else
                        {
                            Console.WriteLine("You have used all your attempts");
                            Thread.Sleep(10000);
                            Environment.Exit(0);
                        }

                    }
                }
            }

            #endregion
        
    }
}