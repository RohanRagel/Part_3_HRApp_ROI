
namespace Part_3_HRApp_ROI;

public partial class CompanyProfiles : ContentPage
{
	public CompanyProfiles()
	{
        InitializeComponent(); 
	}
    private void HRDepartmentbtn(object sender, EventArgs e)
    {

        Navigation.PushAsync(new HRDepartment());
    }

    private void ITDepartmentbtn(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ITDepartment());
    }

    private void SalesDepartmentbtn(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SalesDepartment());
    }
    
    private void AdminDepartmentbtn(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AdminDepartment());
    }
}