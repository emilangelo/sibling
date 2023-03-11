using Sibling.Data.Model;

namespace Sibling.Repositories
{
    internal class MotherRepositorie
    {
        public Mother FindMotherByID(int motherID)
        {
            var mother = (from m in Program.sibling.Mothers
                          where motherID == m.MotherID
                          select m).First();
            return mother;
        }

        public List<Mother> AllMoters()
        {
            var mothers = (from m in Program.sibling.Mothers
                           select m).ToList<Mother>();
            return mothers;
        }
        public Mother FindMotherByName(string motherName)
        {
            Mother mother = null;
            try
            {
                mother = (from m in Program.sibling.Mothers
                          where m.Name == motherName
                          select m).First();
            }
            catch (InvalidOperationException)
            {
                // този catch блок ще се изпълни само ако методът First() хвърли грешка
                // в случай, че не е намерена майка, която отговаря на условието
            }
            return mother;
        }
        public Mother FindMotherByName(int motherID)
        {
            Mother mother = null;
            try
            {
                mother = (from m in Program.sibling.Mothers
                          where m.MotherID == motherID
                          select m).ToList<Mother>().First();
                return mother;
            }
            catch { return mother; }
        }
    }
}