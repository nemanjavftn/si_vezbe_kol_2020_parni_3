using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookRepository
    {
        public int InsertBook(Book book)
        {
            using (SqlConnection sqlConn = new SqlConnection(Constants.connString))
            {
                sqlConn.Open();
                SqlCommand comm = new SqlCommand(
                    string.Format("INSERT INTO dbo.Books VALUES('{0}',{1})", book.Name, book.NumberOfpages),
                    sqlConn);

                return comm.ExecuteNonQuery();
            }

        }
        public List<Book> GetAllBooks()
        {
            using (SqlConnection sqlConn = new SqlConnection(Constants.connString))
            {
                sqlConn.Open();
                List<Book> list = new List<Book>();
                SqlCommand comm = new SqlCommand(
                    "SELECT * FROM dbo.Books",
                    sqlConn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {

                    Book bk = new Book();
                    bk.Id = reader.GetInt32(0);
                    bk.Name = reader.GetString(1);
                    bk.NumberOfpages = reader.GetInt32(2);
                    list.Add(bk);

                }
                return list;
            }
        }
    }
}
