using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignmentNew
{

    public class Program
    {
        static void Main(string[] args)
        {
            //1.Split string into 2 token
            string text = "Hello$World";

            string[] result = text.Split('$');
            Console.Write("Result: ");
            foreach (String str in result)
            {
                Console.Write(str + " ");

            }
            Console.ReadLine();

            //2.First Occurance of character in string

            Console.WriteLine($"Write a String:");
            String str1 = Console.ReadLine();
            Console.WriteLine("Write a character which occurance will find:");
            char ch = Console.ReadLine()[0];

            for (int i = 0; i < str1.Length; i++)
            {


                if (str1[i] == ch)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            //3.Count the occurance of character in string
            string str2 = "Welcome to all";
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
                str2 = str2.Replace(str2[0].ToString(), string.Empty);




            }

            //ToggleCase

            string str3 = "TesT";
            string str4 = "";
            for (int i = 0; i < str3.Length; i++)
            {
                if (char.IsLower(str3[i]))
                {

                    str4 += str3[i].ToString().ToUpper();
                }
                else if (char.IsUpper(str3[i]))
                {
                    str4 += str3[i].ToString().ToLower();
                }
            }
            Console.WriteLine(str4);
        }

        //count vowels and consonents

        //    int i, length, vowels, consonents;
        //    Console.WriteLine($"Write a String:");
        //    string String1 = Console.ReadLine();
        //    //String1 = "helloworld";
        //    vowels = 0;
        //    consonents = 0;
        //    length=String1.Length;

        //    for(i=0;i<length;i++)
        //    {
        //        if (String1[i] == 'a'|| String1[i]=='e'||String1[i] == 'i' || String1[i] == 'o' || String1[i] == 'u' || 
        //            String1[i] == 'A' || String1[i] == 'E' || String1[i] == 'I' || String1[i] == 'O' || String1[i] == 'U' )
        //        {
        //            vowels++;
        //        }
        //        else
        //        {
        //            consonents++;
        //        }
        //    }
        //    Console.WriteLine("Count of vowels:" + vowels);
        //    Console.WriteLine("Count of consonents:" + consonents);

        //}

        //count alphabet,digits and specialcharacter in string

        //int j, length, alphabet, digit, SpecialChar;
        //    Console.WriteLine($"Write a String:");
        //    string String1 = Console.ReadLine();
        //    String1 = "helloworld";
        //    alphabet = 0;
        //    digit = 0;
        //    SpecialChar = 0;
        //    length = String1.Length;

        //    for (j = 0; j < length; j++)
        //    {
        //        if ((String1[j] >= 'a' && String1[j] <= 'z') || (String1[j] >= 'A' && String1[j] <= 'Z'))
        //        {
        //            alphabet++;
        //        }
        //        else if (String1[j] >= '0' && String1[j] <= '9')
        //        {
        //            digit++;
        //        }
        //        else
        //        {
        //            SpecialChar++;
        //        }
        //    }
        //    Console.WriteLine("Count of alphabet:" + alphabet);
        //    Console.WriteLine("Count of digits:" + digit);
        //    Console.WriteLine("Count of SpecialChar:" + SpecialChar);


            //find reverse string
            //string strnew = "Music";
            //string strNew="";
            //for (int k = strnew.Length - 1; k >= 0; k--)
            //{
            //    Console.Write(strnew[k]);

            //}
            //Console.WriteLine(strNew);





        }
    }




