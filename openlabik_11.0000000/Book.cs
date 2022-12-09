using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openlabik_11._0000000
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        /// <summary>
        ///  this list contains categories
        /// </summary>
        public static List<string> categoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };

        /// <summary>
        /// non-parametric constructor
        /// </summary>
        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        /// <summary>
        /// parametric constructor that sets certain values to Title and Pages
        /// </summary>
        public Book(string sTitle, int iPages)
        {
            this.title = sTitle;
            this.pages = iPages;
            category = "-1";
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        /// <summary>
        /// parametric constructor that sets every value  in Book
        /// </summary>
        public Book(string sTitle, int iPages, string sCategory, string sAuthor, int iReleaseDate)
        {
            this.title = sTitle;
            this.pages = iPages;
            this.category = sCategory;
            this.author = sAuthor;
            this.releaseDate = iReleaseDate;
        }
        /// <summary>
        /// getter and setter for Title
        /// </summary>
        public string Title { get { return title; } set { title = value; } }

        /// <summary>
        /// getter and setter for Pages
        /// </summary>
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = pages = value <= 0 ? 1 : value;
            }
        }

        /// <summary>
        /// getter and setter for Category
        /// </summary>
        public string Category { set { category = value; } }

        /// <summary>
        /// getter and setter for Author
        /// </summary>
        public string Author { get { return author; } set { author = value; } }

        /// <summary>
        /// getter and setter for ReleaseDate
        /// </summary>
        public int ReleaseDate
        {
            get
            {
                return releaseDate;

            }
            set
            {
                releaseDate = releaseDate = value <= 1450 || value >= 2021 ? -1 : value;
            }
        }
        /// <summary>
        /// method that returns customised strings
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format($"\n{title}\n{pages}\n{category}\n{author}\n{releaseDate}\n");
        }
    }
}