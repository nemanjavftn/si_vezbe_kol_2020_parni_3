using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LibraryRepository
    {
        public List<Library> GetAllBooks()
        {
            List<Library> lib = new List<Library>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Books";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Library l = new Library();
                    l.Id = sqlDataReader.GetInt32(0);
                    l.Name = sqlDataReader.GetString(1);
                    l.NumberOfPages = sqlDataReader.GetInt32(2);

                    lib.Add(l);
                }
            }
            return lib;
        }

        public int InsertBooks(Library l)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Books VALUES ('{0}', {1})",
                        l.Name, l.NumberOfPages);

                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
