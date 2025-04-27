using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public class LibraryEngine
    {

        public delegate string CurrentDelegate(Book B);

        public static void ProcessBooks(Book [] bList
        ,/*Pointer To BookFunciton*/ CurrentDelegate bookDel)

        {
            foreach (Book B in bList)
            {
                Console.WriteLine(bookDel(B));
            }
        }
    }
}
