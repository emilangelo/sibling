using Sibling.Repositories;
using Sibling.Views.ChildViews;
using System.Globalization;

namespace Sibling.Controllers.ChildController
{
    public class FindChildByMotherAndFatherController
    {
        private FindChildByMotherAndFatherView findChildByMotherAndFather;
        private ChildRepositorie childRepositorie;
        private FatherRepositorie fatherRepositorie;
        private MotherRepositorie motherRepositorie;
        public FindChildByMotherAndFatherController()
        {
            findChildByMotherAndFather = new FindChildByMotherAndFatherView();
            childRepositorie = new ChildRepositorie();
            fatherRepositorie = new FatherRepositorie();
            motherRepositorie = new MotherRepositorie();
        }
        public void FindChildByMotherAndFather()
        {
            findChildByMotherAndFather.MotherAndFatherGetName();
            var mother = motherRepositorie.FindMotherByName(findChildByMotherAndFather.MotherName);
            var father = fatherRepositorie.FindFatherByName(findChildByMotherAndFather.FatherName);
            findChildByMotherAndFather.FindChildByMotherAndFather(
                childRepositorie.FindChildByMotherAndFather(mother,father));
        }
    }
}