using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;


namespace HotelApi.DataAccess.Repositories
{
    public class GenericRepository<T> where T : class
    {
        private readonly IConfiguration _config;

        public GenericRepository(IConfiguration config)
        {
            _config = config;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        }

        public void Delete(int id)
        {
            using var dbConnection = CreateConnection();
            dbConnection.Open();

            string query = $"DELETE FROM {GetTableName()} WHERE {typeof(T).Name + "Id"} = {id}";

            dbConnection.Execute(query);
        }

        public T GetById(int id)
        {
            using var dbConnection = CreateConnection();
            dbConnection.Open();

            string query = "SELECT * FROM " + GetTableName() + " WHERE " + typeof(T).Name + "Id = " + id; //Assuming that id name rules are EntityName+Id (example: RoomId)

            T queryObj = dbConnection.QueryFirstOrDefault<T>(query);
            return queryObj;
        }

        public List<T> GetList()
        {
            using var dbConnection = CreateConnection();
            dbConnection.Open();

            string query = "SELECT * FROM " + GetTableName();

            List<T> queryList = dbConnection.Query<T>(query).ToList();
            return queryList;
        }

        public void Insert(T entity)
        {
            using var dbConnection = CreateConnection();
            dbConnection.Open();

            string query = "INSERT INTO " + GetTableName() + " (" + GetColumnNames() + " )" +
                                 "VALUES (" + GetParameterValues(entity) + " )";

            dbConnection.Execute(query);
        }

        public void Update(T entity)
        {
            using var dbConnection = CreateConnection();
            dbConnection.Open();

            var properties = typeof(T).GetProperties();
            var columnValuePairs = new List<string>();

            foreach (var prop in properties)
            {
                if (!(ScanPropertyId(prop.Name))) // Exclude the 'Id' property for update operations.
                {
                    var value = prop.GetValue(entity);
                    var formattedValue = FormatPropertyValue(value);
                    columnValuePairs.Add($"{prop.Name} = {formattedValue}");
                }
            }

            string idColumnName = typeof(T).Name + "Id";
            var idProperty = properties.FirstOrDefault(prop => prop.Name.Equals(idColumnName, StringComparison.OrdinalIgnoreCase));
            if (idProperty == null)
            {
                throw new Exception($"No property found for ID column '{idColumnName}'.");
            }

            var idValue = idProperty.GetValue(entity);
            var formattedIdValue = FormatPropertyValue(idValue);

            string query = $"UPDATE {GetTableName()} SET {string.Join(", ", columnValuePairs)} WHERE {idColumnName} = {formattedIdValue}";

            dbConnection.Execute(query);
        }

        private string GetTableName()
        {
            bool IsVowel(char c)
            {
                c = char.ToLower(c);
                return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
            }

            string entityName = typeof(T).Name;

            if (entityName.EndsWith("s") || entityName.EndsWith("x") || entityName.EndsWith("z") ||
                entityName.EndsWith("sh") || entityName.EndsWith("ch"))
            {
                return entityName + "es";
            }
            else if (entityName.EndsWith("y") && entityName.Length > 1 &&
                     !IsVowel(entityName[entityName.Length - 2]))
            {
                entityName = entityName.Substring(0, entityName.Length - 1);
                return entityName + "ies";
            }
            else if (entityName.EndsWith("f") || entityName.EndsWith("fe"))
            {
                entityName = entityName.Substring(0, entityName.Length - (entityName.EndsWith("fe") ? 2 : 1));
                return entityName + "ves";
            }
            else
            {
                return entityName + "s";
            }
        }

        private string GetColumnNames()
        {
            var properties = typeof(T).GetProperties();
            List<string> columnNames = new List<string>();
            foreach (var prop in properties)
            {
                if (!(ScanPropertyId(prop.Name))) // Exclude the 'Id' property for insert operations.
                {
                    columnNames.Add(prop.Name);
                }
            }
            return string.Join(", ", columnNames);
        }

        private string GetParameterValues(T entity)
        {
            var properties = typeof(T).GetProperties();
            List<string> parameterValues = new List<string>();

            foreach (var prop in properties)
            {
                if (!(ScanPropertyId(prop.Name))) // Exclude the 'Id' property for insert operations.
                {
                    var value = prop.GetValue(entity);
                    var formattedValue = FormatPropertyValue(value);
                    parameterValues.Add(formattedValue);
                }
            }

            return string.Join(", ", parameterValues);
        }

        private string FormatPropertyValue(object value)
        {
            if (value == null)
            {
                return "NULL";
            }
            else if (value is string)
            {
                return "'" + value.ToString().Replace("'", "''") + "'";
            }
            else if (value is DateTime dateTime)
            {
                return "'" + dateTime.ToString("yyyy-MM-dd HH:mm:ss") + "'";
            }
            else
            {
                return value.ToString();
            }
        }

        private bool ScanPropertyId(string text)
        {
            return text.ToLower() == typeof(T).Name.ToLower() + "id";
        }

    }
}