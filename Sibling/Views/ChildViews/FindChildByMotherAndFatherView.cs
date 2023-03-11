using Sibling.Data.Model;

namespace Sibling.Views.ChildViews
{
    public class FindChildByMotherAndFatherView
    {
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public void MotherAndFatherGetName()
        {
            Console.Write("Име на майката: ");
            MotherName = Console.ReadLine();
            Console.Write("Име на бащата: ");
            FatherName = Console.ReadLine();
        }
        public void FindChildByMotherAndFather(List<Child> children)
        {
            if (children == null) { Console.WriteLine("Невалидна майка или баща!"); }
            else
            {
                if (children.Count == 0) { Console.WriteLine("Нямат общи деца!"); }
                else if (children.Count == 1)
                {
                    Console.WriteLine($"Те имат: {children.Count} дете.");
                    Console.WriteLine($"Тяхното дете е с ИД: {children[0].ChildID}," +
                        $" Име: {children[0].Name}, Пол: {children[0].Gender}, " +
                        $"Рожденна дата: {children[0].Date.ToShortDateString()}");
                }
                else
                {
                    Console.WriteLine($"Те имат: {children.Count} деца.");
                    for (int i = 0; i < children.Count; i++)
                    {
                        Console.WriteLine($"Дете №{i+1} с ИД: {children[i].ChildID}," +
                            $" Име: {children[i].Name}, Пол: {children[i].Gender}," +
                            $" Рожденна дата: {children[i].Date.ToShortDateString()}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}