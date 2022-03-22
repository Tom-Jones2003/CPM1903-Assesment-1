using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void outputReport(List<int> vals)
        {
            Console.WriteLine("Your Text Contained " + vals[0] + " Upper Case Letters! \n");
            Console.WriteLine("Your Text Also Contained " + vals[1] + " Lower Case Letters! \n");
            Console.WriteLine("Your Text Was " + vals[2] + " Sentences Long! \n");
            Console.WriteLine("Your Text Contained " + vals[3] + " Vowels! \n");
            Console.WriteLine("Your Text Also Contained " + vals[4] + " Consonants! \n");
        }

    }
}
