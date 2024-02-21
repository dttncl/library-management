using LibraryManagement.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement.GUI
{
    public partial class LibrarianDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Librarian lib = (Librarian)Session["User"];
            LabelLibrarianName.Text = lib.FirstName + " " + lib.LastName;
        }
    }
}