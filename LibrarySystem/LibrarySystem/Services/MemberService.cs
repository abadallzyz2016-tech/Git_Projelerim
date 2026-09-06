using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using LibrarySystem.Forms;
using Microsoft.Data.SqlClient;

namespace LibrarySystem.Services
{
    internal class MemberService
    {
        string connectionString = $@"Server = .\SQLEXPRESS; DataBase = LibrarySystem; Encrypt = True; integrated security = True; TrustServerCertificate = True;  ";

        public void MemberAdd(Add_Member add)
        {
            if (!string.IsNullOrEmpty(add.text_addmember_firstname.Text) && !string.IsNullOrEmpty(add.text_addmember_lastname.Text) && !string.IsNullOrEmpty(add.text_addmember_phone.Text))
            {
                // Proceed with member addition

                string RegistrationsDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string firstName = add.text_addmember_firstname.Text;
                string lastName = add.text_addmember_lastname.Text;
                string phone = add.text_addmember_phone.Text;
                string fullname = firstName + " " + lastName;
                // SQL Server Operations 
                using SqlConnection connection = new SqlConnection(connectionString);
                string query = @"Insert Into Members (FirstName, LastName,FullName, Phone, RegistrationsDate) Values (@firstName, @lastName, @fullname, @phone, @RegistrationsDate)";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@fullname", fullname);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@RegistrationsDate", RegistrationsDate);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add.text_addmember_firstname.Clear();
                add.text_addmember_lastname.Clear();
                add.text_addmember_phone.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public void MemberDelete(Delete_Member delete)
        {
            string firstName = delete.text_deletemember_firstname.Text;
            string lastName = delete.text_deletemember_lastname.Text;
            string fullname = firstName + " " + lastName;
            // SQL Server Operations 
            using SqlConnection connection = new SqlConnection(connectionString);
            string query = @"Delete From Members Where FullName = @fullname";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@fullname", fullname);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                delete.text_deletemember_firstname.Clear();
                delete.text_deletemember_lastname.Clear();
            }
            else
            {
                MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MemberList(List_Member list)
        {
            // SQL Server Operations 
            using SqlConnection connection = new SqlConnection(connectionString);
            string query = @"Select * From Members order by ID";
            using SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();
            list.datagridview_listmember.Columns.Add("Id", "ID");
            list.datagridview_listmember.Columns.Add("FirstName", "First Name");
            list.datagridview_listmember.Columns.Add("LastName", "Last Name");
            list.datagridview_listmember.Columns.Add("FullName", "Full Name");
            list.datagridview_listmember.Columns.Add("Phone", "Phone");
            list.datagridview_listmember.Columns.Add("RegistrationsDate", "Registration Date");

            while (reader.Read())
            {
                list.datagridview_listmember.Rows.Add(reader["Id"], reader["FirstName"], reader["LastName"], reader["FullName"], reader["Phone"], reader["RegistrationsDate"]);
            }
            connection.Close();


        }

        public void MemberSearch(Search_Member search)
        {
            if(int.TryParse(search.text_searchmember_id.Text, out int memberId))
            {
                // SQL Server Operations 
                using SqlConnection connection = new SqlConnection(connectionString);
                string query = @"Select * From Members Where ID = @memberId";
                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@memberId", memberId);
                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    search.text_searchmember_firstname.Text = reader["FirstName"].ToString();
                    search.text_searchmember_lastname.Text = reader["LastName"].ToString();
                    search.text_searchmember_phone.Text = reader["Phone"].ToString();
                    search.text_searchmember_regdate.Text = reader["RegistrationsDate"].ToString();
                }
                else
                {
                    MessageBox.Show("No member found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

         
