using Sibling.Data.Model;

namespace Sibling.Repositories
{
    internal class ChildRepositorie
    {
        public List<Child> AllChildren()
        {
            var child = (from c in Program.sibling.Children
                         select c).ToList<Child>();
            return child;
        }
        public List<Child> FindingAChildByFather(Father father)
        {
            var children = (from c in Program.sibling.Children
                            where c.FatherID == father.FatherID
                            select c).ToList<Child>();
            return children;
        }
        public List<Child> FindingAChildByMother(Mother mother)
        {
            var children = (from c in Program.sibling.Children
                            where c.MotherID == mother.MotherID
                            select c).ToList<Child>();
            return children;
        }
        public Child FindChildByName(string childName)
        {
            try
            {
                var childID = (from c in Program.sibling.Children
                               where c.Name == childName
                               select c).First();
                return childID;
            }
            catch (InvalidOperationException)
            {
                // този catch блок ще се изпълни само ако методът First() хвърли грешка
                // в случай, че не е намерена майка, която отговаря на условието
            }
            return null;
        }
        public List<Child> FindChildByMotherAndFather(Mother mother, Father father)
        {
            if (father == null || mother == null) { return null; }
            try
            {
                var child = (from c in Program.sibling.Children
                             where c.MotherID == mother.MotherID && c.FatherID == father.FatherID
                             select c).ToList<Child>();
                return child;
            }
            catch (InvalidOperationException)
            {
                // този catch блок ще се изпълни само ако методът First() хвърли грешка
                // в случай, че не е намерена майка, която отговаря на условието
            }
            return null;
        }
    }
}