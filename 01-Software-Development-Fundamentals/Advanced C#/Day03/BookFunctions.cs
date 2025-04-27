using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public class BookFunctions
    {
        public static string GetTitle(Book B) => $"Book Title: {B.Title}";
        public static string GetAuthors(Book B) => $"Book authors: {B.Authors}";
        public static string GetPrice(Book B) => $"Book Price: B.Price.ToString('C')$";
           
    }
}
