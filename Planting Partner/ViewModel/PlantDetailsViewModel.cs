
namespace Planting_Partner.ViewModel
{
    [QueryProperty(nameof(Plant), "Plant")]
    public partial class PlantDetailsViewModel : BaseViewModel
    {
        public PlantDetailsViewModel() { }

        [ObservableProperty]
        Plant plant;
    }
}
