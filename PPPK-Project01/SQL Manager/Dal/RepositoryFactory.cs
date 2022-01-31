using System;

namespace SQL_Manager.Dal
{
    static class RepositoryFactory
    {
        private static readonly Lazy<IRepository> repository = new Lazy<IRepository>(() => new SqlRepository());
        public static IRepository GetRepository() => repository.Value;
    }
}
