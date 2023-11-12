namespace Part_3_HRApp_ROI;

public partial class Announcements : ContentPage
{
	public Announcements()
	{
		InitializeComponent();
	}

    private void SendAnnouncementsbtn(object sender, EventArgs e)
    {

        Navigation.PushAsync(new SendAnnouncements());
    }
    private void PreviousAnnouncementsbtn(object sender, EventArgs e)
    {

        Navigation.PushAsync(new PreviousAnnouncement());
    }
}