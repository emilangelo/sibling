using Sibling.Controllers.MotherController;
using Sibling.Controllers.FatherController;
using Sibling.Controllers.ChildController;
using Sibling.Data;

namespace Sibling
{
    class Program
    {
        public static SiblingDB sibling = new SiblingDB();
        static void Command()
        {
            Console.Write("1 - Добавяне на майка\n2 - Добавяне на баща\n3 - Добавяне на дете" +
                "\n4 - Списък с всички майки\n5 - Списък с всички бащи\n6 - Списък с всички деца" +
                "\n7 - Справка по майка\n8 - Справка по баща\n9 - Справка по дете" +
                "\n10 - Справка по майка и баща\n11 - Край\nКоманда: ");
        }
        static void Main()
        {
            sibling.Database.EnsureCreatedAsync();
            Command();
            int command = int.Parse(Console.ReadLine());
            while (command != 11)
            {
                switch (command)
                {
                    case 1:
                        Console.Clear();
                        var adm = new AddMotherController();
                        adm.AddMother();
                        break;
                    case 2:
                        Console.Clear();
                        var adf = new AddFatherController();
                        adf.AddFather();
                        break;
                    case 3:
                        Console.Clear();
                        var adc = new AddChildController();
                        adc.AddChild();
                        break;
                    case 4:
                        Console.Clear();
                        var sm = new ShowMothersController();
                        sm.ShowMothers();
                        break;
                    case 5:
                        Console.Clear();
                        var sf = new ShowFathersController();
                        sf.ShowFathers();
                        break;
                    case 6:
                        Console.Clear();
                        var sc = new ShowChildrenController();
                        sc.ShowChildrens();
                        break;
                    case 7:
                        Console.Clear();
                        var rm = new ReferenceByMotherController();
                        rm.ReferenceByMother();
                        break;
                    case 8:
                        Console.Clear();
                        var rf = new ReferenceByFatherController();
                        rf.ReferenceByFather();
                        break;
                    case 9:
                        Console.Clear();
                        var rc = new ReferenceByChildController();
                        rc.ReferenceByChild();
                        break;
                    case 10:
                        Console.Clear();
                        var fcbmaf = new FindChildByMotherAndFatherController();
                        fcbmaf.FindChildByMotherAndFather();
                        break;
                }
                Console.Clear();
                Command();
                command = int.Parse(Console.ReadLine());
            }
        }
    }
}