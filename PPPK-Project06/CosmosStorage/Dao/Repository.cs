using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CosmosStorage.Dao
{
    public class Repository
    {
        public const string DatabaseName = "Tasks";
        public const string ContainerName = "Tasks";
        public const string Account = "https://cosmostodoitems.documents.azure.com:443/";
        public const string Key = "XeXX6MysdZONQrSeekaJbXr9Uw4A0PSg2sJxi3YiueLdCQffj2AUDHyYZAr2I4BJtHeTRjpJZlLtI1EV9C3beA==";
        private static ICosmosDbService cosmosDbService;
        public static ICosmosDbService CosmosDbService { get => cosmosDbService; }

        public async static Task Init()
        {
            CosmosClient client = new CosmosClient(Account, Key);
            cosmosDbService = new CosmosDbService(client, DatabaseName, ContainerName);
            DatabaseResponse database = await client.CreateDatabaseIfNotExistsAsync(DatabaseName);
            await database.Database.CreateContainerIfNotExistsAsync(ContainerName, "/id");
        }
    }
}