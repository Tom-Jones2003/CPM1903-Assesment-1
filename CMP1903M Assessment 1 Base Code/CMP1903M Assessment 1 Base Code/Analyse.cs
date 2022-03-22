﻿using System;
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
                
                if(result == true)
                {
                    upper = upper + 1;
                    
                    
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
                
                if(result == true)
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

            //4. Number of vowels
            // int vowels = 0;

            // for(int i = 0; i < input.Length; i++)
            // {
            //     char letter = input[i];
                
            //     if(letter == 'a' | letter == 'e' | letter == 'i' | letter == 'o' | letter == 'u')
            //     {
            //         vowels++;
                    
            //     }
                
            // }

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
                    vowels[character] = vowels[character] + 1;
                }
                
            }

            int sum = 0;
            foreach(var item in vowels)
            {
                sum = sum + item.Value;
            }
            values.Add(sum);

            //5. Number of consonants
            int consonants = 0;

            for(int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                
                if( letter == 'b' | letter == 'c' | letter == 'd' | letter == 'f' | letter == 'g' | letter == 'h' | letter == 'j'
                  | letter == 'k' | letter == 'l' | letter == 'm' | letter == 'n' | letter == 'p' | letter == 'q' | letter == 'r'
                  | letter == 's' | letter == 't' | letter == 'u' | letter == 'v' | letter == 'w' | letter == 'x' | letter == 'y'
                  | letter == 'z')
                {
                    consonants++;
                    
                }
                 
            }
            values.Add(consonants);
            
            
            
            
        }
    }
}
