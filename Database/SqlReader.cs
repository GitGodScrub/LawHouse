using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{/*
    class SqlReader
    {
        public List<Object> ReadThis(string sqlString, Object toReadType)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString);
            SqlCommand com = new SqlCommand(sqlString, conn);
            SqlDataReader sqld = com.ExecuteReader();

            List<toReadType> listToReturn = new List<toReadType>();
            try
            {
                List<Object> typesToRead = ReaderHelper(sqlString, toReadType, conn, com, sqld);

                conn.Open();
                if (sqld.HasRows)
                {
                    while (sqld.Read())
                    {
                        toReadType @returnItem = new toReadType();
                        for (int i = 0; i < typesToRead.Count; i++)
                        {
                            Object @currentType = typesToRead[i];
                            @returnItem.@currentType = Convert.ChangeType(sqld[$"{@currentType}"], @currentType.GetType());
                        }

                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }

            return listToReturn;
        }

        private List<Object> ReaderHelper(string sqlString, Object toReadType, SqlConnection conn, SqlCommand com, SqlDataReader sqld)
        {
            List<Object> varTypesInObject = new List<object>();
            try
            {
                conn.Open();
                if (sqld.HasRows)
                {
                    while (sqld.Read())
                    {

                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }

            return varTypesInObject;
        }
    }*/
}
