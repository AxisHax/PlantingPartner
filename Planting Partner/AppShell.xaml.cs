using Planting_Partner.View;

namespace Planting_Partner
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
            Routing.RegisterRoute(nameof(PlantCollection), typeof(PlantCollection));
        }
    }
}