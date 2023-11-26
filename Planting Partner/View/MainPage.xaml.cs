namespace Planting_Partner
{
    public partial class MainPage : ContentPage
    {
        public MainPage(PlantsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        //private void OnSubmitClicked(object sender, EventArgs e)
        //{
        //    ErrorMessageLbl.Text = string.Empty;
        //    ErrorMessageLbl.IsVisible = false;

        //    //Validate user input
        //    bool userInputIsValid = ValidateUserInput();

        //    if (userInputIsValid)
        //    {
        //        //Once this is clicked, store user input for climate for later
        //        Climate climate = new Climate();
        //        climate.CurrentSeason = (string)SeasonPicker.SelectedItem;

        //        //This is where we move to next screen
        //    }
        //}

        ////There will likely be a better way to do this once more input is added to starting screen
        //private bool ValidateUserInput()
        //{
        //    //Make sure input made by users is valid
        //    if (SeasonPicker.SelectedItem == null) 
        //    {
        //        ErrorMessageLbl.Text = "You must enter a value for the current season.";
        //    }

        //    if (ErrorMessageLbl.Text != string.Empty)
        //    {
        //        ErrorMessageLbl.IsVisible = true;
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        private bool seasonSelected = false;
        private bool zoneSelected = false; 
        private void SeasonPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SeasonPicker.SelectedIndex != -1)
            {
                SelectedOptions.SetSeason(SeasonPicker.SelectedItem.ToString());
                seasonSelected = true;
            }
            EnableSubmitBtnCheck();
        }

        private void ZonePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ZonePicker.SelectedIndex != -1)
            {
                SelectedOptions.SetZone(ZonePicker.SelectedItem.ToString());
                zoneSelected = true;
            }
            EnableSubmitBtnCheck();
        }

        private void EnableSubmitBtnCheck()
        {
            if (seasonSelected is true && zoneSelected is true)
                SubmitBtn.IsEnabled = true;
        }
    }
}
