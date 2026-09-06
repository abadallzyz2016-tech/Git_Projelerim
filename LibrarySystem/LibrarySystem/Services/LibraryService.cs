using LibrarySystem.Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace LibrarySystem.Services
{
    internal class LibraryService
    {
        string connectionString = $@"Server = .\SQLEXPRESS; DataBase = LibrarySystem; Encrypt = True; integrated security = True; TrustServerCertificate = True;";

        public void BorrowBook(BorrowBook borrow)
        {
            if (CheckBook(borrow))
            {
                if (int.TryParse(borrow.text_borrowbook_id.Text, out int bookID))
                {
                    using SqlConnection connection = new SqlConnection(connectionString);

                    string queryBook = "Update Books set IsAvailable = @isAvailable where ID = @bookID";
                    using SqlCommand commandbook = new SqlCommand(queryBook, connection);

                    commandbook.Parameters.AddWithValue("@isAvailable", "No");
                    commandbook.Parameters.AddWithValue("@bookID", bookID);

                    string querymember = "Update Members set NoOfActiveBooks = NoOfActiveBooks + 1 where ID = @memberID";
                    using SqlCommand commandmember = new SqlCommand(querymember, connection);

                    commandmember.Parameters.AddWithValue("@memberID", borrow.text_borrowbook_memberid.Text);

                    string queryborrowing = "INSERT INTO Borrowing (BookID, MemberID, BorrowDate) VALUES (@bookID, @memberID, getdate())";
                    using SqlCommand commandborrowing = new SqlCommand(queryborrowing, connection);

                    commandborrowing.Parameters.AddWithValue("@bookID", bookID);
                    commandborrowing.Parameters.AddWithValue("@memberID", borrow.text_borrowbook_memberid.Text);

                    connection.Open();
                    commandbook.ExecuteNonQuery();
                    commandmember.ExecuteNonQuery();
                    commandborrowing.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("You borrowed the book Successfully ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        public bool CheckBook(BorrowBook check)
        {
            if (!string.IsNullOrEmpty(check.text_borrowbook_id.Text) && !string.IsNullOrEmpty(check.text_borrowbook_memberid.Text))
            {
                if (int.TryParse(check.text_borrowbook_id.Text, out int bookID) && int.TryParse(check.text_borrowbook_memberid.Text, out int memberID))
                {

                    using SqlConnection connection2 = new SqlConnection(connectionString);
                    string query2 = "Select ID From Members Where ID = @memberID";
                    using SqlCommand command2 = new SqlCommand(query2, connection2);
                    command2.Parameters.AddWithValue("@memberID", memberID);
                    connection2.Open();
                    if (command2.ExecuteScalar() != null)
                    {
                        using SqlConnection connection = new SqlConnection(connectionString);
                        string querymember = "SELECT * FROM Members Where ID = @memberID";
                        using SqlCommand command = new SqlCommand(querymember, connection);
                        command.Parameters.AddWithValue("@memberID", memberID);
                        connection.Open();
                        using SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            check.text_borrowbook_firstname.Text = reader["FirstName"].ToString();
                            check.text_borrowbook_lastname.Text = reader["LastName"].ToString();
                            check.text_borrowbook_phone.Text = reader["Phone"].ToString();
                            check.text_borrowbook_reg.Text = reader["RegistrationsDate"].ToString();
                        }
                        connection2.Close();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Member Not Found! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    string available = string.Empty;
                    using SqlConnection connection1 = new SqlConnection(connectionString);
                    string query1 = "Select ID from Books where ID = @bookID";
                    using SqlCommand command1 = new SqlCommand(query1, connection1);
                    command1.Parameters.AddWithValue("@bookID", bookID);
                    connection1.Open();
                    if (command1.ExecuteScalar() != null)
                    {
                        using SqlConnection connection = new SqlConnection(connectionString);
                        string query = "SELECT * FROM Books Where ID = @bookID";
                        using SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@bookID", bookID);
                        connection.Open();
                        using SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            check.text_borrowbook_title.Text = reader["Title"].ToString();
                            check.text_borrowbook_author.Text = reader["Author"].ToString();
                            check.text_borrowbook_category.Text = reader["Category"].ToString();
                            check.text_borrowbook_pyear.Text = reader["PublicationYear"].ToString();
                            check.text_borrowbook_isavailable.Text = reader["IsAvailable"].ToString();
                            if (check.text_borrowbook_isavailable.Text == "Yes")
                            {
                                available = "Yes";
                            }
                            else
                            {
                                available = "No";
                                MessageBox.Show("Book is not available for borrowing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        connection1.Close();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Book Not Found! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                MessageBox.Show("You can borrow the book!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Please enter both Book ID and Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ReturnBook(ReturnBook returnbook)
        {
            if (int.TryParse(returnbook.text_returnbook_id.Text, out int bookID) &&
                int.TryParse(returnbook.text_returnbook_memberid.Text, out int memberID))
            {
                using SqlConnection connection = new SqlConnection(connectionString);

                string checkQuery = "SELECT IsAvailable FROM Books WHERE ID = @bookID";

                using SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@bookID", bookID);
                using SqlCommand commandMember = new SqlCommand("SELECT * FROM Members WHERE ID = @memberID", connection);
                commandMember.Parameters.AddWithValue("@memberID", memberID);
                connection.Open();
                object result = checkCommand.ExecuteScalar();
                using SqlDataReader reader = commandMember.ExecuteReader();

                while (reader.Read())
                {
                    returnbook.text_returnbook_firstname.Text = reader["FirstName"].ToString();
                    returnbook.text_returnbook_lastname.Text = reader["LastName"].ToString();
                    returnbook.text_returnbook_phone.Text = reader["Phone"].ToString();
                    returnbook.text_returnbook_reg.Text = reader["RegistrationsDate"].ToString();
                }
                connection.Close();
                if (result == null)
                {
                    MessageBox.Show(
                        "Book not found!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                string isAvailable = result.ToString();
                connection.Open();
                using SqlCommand commandbook1 = new SqlCommand("Select * From Books Where ID = @BookID", connection);
                commandbook1.Parameters.AddWithValue("@BookID", bookID);
                using SqlDataReader bookDataReader = commandbook1.ExecuteReader();
                while (bookDataReader.Read())
                {
                    returnbook.text_returnbook_title.Text = bookDataReader["Title"].ToString();
                    returnbook.text_returnbook_author.Text = bookDataReader["Author"].ToString();
                    returnbook.text_returnbook_category.Text = bookDataReader["Category"].ToString();
                    returnbook.text_returnbook_pyear.Text = bookDataReader["PublicationYear"].ToString();
                    returnbook.text_returnbook_isavailable.Text = bookDataReader["IsAvailable"].ToString();
                }
                connection.Close();

                connection.Open();
                if (isAvailable == "Yes")
                {
                    MessageBox.Show(
                        "This book has not been borrowed. It cannot be returned.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                string queryBorrowings = "UPDATE Borrowings " +
                    "SET    IsReturned = 1,ReturnDate = GETDATE()" +
                    "WHERE MemberID = @memberID AND BookID = @bookID" +
                    "AND IsReturned = 0;";
                using SqlCommand commandBorrowings = new SqlCommand(queryBorrowings, connection);
                commandBorrowings.Parameters.AddWithValue("@memberID", memberID);
                commandBorrowings.Parameters.AddWithValue("@bookID", bookID);
                string queryBook =
                    "UPDATE Books SET IsAvailable = @isAvailable WHERE ID = @bookID";

                using SqlCommand commandbook = new SqlCommand(queryBook, connection);

                commandbook.Parameters.AddWithValue("@isAvailable", "Yes");
                commandbook.Parameters.AddWithValue("@bookID", bookID);

                string querymember =
                    "UPDATE Members SET NoOfActiveBooks = NoOfActiveBooks - 1 WHERE ID = @memberID";
                using SqlCommand commandmember = new SqlCommand(querymember, connection);
                commandmember.Parameters.AddWithValue("@memberID", memberID);

                commandbook.ExecuteNonQuery();
                commandmember.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(
                    "You returned the book successfully!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please enter valid Book ID and Member ID.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        public void BooksLoan(BooksLoan booksLoan)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            string queryloan = "Select * From Books Where IsAvailable = 'Yes'";
            using SqlCommand commandbook = new SqlCommand(queryloan, connection);
            connection.Open();
            using SqlDataReader reader = commandbook.ExecuteReader();
            booksLoan.datagridview_booksloan.Columns.Add("ID", "ID");
            booksLoan.datagridview_booksloan.Columns.Add("Title", "Title");
            booksLoan.datagridview_booksloan.Columns.Add("Author", "Author");
            booksLoan.datagridview_booksloan.Columns.Add("Category", "Category");
            booksLoan.datagridview_booksloan.Columns.Add("IsAvailable", "Is Available");
            booksLoan.datagridview_booksloan.Columns.Add("PublicationYear", "Publication Year");
            while (reader.Read())
            {
                booksLoan.datagridview_booksloan.Rows.Add(reader["ID"].ToString(), reader["Title"].ToString(), reader["Author"].ToString(), reader["Category"].ToString(), reader["IsAvailable"].ToString(), reader["PublicationYear"].ToString());
            }
            connection.Close();

        }

        public void HistoryLoan(LoanHistory loanHistory) 
        {
            if (loanHistory.text_loanhistory_memberid.Text != null && loanHistory.text_loanhistory_memberid.Text != "")
            {
                using SqlConnection connection = new SqlConnection(connectionString);

                string queryCheck = "Select ID From Members Where ID = @MemberID";

                using SqlCommand memberCheck = new SqlCommand(queryCheck, connection);
                memberCheck.Parameters.AddWithValue("@MemberID", loanHistory.text_loanhistory_memberid.Text);
                connection.Open();
                using SqlDataReader memberReader = memberCheck.ExecuteReader();
                bool memberExists = memberReader.HasRows;
                
                memberReader.Close();
                connection.Close();

                if (memberExists)
                {

                    string query = @"SELECT b.ID, b.Title, b.Author, b.Category, b.PublicationYear, m.FirstName, m.LastName, br.BorrowDate
                                     FROM Borrowings br
                                     INNER JOIN Books b ON br.BookID = b.ID
                                     INNER JOIN Members m ON br.MemberID = m.ID
                                     WHERE m.ID = @memberID";

                    using SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@memberID", loanHistory.text_loanhistory_memberid.Text);

                    connection.Open();
                    using SqlDataReader reader = command.ExecuteReader();

                    if (loanHistory.datagridview_loanhistory.Columns.Count == 0)
                    {
                        loanHistory.datagridview_loanhistory.Columns.Add("FirstName", "First Name");
                        loanHistory.datagridview_loanhistory.Columns.Add("LastName", "Last Name");
                        loanHistory.datagridview_loanhistory.Columns.Add("BookID", "Book ID");
                        loanHistory.datagridview_loanhistory.Columns.Add("Title", "Title");
                        loanHistory.datagridview_loanhistory.Columns.Add("Author", "Author");
                        loanHistory.datagridview_loanhistory.Columns.Add("Category", "Category");
                        loanHistory.datagridview_loanhistory.Columns.Add("PublicationYear", "Publication Year");
                        loanHistory.datagridview_loanhistory.Columns.Add("BorrowDate", "Borrow Date");
                    }

                    while (reader.Read())
                    {
                        loanHistory.datagridview_loanhistory.Rows.Add(reader["ID"], reader["Title"], reader["Author"], reader["Category"], reader["PublicationYear"], reader["FirstName"], reader["LastName"], reader["BorrowDate"]);
                    }
                    connection.Close();
                }
                else
                {
                    loanHistory.datagridview_loanhistory.Columns.Clear();
                    loanHistory.datagridview_loanhistory.Rows.Clear();
                    MessageBox.Show(
                        "Member not found!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show(
                    "Please enter a valid Member ID.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

        }



    }
}
