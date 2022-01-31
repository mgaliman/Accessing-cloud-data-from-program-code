namespace SQL_Manager.Model
{
    class Procedures
    {
        public string Name { get; set; }
        public string Definition { get; set; }
        public Database Database { get; set; }
        public override string ToString() => Name;
    }
}
