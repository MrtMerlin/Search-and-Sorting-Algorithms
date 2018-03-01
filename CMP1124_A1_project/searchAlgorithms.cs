using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmAss1
{
    class SearchAlgorithms
    {
        private readonly object sortedListToSearchA1;

        //The class contains differing search algorithms based on Lists using DateTime or String Days
        public SearchAlgorithms()
        {
                //constructor - not needed
        }
        //---------------------------------------------------------------------------------------------
        #region search date
        /// <summary>
        /// This method will search the given list of records for matching dates and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchByDateA1(List<StoredData> sortedListToSearchA1, DateTime dateToFind)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to search the data
            //#####################################################################################################
            //Place your first search algorithm below here - the results must be in the List 'searchResults'
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            List<StoredData> searchResults = new List<StoredData>();

            // linear search
             
            // for statement to look through list of items for dateToFind.
            for (int i = 0; i < sortedListToSearchA1.Count; i++)
            {
                
                // search sorted list for date to find
                if (sortedListToSearchA1[i].TxDate == dateToFind)
                {
                    // search results are added to searchResults.
                    searchResults.Add(sortedListToSearchA1[i]);
                    // counts iterations of how many time the search passes through the list.
                    countOfRepetitions++;
                    //breaks out of search.
                    break;
                }
                
            }

            //#####################################################################################################
            //Place your first search algorithm above here - the results must be in the List 'searchResults'
            //#####################################################################################################
            // *** your search result data should be placed in 'searchResults' 
            searchResults.First().SearchTypeAndTime = "Using 'linear' search by date";//rewrite the text to show user which algorithm you have used
            // place your total count of loops (countOfRepetitions) here
            searchResults.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            return searchResults;
        }
        //**********************************************************************************************
        /// <summary>
        /// This method will search the given list of records for matching dates and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchByDateA2(List<StoredData> sortedListToSearchA2, DateTime dateToFind)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to search the data
            //#####################################################################################################
            //Place your second search algorithm below here - the results must be in the List 'searchResults'
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
            List<StoredData> searchResults = new List<StoredData>();
            sortedListToSearchA2.Sort(delegate (StoredData d1, StoredData d2)
            {
                return d1.TxDate.CompareTo(d2.TxDate);
            }
);
            // binary search 

            // variables for binary search
            int min = 0;
            int max = sortedListToSearchA2.Count;

            // while statement min is less than or equal to max.
            while (min <= max)
            {
                // counts iterations of how many time the search passes through the list.
                countOfRepetitions++;
                // variable for mid.
                int mid = (min + max) / 2;

                // if statement if the dateToFind is mid then it will save
                if (sortedListToSearchA2[mid].TxDate == dateToFind)
                {
                    // stores sorted mid in search results.
                    searchResults.Add(sortedListToSearchA2[mid]);
                    break;
                }
                // if dateToFind is less than than mid point.
                else if (dateToFind < sortedListToSearchA2[mid].TxDate)
                {                    
                    max = mid - 1;
                }
                // if dateTofind is more than mid point.
                else
                {
                    min = mid + 1;
                }
               
                
            }
            



            //#####################################################################################################
            //Place your second search algorithm above here - the results must be in the List 'searchResults'
            //#####################################################################################################
            // *** your search result data should be placed in 'searchResults' 
            searchResults.First().SearchTypeAndTime = "Using 'binary' search by date";//rewrite the text to show user which algorithm you have used
            // place your total count of loops (countOfRepetitions) here
            searchResults.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            return searchResults;
        }
        #endregion search date
        #region search day
        //**********************************************************************************************
        /// <summary>
        /// This method will search the given list of records for matching days and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchByDayA1(List<StoredData> dataToSearchA1, string dayToFind)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to search the data
            //#####################################################################################################
            //Place your first search algorithm below here - the results must be in the List 'searchResults'
            //This will be displayed on the left-hand-side of the console window
            //#####################################################################################################
            //Create a blank data item to indicate the searched for date doesnot exist in the data set
           
            List<StoredData> searchResults = new List<StoredData>();

            // linear search

            // for statement to look through list of items for dateToFind.
            for (int i = 0; i < dataToSearchA1.Count; i++)
            {

                // search sorted list for date to find
                if (dataToSearchA1[i].TxDay == dayToFind)
                {
                    // search results are added to searchResults.
                    searchResults.Add(dataToSearchA1[i]);
                    // counts iterations of how many time the search passes through the list.
                    countOfRepetitions++;
                    //breaks out of search.
                    break;
                }

            }



            //#####################################################################################################
            //Place your first search algorithm below here - the results must be in the List 'searchResults'
            //#####################################################################################################
            // *** your search result data should be placed in 'searchResults' 
            searchResults.First().SearchTypeAndTime = "Using 'linear' search by day";//rewrite the text to show user which algorithm you have used
            // place your total count of loops (countOfRepetitions) here
            searchResults.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            return searchResults;
        }
        //**********************************************************************************************
        /// <summary>
        /// This method will search the given list of records for matching days and return a match or a 'did not match' result in a list
        /// </summary>
        public List<StoredData> searchByDayA2(List<StoredData> dataToSearchA2, string dayToFind)
        {
            int countOfRepetitions = 0; // use this to hold the number of repetitions your algorithm has to make to search the data
            //#####################################################################################################
            //Place your second search algorithm below here - the results must be in the List 'searchResults'
            //This will be displayed on the right-hand-side of the console window
            //#####################################################################################################
            //Create a blank data item to indicate the searched for date doesnot exist in the data set
            List<StoredData> searchResults = new List<StoredData>();

            dataToSearchA2.Sort(delegate (StoredData d1, StoredData d2)
            {
                return d1.TxDay.CompareTo(d2.TxDay);
            }
);
            // binary search 

            // variables for binary search
            int min = 0;
            int max = dataToSearchA2.Count;

            // while statement min is less than or equal to max.
            while (min <= max)
            {
                countOfRepetitions++;
                // variable for mid.
                int mid = (min + max) / 2;

                // if statement if the dateToFind is mid then it will save
                if (dataToSearchA2[mid].TxDay == dayToFind)
                {
                    // stores sorted mid in search results.
                    searchResults.Add(dataToSearchA2[mid]);
                    break;
                }
                // if dateToFind is less than than mid point.
                else if (value(dayToFind) > checkDay(dataToSearchA2[mid].TxDay))
                {
                    max = mid + 1;
                }
                // if dateTofind is more than mid point.
                else
                {
                    min = mid - 1;
                }
                // counts iterations of how many time the search passes through the list.
                
            }


            //#####################################################################################################
            //Place your second search algorithm below here - the results must be in the List 'searchResults'
            //#####################################################################################################
            // *** your search result data should be placed in 'searchResults' 
            searchResults.First().SearchTypeAndTime = "Using 'binary' search by day";//rewrite the text to show user which algorithm you have used
            // place your total count of loops (countOfRepetitions) here
            searchResults.First().CountRepetitions = countOfRepetitions; //rewrite to show user the number of steps (loops) this algorithm has made to sort the data
            
            return searchResults;
        }
        //**********************************************************************************************
        #endregion search day

        
        // 
        public int checkDay(string dayInList)
        {
            int value = -1;

            if (dayInList.Contains("Monday"))
                value = 0;

            if (dayInList.Contains("Tuesday"))
                value = 1;

            if (dayInList.Contains("Wednesday"))
                value = 2;

            if (dayInList.Contains("Thursday"))
                value = 3;

            if (dayInList.Contains("Friday"))
                value = 4;

            return value;
        }

        public int value(string days)
        {
            int value = -1;

            if (days.Contains("Monday"))
                value = 0;

            if (days.Contains("Tuesday"))
                value = 1;

            if (days.Contains("Wednesday"))
                value = 2;

            if (days.Contains("Thursday"))
                value = 3;

            if (days.Contains("Friday"))
                value = 4;

            return value;
        }
    }   
}
