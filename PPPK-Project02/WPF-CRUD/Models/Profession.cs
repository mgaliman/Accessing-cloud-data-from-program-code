namespace WPF_CRUD.Models
{
    public class Profession
    {
        public int IDProfession { get; set; }
        public string ProfessionName { get; set; }
        public override string ToString() => $"{ProfessionName}";
    }
}
