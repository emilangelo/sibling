namespace Sibling.Data.Model
{
    public class Child
    {
        public int ChildID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime Date { get; set; }
        public int FatherID { get; set; }
        public int MotherID { get; set; }
    }
}