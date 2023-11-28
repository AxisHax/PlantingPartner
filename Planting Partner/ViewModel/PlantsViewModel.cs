using Planting_Partner.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planting_Partner.ViewModel
{
    public partial class PlantsViewModel : BaseViewModel
    {
        public PlantsViewModel()
        {
            Title = "Planting Partner";
        }

        [RelayCommand]
        async Task GoToDetailsAsync()
        {// Navigate to Collection Page and get plants from there.
            try
            {
                await Shell.Current.GoToAsync($"{nameof(PlantCollection)}", true);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Fatal error occured: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
        }
    }
}
