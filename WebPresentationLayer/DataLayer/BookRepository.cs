using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BookRepository
    {
        public List<Book> GetAllBoks()
        {
            List<Book> result = new List<Book>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString)) 
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Books";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Book b = new Book();
                    b.Id = sqlDataReader.GetInt32(0);
                    b.Name = sqlDataReader.GetString(1);
                    b.NumberOfPages = sqlDataReader.GetInt32(2);
                    result.Add(b);
                }
            }

            return result;
        }
        public int InsertStudent(Book b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Books VALUES('{0}',{1})", b.Name, b.NumberOfPages );
                return sqlCommand.ExecuteNonQuery();
            }

        }
    }
}