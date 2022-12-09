using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace openlabik_11._0000000
{
    internal class Library
    {
        private int numberOfBooks;
        private int numberOfStudents;
        private List<string> studentsList = new List<string>();
        public List<string> StudentsList
        {
            get { return studentsList; }
            set { studentsList = value; }
        }
        private List<string> booksList = new List<string>();
        public List<string> BooksList
        {
            get { return booksList; }
            set { booksList = value; }
        }

        public int NumberOfBooks
        {
            get { return numberOfBooks; } set { numberOfBooks = value; } 
        }

        public int NumberOfStudents
        {
            get { return numberOfStudents; } set { numberOfStudents = value; }
            
        }
        /// <summary>
        /// method that returns customised strings
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format($"\n{numberOfBooks}\n{NumberOfStudents}\n{booksList}\n{StudentsList}\n");
        }
    }
}
