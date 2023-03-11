using Sibling.Data.Model;
using Sibling.Repositories;
using Sibling.Views.FatherViews;
using Sibling.Views.MotherViews;

namespace Sibling.Views.ChildViews
{
    public class ShowChildrenView
    {
        public void ShowChildren(List<Child> children)
        {
            bool flag = false;
            if (children.Count == 0) { Console.WriteLine("Няма деца!"); }
            else
            {
                MotherRepositorie mr = new MotherRepositorie();
                FatherRepositorie fr = new FatherRepositorie();
                ShowFathersView sfv = new ShowFathersView();
                ShowMothersView smv = new ShowMothersView();
                Console.WriteLine(new string(' ', 40) + "Деца");
                foreach (var c in children)
                {
                    if (flag) { Console.WriteLine("\n"); }
                    Console.WriteLine($"ИД: {c.ChildID}," +
                        $" Име: {c.Name}, Рожденна дата: {c.Date.ToShortDateString()}");
                    Mother mother = mr.FindMotherByID(c.MotherID);
                    Father father = fr.FindFatherByID(c.FatherID);
                    smv.ShowMother(mother);
                    sfv.ShowFather(father);
                    flag = true;
                }
            }
            Console.ReadKey();
        }
    }
}