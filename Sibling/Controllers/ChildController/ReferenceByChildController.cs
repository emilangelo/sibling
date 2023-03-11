using Sibling.Repositories;
using Sibling.Views.ChildViews;

namespace Sibling.Controllers.ChildController
{
    public class ReferenceByChildController
    {
        private ReferenceByChildView referenceByChild;
        private ChildRepositorie childRepositorie;
        public ReferenceByChildController()
        {
            referenceByChild = new ReferenceByChildView();
            childRepositorie = new ChildRepositorie();
        }
        public void ReferenceByChild()
        {
            referenceByChild.ChildGetName();
            var child = childRepositorie.FindChildByName(referenceByChild.Name);
            referenceByChild.ReferenceByChild(child);
        }
    }
}