using LibraryManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.BLL
{
    public class Librarian
    {
        private int librarianID;
        private string firstName;
        private string lastName;
        private string password;

        public Librarian()
        {
            librarianID = 0;
            firstName = string.Empty;
            lastName = string.Empty;
            password = string.Empty;
        }

        public Librarian(int librarianID, string firstName, string lastName, string password)
        {
            this.librarianID = librarianID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
        }

        public int LibrarianID { get => librarianID; set => librarianID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Password { get => password; set => password = value; }

        public static Librarian Search(int id, string password) => LibrarianDB.SearchRecord(id, password);

    }
}