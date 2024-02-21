using LibraryManagement.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagement.DAL
{
    public class BookDB
    {

        // search one book
        public static Book SearchRecord(string code)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM BOOKS WHERE BookCode = @BookCode";
                cmd.Parameters.AddWithValue("@BookCode", code);

                SqlDataReader reader = cmd.ExecuteReader();
                Book book = null;
                if (reader.Read())
                {
                    book = new Book();
                    book.Code = reader["BookCode"].ToString();
                    book.Name = reader["BookName"].ToString();
                    book.Author = reader["Author"].ToString();
                }

                return book;
            }
        }

        // list all books
        public static List<Book> ListBooks()
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {

                List<Book> all = new List<Book>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM BOOKS";
                SqlDataReader reader = cmd.ExecuteReader();

                Book book;
                while (reader.Read())
                {
                    book = new Book();
                    book.Code = reader["BookCode"].ToString();
                    book.Name = reader["BookName"].ToString();
                    book.Author = reader["Author"].ToString();
                    all.Add(book);
                }

                return all;
            }
        }

        // list borrowed books by student
        public static List<Book> ListBooks(int id)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {

                List<Book> all = new List<Book>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT B.BookCode, B.BookName, B. Author FROM BOOKS B JOIN BORROWEDBOOKS R ON B.BOOKCODE = R.BOOKCODE WHERE R.STUDENTID = @StudentID";
                cmd.Parameters.AddWithValue("@StudentID", id);
                SqlDataReader reader = cmd.ExecuteReader();

                Book book;
                while (reader.Read())
                {
                    book = new Book();
                    book.Code = reader["BookCode"].ToString();
                    book.Name = reader["BookName"].ToString();
                    book.Author = reader["Author"].ToString();
                    all.Add(book);
                }

                return all;
            }
        }

        // list available books by student
        public static List<Book> ListAvailableBooks(int id)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {

                List<Book> all = new List<Book>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM BOOKS WHERE BookCode NOT IN (SELECT B.BookCode FROM BOOKS B JOIN BORROWEDBOOKS R ON B.BOOKCODE = R.BOOKCODE WHERE R.STUDENTID = @StudentID)";
                cmd.Parameters.AddWithValue("@StudentID", id);
                SqlDataReader reader = cmd.ExecuteReader();

                Book book;
                while (reader.Read())
                {
                    book = new Book();
                    book.Code = reader["BookCode"].ToString();
                    book.Name = reader["BookName"].ToString();
                    book.Author = reader["Author"].ToString();
                    all.Add(book);
                }

                return all;
            }
        }

        
    }
}