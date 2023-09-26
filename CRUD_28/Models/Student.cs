namespace CRUD_28.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Enail { get; set; }
        public string Contact { get; set; }
        public Eductions Eduction { get; set; }
        public Skills Skill { get; set; }
    }
    public enum Eductions
    {
        BCA, MCA
    }
    public enum Skills
    {
        ADCA, CCC, SSC
    }
}
