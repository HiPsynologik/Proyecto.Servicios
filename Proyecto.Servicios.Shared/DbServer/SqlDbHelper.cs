using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Servicios.Shared.DbServer
{
    public class SqlDbHelper : IDisposable
    {
        private SqlConnection sqlConnection;

        public SqlDbHelper(string ConnectionStringSqlServer)
        {
            sqlConnection = new SqlConnection(ConnectionStringSqlServer);
            sqlConnection.Open();
        }

        public SqlDataReader ExecuteReader(string StoredProcedureName)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = StoredProcedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            reader = cmd.ExecuteReader();

            return reader;
        }

        public SqlDataReader ExecuteReader(string StoredProcedureName, List<DbParameterItem> parameter)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = StoredProcedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            if (parameter.Count > 0)
            {
                foreach(var item in parameter)
                {
                    cmd.Parameters.AddWithValue(item.ParameterNameSP, item.Value);
                }
            }
            reader = cmd.ExecuteReader();

            return reader;
        }

        public object ExecuteNonQuery(string StoredProcedureName, List<DbParameterItem> parameter)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter returnParameter = new SqlParameter();

            cmd.CommandText = StoredProcedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            if (parameter.Count > 0)
            {
                foreach (var item in parameter)
                {
                    if(item.ParameterDirection.Equals(ParameterDirection.ReturnValue))
                    {
                        returnParameter = cmd.Parameters.AddWithValue(item.ParameterNameSP, item.Value);
                        returnParameter.Direction = item.ParameterDirection;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue(item.ParameterNameSP, item.Value);
                    }
                }
            }
            cmd.ExecuteNonQuery();

            return returnParameter.Value;
        }

        public void Dispose()
        {
            sqlConnection.Close();
            GC.SuppressFinalize(this);
        }
    }
}
