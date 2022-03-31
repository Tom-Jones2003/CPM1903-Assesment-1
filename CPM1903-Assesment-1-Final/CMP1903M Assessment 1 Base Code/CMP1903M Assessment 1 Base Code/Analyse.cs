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
            

            //List of integers to hold the first five measurements:

            //1. Number of upper case letters
            int upper = 0;

            for(int i = 0; i < input.Length; i++)
            {
                

                bool result = false;
                char letter = input[i];
                
                result = Char.IsUpper(letter);
                
                if(result)
                {
                    upper++;
                    
                    
                }
                 
            }
            values.Add(upper);

            //2. Number of lower case letters
            int lower = 0;

            for(int i = 0; i < input.Length; i++)
            {
                bool result = false;
                char letter = input[i];
                
                result = Char.IsLower(letter);
                
                if(result)
                {
                    lower++;
                    
                }
                
            }
            values.Add(lower);

            input.ToLower();

            
            //3. Number of sentences
            int sentences = 0;

            for(int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                
                if(letter == '.')
                {
                    sentences++;
                    
                }
                
            }
            values.Add(sentences); 


            Dictionary<char, int> vowels = new Dictionary<char, int>();

            vowels.Add('a', 0);
            vowels.Add('e', 0);
            vowels.Add('i', 0);
            vowels.Add('o', 0);
            vowels.Add('u', 0);

            foreach(char character in input)
            {
                if(vowels.ContainsKey(character))
                {
                    vowels[character]++;
                }
                
            }

            int sum = 0;
            foreach(var item in vowels)
            {
                sum = sum + item.Value;
            }
            values.Add(sum);

            //5. Number of 

            Dictionary<char, int> consonants = new Dictionary<char, int>();

            consonants.Add('b', 0);
            consonants.Add('c', 0);
            consonants.Add('d', 0);
            consonants.Add('f', 0);
            consonants.Add('g', 0);
            consonants.Add('h', 0);
            consonants.Add('j', 0);
            consonants.Add('k', 0);
            consonants.Add('l', 0);
            consonants.Add('m', 0);
            consonants.Add('n', 0);
            consonants.Add('p', 0);
            consonants.Add('q', 0);
            consonants.Add('r', 0);
            consonants.Add('s', 0);
            consonants.Add('t', 0);
            consonants.Add('u', 0);
            consonants.Add('v', 0);
            consonants.Add('w', 0);
            consonants.Add('x', 0);
            consonants.Add('y', 0);
            consonants.Add('z', 0);

            foreach (char character in input)
            {
                if (vowels.ContainsKey(character))
                {
                    consonants[character]++;
                }

            }

            int sum1 = 0;
            foreach (var item in consonants)
            {
                sum1 = sum1 + item.Value;
            }
            
            values.Add(sum1);
            

            
            
            
        }
    }
}
