using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using LinqToDB;
using LinqToDB.Data;

namespace DAL
{
    public class ConexionRepository 
    {
        public string ConnectionString;
        internal SqlConnection connection;

        public ConexionRepository(string conectionrepository) {

            ConnectionString = conectionrepository;
            connection = new SqlConnection(ConnectionString);

        }

        public void Open()
        {
            connection.Open();
        }

        public void Close() { 
             connection.Close();   
        }

        
    }
}
