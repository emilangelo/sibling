using Sibling.Data.Model;
using Sibling.Repositories;
using Sibling.Views.FatherViews;
using Sibling.Views.MotherViews;

namespace Sibling.Views.ChildViews
{
    public class AddChildView
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public int FatherID { get; set; }
        public int MotherID { get; set; }
        public AddChildView()
        {
            Name = "";
            BirthDay = DateTime.MinValue;
            FatherID = 0;
            MotherID = 0;
        }
        public void GetValuesChild()
        {
            Console.Write("Име на детето: ");
            Name = Console.ReadLine();
            Console.Write("Пол: ");
            string gender = Console.ReadLine();
            switch (gender)
            {
                case "Ж":
                    Gender = Gender.Ж;
                    break;
                case "М":
                    Gender = Gender.М;
                    break;
            }
            Console.Write("Рожден ден (dd.mm.yyyy): ");
            BirthDay = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy",
                System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("ИД на майката: ");
            MotherID = int.Parse(Console.ReadLine());
            Console.Write("ИД на бащата: ");
            FatherID = int.Parse(Console.ReadLine());
        }
        public void AddChildDialog()
        {
            Console.WriteLine($"Добавено е дете с Име: {Name}, Пол: {Gender}," +
                $" Рожден ден: {BirthDay.ToShortDateString()}");
            MotherRepositorie mr = new MotherRepositorie();
            FatherRepositorie fr = new FatherRepositorie();
            ShowFathersView sfv = new ShowFathersView();
            ShowMothersView smv = new ShowMothersView();
            var mother = mr.FindMotherByID(MotherID);
            var father = fr.FindFatherByID(FatherID);
            smv.ShowMother(mother);
            sfv.ShowFather(father);
            Console.ReadKey();
        }
    }
}