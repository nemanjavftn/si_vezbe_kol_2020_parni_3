using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            List<Book> b = new List<Book>();

            using (SqlConnection con = new SqlConnection(Constants.conString))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "SELECT * FROM Books";

                con.Open();
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    Book item = new Book();
                    item.Id = dr.GetInt32(0);
                    item.Name = dr.GetString(1);
                    item.NumberOfPages = dr.GetInt32(2);

                    b.Add(item);

                }

                return b;

            }
        }

        public int InsertBook(Book b)
        {
            int result;
            using (SqlConnection con = new SqlConnection(Constants.conString))
            {
                string commandText = string.Format("INSERT INTO Books VALUES( '{0}', {1})",  b.Name, b.NumberOfPages);
                SqlCommand com = new SqlCommand(commandText, con);

                con.Open();
                result = com.ExecuteNonQuery();
            }

            return result;
        }

    }
}
