namespace Part_3_HRApp_ROI
{
    public partial class SendAnnouncements : ContentPage
    {
        public SendAnnouncements()
        {
            InitializeComponent();
        }

        private void AnnouncementSent(object sender, EventArgs e)
        {

            DisplayAlert("Announcement Sent", "Your announcement has been sent.", "OK");
        }
        

    }
}
