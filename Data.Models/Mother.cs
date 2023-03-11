namespace Sibling.Data.Model
{
    public class Mother
    {
        public int MotherID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Child> Children { get; set; }
    }
}