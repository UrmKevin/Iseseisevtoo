using System;
using System.Collections.Generic;

namespace Kordamine
{
    class Program
    {
        static void Main()
        {
            //Variant 5 Ü1
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            int vows = 0;

            Console.WriteLine("Enter a Sentence");
            string sentence = Console.ReadLine().ToLower();
            int len = sentence.Length;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    vows++;
                }
            }
            float total = ((float)((decimal)vows / len * 100));

            Console.WriteLine("Your total percentage of vowels is: {0}%", total);


            Random rnd = new Random();
            Console.WriteLine("Write any integer number more than 0");
            int n = Int32.Parse(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(-500, 500);
                Console.Write(mas[i] + " ");
            }
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (mas[i] > -100 && mas[i] < 100)
                {
                    ans += 1;
                }
            }
            Console.WriteLine(ans);

            Console.WriteLine("Write netto salary in euro");
            int salary = Int32.Parse(Console.ReadLine());
            float tax = (float)(salary * 0.2);
            Console.WriteLine("Your income tax is {0} euro", tax);

            Console.ReadLine();
        }
    }
}