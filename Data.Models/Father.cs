namespace Sibling.Data.Model
{
    public class Father
    {
        public int FatherID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Child> Children { get; set; }

    }
}