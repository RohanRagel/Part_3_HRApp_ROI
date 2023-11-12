namespace Part_3_HRApp_ROI;

public partial class LeaveReq : ContentPage
{
	public LeaveReq()
	{
		InitializeComponent();
	}
    private async void SendMessageBtn(object sender, EventArgs e)
    {
        // Display a prompt to the user
        bool result = await DisplayAlert("Approve Leave", "Are you sure you want to grant this request?", "Yes", "No");

        if (result)
        {

            await DisplayAlert("Leave approved", "The Leave has been approved and time sheets have been altered. Please allow a few days for processing", "OK");
        }
    }

}