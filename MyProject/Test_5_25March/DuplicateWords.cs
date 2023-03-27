using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test_5_25March
{
    internal class DuplicateWords
    {
        public static void Main()
        {
            String string1 = "Om had been saying that he had been there";
            int count;

            //Converts the string into lowercase  
            string1 = string1.ToLower();

            //Split the string into words   
            String[] words = string1.Split(' ');

            Console.WriteLine("Duplicate words in a given string : ");
            for (int i = 0; i < words.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Equals(words[j]))
                    {
                        count++;
                        //Set words[j] to 0 to avoid printing visited word  
                        words[j] = "0";
                    }
                }

                //Displays duplicate word is greater than 1  
                if (count > 1 && words[i] != "0")
                    Console.WriteLine(words[i]);
            }
        }

    }
}
