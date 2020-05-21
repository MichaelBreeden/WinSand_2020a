using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSand_2020a.ClassLibFrameWork
{
    public class Class1
    {
    }

    public class SQLLiteDatAccess
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
    }

}
