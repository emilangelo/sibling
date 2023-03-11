using Sibling.Data.Model;

namespace Sibling.Repositories
{
    internal class FatherRepositorie
    {
        public Father FindFatherByID(int fatherID)
        {
            var father = (from f in Program.sibling.Fathers
                          where fatherID == f.FatherID
                          select f).First();
            return father;
        }

        public List<Father> AllFathers()
        {
            var fathers = (from f in Program.sibling.Fathers
                           select f).ToList<Father>();
            return fathers;
        }
        public Father FindFatherByName(string fatherName)
        {
            try
            {
                var father = (from f in Program.sibling.Fathers
                              where f.Name == fatherName
                              select f).First();
                return father;
            }
            catch (InvalidOperationException)
            {
                // този catch блок ще се изпълни само ако методът First() хвърли грешка
                // в случай, че не е намерена майка, която отговаря на условието
            }
            return null;
        }
        public Father FindFatherByChild(int fatherID)
        {
            try
            {
                var father = (from f in Program.sibling.Fathers
                              where f.FatherID == f.FatherID
                              select f).ToList<Father>().First();
                return father;
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