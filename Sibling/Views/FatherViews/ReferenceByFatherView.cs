using Sibling.Data.Model;
using Sibling.Repositories;
using Sibling.Views.MotherViews;

namespace Sibling.Views.FatherViews
{
    public class ReferenceByFatherView
    {
        public string FatherGetName()
        {
            Console.Write("Име на бащата: ");
            string fatherName = Console.ReadLine();
            return fatherName;
        }
        public void ReferenceByFather(Father father, List<Child> children)
        {
            if (father == null) { Console.WriteLine("Няма такъв баща!"); }
            else
            {
                Console.WriteLine($"Баща с ИД: {father.FatherID}, Име: {father.Name}, Години: {father.Age}");
                if (children.Count == 0) { Console.WriteLine("Този баща няма деца!"); }
                else
                {
                    MotherRepositorie mr = new MotherRepositorie();
                    ShowMothersView smv = new ShowMothersView();
                    foreach (var c in children)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Дете с ИД: {c.ChildID}, Име: {c.Name}," +
                            $" Пол: {c.Gender}, Рожден ден: {c.Date.ToShortDateString()}");
                        Mother mother = mr.FindMotherByID(c.MotherID);
                        smv.ShowMother(mother);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}