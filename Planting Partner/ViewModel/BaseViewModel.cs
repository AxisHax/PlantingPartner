namespace Planting_Partner.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    string title;

    public bool IsNotBusy => !IsBusy;
}
