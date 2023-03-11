using Sibling.Data.Model;
using Sibling.Views.FatherViews;

namespace Sibling.Controllers.FatherController
{
    public class AddFatherController
    {
        private AddFatherView addFatherView;
        private Father father;
        public AddFatherController()
        {
            addFatherView = new AddFatherView();
            father = new Father();
        }
        public void AddFather()
        {
            addFatherView.GetValuesFather();
            father.Name = addFatherView.Name;
            father.Age = addFatherView.Age;
            Program.sibling.Fathers.Add(father);
            Program.sibling.SaveChanges();
            addFatherView.FatherID = father.FatherID;
            addFatherView.ShowAddFather();
        }
    }
}