using LibraryManagement.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagement.DAL
{
    public class LibrarianDB
    {
        // search one librarian
        public static Librarian SearchRecord(int ID, string password)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM LIBRARIANS WHERE LibrarianID = @LibrarianID AND Password = @Password";
                cmd.Parameters.AddWithValue("@LibrarianID", ID);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                Librarian lib = null;
                if (reader.Read())
                {
                    lib = new Librarian();
                    lib.LibrarianID = Convert.ToInt32(reader["LibrarianID"]);
                    lib.FirstName = reader["FirstName"].ToString();
                    lib.LastName = reader["LastName"].ToString();
                    lib.Password = reader["Password"].ToString();
                }

                return lib;
            }
        }
    }
}