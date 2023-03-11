using Sibling.Data.Model;
using Sibling.Views.MotherViews;

namespace Sibling.Controllers.MotherController
{
    public class AddMotherController
    {
        private Mother mother;
        private AddMotherView addMotherView;
        public AddMotherController()
        {
            mother = new Mother();
            addMotherView = new AddMotherView();
        }
        public void AddMother()
        {
            addMotherView.GetValuesMother();
            mother.Name = addMotherView.Name;
            mother.Age = addMotherView.Age;
            Program.sibling.Mothers.Add(mother);
            Program.sibling.SaveChanges();
            addMotherView.MotherID = mother.MotherID;
            addMotherView.ShowAddMother();
        }
    }
}