namespace Sibling.Views.MotherViews
{
    public class AddMotherView
    {
        public int MotherID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public AddMotherView()
        {
            MotherID = 0;
            Name = "";
            Age = 0;
        }
        public void GetValuesMother()
        {
            Console.Write("Име на майката: ");
            Name = Console.ReadLine();
            Console.Write("Години: ");
            Age = int.Parse(Console.ReadLine());
        }
        public void ShowAddMother()
        {
            Console.WriteLine($"Добавена майка с ИД: {MotherID}," +
                $" Име: {Name}, Години: {Age}");
            Console.ReadKey();
        }
    }
}