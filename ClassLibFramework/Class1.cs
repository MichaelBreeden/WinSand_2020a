using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SQLite;

namespace WinSand_2020a.ClassLibFrameWork
{
    public class Class1
    {
    }

    public class SQLLiteDataAccess
    {
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionSring())) // SQLLiteDatAccess())
            {
                // This will make IEnumerable.
                var people = cnn.Query<PersonModel>("select * from Persons", new DynamicParameters());
                return people.ToList();
            }
        }
        public static void SavePerson(PersonModel person)
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionSring())) // SQLLiteDatAccess())
            {
                cnn.Execute("insert into persons (FirstName, LastName) values (@FirstName, @LastName)", person);
            }
        }
        public static void DeletePerson(PersonModel person)
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionSring())) // SQLLiteDatAccess())
            {
                cnn.Execute("delete from persons where FirstName = ''"); //   (FirstName, LastName) values (@FirstName, @LastName)", person);
            }
        }

        private static string LoadConnectionSring(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ToString();
        }
    } // End class SQLLiteDataAccess

#if THIS_SQLITE_CODE_CAME_FROM_ANOTHER_PROJECT 

    public class c_DalLite
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        //private DataSet DS = null;
        //private DataTable DT = null;

        private string ConnectionString = null;

        private void SetConnection()
        {
            sql_con = new SQLiteConnection(ConnectionString);
            // Pass any errors up
        }

        public void ExecuteQuery(string strQuery, DataSet ds, out string strError, out string strExMsg)
        {
            strError = String.Empty;
            strExMsg = String.Empty;
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                DB = new SQLiteDataAdapter(strQuery, sql_con);
                //DS.Reset();
                ds.Reset();
                DB.Fill(ds);
            }
            catch (Exception ex)
            {
                strError = "Error ExecuteQuery()";
                strError = ex.Message;
            }
            finally
            {
                sql_con.Close();
            }
        }

        public void ExecuteNonQuery(string txtQuery, out string strError, out string strExMsg)
        {
            strError = String.Empty;
            strExMsg = String.Empty;
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = txtQuery;
                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
            catch (Exception ex)
            {
                strError = "Error ExecuteNonQuery()";
                strError = ex.Message;
            }
            finally
            {
                sql_con.Close();
            }
        }

        public static void statExecuteQuery(string strQuery, DataSet ds, string ConnectionString, out string strError, out string strExMsg)
        {
            SQLiteConnection sql_con;
            SQLiteCommand sql_cmd;
            SQLiteDataAdapter DB;
            sql_con = new SQLiteConnection(ConnectionString);
            strError = String.Empty;
            strExMsg = String.Empty;
            try
            {
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                DB = new SQLiteDataAdapter(strQuery, sql_con);
                //DS.Reset();
                ds.Reset();
                DB.Fill(ds);
            }
            catch (Exception ex)
            {
                strError = "Error ExecuteQuery()";
                strError = ex.Message;
            }
            finally
            {
                sql_con.Close();
            }
        }

        public static void statExecuteNonQuery(string strQuery, string ConnectionString, out string strError, out string strExMsg)
        {
            SQLiteConnection sql_con;
            SQLiteCommand sql_cmd;
            sql_con = new SQLiteConnection(ConnectionString);
            strError = String.Empty;
            strExMsg = String.Empty;
            try
            {
                sql_con = new SQLiteConnection(ConnectionString);
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = strQuery;
                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
            catch (Exception ex)
            {
                strError = "Error ExecuteNonQuery()";
                strError = ex.Message;
            }
            finally
            {
                sql_con.Close();
            }
        }

        public static void createDb(string strName, out string strError, out string strExMsg)
        {
            strError = String.Empty;
            strExMsg = String.Empty;
            try
            {
                SQLiteConnection.CreateFile(strName);
            }
            catch (Exception ex)
            {
                strError = "Error createDb()";
                strError = ex.Message;
            }
        }

        public void createTable(string strName, string strColumns, out string strError, out string strExMsg)
        {
            strError = String.Empty;
            strExMsg = String.Empty;
            string strQuery = "CREATE TABLE IF NOT EXISTS " + strName + "(" + strColumns + ");";
            ExecuteNonQuery(strQuery, out strError, out strExMsg);
        }
    }     // End Class
#endif
}
