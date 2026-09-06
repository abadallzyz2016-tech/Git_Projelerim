using LibrarySystem.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace LibrarySystem.Services
{
    internal class BookService
    {
        string connectionString = $@"Server = .\SQLEXPRESS; DataBase = LibrarySystem; Encrypt = True; integrated security = True; TrustServerCertificate = True;  ";

        public void BookAdd(Add_Book add)
        {
            string isAvailable = "Yes";

            string title = add.text_addbook_title.Text;
            string author = add.text_addbook_author.Text;
            string category = add.text_addbook_category.Text;
            if (!int.TryParse(add.text_addbook_pyear.Text, out int pubYear))
            {
                MessageBox.Show("Please enter a valis publication year. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL Server Operations 
            using SqlConnection connection = new SqlConnection(connectionString);

            string query = @"Insert Into Books (Title, Author, Category, IsAvailable, PublicationYear) Values (@title, @author, @category, @isAvailable, @pubYear)";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@category", category);
            command.Parameters.AddWithValue("@isAvailable", isAvailable);
            command.Parameters.AddWithValue("@pubYear", pubYear);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void BookDelete(Delete_Book delete)
        {
            string title = string.Empty;
            string author = string.Empty;

            title = delete.text_deletebook_title.Text;
            author = delete.text_deletebook_author.Text;
            if (!int.TryParse(delete.text_deletebook_pyear.Text, out int pubYear))
            {
                MessageBox.Show("Please enter a valid publication year.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // SQL Server Operations 

            using SqlConnection connection = new SqlConnection(connectionString);
            string query = @"Delete From Books Where Title = @title AND Author = @author AND PublicationYear = @pubYear";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@pubYear", pubYear);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No book found with the specified title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BookSearch(Search_Book search)
        {
            int id = 0;
            string title = string.Empty;
            string author = string.Empty;
            string category = string.Empty;
            bool isAvailable = true;
            if (int.TryParse(search.text_searchbook_id.Text, out id))
            {
                // Use the ID for the search   
            }
            else
            {
                MessageBox.Show("Please enter a valid book ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // SQL Server Operations 

            using SqlConnection connection = new SqlConnection(connectionString);
            string query = @"Select * From Books Where ID = @id";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                search.text_searchbook_title.Text = reader["Title"].ToString();
                search.text_searchbook_author.Text = reader["Author"].ToString();
                search.text_searchbook_category.Text = reader["Category"].ToString();
                search.text_searchbook_pyear.Text = reader["PublicationYear"].ToString();
                search.text_searchbook_available.Text = reader["IsAvailable"].ToString();
            }
            else
            {
                MessageBox.Show("No book found with the specified details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public void BookList(List_Book list)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            string query = @"Select * From Books Order By ID";
            using SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();
            list.datagridview_listbook.Columns.Add("ID", "ID");
            list.datagridview_listbook.Columns.Add("Title", "Title");
            list.datagridview_listbook.Columns.Add("Author", "Author");
            list.datagridview_listbook.Columns.Add("Category", "Category");
            list.datagridview_listbook.Columns.Add("IsAvailable", "Is Available");
            list.datagridview_listbook.Columns.Add("PublicationYear", "Publication Year");
            while (reader.Read())
            {
                list.datagridview_listbook.Rows.Add(reader["ID"].ToString(), reader["Title"].ToString(), reader["Author"].ToString(), reader["Category"].ToString(), reader["IsAvailable"].ToString(), reader["PublicationYear"].ToString());
            }
            

            connection.Close();
        }
    }
}
