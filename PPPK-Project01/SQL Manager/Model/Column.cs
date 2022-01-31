namespace SQL_Manager.Model
{
    class Column
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public override string ToString() => $"{Name} ({DataType})";
    }
}
