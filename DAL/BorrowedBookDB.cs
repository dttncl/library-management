using LibraryManagement.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagement.DAL
{
    public class BorrowedBookDB
    {
        // list borrowed books by student
        public static List<BorrowedBook> ListBooks(int id)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {

                List<BorrowedBook> all = new List<BorrowedBook>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM BORROWEDBOOKS WHERE STUDENTID = @StudentID";
                cmd.Parameters.AddWithValue("@StudentID", id);
                SqlDataReader reader = cmd.ExecuteReader();

                BorrowedBook borrowedbook;
                while (reader.Read())
                {
                    borrowedbook = new BorrowedBook();
                    borrowedbook.StudentID = Convert.ToInt32(reader["StudentID"]);
                    borrowedbook.Code = reader["BookCode"].ToString();
                    borrowedbook.BorrowedDate = Convert.ToDateTime(reader["BorrowedDate"]);
                    borrowedbook.ReturnedDate = Convert.ToDateTime(reader["ReturnedDate"]);

                    all.Add(borrowedbook);
                }

                return all;
            }
        }

        // borrow a book
        public static void BorrowBook(BorrowedBook borrowedbook)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                // perform INSERT operation
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT BorrowedBooks VALUES (@StudentId, @BookCode, @BorrowedDate, NULL)";
                cmd.Parameters.AddWithValue("@StudentId", borrowedbook.StudentID);
                cmd.Parameters.AddWithValue("@BookCode", borrowedbook.Code);
                cmd.Parameters.AddWithValue("@BorrowedDate", borrowedbook.BorrowedDate);

                cmd.ExecuteNonQuery();
            }
        }

        // return a book
        public static void ReturnBook(int id, string code, DateTime returnDate)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                // perform UPDATE operation
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "UPDATE BorrowedBooks SET ReturnedDate = @ReturnedDate WHERE StudentId = @StudentId AND BookCode = BookCode";
                cmd.Parameters.AddWithValue("@StudentId", id);
                cmd.Parameters.AddWithValue("@BookCode", code);
                cmd.Parameters.AddWithValue("@ReturnedDate", returnDate);

                cmd.ExecuteNonQuery();
            }
        }
    }
}