using System.Collections.ObjectModel;

namespace Part_3_HRApp_ROI;

public partial class StaffReviews : ContentPage
{
	public StaffReviews()
	{
		InitializeComponent();
	}
    ObservableCollection
<Review> reviews = new ObservableCollection
    <Review>();

 private void SubmitReviewClicked(object sender, EventArgs e)
    {
        var review = new Review
        {
            EmployeeName = EmployeeNameEntry.Text,
            EmployeeDepartment = EmployeeDepartmentEntry.Text,
            ReviewDate = ReviewDateEntry.Text,
            ReviewComments = ReviewCommentsEntry.Text
        };

        reviews.Add(review);

        // Clear the entry fields
        EmployeeNameEntry.Text = string.Empty;
        EmployeeDepartmentEntry.Text = string.Empty;
        ReviewDateEntry.Text = string.Empty;
        ReviewCommentsEntry.Text = string.Empty;
    }
}

public class Review
{
    public string EmployeeName { get; set; }
    public string EmployeeDepartment { get; set; }
    public string ReviewDate { get; set; }
    public string ReviewComments { get; set; }
}