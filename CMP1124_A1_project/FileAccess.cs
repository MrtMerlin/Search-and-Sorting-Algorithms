using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileAccessClass
{
    public class FileAccess
    {
        #region Public
        /// <summary>
        /// This method accepts a string varaible which contains the path location of a text file.
        /// It will then open the file, read it and copy the contents into an array for use 
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns>a String arary containing the lines from a text file</returns>
        public string[] readFromTextArray(string strPath)
        {
            try//try to access the file
            {
                return _readFromTextFile(strPath);
            }
            catch//if it fails then...
            {
                Console.WriteLine("there was a problem reading data from the file " + strPath);
                Console.Read();
                string[] error = new string[1];
                return error;
            }
            
        }
        /// <summary>
        /// This method is used to read text from a txt file, it will open the file read the whole text and then store it all as a single string variable
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public string readFromText(string strPath)
        {
            try//try to access the file
            {
                return _readFromText(strPath);
            }
            catch//if it fails then...
            {
                Console.WriteLine("there was a problem reading data from the file " + strPath);
                Console.Read();
                return "";
            }
            
        }
        /// <summary>
        /// This method is used to write the contects of a string to a file.  This will be a new file that is created at the target location
        /// as directed by the strPath variable name
        /// </summary>
        /// <param name="strPath">Path of the file to be written</param>
        /// <param name="strContents">The string contents to be short</param>
        public void writeToFile(string strPath, string strContents)
        {
            try//try to access the file
            {
                _writeToFile(strPath, strContents);
            }
            catch//if it fails then...
            {
                Console.WriteLine("there was a problem writing data to the file " + strPath);
                Console.Read();
            }

        }
        /// <summary>
        /// Writes an array of strings to a file.
        /// </summary>
        /// <param name="strPath"></param>
        /// <param name="strContents"></param>
        public void writeToFile(string strPath, string[] strContents)
        {
            try//try to access the file
            {
                _writeToFile(strPath, strContents);
                
            }
            catch//if it fails then...
            {
                Console.WriteLine("there was a problem writing data to the file " + strPath);
                Console.Read();//pause the program
            }

        }
        /// <summary>
        /// This method is used to remove all text from a txt file, it will open the file clear the whole text 
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public bool emptyFile(string strPath)
        {
            try//try to access the file
            {
                return _emptyFile(strPath);

            }
            catch//if it fails then...
            {
                Console.WriteLine("there was a problem writing data to the file " + strPath);
                Console.Read();//pause the program
                return false;
            } 
        }
        /// <summary>
        /// This method will append text onto a text file at the path with the contents
        /// </summary>
        /// <param name="strPath"></param>
        /// <param name="strContents"></param>
        public void appendToFile(string strPath, string strContents)
        {
            try//try to access the file
            {
                _appendToFile(strPath, strContents);
            }
            catch//if it fails then...
            {
                Console.WriteLine("there was a problem reading data from the file " + strPath);
                Console.Read();
                
            } 
        }
        /// <summary>
        /// Writes an array of strings to a file
        /// </summary>
        /// <param name="strPath"></param>
        /// <param name="strContents"></param>
        public void appendToFile(string strPath, string[] strContents)
        {
            try//try to access the file
            {
                _appendToFile(strPath, strContents);
            }
            catch//if it fails then...
            {
                Console.WriteLine("there was a problem reading data from the file " + strPath);
                Console.Read();

            } 
        }
        #endregion
        #region Private

        //class will read from a text file and output the contents in an array
        private string[] _readFromTextFile(string strPath)
        {
            string[] strFileContainsArray = new string[] { "" };//declare a new string and give it a value

            return strFileContainsArray = File.ReadAllLines(strPath);//assign the variable with the contents of the file
            /*
             * Read All Lines method has been used here because it will read each line of a text file and save each line into a cell in 
             * an array, handy
             */
        }

        //read from the welcome text
        private string _readFromText(string strPath)
        {
            string strTextFileEntry = "";
            return strTextFileEntry = File.ReadAllText(strPath);//read from the welcome text file and takes everything out of it, stores it all as a string
        }

        //write text to a new text file
        private bool _writeToFile(string strPath, string strContents)
        {
            //appends a string to a new line in a file at a location specified in the path
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(strPath, true))
                file.WriteLine(strContents);
            return true; //*****!Need to change*****!
        }

        //write an empty string of text to a text file
        private bool _emptyFile(string strPath)
        {
            //clears the text contents of a given file
            File.WriteAllText(strPath, "");
            return true; //*****!Need to change*****!
        }

        //writes to a file using arrays
        private bool _writeToFile(string strPath, string[] strContents)
        {
            //writes to a file using arrays
            File.WriteAllLines(strPath, strContents);
            return true;//*****!Needs to change!*****
        }

        //appends (adds to) an array to a file
        private void _appendToFile(string strPath, string[] strContents)
        {
            //appends string array to file
            File.AppendAllLines(strPath, strContents);
        }

        //appends (adds to) text to a txt file
        private void _appendToFile(string strPath, string strContents)
        {
            File.AppendAllText(strPath, strContents);
        }

        #endregion

    }
}
