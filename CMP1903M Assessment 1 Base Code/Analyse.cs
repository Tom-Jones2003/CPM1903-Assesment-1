using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text

        public List<int> values = new List<int>();

        public void analyseText(string input)
        {

            
            values.Clear();
            

            //List of variables to hold the first five measurements:

            int upper = 0;
            int lower = 0;
            int sentences = 0;

            Dictionary<char, int> vowels = new Dictionary<char, int>();

            vowels.Add('a', 0);
            vowels.Add('e', 0);
            vowels.Add('i', 0);
            vowels.Add('o', 0);
            vowels.Add('u', 0);

            int consonants = 0;

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                char letter_lower = char.ToLower(letter);

                //1. Number of upper case letters
                if (char.IsUpper(letter))
                {
                    upper++;
                }
                //2. Number of lower case letters
                else if (char.IsLower(letter))
                {
                    lower++;
                }


                //3. Number of sentences
                if (letter == '.')
                {
                    sentences++;
                }

                //4. Number of vowels
                if (vowels.ContainsKey(letter_lower))
                {
                    vowels[letter_lower]++;
                    sum++;
                }
                //5. Number of consonants
                else
                {
                    consonants++;
                }
            }

            values.Add(upper);
            values.Add(lower);
            values.Add(sentences);
            values.Add(sum);
            values.Add(consonants);
        }
    }
}
