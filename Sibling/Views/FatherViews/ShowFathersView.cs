using Sibling.Data.Model;

namespace Sibling.Views.FatherViews
{
    public class ShowFathersView
    {
        public void ShowFather(Father father)
        {
            Console.WriteLine($"{new string(' ', 10)}" +
                $"Баща\nИД: {father.FatherID}, Име: {father.Name}, Години: {father.Age}");
        }
        public void ShowFathers(List<Father> fathers)
        {
            if (fathers.Count == 0) { Console.WriteLine("Няма бащи!"); }
            else
            {
                Console.WriteLine(new string(' ', 10) + "Бащи");
                foreach (var f in fathers)
                    Console.WriteLine($"ИД: {f.FatherID}, Име: {f.Name}, Години: {f.Age}");
            }
            Console.ReadKey();
        }
    }
}