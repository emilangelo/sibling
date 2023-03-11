using Sibling.Repositories;
using Sibling.Views.MotherViews;

namespace Sibling.Controllers.MotherController
{
    public class ShowMothersController
    {
        private ShowMothersView showMothers;
        private MotherRepositorie motherRepositorie;
        public ShowMothersController()
        {
            showMothers = new ShowMothersView();
            motherRepositorie = new MotherRepositorie();
        }
        public void ShowMothers()
        {
            showMothers.ShowMothers(motherRepositorie.AllMoters());
        }
    }
}