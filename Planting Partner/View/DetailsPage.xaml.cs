namespace Planting_Partner;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(/*PlantDetailsViewModel viewModel*/)
	{
		InitializeComponent();
		//BindingContext = viewModel;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}