using Sibling.Data.Model;
using Sibling.Repositories;
using Sibling.Views.MotherViews;

namespace Sibling.Controllers.MotherController
{
    public class ReferenceByMotherController
    {
        private ReferenceByMotherView referenceByMother;
        private MotherRepositorie motherRepositorie;
        private ChildRepositorie childRepositorie;
        public ReferenceByMotherController()
        {
            referenceByMother = new ReferenceByMotherView();
            motherRepositorie = new MotherRepositorie();
            childRepositorie = new ChildRepositorie();
        }
        public void ReferenceByMother()
        {
            var mother = motherRepositorie.FindMotherByName(referenceByMother.MotherGetName());
            List<Child> child = null;
            if (mother != null)
            { child = childRepositorie.FindingAChildByMother(mother); }
            referenceByMother.ReferenceByMother(mother, child);
        }
    }
}