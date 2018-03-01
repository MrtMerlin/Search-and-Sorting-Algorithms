using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; //for stopwatch
using System.Threading; //for thread.sleep

/*
 * This is the class dedicated to the sorting algorithms that you need to provide and test
 * There is no need to change this code as it is not part of the assessment
 */

namespace AlgorithmAss1
{
    class SortingAlgorithms
    {
        #region class variables
        //**************** CLASS VARIABLES *************
        // Timespan is required to provide the time taken by the algoritms
        private List<TimeSpan> timesTaken;
        private List<string> testName;
        //The stopwatch attribute is used in the timing of the algorithms
        private Stopwatch stopWatch;
        #endregion class variables
        public SortingAlgorithms()
        {
            //constructor for the algorithm object
            timesTaken = new List<TimeSpan>();
            testName = new List<string>();
            stopWatch = new Stopwatch();
        }
        /* ********************************************************
         * This is where you must create the required Algorithms  *
         * ********************************************************/
        #region Option 1. List Date Ascending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option Option 1. List Date Ascending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Date' attribute
        /// <para>You need to place the result into a List of StoredData objects called 'listToSort'</para>
        /// </summary>
        public List<StoredData> sortDateAscendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //###################################################################################
            //Place your first algorithm to sort by the date in ASCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //###################################################################################

            //insertion sort
            // variables for sorting
            DateTime temp;
            int j;

            // for loop if i is less than listToSort.Count.
            for (int i = 0; i < listToSort.Count; i++)
            {
                
                // temp variable storing list of dates from data source.
                temp = listToSort[i].TxDate;
                
                // j variable stores the i count - 1.
                j = i - 1;

                // while statement, while j is greater than or equal to and listToSort[j].txDate is less than temp
                // iterate through.
                
                while (j >= 0 && listToSort[j].TxDate < temp)
                {
                    listToSort[j + 1] = listToSort[j];
                    j++;
                }
                
                // data to be fed back through iterations.
                listToSort[j + 1].TxDate = temp;
                // count of iterations.
                countOfRepetitions++;
            }
           




            //###################################################################################
            //Place your first algorithm to sort by the date in ASCENDING order above here
            //###################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Insertion' sort Date Ascending";//*** Change 'DateAscAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort; 
        }
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option Option 1. List Date Ascending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Date' attribute
        /// <para>You need to place the result into a List of StoredData objects called 'listToSort'</para>
        /// </summary>
        public List<StoredData> sortDateAscendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //###################################################################################
            //Place your second algorithm to sort by the date in ASCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //###################################################################################

            //BubbleSort
            // temp variable for date.
            StoredData temp;

            for (int i = 0; i < listToSort.Count; i++)
            {
                for (int j = 0; j < listToSort.Count - 1; j++)
                {
                    if (listToSort[j].TxDate > listToSort[j + 1].TxDate)
                    {
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                        countOfRepetitions++;
                    }
                }
            }

            //###################################################################################
            //Place your second algorithm to sort by the date in ASCENDING order above here
            //###################################################################################
            listToSort.First().SearchTypeAndTime = "Using 'Bubblesort' sort Date Ascending";//*** Change 'DateAscAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort;
        }
        #endregion Option 1.
        /**********************************************************************************************************************/
        #region Option 2. List Date Descending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        //Option 2. List Date Descending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in descending order by its 'Date' attribute
        /// <para>You need to place the result into a List of StoredData objects called 'listToSort'</para>
        /// </summary>
        public List<StoredData> sortDateDescendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //###################################################################################
            //Place your first algorithm to sort by the date in DECENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //###################################################################################

            //insertion sort
            // variables for sorting
            DateTime temp;
            int j;

            // for loop if i is less than listToSort.Count.
            for (int i = 0; i < listToSort.Count; i++)
            {
                // temp variable storing list of dates from data source.
                temp = listToSort[i].TxDate;
                // j variable stores the i count - 1.
                j = i - 1;

                // while statement, while j is greater than or equal to and listToSort[j].txDate is less than temp
                // iterate through.
                while (j >= 0 && listToSort[j].TxDate < temp)
                {
                    listToSort[j + 1] = listToSort[j];
                    j--;
                }
                // data to be fed back through iterations.
                listToSort[j + 1].TxDate = temp;
                // iterations recorded.
                countOfRepetitions++;
            }
            

            //int j;
            //for (int i = 1; i < listToSort.Count; i++)
            //{
            //    int temp = Convert.ToInt32(listToSort[i]);
            //    j = i - 1;

            //    int ja = Convert.ToInt32(listToSort[j]);

            //    while (j >= 0 && listToSort[j].TxDay > temp)
            //    {
            //        listToSort[j + 1] = listToSort[j];
            //        j--;
            //    }

            //    listToSort[j + 1] = temp;
            //    countOfRepetitions++;
            //}

            //###################################################################################
            //Place your second algorithm to sort by the date in DECENDING order above here
            //###################################################################################
            //// *** Place your algorithm to sort the data above here

            listToSort.First().SearchTypeAndTime = "Using 'Insertion' sort Date Descending"; //*** Change 'DateDesAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        //Option 2. List Date Descending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in descending order by its 'Date' attribute
        /// <para>You need to place the result into a List of StoredData objects called 'listToSort'</para>
        /// </summary>
        public List<StoredData> sortDateDescendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0;
            // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //###################################################################################
            //Place your second algorithm to sort by the date in DECENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //###################################################################################

            //BubbleSort
            // temp variable for date.
            StoredData temp;

            for (int i = 0; i < listToSort.Count; i++)
            {
                for (int j = 0; j < listToSort.Count - 1; j++)
                {
                    if (listToSort[j].TxDate < listToSort[j + 1].TxDate)
                    {
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                        countOfRepetitions++;
                    }
                }

            }



            //###################################################################################
            //Place your second algorithm to sort by the date in DECENDING order above here
            //###################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Bubblesort' sort Date Descending"; //*** Change 'DateDesAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions;
            return listToSort;
        }
        #endregion Option 2.
        /**********************************************************************************************************************/
        #region Option 3. List Opening Price Ascending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 3. List Opening Price Ascending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' (Sh_open) attribute
        /// <para>You need to place the result into a List of StoredData objects</para>
        /// </summary>
        public List<StoredData> sortOpenAscendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the opening value (Sh_open) in ASCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            // insertion sort
            StoredData temp;
            int j;

            // for loop if i is less than listToSort.Count.
            for (int i = 0; i < listToSort.Count; i++)
            {
                // j variable stores the i count - 1.
                j = i - 1;

                // while statement, while j is greater than or equal to and listToSort[j].txDate is less than temp
                // iterate through.
                while (j >= 0 && Convert.ToDouble(listToSort[j + 1].Sh_open) > Convert.ToDouble(listToSort[j].Sh_open))
                {
                    temp = listToSort[j + 1];
                    listToSort[j + 1] = listToSort[j];                    
                    // data to be fed back through iterations.                    
                    listToSort[j] = temp;
                    j--;
                }

                
                // iterations recorded.
                countOfRepetitions++;
            }

            //######################################################################################################
            //Place your first algorithm to sort by the the opening value (Sh_open) in ASCENDING order above here
            //######################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Insertion' sort Open Ascending"; //*** Change 'DateDA2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort; 
        }

        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 3. List Opening Price Ascending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬     
        public List<StoredData> sortOpenAscendingA2(List<StoredData> listToSortA2)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //###################################################################################
            //Place your second algorithm to sort by the the opening value (Sh_open) in ASCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //###################################################################################
            // bubblesort
            StoredData temp;

            for (int i = 0; i < listToSortA2.Count; i++)
            {
                for (int j = 0; j < listToSortA2.Count - 1; j++)
                {
                    if (Convert.ToDouble(listToSortA2[j].Sh_open) < Convert.ToDouble(listToSortA2[j + 1].Sh_open))
                    {
                        temp = listToSortA2[j];
                        listToSortA2[j] = listToSortA2[j + 1];
                        listToSortA2[j + 1] = temp;
                        countOfRepetitions++;
                    }
                }
                
            }

            //######################################################################################################
            //Place your second algorithm to sort by the the opening value (Sh_open) in ASCENDING order above here
            //######################################################################################################

            listToSortA2.First().SearchTypeAndTime = "Using 'Bubblesort' sort Open Ascending"; //*** Change 'DateDA2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSortA2.First().CountRepetitions = countOfRepetitions;
            return listToSortA2; 
        }
#endregion Sort the data Ascending by Opening Value
        /**********************************************************************************************************************/
        #region Option 4. List Opening Price Descending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 4. List Opening Price Descending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in Descending order by its 'Opening Value' attribute
        /// <para>You need to place the result into a List of StoredData objects</para>
        /// </summary>
        public List<StoredData> sortOpenDescendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the opening value (Sh_open) in DESCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################

            // insertion sort
            StoredData temp;
            int j;

            // for loop if i is less than listToSort.Count.
            for (int i = 0; i < listToSort.Count; i++)
            {
                // j variable stores the i count - 1.
                j = i - 1;

                // while statement, while j is greater than or equal to and listToSort[j].txDate is less than temp
                // iterate through.
                while (j >= 0 && Convert.ToDouble(listToSort[j + 1].Sh_open) < Convert.ToDouble(listToSort[j].Sh_open))
                {
                    temp = listToSort[j + 1];
                    listToSort[j + 1] = listToSort[j];
                    // data to be fed back through iterations.                    
                    listToSort[j] = temp;
                    j--;
                }


                // iterations recorded.
                countOfRepetitions++;
            }

            //######################################################################################################
            //Place your first algorithm to sort by the the opening value (Sh_open) in DESCENDING order above here
            //######################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Insertion' sort Open Ascending"; //*** Change 'DateDA2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }

        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 4. List Opening Price Descending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortOpenDescendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the opening value (Sh_open) in DESCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################

            // bubblesort
            StoredData temp;

            for (int i = 0; i < listToSort.Count; i++)
            {
                for (int j = 0; j < listToSort.Count - 1; j++)
                {
                    if (Convert.ToDouble(listToSort[j].Sh_open) > Convert.ToDouble(listToSort[j + 1].Sh_open))
                    {
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                        countOfRepetitions++;
                    }
                }
                
            }

            //######################################################################################################
            //Place your second algorithm to sort by the the opening value (Sh_open) in DESCENDING order above here
            //######################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Bubblesort' sort Open Ascending"; //*** Change 'DateDA2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions;  
            return listToSort;
        }
        #endregion Option 4.
        /**********************************************************************************************************************/
        #region Option 5. List Closing Price Ascending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 5. List Closing Price Ascending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortCloseAscendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the closing value (Sh_close) in ASSCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################

            StoredData temp;
            int j;

            // for loop if i is less than listToSort.Count.
            for (int i = 0; i < listToSort.Count; i++)
            {
                // j variable stores the i count - 1.
                j = i - 1;

                // while statement, while j is greater than or equal to and listToSort[j].txDate is less than temp
                // iterate through.
                while (j >= 0 && Convert.ToDouble(listToSort[j + 1].Sh_close) > Convert.ToDouble(listToSort[j].Sh_close))
                {
                    temp = listToSort[j + 1];
                    listToSort[j + 1] = listToSort[j];
                    // data to be fed back through iterations.                    
                    listToSort[j] = temp;
                    j--;
                }


                // iterations recorded.
                countOfRepetitions++;
            }

            //#####################################################################################################
            //Place your first algorithm to sort by the the closing value (Sh_close) in ASSCENDING order above here
            //#####################################################################################################

            //// *** Place your algorithm to sort the data above here

            listToSort.First().SearchTypeAndTime = "Using 'Insertion' sort Close Ascending"; //*** Change 'CloseAscAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions;  
            return listToSort; 
        }        

        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 5. List Closing Price Ascending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortCloseAscendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the closing value (Sh_close) in ASCENDING order below here
            //This will be displayed on the righr-hand-side of the console window
            //#####################################################################################################

            StoredData temp;

            for (int i = 0; i < listToSort.Count; i++)
            {
                for (int j = 0; j < listToSort.Count - 1; j++)
                {
                    if (Convert.ToDouble(listToSort[j].Sh_close) < Convert.ToDouble(listToSort[j + 1].Sh_close))
                    {
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                        countOfRepetitions++;
                    }
                }
                
            }

            //#####################################################################################################
            //Place your second algorithm to sort by the the closing value (Sh_close) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Bubblesort' sort Close Ascending"; //*** Change 'CloseAscAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        #endregion Option 5.
        /**********************************************************************************************************************/
        #region Option 6. List Closing Price Descending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 6. List Closing Price Descending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in Descending order by its 'Opening Value' attribute
        /// <para>You need to place the result into a List of StoredData objects</para>
        /// </summary>
        public List<StoredData> sortCloseDescendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the closing value (Sh_close) in DESCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################

            // insertion sort
            StoredData temp;
            int j;

            // for loop if i is less than listToSort.Count.
            for (int i = 0; i < listToSort.Count; i++)
            {
                // j variable stores the i count - 1.
                j = i - 1;

                // while statement, while j is greater than or equal to and listToSort[j].txDate is less than temp
                // iterate through.
                while (j >= 0 && Convert.ToDouble(listToSort[j + 1].Sh_close) < Convert.ToDouble(listToSort[j].Sh_close))
                {
                    temp = listToSort[j + 1];
                    listToSort[j + 1] = listToSort[j];
                    // data to be fed back through iterations.                    
                    listToSort[j] = temp;
                    j--;
                }


                // iterations recorded.
                countOfRepetitions++;
            }

            //#####################################################################################################
            //Place your first algorithm to sort by the the closing value (Sh_close) in DESCENDING order above here
            //#####################################################################################################

            //// *** Place your algorithm to sort the data above here

            listToSort.First().SearchTypeAndTime = "Using 'Insertion' sort Close Ascending"; //*** Change 'CloseAscAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort; 
        }


        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 6. List Closing Price Descending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortCloseDescendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the closing value (Sh_close) in DESCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################

            // bubblesort
            StoredData temp;

            for (int i = 0; i < listToSort.Count; i++)
            {
                for (int j = 0; j < listToSort.Count - 1; j++)
                {
                    if (Convert.ToDouble(listToSort[j].Sh_close) > Convert.ToDouble(listToSort[j + 1].Sh_close))
                    {
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                        countOfRepetitions++;
                    }
                }
                
            }

            //#####################################################################################################
            //Place your first algorithm to sort by the the closing value (Sh_close) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Bubble' sort Close Ascending"; //*** Change 'CloseAscAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        #endregion Option 6.
        /**********************************************************************************************************************/
        #region Option 7. List Volume of sales Ascending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 7. List Volume of sales Ascending algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortVolAscendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_volume) in ASCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################

             StoredData temp;
            int j;

            // for loop if i is less than listToSort.Count.
            for (int i = 0; i < listToSort.Count; i++)
            {
                // j variable stores the i count - 1.
                j = i - 1;

                // while statement, while j is greater than or equal to and listToSort[j].txDate is less than temp
                // iterate through.
                while (j >= 0 && Convert.ToDouble(listToSort[j + 1].Sh_volume) > Convert.ToDouble(listToSort[j].Sh_volume))
                {
                    temp = listToSort[j + 1];
                    listToSort[j + 1] = listToSort[j];
                    // data to be fed back through iterations.                    
                    listToSort[j] = temp;
                    j--;
                }


                // iterations recorded.
                countOfRepetitions++;
            }

           
            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_volume) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'insertion' sort Volume Ascending"; //*** Change 'VolAscAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }


        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 7. List Volume of sales Ascending algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortVolAscendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the Volume value (Sh_volume) in ASCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################

            StoredData temp;

            for (int i = 0; i < listToSort.Count; i++)
            {
                for (int j = 0; j < listToSort.Count - 1; j++)
                {
                    if (Convert.ToDouble(listToSort[j].Sh_volume) < Convert.ToDouble(listToSort[j + 1].Sh_volume))
                    {
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                        countOfRepetitions++;
                    }
                }
                
            }

            //#####################################################################################################
            //Place your second algorithm to sort by the the Volume value (Sh_volume) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'bubble' sort Volume Ascending"; //*** Change 'VolumeAscAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        #endregion Option 7. 
        /**********************************************************************************************************************/
        #region Option 8. List List Volume of sales Descending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 8. List List Volume of sales Descending algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortVolDescendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_volume) in DESCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################

            // insertion sort
            StoredData temp;
            int j;

            // for loop if i is less than listToSort.Count.
            for (int i = 0; i < listToSort.Count; i++)
            {
                // j variable stores the i count - 1.
                j = i - 1;

                // while statement, while j is greater than or equal to and listToSort[j].txDate is less than temp
                // iterate through.
                while (j >= 0 && Convert.ToDouble(listToSort[j + 1].Sh_volume) < Convert.ToDouble(listToSort[j].Sh_volume))
                {
                    temp = listToSort[j + 1];
                    listToSort[j + 1] = listToSort[j];
                    // data to be fed back through iterations.                    
                    listToSort[j] = temp;
                    j--;
                }


                // iterations recorded.
                countOfRepetitions++;
            }


            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_volume) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'Insertion' sort Volume Descending"; //*** Change 'VolDescAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 8. List List Volume of sales Descending algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortVolDescendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the Volume value (Sh_volume) in DESCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################

            // bubblesort
            StoredData temp;

            for (int i = 0; i < listToSort.Count; i++)
            {
                for (int j = 0; j < listToSort.Count - 1; j++)
                {
                    if (Convert.ToDouble(listToSort[j].Sh_volume) > Convert.ToDouble(listToSort[j + 1].Sh_volume))
                    {
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                        countOfRepetitions++;
                    }
                }
                
            }

            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_volume) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'bubble' sort Volume Descending"; //*** Change 'VolumeDescAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        #endregion Option 8. 
        /**********************************************************************************************************************/
        #region Option 9. List difference of sales Ascending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 9. List difference of sales Ascending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDiffAscendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_diff) in ASCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################

            StoredData temp;
            int j;

            // for loop if i is less than listToSort.Count.
            for (int i = 0; i < listToSort.Count; i++)
            {
                // j variable stores the i count - 1.
                j = i - 1;

                // while statement, while j is greater than or equal to and listToSort[j].txDate is less than temp
                // iterate through.
                while (j >= 0 && Convert.ToDouble(listToSort[j + 1].Sh_diff) > Convert.ToDouble(listToSort[j].Sh_diff))
                {
                    temp = listToSort[j + 1];
                    listToSort[j + 1] = listToSort[j];
                    // data to be fed back through iterations.                    
                    listToSort[j] = temp;
                    j--;
                }


                // iterations recorded.
                countOfRepetitions++;
            }

            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_diff) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'insertion' sort Difference Ascending"; //*** Change 'DiffAscAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }


        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 9. List difference of sales Ascending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDiffAscendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the Volume value (Sh_diff) in ASCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################

            StoredData temp;

            for (int i = 0; i < listToSort.Count; i++)
            {
                for (int j = 0; j < listToSort.Count - 1; j++)
                {
                    if (Convert.ToDouble(listToSort[j].Sh_diff) < Convert.ToDouble(listToSort[j + 1].Sh_diff))
                    {
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                        countOfRepetitions++;
                    }
                }
            }

            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_diff) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'bubble' sort Difference Ascending"; //** Change 'DiffAscAlg2' for the algorithm used by you ***
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions;  
            return listToSort;
        }
        #endregion Option 9.
        /**********************************************************************************************************************/
        #region Option 10. List difference of sales Descending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 10. List difference of sales Descending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDiffDescendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_diff) in DESCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################

            // insertion sort
            StoredData temp;
            int j;

            // for loop if i is less than listToSort.Count.
            for (int i = 0; i < listToSort.Count; i++)
            {
                // j variable stores the i count - 1.
                j = i - 1;

                // while statement, while j is greater than or equal to and listToSort[j].txDate is less than temp
                // iterate through.
                while (j >= 0 && Convert.ToDouble(listToSort[j + 1].Sh_diff) < Convert.ToDouble(listToSort[j].Sh_diff))
                {
                    temp = listToSort[j + 1];
                    listToSort[j + 1] = listToSort[j];
                    // data to be fed back through iterations.                    
                    listToSort[j] = temp;
                    j--;
                }


                // iterations recorded.
                countOfRepetitions++;
            }

            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_diff) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'insertion' sort Difference Descending"; //*** Change 'DiffDescAlg1' for the algorithm used by you ***
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }


        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 10. List difference of sales Descending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDiffDescendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //#####################################################################################################
            //Place your second algorithm to sort by the the Volume value (Sh_diff) in DESCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################

            // bubblesort
            StoredData temp;

            for (int i = 0; i < listToSort.Count; i++)
            {
                for (int j = 0; j < listToSort.Count - 1; j++)
                {
                    if (Convert.ToDouble(listToSort[j].Sh_diff) > Convert.ToDouble(listToSort[j + 1].Sh_diff))
                    {
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                        countOfRepetitions++;
                    }
                }
            }

            //#####################################################################################################
            //Place your first algorithm to sort by the the Volume value (Sh_diff) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'bubble' sort Difference Descending"; //***Change 'DiffDescAlg2' for the algorithm used by you ***
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; 
            return listToSort;
        }
        #endregion Option 10.
        /**********************************************************************************************************************/
        #region Option 11. List days Ascending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 11. List days Ascending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDayAscendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
                                        //Remember the order is to be by day order - Mon, Tues, Wed ... not Alphabetical
                                        //#####################################################################################################
                                        //Place your first algorithm to sort by the the Day value (TxDay) in ASCENDING order below here
                                        //This will be displayed on the left-hand-side of the console window
                                        //#####################################################################################################

            StoredData temp;
            int j;

            // for loop if i is less than listToSort.Count.
            for (int i = 0; i < listToSort.Count; i++)
            {
                // j variable stores the i count - 1.
                j = i - 1;

                // while statement, while j is greater than or equal to and listToSort[j].txDate is less than temp
                // iterate through.
                while (j >= 0 && checkDay(listToSort[j + 1].TxDay) < checkDay(listToSort[j].TxDay))
                {
                    temp = listToSort[j + 1];
                    listToSort[j + 1] = listToSort[j];
                    // data to be fed back through iterations.                    
                    listToSort[j] = temp;
                    j--;
                }


                // iterations recorded.
                countOfRepetitions++;
            }

            //#####################################################################################################
            //Place your first algorithm to sort by the the Day value (TxDay) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'insertion' sort Day Ascending"; //*** Change 'DayAscAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data

            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort;
        }


        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 11. List days Ascending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDayAscendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //Remember the order is to be by day order - Mon, Tues, Wed ... not Alphabetical
            //#####################################################################################################
            //Place your second algorithm to sort by the the Day value (TxDay) in ASCENDING order below here
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################


            StoredData temp;

            for (int i = 0; i < listToSort.Count; i++)
            {
                for (int j = 0; j < listToSort.Count - 1; j++)
                {
                    if (checkDay(listToSort[j].TxDay) > checkDay(listToSort[j + 1].TxDay))
                    {
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                        countOfRepetitions++;
                    }
                }
            }


            //#####################################################################################################
            //Place your second algorithm to sort by the the Day value (TxDay) in ASCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'bubble' sort Day Ascending"; //*** Change 'DiffDayAlg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort;
        }
        #endregion Option 11.
        /**********************************************************************************************************************/
        #region Option 12. List days Descending's 2 algorithms
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 12. List days Descending Algorithm 1
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDayDescendingA1(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data 
            //Remember the order is to be by day order - Mon, Tues, Wed ... not Alphabetical
            //#####################################################################################################
            //Place your first algorithm to sort by the the Day value (TxDay) in DESCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################

            StoredData temp;
            int j;

            // for loop if i is less than listToSort.Count.
            for (int i = 0; i < listToSort.Count; i++)
            {
                // j variable stores the i count - 1.
                j = i - 1;

                // while statement, while j is greater than or equal to and listToSort[j].txDate is less than temp
                // iterate through.
                while (j >= 0 && checkDay(listToSort[j + 1].TxDay) > checkDay(listToSort[j].TxDay))
                {
                    temp = listToSort[j + 1];
                    listToSort[j + 1] = listToSort[j];
                    // data to be fed back through iterations.                    
                    listToSort[j] = temp;
                    j--;
                }


                // iterations recorded.
                countOfRepetitions++;
            }

            //#####################################################################################################
            //Place your first algorithm to sort by the the Day value (TxDay) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'insertion' sort Day Descending"; //*** Change 'DayDescAlg1' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data

            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort;
        }
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        // Option 12. List days Descending Algorithm 2
        //¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬
        public List<StoredData> sortDayDescendingA2(List<StoredData> listToSort)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to sort the data
            //Remember the order is to be by day order - Mon, Tues, Wed ... not Alphabetical
            //#####################################################################################################
            //Place your second algorithm to sort by the the Day value (TxDay) in DESCENDING order below here
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################

            StoredData temp;

            for (int i = 0; i < listToSort.Count; i++)
            {
                for (int j = 0; j < listToSort.Count - 1; j++)
                {
                    if (checkDay(listToSort[j].TxDay) < checkDay(listToSort[j + 1].TxDay))
                    {
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                        countOfRepetitions++;
                    }
                }
            }

            //#####################################################################################################
            //Place your second algorithm to sort by the the Day value (TxDay) in DESCENDING order above here
            //#####################################################################################################

            listToSort.First().SearchTypeAndTime = "Using 'DayDescAlg2' sort Day Descending"; //*** Change 'DiffDayDelg2' for the algorithm used by you
            // place your total count of loops (countOfRepetitions) here
            listToSort.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort;
        }
        #endregion Option 12.
        /**********************************************************************************************************************/

        #region private methods

        /*************************************************************************************************/
        private string outputTime(List<TimeSpan> timesTaken, string testName)
        {
            string timeTakenString = "";
            //Console.WriteLine("\n ************************************************************\n");
            for (int i = 0; i < timesTaken.Count(); i++)
            {
                // Format and display the TimeSpan value. 
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timesTaken[i].Hours, timesTaken[i].Minutes, timesTaken[i].Seconds, timesTaken[i].Milliseconds / 10);
                timeTakenString = testName + " : " + elapsedTime;
            }

            //Console.WriteLine("\n ************************************************************\n");

            return timeTakenString;
        }

        public int checkDay(string day)
        {
            int value = 0;

            if (day.Contains("Monday"))
                value = 0;
                           
            if (day.Contains("Tuesday"))
                value = 1;

            if (day.Contains("Wednesday"))
                value = 2;

            if (day.Contains("Thursday"))
                value = 3;

            if (day.Contains("Friday"))
                value = 4;

            return value;
        }

        
    }
        #endregion
}
 