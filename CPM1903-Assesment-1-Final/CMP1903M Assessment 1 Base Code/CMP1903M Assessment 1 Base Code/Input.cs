using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        public string text = "Nothing";


        public void userInput()
        {
            Console.WriteLine("Please Enter 'm' for manual text input or 'f' to read from a file");
            String Mode = Console.ReadLine();
            if(Mode == "m")
            {
                manualTextInput();
            }

            else if (Mode == "f")
            {
                fileTextInput("");
            }
        }
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public void manualTextInput()
        {
            Console.WriteLine("Please enter a sentence");

            text = Console.ReadLine();

             if(text == null)
            {
                 text = "";
            }

            Console.Write(text);
            
            
        }
        

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public void fileTextInput(string fileName)
        {

            Console.WriteLine("Please Specify File Path: ");
            fileName = Console.ReadLine();
            Console.WriteLine($"You entered {fileName}, Is This Correct? (yes/no)");
            String confirm = Console.ReadLine();
            if(confirm == "yes")
            {
                    text = System.IO.File.ReadAllText(@fileName);
            }
            else if (confirm == "no")
            {
                fileTextInput("");
            }
            
            
        }

    }
}
