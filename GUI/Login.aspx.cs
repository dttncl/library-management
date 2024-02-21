using LibraryManagement.BLL;
using LibraryManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RadioButtonListUser.Items.Add("Student");
            RadioButtonListUser.Items.Add("Librarian");

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            switch(RadioButtonListUser.SelectedIndex)
            {
                case 0:
                    int id = Convert.ToInt32(TextBoxID.Text);
                    string password = TextBoxPassword.Text;

                    Student stud = Student.Search(id, password);

                    if (stud != null)
                    {
                        Session["User"] = stud;
                        Response.Redirect("StudentLibrary.aspx");
                    }

                    break;
                case 1:
                    id = Convert.ToInt32(TextBoxID.Text);
                    password = TextBoxPassword.Text;

                    Librarian lib = Librarian.Search(id, password);

                    if (lib != null)
                    {
                        Session["User"] = lib;
                        Response.Redirect("LibrarianDashboard.aspx");
                    }

                    break;
                    break;
                default:
                    break;
            }
        }
    }
}