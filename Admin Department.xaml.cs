namespace Part_3_HRApp_ROI;

public partial class AdminDepartment : ContentPage
{
	public AdminDepartment()
	{
		InitializeComponent();
	}
    private async void Addbtn(object sender, EventArgs e)
    {
        // Display the alert message when the "Add" button is clicked
        await DisplayAlert("Error", "No new employees in the database. Please consult management if there is an error.", "OK");
    }
    private async void MossEdit(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        string buttonText = button.Text;

        var editEntry = new Entry { Placeholder = "Edit Information", Text = buttonText };

        // Create a Save button to update the information.
        var saveButton = new Button { Text = "Save" };
        saveButton.Clicked += (s, args) =>
        {
            // Update the button text with the edited information.
            string editedText = editEntry.Text;
            button.Text = editedText;

            //Adds a message after you press "Save"
            DisplayAlert("Profile saved", "The profile has been saved", "OK");
        };

        var editPage = new ContentPage
        {
            Content = new StackLayout
            {
                Children = { editEntry, saveButton }
            }
        };


        await Navigation.PushAsync(editPage);
    }
    private async void JenEdit(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        string buttonText = button.Text;

        var editEntry = new Entry { Placeholder = "Edit Information", Text = buttonText };

        // Create a Save button to update the information.
        var saveButton = new Button { Text = "Save" };
        saveButton.Clicked += (s, args) =>
        {
            // Update the button text with the edited information.
            string editedText = editEntry.Text;
            button.Text = editedText;

            //Adds a message after you press "Save"
            DisplayAlert("Profile saved", "The profile has been saved", "OK");
        };

        var editPage = new ContentPage
        {
            Content = new StackLayout
            {
                Children = { editEntry, saveButton }
            }
        };


        await Navigation.PushAsync(editPage);

    }
    private async void RoyEdit(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        string buttonText = button.Text;

        var editEntry = new Entry { Placeholder = "Edit Information", Text = buttonText };

        // Create a Save button to update the information.
        var saveButton = new Button { Text = "Save" };
        saveButton.Clicked += (s, args) =>
        {
            // Update the button text with the edited information.
            string editedText = editEntry.Text;
            button.Text = editedText;

            //Adds a message after you press "Save"
            DisplayAlert("Profile saved", "The profile has been saved", "OK");
        };

        var editPage = new ContentPage
        {
            Content = new StackLayout
            {
                Children = { editEntry, saveButton }
            }
        };


        await Navigation.PushAsync(editPage);
    }
}