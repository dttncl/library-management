using LibraryManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.BLL
{
    public class Book
    {
        private string code;
        private string name;
        private string author;

        public Book()
        {
            code = string.Empty;
            name = string.Empty;
            author = string.Empty;
        }

        public Book(string code, string name, string author)
        {
            this.code = code;
            this.name = name;
            this.author = author;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }

        public static List<Book> GetBooks() => BookDB.ListBooks();
        public static List<Book> GetBooks(int id) => BookDB.ListBooks(id);
        public static List<Book> GetAvailableBooks(int id) => BookDB.ListAvailableBooks(id);
        public static Book Search(string code) => BookDB.SearchRecord(code);
    }
}