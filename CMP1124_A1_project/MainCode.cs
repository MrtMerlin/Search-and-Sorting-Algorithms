using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; //for stopwatch
using System.Threading; //for thread.sleep

/*
 * This is the Main Class used to start your project
 * There is no need to change this code as it is not part of the assessment
 */
namespace AlgorithmAss1
{
    class AlgorithmMain
    {
        #region class variables
        //**************** CLASS VARIABLES *************
        /* we need to work with file so we create an instance of the FileAccessClass object called 'libraryFileController' */
        private FileAccessClass.FileAccess fileController = new FileAccessClass.FileAccess();
        /* We need to work with the console/display so we create an instance of the DisplayClass object called 'libraryConsole' */
        private DisplayClass.Display progConsole = new DisplayClass.Display();

        //Store the data friom the given files

        private List<StoredData> bank2Data = new List<StoredData>();

        // Add the sorting algorithm object
        private SortingAlgorithms sortObject = new SortingAlgorithms();
        private SearchAlgorithms searchObject = new SearchAlgorithms();

        //Add a diagnostics Class Object to receive search/sort requests
        private Diagnostics diagnosticTool = new Diagnostics();
        // Timespan is required to provide the time taken by the algoritms
        private List<TimeSpan> timesTaken = new List<TimeSpan>();
        private List<string> testName = new List<string>();
        //The stopwatch attribute is used in the timing of the algorithms
        private Stopwatch stopWatch = new Stopwatch();
        //**************** CLASS VARIABLES *************
        #endregion class variables
        static void Main(string[] args)
        {
            //run the console
            AlgorithmMain myProject = new AlgorithmMain();
            myProject.run();
        }
        //*****************************************************************************************
        #region start, load and initialise
        private void run()
        {
            initialiseSystem();
            while (userOptions()) /*run the loop until Exit is entered */
            { }

            // Process.GetCurrentProcess().CloseMainWindow();

        }
        //*****************************************************************************************
        private void initialiseSystem()
        {
            //Load text from files and display via the console window
            //Set up the console's window size
            progConsole.setConsoleSize(115, 35);
            //Give the console's window a title
            progConsole.setConsoleTitle("Algorithms Assignment ideas");
            //fileController.readFromTextArray("../../../textfiles/Day.txt");
            //read in from the welcome text file and display it's contents in the console
            progConsole.screenWrite(fileController.readFromText("../../../textfiles/WelcomeText.txt"));
            //read in from the options text file and display it's contents in the console
        }
        //*****************************************************************************************
        //*** LOAD THE DATA FROM THE TEXT FILES ***
        //*****************************************************************************************
        private List<StoredData> loadSharesData()
        {
            /*the program collects data from several files 
             * each entry links to the respective entries in the other files
             * i.e the leftHandValue entry in the 'day text' file corresponds to the leftHandValue entry of all of the other files
             * hence for SH1 (Lloyds);
             * Day      Date            Open        Close   Diff    Volume
             * Monday,  16/02/2015,     75.260,     75.730, 0.470,  68182943    
             * */
            String[] _strDay;//to store the text received from the file
            String[] _strDate;//to store the text received from the file
            String[] _strOpen;//to store the text received from the file
            String[] _strClose;//to store the text received from the file
            String[] _strDifference;//to store the text received from the file
            String[] _strVolume;//to store the text received from the file
            List<StoredData> bank1Data = new List<StoredData>();

            //_________________________________________________________________________________
            //             
            //read in data from files - 200 entries!
            _strDay = fileController.readFromTextArray("../../../textfiles/SharesData_Day.txt");
            _strDate = fileController.readFromTextArray("../../../textfiles/SharesData_Date.txt");
            _strOpen = fileController.readFromTextArray("../../../textfiles/SharesData_Open.txt");
            _strClose = fileController.readFromTextArray("../../../textfiles/SharesData_Close.txt");
            _strDifference = fileController.readFromTextArray("../../../textfiles/SharesData_Diff.txt");
            _strVolume = fileController.readFromTextArray("../../../textfiles/SharesData_Volume.txt");
            //get day, date, and all bank1's data and place it in a list of StoredData
            //Parse through the data and place each cross file data into a List of 'StoredData' objects
            DateTime dateOfTx;
            IFormatProvider culture = new System.Globalization.CultureInfo("en-gb", true);//ensure that date is read in UK format (Not US)
            for (int _index = 0; _index < _strOpen.Count(); _index++)
            {
                //convert date to a DateTime data type                
                dateOfTx = DateTime.Parse(_strDate[_index], culture, System.Globalization.DateTimeStyles.AssumeLocal);
                StoredData dataIn = new StoredData(_strDay[_index], dateOfTx, _strOpen[_index], _strClose[_index], _strDifference[_index], _strVolume[_index]);
                bank1Data.Add(dataIn);
            }
            return bank1Data;
        }
        //*****************************************************************************************
        private List<StoredData> loadOptionalSharesData()
        {
            //Used to include full data for comparing the same algorithm of a second size of data

            //read in data from files - 2,000 entries
            /*the program collects data from several files 
             * each entry links to the respective entries in the other files
             * i.e the leftHandValue entry in the 'day text' file corresponds to the leftHandValue entry of all of the other files
             * hence for SH1 (Lloyds);
             * Day      Date            Open        Close   Diff    Volume
             * Monday,  16/02/2015,     75.260,     75.730, 0.470,  68182943    
             * */
            String[] _strDay;//to store the text received from the file
            String[] _strDate;//to store the text received from the file
            String[] _strOpen;//to store the text received from the file
            String[] _strClose;//to store the text received from the file
            String[] _strDifference;//to store the text received from the file
            String[] _strVolume;//to store the text received from the file
            List<StoredData> bank2Data = new List<StoredData>();

            //read in data from files for bank2 - 2000 entries
            _strDay = fileController.readFromTextArray("../../../textfiles/ExtSharesData_Day.txt");
            _strDate = fileController.readFromTextArray("../../../textfiles/ExtSharesData_Date.txt");
            _strOpen = fileController.readFromTextArray("../../../textfiles/ExtSharesData_Open.txt");
            _strClose = fileController.readFromTextArray("../../../textfiles/ExtSharesData_Close.txt");
            _strDifference = fileController.readFromTextArray("../../../textfiles/ExtSharesData_Diff.txt");
            _strVolume = fileController.readFromTextArray("../../../textfiles/ExtSharesData_Volume.txt");
            //get day, date, and all bank2's data and place it in a list of StoredData
            //Parse through the data and place each cross file data into a List of 'StoredData' objects
            DateTime dateOfTx;
            IFormatProvider culture = new System.Globalization.CultureInfo("en-gb", true);//ensure that date is read in UK format (Not US)

            for (int _index = 0; _index < _strOpen.Count(); _index++)
            {
                //convert date to a DateTime data type                
                dateOfTx = DateTime.Parse(_strDate[_index], culture, System.Globalization.DateTimeStyles.AssumeLocal);
                StoredData dataIn = new StoredData(_strDay[_index], dateOfTx, _strOpen[_index], _strClose[_index], _strDifference[_index], _strVolume[_index]);
                bank2Data.Add(dataIn);
            }
            return bank2Data;
        }
        #endregion start, load and initialise
        //*****************************************************************************************
        #region user Options
        /*************************************************************************************************/
        /* User options  */
        /*************************************************************************************************/
        private bool userOptions()
        {
            //use case switch in a while loop here
            //decide on what to compare
            int _selection = 1;
            int _intChoice;
            do
            {
                progConsole.screenWrite(fileController.readFromText("../../../textfiles/choiceOfDataToCompare.txt"));
                //Get user's input on choice of datasets
                _selection = progConsole.userInputAsInteger("\n*** select option by its number and press enter ***\n");
            } while (!(_selection > 0 && _selection < 5));
            // get the lists as chosen above
            List<StoredData> firstList = new List<StoredData>();
            List<StoredData> secondList = new List<StoredData>();
            string firstListType = "", secondListType = "";
            switch (_selection)
            {
                case 1:
                    {
                        firstList = loadSharesData();
                        secondList = loadSharesData();
                        firstListType = "200 elements";
                        secondListType = "200 elements";
                        break;
                    }
                case 2:
                    {
                        firstList = loadOptionalSharesData();
                        secondList = loadSharesData();
                        firstListType = "2,000 elements";
                        secondListType = "200 elements";
                        break;
                    }
                case 3:
                    {
                        firstList = loadSharesData();
                        secondList = loadOptionalSharesData();
                        firstListType = "200 elements";
                        secondListType = "2,000 elements";
                        break;
                    }
                case 4:
                    {
                        firstList = loadOptionalSharesData();
                        secondList = loadOptionalSharesData();
                        firstListType = "2,000 elements";
                        secondListType = "2,000 elements";
                        break;
                    }
            }
            //Method to react to the users input
            progConsole.screenWrite(fileController.readFromText("../../../textfiles/Options.txt"));
            bool _boolContinue = true;  //used so a loop control can be used with this method
            /* get an integer via keyboard input */
            _intChoice = progConsole.userInputAsInteger("\n*** select option by its number and press enter ***\n");
            //Check if it is within the range of options
            if (_intChoice < 18)
            {
                switch (_intChoice)
                {
                    /***************************************************************************************************/
                    case 1:
                        {
                            //List Date Ascending and display
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Listing in Date Ascending Order ***\n");
                            // sortDateAscendingA1 is the 1st algorithm
                            // sortDateAscendingA2 is the rightHandValue algorithm
                            // loadSharesData() is the function that provides the small sub-list of data for the shares
                            // loadOptionalSharesData() is the function that provides the large list of data for the shares
                            displayDoubleSortArray(diagnosticTool.sortDateAscendingA1(firstList), diagnosticTool.sortDateAscendingA2(secondList));
                            break;
                        }
                    case 2://List Date Descending 
                        {
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Listing in Date Descending Order ***\n");
                            displayDoubleSortArray(diagnosticTool.sortDateDescendingA1(firstList), diagnosticTool.sortDateDescendingA2(secondList));
                            break;
                        }
                    case 3://List Opening Price Ascending  
                        {
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Listing in Opening Price Ascending Order (low to high) ***\n");
                            displayDoubleSortArray(diagnosticTool.sortOpenAscendingA1(firstList), diagnosticTool.sortOpenAscendingA2(secondList));
                            break;
                        }
                    case 4://List Opening Price Descending 
                        {
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Listing in Opening Price Descending Order (high to low) ***\n");
                            displayDoubleSortArray(diagnosticTool.sortOpenDescendingA1(firstList), diagnosticTool.sortOpenDescendingA2(secondList));
                            break;
                        }
                    case 5://List Closing Price Ascending
                        {
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Listing in Closing Price Ascending Order (low to high) ***\n");
                            displayDoubleSortArray(diagnosticTool.sortCloseAscendingA1(firstList), diagnosticTool.sortCloseAscendingA2(secondList));
                            break;
                        }
                    case 6://List Closing Price Descending 
                        {
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Listing in Closing Price Descending Order (high to low) ***\n");
                            displayDoubleSortArray(diagnosticTool.sortCloseDescendingA1(firstList), diagnosticTool.sortCloseDescendingA2(secondList));
                            break;
                        }
                    case 7://List Volume of sales Ascending
                        {
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Listing in Volume of Sales Ascending Order ***\n");
                            displayDoubleSortArray(diagnosticTool.sortVolAscendingA1(firstList), diagnosticTool.sortVolAscendingA2(secondList));
                            break;
                        }
                    case 8://List List Volume of sales Descending
                        {
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Listing in Volume of Sales Descending Order ***\n");
                            displayDoubleSortArray(diagnosticTool.sortVolDescendingA1(firstList), diagnosticTool.sortVolDescendingA2(secondList));
                            break;
                        }
                    case 9://List difference of sales Ascending
                        {
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Listing in Difference of Price Ascending Order ***\n");
                            displayDoubleSortArray(diagnosticTool.sortDiffAscendingA1(firstList), diagnosticTool.sortDiffAscendingA2(secondList));
                            break;
                        }
                    case 10://List difference of sales Descending 
                        {
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Listing in Difference of Price Descending Order ***\n");
                            displayDoubleSortArray(diagnosticTool.sortDiffDescendingA1(firstList), diagnosticTool.sortDiffDescendingA2(secondList));
                            break;
                        }
                    case 11://List days Ascending  
                        {
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Listing in Days Asscending Order ***\n");
                            displayDoubleSortArray(diagnosticTool.sortDayAscendingA1(firstList), diagnosticTool.sortDayAscendingA2(secondList));
                            break;
                        }
                    case 12://List days Descending 
                        {
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Listing in Difference of Price Descending Order ***\n");
                            displayDoubleSortArray(diagnosticTool.sortDayDescendingA1(firstList), diagnosticTool.sortDayDescendingA2(secondList));
                            break;
                        }
                    case 13://Search for data by the date
                        {
                            DateTime searchDate = progConsole.userInputAsDate("Searching by the Date");

                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Your search for  ***\n");
                            displayDoubleSearchArray(diagnosticTool.searchLinearByDateA1(firstList, searchDate), diagnosticTool.searchLinearByDateA2(secondList, searchDate));
                            break;
                        }
                    case 14://Search for data by the day
                        {
                            String searchDays = progConsole.userInputAsDay("Searching by the Day given - Mon, Tues etc. ");
                            progConsole.screenWrite("\n*** (" + firstListType + " vs " + secondListType + ") Your search for  ***\n");
                            displayDoubleSearchArray(diagnosticTool.searchByDayA1(firstList, searchDays), diagnosticTool.searchByDayA2(secondList, searchDays));
                            break;
                        }
                    case 15://Exit the program searchLinearByDate
                        {
                            _boolContinue = false;
                            break;
                        }
                }
                //pause for viewing
                if (_boolContinue)
                    Console.ReadLine();//pause screen

            }
            return _boolContinue;
        }
        /*************************************************************************************************/
        #endregion user Options
        /*************************************************************************************************/
        #region private methods
        /*************************************************************************************************/
        private void displaySingleArray(List<StoredData> dataToDisplay)
        {
            //
            int lastIndex = 0;
            string theDay, theDate, openValue, closeValue, diffValue, volumeValue;
            string heading = "__Day___________Date____Opening Price__Closing Price__Difference_______Volume";
            progConsole.screenWrite(heading);
            for (int index = 0; index < dataToDisplay.Count(); index++)
            {
                theDay = dataToDisplay[index].TxDay;
                theDate = dataToDisplay[index].TxDate.ToShortDateString();
                openValue = dataToDisplay[index].Sh_open;
                closeValue = dataToDisplay[index].Sh_close;
                diffValue = dataToDisplay[index].Sh_diff;
                volumeValue = dataToDisplay[index].Sh_volume;

                // Console.WriteLine(tempLine);
                progConsole.screenWrite(_showTextWithTab(theDay, 12, ' ') +
                _showTextWithTab(theDate, 13, ' ') +
                _showTextWithTab(openValue, 15, ' ') +
                _showTextWithTab(closeValue, 18 - diffValue.Length, ' ') +
                _showTextWithTab(diffValue, diffValue.Length + 15 - volumeValue.Length, ' ') +
                _showTextWithTab(volumeValue, 10, ' '));
                ;
                lastIndex = index;
            }
            Console.WriteLine(dataToDisplay[lastIndex].SearchTypeAndTime);
        }
        /*************************************************************************************************/
        private void displayDoubleSortArray(List<StoredData> firstDataToDisplay, List<StoredData> secondDataToDisplay)
        {
            //
            int totalLines = progConsole.userInputAsInteger("How many rows do you want to list? Note there are a max of " + firstDataToDisplay.Count().ToString() + " rows and a minimum of 2 rows");
            int lastIndex = 0;
            string theDay1, theDate1, openValue1, closeValue1, diffValue1, volumeValue1;
            string theDay2, theDate2, openValue2, closeValue2, diffValue2, volumeValue2;

            string heading = "__Day_______Date_______Open___Close__Diff_____Volume_______||______Day_______Date_______Open___Close__Diff_____Volume\n";
            progConsole.screenWrite(heading);
            if (totalLines > firstDataToDisplay.Count())
            {
                //prevent the user requesting more lines than are stored in the lists
                totalLines = firstDataToDisplay.Count();
            }
            else if (totalLines < 2)
            {
                totalLines = 2;
            }

            //present first half of the data set
            for (int index = 0; index < totalLines / 2; index++) //show leftHandValue top elements
            {
                theDay1 = firstDataToDisplay[index].TxDay;
                theDate1 = firstDataToDisplay[index].TxDate.ToShortDateString();
                openValue1 = firstDataToDisplay[index].Sh_open;
                closeValue1 = firstDataToDisplay[index].Sh_close;
                diffValue1 = firstDataToDisplay[index].Sh_diff;
                volumeValue1 = firstDataToDisplay[index].Sh_volume;
                //-------------------------------------------------------------
                theDay2 = secondDataToDisplay[index].TxDay;
                theDate2 = secondDataToDisplay[index].TxDate.ToShortDateString();
                openValue2 = secondDataToDisplay[index].Sh_open;
                closeValue2 = secondDataToDisplay[index].Sh_close;
                diffValue2 = secondDataToDisplay[index].Sh_diff;
                volumeValue2 = secondDataToDisplay[index].Sh_volume;
                //-------------------------------------------------------------

                progConsole.screenWrite(_showTextWithTab(theDay1, 10, ' ') +
                _showTextWithTab(theDate1, 11, ' ') +
                _showTextWithTab(openValue1, 6, ' ') +
                _showTextWithTab(closeValue1, 11 - diffValue1.Length, ' ') +
                _showTextWithTab(diffValue1, diffValue1.Length + 10 - volumeValue1.Length, ' ') +
                _showTextWithTab(volumeValue1, 5 + volumeValue1.Length, ' ') + "|| " +

                _showTextWithTab(theDay2, 10, ' ') +
                _showTextWithTab(theDate2, 11, ' ') +
                _showTextWithTab(openValue2, 6, ' ') +
                _showTextWithTab(closeValue2, 11 - diffValue2.Length, ' ') +
                _showTextWithTab(diffValue2, diffValue2.Length + 10 - volumeValue2.Length, ' ') +
                _showTextWithTab(volumeValue2, 10, ' '));
                ;
                // lastIndex = index;
            }
            //present the final half of the dataset
            int initialLastSetCount = firstDataToDisplay.Count() - totalLines / 2;
            int secondLastSetCount = secondDataToDisplay.Count() - totalLines / 2;

            progConsole.screenWrite("----------------------------------------------------------------------------------------------------------------------");
            for (int index = 0; index < totalLines / 2; index++) //show bottom elements
            {

                theDay1 = firstDataToDisplay[index + initialLastSetCount].TxDay;
                theDate1 = firstDataToDisplay[index + initialLastSetCount].TxDate.ToShortDateString();
                openValue1 = firstDataToDisplay[index + initialLastSetCount].Sh_open;
                closeValue1 = firstDataToDisplay[index + initialLastSetCount].Sh_close;
                diffValue1 = firstDataToDisplay[index + initialLastSetCount].Sh_diff;
                volumeValue1 = firstDataToDisplay[index + initialLastSetCount].Sh_volume;



                //-------------------------------------------------------------
                theDay2 = secondDataToDisplay[index + secondLastSetCount].TxDay;
                theDate2 = secondDataToDisplay[index + secondLastSetCount].TxDate.ToShortDateString();
                openValue2 = secondDataToDisplay[index + secondLastSetCount].Sh_open;
                closeValue2 = secondDataToDisplay[index + secondLastSetCount].Sh_close;
                diffValue2 = secondDataToDisplay[index + secondLastSetCount].Sh_diff;
                volumeValue2 = secondDataToDisplay[index + secondLastSetCount].Sh_volume;
                //-------------------------------------------------------------

                // Console.WriteLine(tempLine);
                progConsole.screenWrite(_showTextWithTab(theDay1, 10, ' ') +
                _showTextWithTab(theDate1, 11, ' ') +
                _showTextWithTab(openValue1, 6, ' ') +
                _showTextWithTab(closeValue1, 11 - diffValue1.Length, ' ') +
                _showTextWithTab(diffValue1, diffValue1.Length + 10 - volumeValue1.Length, ' ') +
                _showTextWithTab(volumeValue1, 5 + volumeValue1.Length, ' ') + "|| " +

                _showTextWithTab(theDay2, 10, ' ') +
                _showTextWithTab(theDate2, 11, ' ') +
                _showTextWithTab(openValue2, 6, ' ') +
                _showTextWithTab(closeValue2, 11 - diffValue2.Length, ' ') +
                _showTextWithTab(diffValue2, diffValue2.Length + 10 - volumeValue2.Length, ' ') +
                _showTextWithTab(volumeValue2, 10, ' '));
                ;
                lastIndex = index;
            }
            progConsole.screenWrite(heading);

            Console.WriteLine(firstDataToDisplay[0].SearchTypeAndTime + " || " + secondDataToDisplay[0].SearchTypeAndTime);
            Console.WriteLine(" This used " + firstDataToDisplay[0].CountRepetitions.ToString() + " iterations || This used " + secondDataToDisplay[0].CountRepetitions.ToString() + " iterations");
        }

        /*************************************************************************************************/
        private void displayDoubleSearchArray(List<StoredData> firstDataToDisplay, List<StoredData> secondDataToDisplay)
        {
            //
            // int totalLines = progConsole.userInputAsInteger("How many rows do you want to list? Note there are a max of " + firstDataToDisplay.Count().ToString() + " rows and a minimum of 2 rows");
            // int lastIndex = 0;
            string theDay1, theDate1, openValue1, closeValue1, diffValue1, volumeValue1;
            string theDay2, theDate2, openValue2, closeValue2, diffValue2, volumeValue2;

            string heading = "__Day_______Date_______Open___Close__Diff_____Volume_______||______Day_______Date_______Open___Close__Diff_____Volume\n";
            progConsole.screenWrite(heading);

            /********************/
            for (int i = 0; i < firstDataToDisplay.Count(); i++)
            {
                theDay1 = firstDataToDisplay[i].TxDay;
                theDate1 = firstDataToDisplay[i].TxDate.ToShortDateString();
                openValue1 = firstDataToDisplay[i].Sh_open;
                closeValue1 = firstDataToDisplay[i].Sh_close;
                diffValue1 = firstDataToDisplay[i].Sh_diff;
                volumeValue1 = firstDataToDisplay[i].Sh_volume;
                //-------------------------------------------------------------
                theDay2 = secondDataToDisplay[i].TxDay;
                theDate2 = secondDataToDisplay[i].TxDate.ToShortDateString();
                openValue2 = secondDataToDisplay[i].Sh_open;
                closeValue2 = secondDataToDisplay[i].Sh_close;
                diffValue2 = secondDataToDisplay[i].Sh_diff;
                volumeValue2 = secondDataToDisplay[i].Sh_volume;
                //-------------------------------------------------------------
                progConsole.screenWrite(_showTextWithTab(theDay1, 10, ' ') +
                _showTextWithTab(theDate1, 11, ' ') +
                _showTextWithTab(openValue1, 6, ' ') +
                _showTextWithTab(closeValue1, 11 - diffValue1.Length, ' ') +
                _showTextWithTab(diffValue1, diffValue1.Length + 10 - volumeValue1.Length, ' ') +
                _showTextWithTab(volumeValue1, 5 + volumeValue1.Length, ' ') + "||    " +

                _showTextWithTab(theDay2, 10, ' ') +
                _showTextWithTab(theDate2, 11, ' ') +
                _showTextWithTab(openValue2, 6, ' ') +
                _showTextWithTab(closeValue2, 11 - diffValue2.Length, ' ') +
                _showTextWithTab(diffValue2, diffValue2.Length + 10 - volumeValue2.Length, ' ') +
                _showTextWithTab(volumeValue2, 10, ' '));

                //progConsole.screenWrite("\n");
            }
            Console.WriteLine(firstDataToDisplay[0].SearchTypeAndTime + "   || " + secondDataToDisplay[0].SearchTypeAndTime);
            Console.WriteLine("    This used " + firstDataToDisplay[0].CountRepetitions.ToString() + " iterations          ||         This used " + secondDataToDisplay[0].CountRepetitions.ToString() + " iterations");
        }
        /*************************************************************************************************/


        /*************************************************************************************************/
        private string _showTextWithTab(string textToDisplay, int _indent, char _character)
        {
            int spaces = textToDisplay.Length;
            string firstGap = "";
            for (int index = 0; index <= (_indent - spaces); index++)
            {
                firstGap = firstGap + _character.ToString();
            }
            firstGap = textToDisplay + firstGap;
            return firstGap;
        }
        /*************************************************************************************************/
        #endregion private methods
    }
}
