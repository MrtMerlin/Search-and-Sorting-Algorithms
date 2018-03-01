using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * This is an abstract data type to hold the information that is to be searched through and sorted
 * There is no need to change this code as it is not part of the assessment
 */

namespace AlgorithmAss1
{
    class StoredData
    {
        //data held by this data type
        private DateTime txDate;
        private string txDay;
        private string sh_open;
        private string sh_close;
        private string sh_volume;
        private string sh_diff;
        private string searchTypeAndTime;
        private int countRepetitions;
        //private string txtrial;
        //*********************************************************
        // 88, string searchTypeAndTimeInfo, string countOfRepetitions
        public StoredData(string itemDay, DateTime itemDate, string itemOpen, string itemClose, string itemDiff, string itemVolume)
        {
            txDay = itemDay;
            txDate = itemDate;            
            sh_open = itemOpen;
            sh_close = itemClose;
            sh_diff = itemDiff;
            sh_volume = itemVolume;
        }


        //*********************************************************
        //get-set methods
        public DateTime TxDate
        {
            get {return txDate; }
            set {txDate = value;}
        }
        //
        public  string TxDay
        {
            get  {return txDay; }
            set  {txDay = value;}
        }
        public  string Sh_open
        {
            get { return sh_open; }
            set { sh_open = value; }
        }
        public  string Sh_close
        {
            get { return sh_close; }
            set { sh_close = value; }
        }
        public  string Sh_volume
        {
            get { return sh_volume; }
            set { sh_volume = value; }
        }

        public  string Sh_diff
        {
            get { return sh_diff; }
            set { sh_diff = value; }
        }
        //searchTypeAndTime
        public string SearchTypeAndTime
        {
            get { return searchTypeAndTime; }
            set { searchTypeAndTime = value; }
        }
        //repetition counter store
        public int CountRepetitions
        {
            get { return countRepetitions; }
            set { countRepetitions = value; }
        }
    }
}
