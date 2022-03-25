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
        public string? text = "";


        public void userInput()
        {
            Console.WriteLine("Please Enter 'm' for manual text input or 'f' to read from a file");

            while (true)
            {
                bool success = true;
                var mode = Console.ReadLine();

                switch (mode)
                {
                    case "m":
                        manualTextInput();
                        break;
                    case "f":
                        fileTextInput();
                        break;
                    default:
                        Console.WriteLine("Invalid input mode, please try again:");
                        success = false;
                        break;
                }

                if (success)
                {
                    break;
                }
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

            Console.Write("You've inputted " + text);
            
            
        }
        

        //Method: fileTextInput
        //Gets text input from a .txt file and stores state internally
        public void fileTextInput()
        {
            // repeats whole process of attempting to get a valid path, then confirming it

            Console.WriteLine("Please Specify File Path: ");
            while (true)
            {
                string? filePath = null;
                // process of checking a valid file path
                while (true)
                {

                    filePath = Console.ReadLine();

                    if (File.Exists(filePath))
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("File doesn't exist, please enter a file that exists: ");
                    }
                }

                Console.WriteLine($"You entered {filePath}, Is This Correct? (yes/no)");

                // process of confirming user input
                while (true)
                {
                    string? confirm = Console.ReadLine();
                    bool retry_path_asking = false;

                    switch (confirm)
                    {
                        case "yes":
                            // get text, exit function
                            text = File.ReadAllText(filePath);
                            return;
                        case "no":
                            // user will get to attempt the file path entering again
                            Console.WriteLine("Please write the correct file path: ");
                            break;
                        default:
                            // unknown input, make the user try again
                            Console.WriteLine("Invalid input, please enter yes or no: ");
                            retry_path_asking = true;
                            break;
                    }

                    if (retry_path_asking)
                    {
                        break;
                    }
                }
            }
        }

    }
}
