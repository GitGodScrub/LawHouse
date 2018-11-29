using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class SqlReader
    {
        public List<object> ReadThis(string sqlString, Type objectType)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString);
            SqlCommand com = new SqlCommand(sqlString, conn);
            SqlDataReader sqld = com.ExecuteReader();

            List<object> returnList = new List<object>() {objectType};
            List<string[]> typesToRead = getColumnInfo(conn, sqld);
            try
            {
                conn.Open();
                if (sqld.HasRows)
                {
                    while (sqld.Read())
                    {
                        dynamic instanceToAddToList = Activator.CreateInstance(objectType);
                        for (int i = 0; i < sqld.FieldCount; i++)
                        {
                            string fieldName = typesToRead[i][0];
                            var fieldValueRaw = sqld[$"{fieldName}"];
                            Type fieldType = objectType.GetProperty(fieldName).GetType();
                            var fieldValueConverted = Convert.ChangeType(fieldValueRaw, fieldType);

                            instanceToAddToList.GetProperty(fieldName).SetValue(fieldName, fieldValueConverted, null);
                        }
                        returnList.Add(instanceToAddToList);
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
            return returnList;
        }
        private List<string[]> getColumnInfo(SqlConnection conn, SqlDataReader sqld)
        {
            List<string[]> columnInfo = new List<string[]>();
            try
            {
                conn.Open();
                for (int i = 0; i < sqld.FieldCount; i++)
                {
                    string[] arrayWithInfo = new string[2];
                    arrayWithInfo[0] = sqld.GetName(i).ToString();
                    arrayWithInfo[1] = sqld.GetFieldType(i).ToString();
                    columnInfo.Add(arrayWithInfo);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return columnInfo;
        }
    }
}
