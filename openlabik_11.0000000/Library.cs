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

        private List<Book> booksList = new List<Book>();
        public List<Book> BooksList
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
            string booksFromList = String.Empty;
            string studentsFromList = String.Empty;

            foreach (var x in studentsList)
            {
                studentsFromList += x + " ";
            }

            foreach (var x in booksList)
            {
                booksFromList += x + " ";
            }
            return String.Format($"\n{this.numberOfBooks}\n{this.NumberOfStudents}\n{booksFromList}\n{studentsFromList}\n");
        }
    }
}
