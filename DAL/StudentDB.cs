using LibraryManagement.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagement.DAL
{
    public class StudentDB
    {
        // search one student
        public static Student SearchRecord(int ID, string password)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM STUDENTS WHERE StudentID = @StudentId AND Password = @Password";
                cmd.Parameters.AddWithValue("@StudentId", ID);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                Student stud = null;
                if (reader.Read())
                {
                    stud = new Student();
                    stud.StudentID = Convert.ToInt32(reader["StudentID"]);
                    stud.FirstName = reader["FirstName"].ToString();
                    stud.LastName = reader["LastName"].ToString();
                    stud.Password = reader["Password"].ToString();
                }

                return stud;
            }
        }
    }
}