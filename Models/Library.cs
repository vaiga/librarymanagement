using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Librarymanagement.Models
{
    public class Library
    {
        public string path = @"Data Source =NEUDESI-27M3KMR\SQLEXPRESS;Initial Catalog=Librarymanagement;Integrated Security=SSPI";
        public List<librarymodel> BOOKS()
        {
            List<librarymodel> libraryModels = new List<librarymodel>();
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from books1 WHERE status !='Deleted'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                librarymodel lib = new librarymodel();
                lib.BookId = reader.GetInt32(0);
                lib.BookName = reader.GetString(1);
                lib.BookPublishedYear = reader.GetInt32(2);
                lib.BookAuthor = reader.GetString(3);
                lib.BookCategory = reader.GetString(4);
                libraryModels.Add(lib);

            }
            reader.Close();
            con.Close();
            return libraryModels;
        }



        public string Create(librarymodel lib)
        {
            string message;
            SqlConnection connection = new SqlConnection(path);
            connection.Open();
            SqlCommand cmd = new SqlCommand("CreateBook", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Book_Name", lib.BookName);
            cmd.Parameters.AddWithValue("@Book_Published_Year", lib.BookPublishedYear);
            cmd.Parameters.AddWithValue("@Book_Author", lib.BookAuthor);
            cmd.Parameters.AddWithValue("@Book_Category",lib.BookCategory);
            cmd.Parameters.AddWithValue("@status", "Available");
            message = Convert.ToString(cmd.ExecuteScalar());
            connection.Close();
            return message;
        }



        public void Edit(librarymodel bookk)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE books1 SET Book_Name='{bookk.BookName}',Book_published_year={bookk.BookPublishedYear},Book_author='{bookk.BookAuthor}',Book_category='{bookk.BookCategory}' WHERE Book_Id={bookk.BookId}", con);
            int RowCount = cmd.ExecuteNonQuery();
            con.Close();
        }


        public void Delete(int id)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE books1 SET status='Deleted' WHERE Book_id={id}", con);
            int RowCount = cmd.ExecuteNonQuery();
            con.Close();
        }
        public librarymodel Details(int id)
        {
            librarymodel bookk = new librarymodel();
            using (SqlConnection con = new SqlConnection(path))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM books1 WHERE Book_Id={id}", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookk.BookId = id;
                        bookk.BookName = Convert.ToString(reader["Book_Name"]);
                        bookk.BookPublishedYear = Convert.ToInt32(reader["Book_published_year"]);
                        bookk.BookAuthor = Convert.ToString(reader["Book_author"]);
                        bookk.BookCategory = Convert.ToString(reader["Book_category"]);
                    }
                }
            }
            return bookk;
        }

       
        public librarymodel search(string Book_name)
        {
            librarymodel bookk = new librarymodel();
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM books1 WHERE Book_name='{Book_name}' and status = 'Available' ", con);
                SqlDataReader reader = cmd.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        bookk.BookId = Convert.ToInt32(reader["Book_id"]);
                        bookk.BookName = Convert.ToString(reader["Book_Name"]);
                        bookk.BookPublishedYear = Convert.ToInt32(reader["Book_published_year"]);
                        bookk.BookAuthor = Convert.ToString(reader["Book_author"]);
                        bookk.BookCategory = Convert.ToString(reader["Book_category"]);
                    }
                }
                reader.Close();
                con.Close();
            }
            return bookk;
        }
        public List<suggestion> list2()
        {
            List<suggestion> libraryModels = new List<suggestion>();
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from suggestions1", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                suggestion lib = new suggestion();
                lib.SuggestionId = reader.GetInt32(0);
                lib.BookName = reader.GetString(1);    
                lib.BookAuthor = reader.GetString(2);
                lib.BookPublishedYear = reader.GetInt32(3);
               
                if (!reader.IsDBNull(4))
                {
                    lib.status = reader.GetString(4);
                }
               
                if (!reader.IsDBNull(5))
                {
                    lib.BookCategory = reader.GetString(5);
                }
                
                libraryModels.Add(lib);                           
            }
            reader.Close();
            con.Close();
            return libraryModels;
        }
        public void suggest(suggestion bookk)
        {
           
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO suggestions1( Book_Name,Book_Published_Year,Book_Author,Book_Category) VALUES('{bookk.BookName}','{bookk.BookPublishedYear}','{bookk.BookAuthor}','{bookk.BookCategory}')", con);
            int RowCount = cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Reject(int id)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE suggestions1 SET status='Rejected' WHERE suggestion_id={id}", con);
            int RowCount = cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Approve(int id)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE suggestions1 SET status='Approved' WHERE suggestion_id={id}", con);
            int RowCount = cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<Request> List2()
        {
            List<Request> libraryModels = new List<Request>();
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT requests1.user_id,requests1.request_id,requests1.status, userdetails.first_name , userdetails.last_name, books1.Book_name,books1.Book_Id FROM((requests1 INNER JOIN userdetails ON requests1.user_id = userdetails.user_id)INNER JOIN books1 ON requests1.Book_id = books1.Book_id); ", con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Request lib = new Request();
                lib.UserId = reader.GetInt32(0);
                lib.RequestId = reader.GetInt32(1);
                lib.UserName = reader.GetString(3) + " "+reader.GetString(4);
                lib.BookName = reader.GetString(5);
                lib.BookId = reader.GetInt32(6);
              
                if (!reader.IsDBNull(2))
                {
                    lib.status = reader.GetString(2);
                }
                libraryModels.Add(lib);
            }
            reader.Close();
            con.Close();
            return libraryModels;
        }

        public string Register(Registration reg)
        {
            string message;
            SqlConnection connection = new SqlConnection(path);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Registration", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@first_name", reg.FirstName);
            cmd.Parameters.AddWithValue("@last_name", reg.LastName);
            cmd.Parameters.AddWithValue("@mail_id", reg.MailId);
            cmd.Parameters.AddWithValue("@password", reg.Password);
            cmd.Parameters.AddWithValue("@Role", "User");
            message = Convert.ToString(cmd.ExecuteScalar());
            connection.Close();
            return message;
        }

        public UserDetails Login(string MailId,string Password)
        {
            UserDetails user = new UserDetails();
            using (SqlConnection con = new SqlConnection(path))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM userdetails WHERE Mail_Id='{MailId}' and Password='{Password}'", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.UserId = Convert.ToInt32(reader["user_id"]);
                        user.MailId = MailId;
                        user.Password = Password;
                        user.FirstName = Convert.ToString(reader["First_Name"]);
                        user.LastName = Convert.ToString(reader["Last_Name"]);
                        user.Role = Convert.ToString(reader["Role"]);                     
                    }
                }
            }
            return user;
        }
        public string request(Request bookk)
        {
            string message;
            SqlConnection connection = new SqlConnection(path);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Requests", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@User_id", bookk.UserId);
            cmd.Parameters.AddWithValue("@Book_name", bookk.BookName);
            message = Convert.ToString(cmd.ExecuteScalar());
            connection.Close();
            return message;           
        }
        public void RejectRequest(int id)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE requests1 SET status='Rejected' WHERE request_id={id}", con);
            int RowCount = cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ApproveRequest(int id)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE requests1 SET status='Approved' WHERE request_id={id}", con);
            int RowCount = cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateBookStatus(int id)
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE books1 SET status='Not Available' WHERE Book_id={id}", con);
            int RowCount = cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}







