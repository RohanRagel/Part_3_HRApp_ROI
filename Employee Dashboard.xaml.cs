namespace Part_3_HRApp_ROI;

public partial class EmployeeDashboard : ContentPage
{
	public EmployeeDashboard()
	{
		InitializeComponent();
	}


    private void Leavebtn(object sender, EventArgs e)
    {
       
        Navigation.PushAsync(new LeaveReq());
    }

    private void Grantbtn(object sender, EventArgs e)
    {
      
        Navigation.PushAsync(new GrantedReq());
    }

    private void Staffbtn(object sender, EventArgs e)
    {
        
        Navigation.PushAsync(new StaffReviews());
    }
}