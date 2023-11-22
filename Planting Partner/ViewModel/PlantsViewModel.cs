using Planting_Partner.View;
using Planting_Partner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planting_Partner.ViewModel
{
    public partial class PlantsViewModel : BaseViewModel
    {
        public ObservableCollection<Plant> Plants { get; } = new();
        PlantService plantService;
        public PlantsViewModel(PlantService plantService)
        {
            Title = "Planting Partner";
            this.plantService = plantService;
        }

        [RelayCommand]
        async Task GetPlantsAsync()
        {
            if (IsBusy) 
                return;

            try
            {
                IsBusy = true;

                var plants = await plantService.GetPlants();
                if (Plants.Count != 0)
                    Plants.Clear();

                foreach (var plant in plants)
                {
                    // Add plants to the list if the season and zone match
                    if (String.Equals(SelectedOptions.season, plant.GrowSeason, StringComparison.OrdinalIgnoreCase) &&
                        String.Equals(SelectedOptions.zone, plant.GrowthZone, StringComparison.OrdinalIgnoreCase))
                        Plants.Add(plant);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get monkeys: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally 
            { 
                IsBusy = false; 
            }
        }

        [RelayCommand]
        async Task GoToDetailsAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(PlantCollection)}", true);
        }
    }
}
