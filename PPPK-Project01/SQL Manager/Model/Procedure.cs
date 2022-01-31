using SQL_Manager.Dal;
using System;
using System.Collections.Generic;

namespace SQL_Manager.Model
{
    class Procedure
    {
        private readonly Lazy<IEnumerable<Parameter>> parameters;
        public Procedure()
        {
            parameters = new Lazy<IEnumerable<Parameter>>(() => RepositoryFactory.GetRepository().GetParameters(this));
        }
        public IList<Parameter> Parameters
        {
            get => new List<Parameter>(parameters.Value);
        }
        public string Name { get; set; }
        public string Definition { get; set; }
        public Database Database { get; set; }
        public override string ToString() => Name;
    }
}
