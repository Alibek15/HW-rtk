using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CA
{
    class Program
    {
         
        static void Main(string[] args)
        {
            //int[] arr = new int[5];
            //Random rand = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    arr[i] = rand.Next(1, 10);
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine("\n");
            //try
            //{
            //    for (int i = 0; i < 6; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();
            //int firstNumber, secondNumber;
            //bool isParse;

            //WriteLine("Здраствуйте, введите две цифры для деление: \n");

            //WriteLine("Введите 1 цифру: \n");

            //isParse = int.TryParse(ReadLine(), out firstNumber);

            //WriteLine("\n Введите 2 цифру: \n");

            //isParse = int.TryParse(ReadLine(), out secondNumber);

            //CheckProblem(firstNumber, secondNumber);

            ////DivizionByZero(firstNumber,secondNumber);
            //ReadKey();
            string answer;
            string firstName, middleName, lastName;
            int age;
            bool isPars;

            ClassHW person = new ClassHW();

            WriteLine("Здраствуйте, введите пожалуйста те данные что мы попросим:\n");

            WriteLine("Введите Имя: \n");

            firstName = ReadLine();

            person.SetFirstName(firstName);

            WriteLine("\nВведите Фамилия: \n");

            middleName = ReadLine();

            person.SetMiddleName(middleName);

            WriteLine("\nВведите Отчество: \n");

            lastName = ReadLine();

            person.SetLastName(lastName);

            WriteLine("\nВведите Возраст: \n");

            isPars = int.TryParse(ReadLine(), out age);

            person.SetAge(age);

            answer = person.Show();

            WriteLine("Характеристики персоны: \n" + answer);

            ReadKey();
        }

        private static void CheckProblem(int firstNumber, int secondNumber)
        {
            try
            {
                DivizionByZero(firstNumber, secondNumber);
            }
            catch (ArgumentNullException argumentNullException)
            {
                WriteLine(argumentNullException);
            }
            catch (ArithmeticException arithmeticException)
            {
                WriteLine(arithmeticException);
            }
        }
        private static int DivizionByZero(int firstNumber, int secondNumber)
        {
            int sum;
            sum = firstNumber / secondNumber;
            return sum;
        }
    }
    }


