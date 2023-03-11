using Sibling.Repositories;
using Sibling.Views.ChildViews;

namespace Sibling.Controllers.ChildController
{
    public class ShowChildrenController
    {
        private ShowChildrenView showChildren;
        private ChildRepositorie childRepositorie;
        public ShowChildrenController()
        {
            showChildren = new ShowChildrenView();
            childRepositorie = new ChildRepositorie();
        }
        public void ShowChildrens()
        {
            showChildren.ShowChildren(childRepositorie.AllChildren());
        }
    }
}