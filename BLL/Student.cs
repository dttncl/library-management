using LibraryManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.BLL
{
    public class Student
    {
        private int studentID;
        private string firstName;
        private string lastName;
        private string password;

        public Student()
        {
            studentID = 0;
            firstName = string.Empty;
            lastName = string.Empty;
            password = string.Empty;
        }

        public Student(int studentID, string firstName, string lastName, string password)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Password { get => password; set => password = value; }

        public static Student Search(int id, string password) => StudentDB.SearchRecord(id, password);
    }
}