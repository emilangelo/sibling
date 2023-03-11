using Sibling.Data.Model;
using Sibling.Repositories;
using Sibling.Views.FatherViews;
using Sibling.Views.MotherViews;

namespace Sibling.Views.ChildViews
{
    public class ReferenceByChildView
    {
        public string Name { get; set; }

        public ReferenceByChildView()
        {
            Name = "";
        }
        public void ChildGetName()
        {
            Console.Write("Име на детето: ");
            Name = Console.ReadLine();
        }
        public void ReferenceByChild(Child child)
        {
            if (child == null) { Console.WriteLine("Няма такова дете!"); }
            else
            {
                Console.WriteLine($"Дете с ИД: {child.ChildID}," +
                  $" Име: {child.Name}, Пол: {child.Gender}, Рожденна дата: {child.Date.ToShortDateString()}");
                MotherRepositorie mr = new MotherRepositorie();
                FatherRepositorie fr = new FatherRepositorie();
                ShowFathersView sfv = new ShowFathersView();
                ShowMothersView smv = new ShowMothersView();
                smv.ShowMother(mr.FindMotherByID(child.MotherID));
                sfv.ShowFather(fr.FindFatherByID(child.FatherID));
            }       
            Console.ReadKey();
        }
    }
}