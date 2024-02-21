using LibraryManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.BLL
{
    public class BorrowedBook
    {
        private int studentID;
        private string code;
        private DateTime borrowedDate;
        private DateTime returnedDate;

        public BorrowedBook()
        {
            studentID = 0;
            code = string.Empty;
            borrowedDate = DateTime.Now;
            returnedDate = DateTime.Now;
        }

        public BorrowedBook(int studentID, string code, DateTime borrowedDate, DateTime returnedDate)
        {
            this.studentID = studentID;
            this.code = code;
            this.borrowedDate = borrowedDate;
            this.returnedDate = returnedDate;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public string Code { get => code; set => code = value; }
        public DateTime BorrowedDate { get => borrowedDate; set => borrowedDate = value; }
        public DateTime ReturnedDate { get => returnedDate; set => returnedDate = value; }

        public void BorrowNewBook() => BorrowedBookDB.BorrowBook(this);
        public static void ReturnNewBook(int id, string code, DateTime returnDate) => BorrowedBookDB.ReturnBook(id,code,returnDate);

    }
}