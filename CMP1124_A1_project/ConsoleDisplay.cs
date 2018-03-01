using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * This is an class tasked with interfacing the code to the Console Window
 * There is no need to change this code as it is not part of the assessment
 */

namespace DisplayClass
{
    public class Display
    {
        #region Private Methods
        /***************************************************************************************************/
        //a method used to readline user input
        private string _userInput()
        {
            string strUserInput;
            return strUserInput = Console.ReadLine();
        }
        /***************************************************************************************************/
        //write text to screen
        private bool _screenWrite(string strScreenOutput)
        {
            Console.WriteLine(strScreenOutput);
            return true;
        }
        /***************************************************************************************************/
        //sets the console size
        private bool _setConsoleSize(int x, int y)
        {
            Console.SetWindowSize(x, y);
            //the above sets size and position of the cmd window
            return true;//***!Need to change this result!***
        }
        /***************************************************************************************************/
        //used to determine if everything has worked.
        private bool _confirmCompletion()
        {
            return true;
        }
        /***************************************************************************************************/
        //sets the console title
        private bool _setConsoleTitle(string strTitle)
        {
            Console.Title = strTitle;//sets the Console title
            return true;
        }
        /***************************************************************************************************/
        //sets up the display for any system
        private bool _setUpScreen(String strWelcomeFileLocation, string strWindowTitle, string strMenuItems)
        {
            //ConsoleControl contentObj = new ConsoleControl();
            bool boolContinue = true;
            while (boolContinue == true)
            {
                //string strWelcomeTextPath;//string filled from file

                //strWelcomeTextPath = contentObj.welcome(strWelcomeFileLocation, strMenuItems);//reads in the welcome text

                //_screenWrite(strWelcomeTextPath);//Writes the welcome text to the main screen

               // boolContinue = contentObj.request(boolContinue);//works out what the user wants

                #region TEST
#if TESTING
                testPause();//pauses the command
#endif//this #if will on apply if #define TESTING is true.  This means that if the program is being tested (as defined by the TESTING) then it will do the above
                #endregion

                if (boolContinue == false)
                {
                    _screenWrite("\nPress any key to Exit.");
                }
                else
                {
                    _screenWrite("\nPress any key to continue.  Warning this will refresh the screen.\n");
                }

                _userInput();

                Console.Clear();//clears the screen
            }
            return boolContinue;
        }
        /***************************************************************************************************/
        //screen print text file.  !*This is used for testing purposes only*!
        private void _printTextFile(string[] textFileArray)
        {
            //Will print the contents of an array to the screen line by line
            for (int i = 0; i <= textFileArray.Length - 1; i++)
            {
                _screenWrite(textFileArray[i]);
            }
        }
        /***************************************************************************************************/
        private void _clearScreen()
        {
            Console.Clear();
        }
        /***************************************************************************************************/
        /*** checks a string - returns true if it only contains numbers ***/
        /***************************************************************************************************/
        private bool _isANumber(String _strInput)
        {
            //checks the given string to ensure that no text or symbols are in it
            //Returns true if the string can be converted into an integer
            bool _boolIsNumber = true;
            for(int _count = 0; _count < _strInput.Length; _count++)
            {
                //get the char 
                char _selectedChar = Convert.ToChar(_strInput[_count]);
                //check the char is an integer (ASCII Code 47 - 57 represent chars 0,1,2,3,4,5,6,7,8 and 9)
                if (((Convert.ToInt16(_selectedChar)) < 47) || ((Convert.ToInt16(_selectedChar)) > 58))
                {
                    _boolIsNumber = false; // a non integer value has been found
                }
            }
            return _boolIsNumber;
        }
        /***************************************************************************************************/
        private string _isADay(String _strInput)
        {
            //checks the given string to ensure that no text or symbols are in it
            //Returns true if the string can be converted into a day name
            string _dayString = null;
            string first2Letters;
            for (int _count = 0; _count < _strInput.Length-1; _count++)
            {
                //get the char 
                first2Letters = ""+ _strInput[_count] + _strInput[_count+ 1];

                switch (first2Letters.ToLower())
                {
                    case "mo":
                        {
                            _dayString = "Monday";
                            break;
                        }
                    case "tu":
                        {
                            _dayString = "Tuesday";
                            break;
                        }
                    case "we":
                        {
                            _dayString = "Wednesday";
                            break;
                        }
                    case "th":
                        {
                            _dayString = "Thursday";
                            break;
                        }
                    case "fr":
                        {
                            _dayString = "Friday";
                            break;
                        }
                    case "sa":
                        {
                            _dayString = "Saturday";
                            break;
                        }
                    case "su":
                        {
                            _dayString = "Sunday";
                            break;
                        }
                }
            }
            return _dayString;
        }
        /***************************************************************************************************/
        /// <summary>
        /// This method will read in information provided and confirm it is a date in the format dd/mm/yyyy
        /// </summary>
        /// <returns></returns>
        private bool _isADate(String _strInput)
        {
            //checks the given string to ensure that no text or symbols are in it
            //Returns true if the string can be converted into a date
            bool _boolIsDate = true;
            DateTime  stringIsDate;
            IFormatProvider culture = new System.Globalization.CultureInfo("en-gb", true);//ensure that date is read in UK format (Not US)

            //check 1s2 2 chars are numbers
            try
            {
                stringIsDate = DateTime.Parse(_strInput, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            }
            catch
            {
                _boolIsDate = false;
            }
            
            return _boolIsDate;
        }
        /***************************************************************************************************/
        /// <summary>
        /// This method will read in information provided and confirm it is a boolean -1 = bad input, 0 = false, 1 = true
        /// </summary>
        /// <returns></returns>
        private int isBoolean(string _strInput)
        {
            //checks the given string to ensure that no text or symbols are in it
            //Returns true if the string can be converted into an integer
            int _boolIsNumber = -1;

            if (_strInput[0] == 't' || _strInput[0] == 'T' || _strInput[0] == 'y' || _strInput[0] == 'Y')
            {
                _boolIsNumber = 1;
            }
            else
            {
                if (_strInput[0] == 'f' || _strInput[0] == 'F' || _strInput[0] == 'n' || _strInput[0] == 'N')
                {
                    _boolIsNumber = 0;
                }
            }
            return _boolIsNumber;
        }
        /*************************************************************************************************/
        private string _showTextWithTab(string _textToDisplay, int _indent, char _character)
        {
            int spaces = _textToDisplay.Length;
            string firstGap = "";
            for (int index = 0; index <= (_indent - spaces); index++)
            {
                firstGap = firstGap + _character.ToString();
            }
            firstGap = _textToDisplay + firstGap;
            return firstGap;
        }
        /*************************************************************************************************/

        #region Test
#if TESTING
        //sets up the display for the library system
        private bool _setUpScreen(bool boolContinue)
        {
            while (boolContinue == true)
            {
                string[] strTextFileArray;//string array
                string strWelcomeTextPath;//string

                strWelcomeTextPath = ioFile.readFromText("../../../welcomeText.txt");//reads in the welcome text
                strTextFileArray = ioFile.readFromTextFile("../../../TextFile.txt");//feeds in a path for the text file

                int intWindowHeight = 45;
                int intWindowWidth = 150;
                Console.SetWindowSize(intWindowWidth, intWindowHeight);
                //the above sets size and position of the cmd window

                Console.Title = "Library System";//Changes the title of the CMD

                _screenWrite(strWelcomeTextPath);//Writes the welcome text to the main screen

                boolContinue = _request(boolContinue);//workout what the user wants

                
                //_screenWrite("\n");//adds a new line after the readkey


        #region TEST
#if TESTING
                testPause();//pauses the command
                _printTextFile(strTextFileArray);//send the array to the screen to show the user
#endif//this #if will on apply if #define TESTING is true.  This means that if the program is being tested (as defined by the TESTING) then it will do the above
                

                if (boolContinue == false)
                {
                    _screenWrite("\nPress any key to Exit.");
                }
                else
                {
                    _screenWrite("\nPress any key to continue.  Warning this will refresh the screen.\n");
                }

                _userInput();
                Console.Clear();//clears the screen
            }
            return boolContinue;
        }
        #endregion
#endif
        #endregion

        #endregion

        #region Public Methods

        /***************************************************************************************************/
        /// <summary>
        /// method used to set the size of the console
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool setConsoleSize(int x, int y)
        {
            _setConsoleSize(x, y);
            return true;
        }
        /***************************************************************************************************/
        /// <summary>
        /// Sets the title of the CMD window
        /// </summary>
        /// <param name="strTitle"></param>
        /// <returns></returns>
        public bool setConsoleTitle(string strTitle)
        {
            _setConsoleTitle(strTitle);
            return true;
        }
        /***************************************************************************************************/
        /// <summary>
        /// Writes an input to the screen
        /// </summary>
        /// <param name="strOutput"></param>
        public void screenWrite(string strOutput)
        {
            _screenWrite(strOutput);
        }
        /***************************************************************************************************/
        /// <summary>
        /// This method will read in information from the user
        /// </summary>
        /// <returns></returns>
        public string userInput()
        {
            return _userInput();
        }
        /***************************************************************************************************/
        /// <summary>
        /// This method will read in information from the user and provide a prompt and demand an integer
        /// </summary>
        /// <returns></returns>
        public int userInputAsInteger(string srtPrompt)
        {
            string _inputtedChars;
            do //loop until a number was entered
            {
                _inputtedChars = userInput(srtPrompt);
            }
            while (!_isANumber(_inputtedChars) || _inputtedChars == ""); //only escape the loop if the input is an integer
                        
            return Convert.ToInt32(_inputtedChars);
        }
        /***************************************************************************************************/
        /// <summary>
        /// This method will read in information from the user and provide a prompt and demand an boolean
        /// </summary>
        /// <returns></returns>
        public bool userInputAsBoolean(string srtPrompt)
        {
            string _inputtedText;
            bool _decision;
            do //loop until a number was entered
            {
                _inputtedText = userInput(srtPrompt + " enter T, F, Y or N as desired");
            }
            while (isBoolean(_inputtedText) == -1); //escape the loop if the input is a boolean (starts with T of F)

            if(isBoolean(_inputtedText) == 1)
            {
                _decision = true;
            }
            else
            {
                _decision = false;
            }
            return _decision;
        }
        /***************************************************************************************************/
        /// <summary>
        /// This method will read in information from the user and provide a prompt and demand a day (Monday, Tuesday etc.)
        /// </summary>
        /// <returns>returns a string object</returns>
        public string userInputAsDay(string srtPrompt)
        {
            string _inputtedText; 
            string dayFound = null;
            do //loop until a number was entered
            {
                _inputtedText = userInput(srtPrompt + " enter the day of the week you want: ");
                dayFound = _isADay(_inputtedText);
            }
            while (dayFound == null); //escape the loop if the input is recognised as a day 

            return dayFound;
        }
        /***************************************************************************************************/
        /// <summary>
        /// This method will read in information from the user and provide a prompt and demand a date in the fromat dd/mm/yyyy
        /// </summary>
        /// <returns>returns a dateTime object</returns>
        public DateTime userInputAsDate(string srtPrompt)
        {
            string _inputtedText;
            DateTime _decision;
            do //loop until a number was entered
            {
                _inputtedText = userInput(srtPrompt + " enter the date as dd/mm/yyyy format");
            }
            while (!_isADate(_inputtedText)); //escape the loop if the input is a boolean (starts with T of F)

           // DateTime  stringIsDate;
            IFormatProvider culture = new System.Globalization.CultureInfo("en-gb", true);//ensure that date is read in UK format (Not US)
            _decision = DateTime.Parse(_inputtedText, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            return _decision;
        }
        /***************************************************************************************************/
        /// <summary>
        /// This method takes a string and the space it will fit in as an integer and what character is to be used to fill the spaces
        /// </summary>
        public void writeTextwithTab(string _textToDisplay, int _indent, char _character)
        {
            Console.WriteLine(_showTextWithTab(_textToDisplay, _indent, _character));
        } 
        /***************************************************************************************************/
        /// <summary>
        /// This method will read in information from the user and provide a prompt
        /// </summary>
        /// <returns></returns>
        public string userInput(string srtPrompt)
        {
            _screenWrite(srtPrompt);
            return _userInput();
        }
        /***************************************************************************************************/
        /// <summary>
        /// Sets up the screen for the Library system. Requires the file path for welcome text and name for the window
        /// </summary>
        public bool setUpScreen(string strWelcomeTextPath, string strWindowTitle, string strMenuItems)
        {
            return _setUpScreen(strWelcomeTextPath, strWindowTitle, strMenuItems);
        }
        /***************************************************************************************************/
        /// <summary>
        /// Removes all text from the window
        /// </summary>
        public void clearScreen()
        {
            _clearScreen();
        }
        /***************************************************************************************************/       
        /// <summary>
        /// Pauses the screen and waits for user to press Enter
        /// </summary>
        public void testPause()
        {
            Console.ReadKey();
        }


#if TESTING
        public bool setUpScreen(bool boolContinue)
        {
            return _setUpScreen(boolContinue);
        }
#endif
        #endregion

    }
}
