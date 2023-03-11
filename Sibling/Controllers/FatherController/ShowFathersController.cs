using Sibling.Repositories;
using Sibling.Views.FatherViews;

namespace Sibling.Controllers.FatherController
{
    public class ShowFathersController
    {
        private ShowFathersView showFathers;
        private FatherRepositorie fatherRepositorie;
        public ShowFathersController()
        {
            showFathers = new ShowFathersView();
            fatherRepositorie = new FatherRepositorie();
        }
        public void ShowFathers()
        {
            showFathers.ShowFathers(fatherRepositorie.AllFathers());
        }
    }
}