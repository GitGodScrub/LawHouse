using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    static class SqlReader //By Julius
    {
        
        public static List<List<string>> ReadThisSql(string sqlString)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString);
            SqlCommand com = new SqlCommand(sqlString, conn);
            List<List<string>> toReturn = new List<List<string>>();

            try
            {
                conn.Open();
                SqlDataReader sqld = com.ExecuteReader();
                if (sqld.HasRows)
                {
                    while (sqld.Read())
                    {
                        List<string> collectedAttributes = new List<string>();
                        for (int i = 0; i < sqld.FieldCount; i++)
                        {
                            collectedAttributes.Add(Convert.ToString(sqld.GetValue(i)));
                        }
                        toReturn.Add(collectedAttributes);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return toReturn;
        }
        

        /*
        public static List<string[]> ReadThisSqlPrototype(string sqlString, Type objectType)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString);
            SqlCommand com = new SqlCommand(sqlString, conn);
            List<string[]> typesToRead = getColumnInfo(conn, com);
            List<string[]> returnList = new List<string[]>();
            //List<int, string[]> returnList = new List<int, string[]>(); //Experimental - new idea
            try
            {
                conn.Open();
                SqlDataReader sqld = com.ExecuteReader();
                if (sqld.HasRows)
                {
                    int runCount = 0;
                    while (sqld.Read())
                    {
                        
                        string[] writeToList = new string[2];
                        for (int i = 0; i < sqld.FieldCount; i++)
                        {

                            string fieldName = typesToRead[i][0];
                            dynamic fieldValueRaw = sqld[$"{fieldName}"];
                            string fieldValueConverted = Convert.ToString(fieldValueRaw);

                            writeToList[0] = fieldName;
                            writeToList[1] = fieldValueConverted;
                        }
                        // returnList.Add(runCount, writeToList); //Experimental - new idea
                        runCount++;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return returnList;
        }
        */

        /*
        public static List<dynamic> SqlReadThisOld(string sqlString, Type objectType)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString);
            SqlCommand com = new SqlCommand(sqlString, conn);
            List<string[]> typesToRead = getColumnInfo(conn, com);

            List<dynamic> returnList = new List<dynamic>() {objectType};
            try
            {
                conn.Open();
                SqlDataReader sqld = com.ExecuteReader();
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
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return returnList;
        }
        */

       /* 
        private static List<string[]> getColumnInfo(SqlConnection conn, SqlCommand com)
        {
            List<string[]> columnInfo = new List<string[]>();
            try
            {
                conn.Open();
                SqlDataReader sqld = com.ExecuteReader();
                for (int i = 0; i < sqld.FieldCount; i++)
                {
                    string[] arrayWithInfo = new string[2];
                    arrayWithInfo[0] = sqld.GetName(i).ToString();
                    arrayWithInfo[1] = sqld.GetFieldType(i).ToString();
                    columnInfo.Add(arrayWithInfo);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return columnInfo;
        }
        */
    }
}
