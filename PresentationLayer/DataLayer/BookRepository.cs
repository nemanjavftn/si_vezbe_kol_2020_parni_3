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
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Books";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    Book b = new Book();
                    b.Id = sqlDataReader.GetInt32(0);
                    b.Name = sqlDataReader.GetString(1);
                    b.NumberOfPages = sqlDataReader.GetInt32(2);
                    books.Add(b);
                }
            }
            return books;
        }
        public int InsertBook(Book b)
        {
           using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =string.Format( "INSERT INTO Books VALUES ('{0}',{1})",b.Name,b.NumberOfPages);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }    
          
        }
    }
}
