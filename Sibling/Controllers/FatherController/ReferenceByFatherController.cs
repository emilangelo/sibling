using Sibling.Data.Model;
using Sibling.Repositories;
using Sibling.Views.FatherViews;

namespace Sibling.Controllers.FatherController
{
    public class ReferenceByFatherController
    {
        private ReferenceByFatherView referenceByFather;
        private FatherRepositorie fatherRepositorie;
        private ChildRepositorie childRepositorie;
        public ReferenceByFatherController()
        {
            referenceByFather = new ReferenceByFatherView();
            fatherRepositorie = new FatherRepositorie();
            childRepositorie = new ChildRepositorie();
        }
        public void ReferenceByFather()
        {
            var father = fatherRepositorie.FindFatherByName(referenceByFather.FatherGetName());
            List<Child> child = null;
            if (father != null)
            { child = childRepositorie.FindingAChildByFather(father); }
            referenceByFather.ReferenceByFather(father, child);
        }
    }
}