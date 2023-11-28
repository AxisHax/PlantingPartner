namespace Planting_Partner.View;

public partial class PlantCollection : ContentPage
{
	public PlantCollection(PlantCollectionViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}