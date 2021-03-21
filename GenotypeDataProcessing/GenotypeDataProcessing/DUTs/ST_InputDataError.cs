using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenotypeDataProcessing.DUTs
{
    /// <summary>
    /// Contains info about error in intput data file
    /// </summary>
    public struct ST_InputDataError
    {
        /// <summary>
        /// Invalid user input, expected number, of either columns or row, is zero
        /// </summary>
        public bool zeroExpectedColsOrRows;
        /// <summary>
        /// Indicates wrong number of rows
        /// </summary>
        public bool rowsError;
        /// <summary>
        /// Expected number of rows in data file
        /// </summary>
        public int expectedRows;
        /// <summary>
        /// Acutal number of rows in data file
        /// </summary>
        public int actualRows;
        /// <summary>
        /// Indicates wrong number of columns
        /// </summary>
        public bool columnsError;
        /// <summary>
        /// Row ID, where columns does not match
        /// </summary>
        public int errorRow;
        /// <summary>
        /// Expected number of columns in certain row
        /// </summary>
        public int expectedColumns;
        /// <summary>
        /// Actual number of columns in certain row
        /// </summary>
        public int actualColumns;
    }
}
