namespace Part_3_HRApp_ROI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void CompanyProfilebtn(object sender, EventArgs e)
        {
            //Navigates to Company Profiles Page
            Navigation.PushAsync(new CompanyProfiles());
        }


        private void Announcementsbtn(object sender, EventArgs e)
        {

            //Navigates to Announcements Page
            Navigation.PushAsync(new Announcements());
        }
        private void EmployeeDashboardbtn(object sender, EventArgs e)
        {
            //Navigates to Employee Dashboard Page
            Navigation.PushAsync(new EmployeeDashboard());

        }
        private void Settingsbtn(object sender, EventArgs e)
        {
            //Navigates to Settings Page
            Navigation.PushAsync(new Settings());
        }
    }
}