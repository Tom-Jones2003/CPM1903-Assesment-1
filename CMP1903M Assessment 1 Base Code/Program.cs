//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input handleInput = new Input();
            handleInput.userInput();
            

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Analyse analysis = new Analyse();
            analysis.analyseText(handleInput.text);
            

            //Report the results of the analysis
            Report output = new Report();
            output.outputReport(analysis.values);
            

            //TO ADD: Get the frequency of individual letters?

           Console.ReadKey();
        }
        
        
    
    }
}
