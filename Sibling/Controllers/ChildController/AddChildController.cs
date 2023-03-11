using Sibling.Data.Model;
using Sibling.Views.ChildViews;

namespace Sibling.Controllers.ChildController
{
    public class AddChildController
    {
        private AddChildView addChild;
        private Child child;
        public AddChildController()
        {
            addChild = new AddChildView();
            child = new Child();
        }
        public void AddChild()
        {
            addChild.GetValuesChild();
            child.Name = addChild.Name;
            child.Gender = addChild.Gender;
            child.Date = addChild.BirthDay;
            child.MotherID = addChild.MotherID;
            child.FatherID = addChild.FatherID;
            Program.sibling.Children.Add(child);
            Program.sibling.SaveChanges();
            addChild.AddChildDialog();
        }
    }
}