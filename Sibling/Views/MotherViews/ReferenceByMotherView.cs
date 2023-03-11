using Sibling.Data.Model;
using Sibling.Repositories;
using Sibling.Views.FatherViews;

namespace Sibling.Views.MotherViews
{
    public class ReferenceByMotherView
    {
        public string MotherGetName()
        {
            Console.Write("Име на майката: ");
            string motherName = Console.ReadLine();
            return motherName;
        }
        public void ReferenceByMother(Mother mother, List<Child> children)
        {
            if (mother == null) { Console.WriteLine("Няма такъва майка!"); }
            else
            {
                Console.WriteLine($"Майка с ИД: {mother.MotherID}, Име: {mother.Name}, Години: {mother.Age}");
                if (children.Count == 0) { Console.WriteLine("Тази майка няма деца!"); }
                else
                {
                    FatherRepositorie fr = new FatherRepositorie(); 
                    ShowFathersView sfv = new ShowFathersView();
                    foreach (var c in children)
                    {
                        Console.WriteLine($"Дете с ИД: {c.ChildID}, Име: {c.Name}," +
                            $" Пол: {c.Gender}, Рожден ден: {c.Date.ToShortDateString()}");
                        Father father = fr.FindFatherByID(c.FatherID);
                        sfv.ShowFather(father);
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}