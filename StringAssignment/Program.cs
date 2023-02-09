using System;
using System.ComponentModel;
using System.Runtime.ExceptionServices;

namespace StringAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1.Split string into 2 token
            //string text = "Hello$World";

            //string[] result = text.Split('$');
            //Console.Write("Result: ");
            //foreach (String str in result)
            //{
            //    Console.Write(str + " ");

            //}
            //Console.ReadLine();

            ////2.First Occurance of character in string

            //Console.WriteLine($"Write a String:");
            //String str1 = Console.ReadLine();
            //Console.WriteLine("Write a character which occurance will find:");
            //char ch = Console.ReadLine()[0];

            //for (int i = 0; i < str1.Length; i++)
            //{


            //    if (str1[i] == ch)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}

            //3.Count the occurance of character in string
            string str2="Welcome to all";
            str2 = str2.Replace(" ", String.Empty);
            Console.WriteLine(str2);

            while (str2.Length > 0)
            {

                Console.Write(str2[0] + "=");
                int count = 0;
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str2[0] == str2[i])
                    {
                        count++;
                        
                    }
                }
                Console.WriteLine(count);
                



            }
        }
    }
}

