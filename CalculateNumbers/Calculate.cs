using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculateNumbers.App_Code
{
    public class Calculate
    {
        /// <summary>
        /// GET ALL NUMBERS
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GetAllNumbers(int number)
        {
            string newNumber = "";
            for (int i = 1; i < number + 1; i++)
            {
                string comma = ", ";
                if (i == number)
                {
                    comma = "";
                }
                newNumber += i.ToString() + comma;
            }
            return newNumber;
        }

        /// <summary>
        /// GET ALL ODD NUMBERS
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GetAllOddNumbers(int number)
        {
            string newNumber = "";
            for (int i = 1; i < number + 1; i++)
            {
                if (i % 2 != 0)
                {
                    string comma = ", ";
                    if (i == number)
                    {
                        comma = "";
                    }
                    newNumber += i.ToString() + comma;
                }
            }
            return newNumber;
        }

        /// <summary>
        /// GET ALL EVEN NUMBERS
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GetAllEvenNumbers(int number)
        {
            string newNumber = "";
            for (int i = 1; i < number + 1; i++)
            {
                if (i % 2 == 0)
                {
                    string comma = ", ";
                    if (i == number)
                    {
                        comma = "";
                    }
                    newNumber += i.ToString() + comma;
                }
            }
            return newNumber;
        }

        /// <summary>
        /// GET ALL NUMBERS AND RETURN LETTERS WHEN % 3, 5
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GetAllLetters(int number)
        {
            string newNumber = "";
            for (int i = 1; i < number + 1; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    string comma = ", ";
                    if (i == number)
                    {
                        comma = "";
                    }
                    newNumber += "C" + comma;
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    string comma = ", ";
                    if (i == number)
                    {
                        comma = "";
                    }
                    newNumber += "E" + comma;
                }
                else if (i % 5 == 0 && i % 3 == 0)
                {
                    string comma = ", ";
                    if (i == number)
                    {
                        comma = "";
                    }
                    newNumber += "Z" + comma;
                }
                else
                {
                    string comma = ", ";
                    if (i == number)
                    {
                        comma = "";
                    }
                    newNumber += i.ToString() + comma;
                }
            }
            return newNumber;
        }

        /// <summary>
        /// GET ALL FIBONACCI NUMBERS 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GetAllFibsNumbers(int number)
        {
            string numbers = "0, 1, ";
            int a = 0;
            int b = 1;
            int c = 1;
            for (int i = 0; i < number + 1; i++)
            {
                while (c <= i)
                {
                    c = a + b;

                    string comma = ", ";
                    if (i == number)
                    {
                        comma = "";
                    }
                    numbers += c.ToString() + comma;

                    a = b;
                    b = c;
                }

            }
            return numbers;
        }
    }
}