using Sibling.Data.Model;

namespace Sibling.Views.MotherViews
{
    public class ShowMothersView
    {
        public void ShowMother(Mother mother)
        {
            Console.WriteLine($"{new string(' ', 10)}" +
                $"Майка\nИД: {mother.MotherID}, Име: {mother.Name}, Години: {mother.Age}");
        }
        public void ShowMothers(List<Mother> mothers)
        {
            if (mothers.Count == 0) { Console.Write("Няма майки!"); }
            else
            {
                Console.WriteLine(new string(' ', 10) + "Майки");
                foreach (var m in mothers)
                    Console.WriteLine($"ИД: {m.MotherID}, Име: {m.Name}, Години: {m.Age}");
            }
            Console.ReadKey();
        }
    }
}