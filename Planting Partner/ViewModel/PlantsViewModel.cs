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
        {
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true);
        }
    }
}
