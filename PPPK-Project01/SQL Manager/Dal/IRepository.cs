using SQL_Manager.Model;
using System.Collections.Generic;
using System.Data;

namespace SQL_Manager.Dal
{
    interface IRepository
    {
        DataSet CreateDataSet(DBEntity dbEntity);
        IEnumerable<Column> GetColumns(DBEntity entity);
        IEnumerable<Database> GetDatabases();
        DataSet GetDataSet(string SQL);
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType entityType);
        IEnumerable<Parameter> GetParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        void LogIn(string server, string username, string password);
    }
}