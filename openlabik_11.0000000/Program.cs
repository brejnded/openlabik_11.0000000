using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openlabik_11._0000000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Book LOTR = new Book();
              LOTR.Title = "Lord Of The Rings";
               LOTR.Pages = 576;
               LOTR.Category = "Fantasy";
               LOTR.Author = "J.R.R.Tolkien";
               LOTR.ReleaseDate = 1954;
               Console.WriteLine(LOTR.ToString());*/

            Library schoolLibrary = new Library();
           
            Book ucebnica1 = new Book("slovencina", 342, Book.categoryList[2], "Cierna Mamba", 1872 );
            Book ucebnica2 = new Book("anglictina", 654, Book.categoryList[2], "Jakub Hanz", 1932);
            Book ucebnica3 = new Book("elektronika", 789, Book.categoryList[2], "Ibi Maiga", 1945);
            Book ucebnica4 = new Book("nemcina", 852, Book.categoryList[2], "Jakub Chalupka", 2004);


            schoolLibrary.StudentsList.Add("John");
            schoolLibrary.StudentsList.Add("Poul");
            schoolLibrary.BooksList.Add("ucebnica1");
            schoolLibrary.BooksList.Add("ucebnica2");
            schoolLibrary.BooksList.Add("ucebnica3");
            schoolLibrary.BooksList.Add("ucebnica4");
            schoolLibrary.NumberOfBooks = 4;
            schoolLibrary.NumberOfStudents = 2;

            Console.WriteLine(ucebnica1.ToString());
            Console.WriteLine(ucebnica2.ToString());
            Console.WriteLine(ucebnica3.ToString());
            Console.WriteLine(ucebnica4.ToString());

            Book LOTR2 = new Book();
            Console.WriteLine(LOTR2.ToString());
            Console.WriteLine();

            Book LOTR3 = new Book("Lord Of The Rings 3", 1536);
            Console.WriteLine(LOTR3.ToString());

            Book HOBIT = new Book("Hobit", 304, Book.categoryList[3], "J. R. R. Tolkien", 1937);
            Console.WriteLine(HOBIT.ToString());

           

        }
    }
}