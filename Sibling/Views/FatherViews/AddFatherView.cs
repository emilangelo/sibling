namespace Sibling.Views.FatherViews
{
    public class AddFatherView
    {
        public int FatherID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public AddFatherView()
        {
            FatherID = 0;
            Name = "";
            Age = 0;
        }
        public void GetValuesFather()
        {
            Console.Write("Име на бащата: ");
            Name = Console.ReadLine();
            Console.Write("Години: ");
            Age = int.Parse(Console.ReadLine());
        }
        public void ShowAddFather()
        {
            Console.WriteLine($"Добавен баща с ИД: {FatherID}, Име: {Name}, Години: {Age}");
            Console.ReadKey();
        }
    }
}