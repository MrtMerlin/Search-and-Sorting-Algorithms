using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; //for stopwatch
using System.Threading; //for thread.sleep

///<summary>
///****************************************************************************************************
/// This class provides an interface for the diagnostic timing of algorithms 
/// it is purely for the assignment and not an independent class as it
/// encapsulates each expected sort/search request code to estimate the time taken 
/// for the algorithms to complete their tasks
/// It will add the time taken to the final searchTypeAndTime variable of the StoredData object/// 
/// ***************************************************************************************************
/// </summary>

namespace AlgorithmAss1
{
    class Diagnostics
    {
        // Add the sorting algorithm object
        private SortingAlgorithms sortObject;
        private SearchAlgorithms searchObject;

        public Diagnostics()
        {
            // constructor creates objects for sorting and for searching
            sortObject = new SortingAlgorithms();
            searchObject = new SearchAlgorithms();
        }
        #region sort requests
        #region sortDateDescending
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in descending order by its 'Date' attribute
        /// <para>You need to place the result into a List of StoredData objects</para>
        /// </summary>
        public List<StoredData> sortDateDescendingA1(List<StoredData> listToSortA1)
        {
            //* code for stopwatch to show efficiency
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithm
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // *** call the algorithm     
            listToSortA1 =  sortObject.sortDateDescendingA1(listToSortA1);
            //--- code to add the timing of the algorithm --------------------
            stopWatch.Stop();
            timesTaken = stopWatch.Elapsed;
            listToSortA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA1.First().SearchTypeAndTime);
            //------------------------------------------------------------------
            return listToSortA1;
        }
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in descending order by its 'Date' attribute
        /// <para>You need to place the result into a List of StoredData objects</para>
        /// </summary>
        public List<StoredData> sortDateDescendingA2(List<StoredData> listToSort)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm     
            listToSort = sortObject.sortDateDescendingA2(listToSort);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSort.First().SearchTypeAndTime = outputTime(timesTaken, listToSort.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort;
        }
        /*********************************************************************************/
        #endregion sortDate Descending
        #region sortDate Ascending
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Date' attribute
        /// </summary>
        public List<StoredData> sortDateAscendingA1(List<StoredData> listToSortA1)
        {
            //* code for stopwatch to show efficiency
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithm
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // *** call the algorithm     
            listToSortA1 = sortObject.sortDateAscendingA1(listToSortA1);
            //--- code to add the timing of the algorithm --------------------
            stopWatch.Stop();
            timesTaken = stopWatch.Elapsed;
            listToSortA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA1.First().SearchTypeAndTime);
            //------------------------------------------------------------------
            return listToSortA1;
        }
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Date' attribute
        /// </summary>
        public List<StoredData> sortDateAscendingA2(List<StoredData> listToSort)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm     
            listToSort = sortObject.sortDateAscendingA2(listToSort);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSort.First().SearchTypeAndTime = outputTime(timesTaken, listToSort.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSort;
        }
        /*********************************************************************************/
        #endregion sort Date Ascending 
        #region sort Open Ascending
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortOpenAscendingA1(List<StoredData> listToSortA1)
        {
            //* code for stopwatch to show efficiency
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithm
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // *** call the algorithm     
            listToSortA1 = sortObject.sortOpenAscendingA1(listToSortA1);
            //--- code to add the timing of the algorithm --------------------
            stopWatch.Stop();
            timesTaken = stopWatch.Elapsed;
            listToSortA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA1.First().SearchTypeAndTime);
            //------------------------------------------------------------------
            return listToSortA1;
        }
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortOpenAscendingA2(List<StoredData> listToSortA2)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm     
            listToSortA2 = sortObject.sortOpenAscendingA2(listToSortA2);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSortA2.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA2.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSortA2;
        }
        /*********************************************************************************/
        #endregion sort Open Ascending 
        #region sort Open Descending
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in Descending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortOpenDescendingA1(List<StoredData> listToSortA1)
        {
            //* code for stopwatch to show efficiency
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithm
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // *** call the algorithm     
            listToSortA1 = sortObject.sortOpenDescendingA1(listToSortA1);
            //--- code to add the timing of the algorithm --------------------
            stopWatch.Stop();
            timesTaken = stopWatch.Elapsed;
            listToSortA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA1.First().SearchTypeAndTime);
            //------------------------------------------------------------------
            return listToSortA1;
        }
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in Descending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortOpenDescendingA2(List<StoredData> listToSortA2)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm     
            listToSortA2 = sortObject.sortOpenDescendingA2(listToSortA2);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSortA2.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA2.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSortA2;
        }
        /*********************************************************************************/
        #endregion sortDate Descending 
        #region sort Close Ascending
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortCloseAscendingA1(List<StoredData> listToSortA1)
        {
            //* code for stopwatch to show efficiency
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithm
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // *** call the algorithm     
            listToSortA1 = sortObject.sortCloseAscendingA1(listToSortA1);
            //--- code to add the timing of the algorithm --------------------
            stopWatch.Stop();
            timesTaken = stopWatch.Elapsed;
            listToSortA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA1.First().SearchTypeAndTime);
            //------------------------------------------------------------------
            return listToSortA1;
        }
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortCloseAscendingA2(List<StoredData> listToSortA2)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm     
            listToSortA2 = sortObject.sortCloseAscendingA2(listToSortA2);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSortA2.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA2.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSortA2;
        }
        /*********************************************************************************/
        #endregion sort Close Ascending 
        #region sort Close Descending
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortCloseDescendingA1(List<StoredData> listToSortA1)
        {
            //* code for stopwatch to show efficiency
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithm
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // *** call the algorithm     
            listToSortA1 = sortObject.sortCloseDescendingA1(listToSortA1);
            //--- code to add the timing of the algorithm --------------------
            stopWatch.Stop();
            timesTaken = stopWatch.Elapsed;
            listToSortA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA1.First().SearchTypeAndTime);
            //------------------------------------------------------------------
            return listToSortA1;
        }
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortCloseDescendingA2(List<StoredData> listToSortA2)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm     
            listToSortA2 = sortObject.sortCloseDescendingA2(listToSortA2);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSortA2.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA2.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSortA2;
        }
        /*********************************************************************************/
        #endregion sort Close Descending 
        #region sort Volume Ascending
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortVolAscendingA1(List<StoredData> listToSortA1)
        {
            //* code for stopwatch to show efficiency
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithm
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // *** call the algorithm     
            listToSortA1 = sortObject.sortVolAscendingA1(listToSortA1);
            //--- code to add the timing of the algorithm --------------------
            stopWatch.Stop();
            timesTaken = stopWatch.Elapsed;
            listToSortA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA1.First().SearchTypeAndTime);
            //------------------------------------------------------------------
            return listToSortA1;
        }
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortVolAscendingA2(List<StoredData> listToSortA2)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm     
            listToSortA2 = sortObject.sortVolAscendingA2(listToSortA2);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSortA2.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA2.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSortA2;
        }
        /*********************************************************************************/
        #endregion sort Volume Ascending
        #region sort Volume Descending
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in Descending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortVolDescendingA1(List<StoredData> listToSortA1)
        {
            //* code for stopwatch to show efficiency
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithm
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // *** call the algorithm     
            listToSortA1 = sortObject.sortVolDescendingA1(listToSortA1);
            //--- code to add the timing of the algorithm --------------------
            stopWatch.Stop();
            timesTaken = stopWatch.Elapsed;
            listToSortA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA1.First().SearchTypeAndTime);
            //------------------------------------------------------------------
            return listToSortA1;
        }
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in Descending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortVolDescendingA2(List<StoredData> listToSortA2)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm     
            listToSortA2 = sortObject.sortVolDescendingA2(listToSortA2);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSortA2.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA2.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSortA2;
        }
        /*********************************************************************************/
        #endregion sort Volume Descending
        #region sort Difference Ascending
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortDiffAscendingA1(List<StoredData> listToSortA1)
        {
            //* code for stopwatch to show efficiency
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithm
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // *** call the algorithm     
            listToSortA1 = sortObject.sortDiffAscendingA1(listToSortA1);
            //--- code to add the timing of the algorithm --------------------
            stopWatch.Stop();
            timesTaken = stopWatch.Elapsed;
            listToSortA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA1.First().SearchTypeAndTime);
            //------------------------------------------------------------------
            return listToSortA1;
        }
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortDiffAscendingA2(List<StoredData> listToSortA2)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm     
            listToSortA2 = sortObject.sortDiffAscendingA2(listToSortA2);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSortA2.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA2.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSortA2;
        }
        /*********************************************************************************/
        #endregion sort Difference Ascending 
        #region sort Difference Descending
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortDiffDescendingA1(List<StoredData> listToSortA1)
        {
            //* code for stopwatch to show efficiency
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithm
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // *** call the algorithm     
            listToSortA1 = sortObject.sortDiffDescendingA1(listToSortA1);
            //--- code to add the timing of the algorithm --------------------
            stopWatch.Stop();
            timesTaken = stopWatch.Elapsed;
            listToSortA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA1.First().SearchTypeAndTime);
            //------------------------------------------------------------------
            return listToSortA1;
        }
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortDiffDescendingA2(List<StoredData> listToSortA2)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm     
            listToSortA2 = sortObject.sortDiffDescendingA2(listToSortA2);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSortA2.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA2.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSortA2;
        }
        /*********************************************************************************/
        #endregion sort Difference Descending 
        #region sort Day Ascending
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortDayAscendingA1(List<StoredData> listToSortA1)
        {
            //* code for stopwatch to show efficiency
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithm
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // *** call the algorithm     
            listToSortA1 = sortObject.sortDayAscendingA1(listToSortA1);
            //--- code to add the timing of the algorithm --------------------
            stopWatch.Stop();
            timesTaken = stopWatch.Elapsed;
            listToSortA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA1.First().SearchTypeAndTime);
            //------------------------------------------------------------------
            return listToSortA1;
        }
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortDayAscendingA2(List<StoredData> listToSortA2)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm     
            listToSortA2 = sortObject.sortDayAscendingA2(listToSortA2);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSortA2.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA2.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSortA2;
        }
        /*********************************************************************************/
        #endregion sort Day Ascending 
        #region sort Day Descending
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortDayDescendingA1(List<StoredData> listToSortA1)
        {
            //* code for stopwatch to show efficiency
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithm
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // *** call the algorithm     
            listToSortA1 = sortObject.sortDayDescendingA1(listToSortA1);
            //--- code to add the timing of the algorithm --------------------
            stopWatch.Stop();
            timesTaken = stopWatch.Elapsed;
            listToSortA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA1.First().SearchTypeAndTime);
            //------------------------------------------------------------------
            return listToSortA1;
        }
        /*********************************************************************************/
        /// <summary>
        /// Takes a given List of 'StoredData' objects and sorts it in ascending order by its 'Opening Value' attribute
        /// </summary>
        public List<StoredData> sortDayDescendingA2(List<StoredData> listToSortA2)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm     
            listToSortA2 = sortObject.sortDayDescendingA2(listToSortA2);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSortA2.First().SearchTypeAndTime = outputTime(timesTaken, listToSortA2.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSortA2;
        }
        /*********************************************************************************/
        #endregion sort Day Descending 
        #endregion  sort requests
        #region search requests
        #region Search the records by date
        /// <summary>
        /// This method will search the given list of records for matching dates and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchLinearByDateA1(List<StoredData> listToSearchA1, DateTime dateToFind)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm   
            listToSearchA1 = searchObject.searchByDateA1(listToSearchA1, dateToFind);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSearchA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSearchA1.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSearchA1;
        }
        //**********************************************************************************************
        /// <summary>
        /// This method will search the given list of records for matching dates and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchLinearByDateA2(List<StoredData> listToSearchA2, DateTime dateToFind)
        {

            //sort the list by date to ensure it is date order ascending
            listToSearchA2.Sort((x, y) => y.TxDate.CompareTo(x.TxDate));
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm   
            listToSearchA2 = searchObject.searchByDateA2(listToSearchA2, dateToFind);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSearchA2.First().SearchTypeAndTime = outputTime(timesTaken, listToSearchA2.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSearchA2;
        }
        //**********************************************************************************************
        #endregion
        #region Search the records by day
        /// <summary>
        /// This method will search the given list of records for matching dates and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchByDayA1(List<StoredData> listToSearchA1, String dayToFind)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm   
            listToSearchA1 = searchObject.searchByDayA1(listToSearchA1, dayToFind);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSearchA1.First().SearchTypeAndTime = outputTime(timesTaken, listToSearchA1.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSearchA1;
        }
        //
        /// <summary>
        /// This method will search the given list of records for matching dates and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchByDayA2(List<StoredData> listToSearchA2, String dayToFind)
        {
            // code for stopwatch to show efficiency 
            TimeSpan timesTaken = new TimeSpan();// Timespan is required to provide the time taken by the algorithms
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            // call the algorithm   
            listToSearchA2 = searchObject.searchByDayA2(listToSearchA2, dayToFind);
            stopWatch.Stop();// *** code to store the timing of the algorithm
            timesTaken = stopWatch.Elapsed;
            listToSearchA2.First().SearchTypeAndTime = outputTime(timesTaken, listToSearchA2.First().SearchTypeAndTime);
            // *** your sorted data should be placed in 'listToSortA1' 
            return listToSearchA2;
        }

        #endregion Search the records by day
        #endregion search requests

        //********************************************************************************************
        //produces a string to tell the user the type of search/sort and the time it took to complete
        private string outputTime(TimeSpan timesTaken, string testName)
        {
            string timeTakenString = "";
            //Format and display the TimeSpan value. 
            timeTakenString = testName + " : " + timesTaken.TotalSeconds.ToString() + " secs";
            return timeTakenString;
        }
    }
}
