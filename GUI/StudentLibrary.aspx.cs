using LibraryManagement.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement.GUI
{
    public partial class StudentLibrary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Student stud = (Student)Session["User"];
                LabelStudentName.Text = stud.FirstName + " " + stud.LastName;

                // set as auto post-back
                DropDownListAvailBooks.DataSource = Book.GetAvailableBooks(stud.StudentID);
                DropDownListAvailBooks.DataTextField = "Name";
                DropDownListAvailBooks.DataValueField = "Code";
                DropDownListAvailBooks.DataBind();

                if (Book.Search(DropDownListAvailBooks.SelectedValue) != null)
                {
                    LabelABAuthor.Text = Book.Search(DropDownListAvailBooks.SelectedValue).Author;

                }
                else
                {
                    LabelABAuthor.Text = "";

                }

                // set as auto post-back
                DropDownListBorrowBooks.DataSource = Book.GetBooks(stud.StudentID);
                DropDownListBorrowBooks.DataTextField = "Name";
                DropDownListBorrowBooks.DataValueField = "Code";
                DropDownListBorrowBooks.DataBind();

                if (Book.Search(DropDownListBorrowBooks.SelectedValue) != null)
                {
                    LabelBBAuthor.Text = Book.Search(DropDownListBorrowBooks.SelectedValue).Author;

                } else
                {
                    LabelBBAuthor.Text = "";

                }


            }
        }

        protected void DropDownListAvailBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelABAuthor.Text = Book.Search(DropDownListAvailBooks.SelectedValue).Author;

        }

        protected void DropDownListBorrowBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelBBAuthor.Text = Book.Search(DropDownListBorrowBooks.SelectedValue).Author;

        }

        protected void CalendarBorrow_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonBorrow_Click(object sender, EventArgs e)
        {
            DateTime borrowDate = CalendarBorrow.SelectedDate;
            DateTime returnDate = DateTime.Now;

            string code = DropDownListAvailBooks.SelectedValue;
            Student stud = (Student)Session["User"];
            int id = stud.StudentID;

            BorrowedBook borrowedbook = new BorrowedBook(id, code, borrowDate, returnDate);
            borrowedbook.BorrowNewBook();
        }

        protected void ButtonReturn_Click(object sender, EventArgs e)
        {
            DateTime returnDate = CalendarReturn.SelectedDate;

            string code = DropDownListBorrowBooks.SelectedValue;
            Student stud = (Student)Session["User"];
            int id = stud.StudentID;

            BorrowedBook.ReturnNewBook(id, code, returnDate);
        }
    }
}