namespace Part_3_HRApp_ROI
{
    public partial class HRDepartment : ContentPage
    {
        // Database service to perform CRUD operations
        private DatabaseService _databaseService;

        // List to store hremployees
        private List<HRModels> _hremployee;

        public HRDepartment()
        {
            InitializeComponent();

            // Initialize the database service
            _databaseService = new DatabaseService();

            // Load hremployees from the database when the page is created
            LoadhremployeeAsync();
        }

        // Load the hremployees from the database and update the ListView
        private async void LoadhremployeeAsync()
        {
            // Retrieve the list of hremployees from the database
            _hremployee = await _databaseService.Gethremployee();

            // Bind the list of hremployees to the ListView
            hremployeeListView.ItemsSource = _hremployee;
        }

        // Event handler for adding a new hremployee
        private async void Addhremployee_Clicked(object sender, EventArgs e)
        {
            // Create a new hremployee object with the input values
            var newhremployee = new HRModels
            {
                FullName = FullNameEntry.Text,
                JobTitle = JobTitleEntry.Text,
                PhoneNumber = PhoneNumberEntry.Text,
                EmailAddress = EmailAddressEntry.Text,
                Address = AddressEntry.Text
            };

            // Add the hremployee to the database
            await _databaseService.AddhremployeeAsync(newhremployee);

            // Clear the input fields
            FullNameEntry.Text = JobTitleEntry.Text = PhoneNumberEntry.Text = EmailAddressEntry.Text = AddressEntry.Text = string.Empty;

            // Reload the hremployees list
            LoadhremployeeAsync();
        }

        // Event handler for updating an existing hremployee
        private async void Updatehremployee_Clicked(object sender, EventArgs e)
        {
            // Check if an hremployee is selected in the ListView
            if (hremployeeListView.SelectedItem != null)
            {
                // Retrieve the selected hremployee
                var selectedhremployee = (HRModels)hremployeeListView.SelectedItem;

                // Update the selected hremployee's information
                selectedhremployee.FullName = FullNameEntry.Text;
                selectedhremployee.JobTitle = JobTitleEntry.Text;
                selectedhremployee.PhoneNumber = PhoneNumberEntry.Text;
                selectedhremployee.EmailAddress = EmailAddressEntry.Text;
                selectedhremployee.Address = AddressEntry.Text;

                // Update the hremployee in the database
                await _databaseService.UpdatehremployeeAsync(selectedhremployee);

                // Clear the input fields and reset the ListView selection
                FullNameEntry.Text = JobTitleEntry.Text = PhoneNumberEntry.Text = EmailAddressEntry.Text = AddressEntry.Text = string.Empty;
                hremployeeListView.SelectedItem = null;

                // Reload the hremployees list
                LoadhremployeeAsync();
            }
        }

        // Event handler for deleting an existing hremployee
        private async void Deletehremployee_Clicked(object sender, EventArgs e)
        {
            // Check if an hremployee is selected in the ListView
            if (hremployeeListView.SelectedItem != null)
            {
                // Retrieve the selected hremployee
                var selectedhremployee = (HRModels)hremployeeListView.SelectedItem;

                // Delete the selected hremployee from the database
                await _databaseService.DeletehremployeeAsync(selectedhremployee);

                // Clear the input fields and reset the ListView selection
                FullNameEntry.Text = JobTitleEntry.Text = PhoneNumberEntry.Text = EmailAddressEntry.Text = AddressEntry.Text = string.Empty;
                hremployeeListView.SelectedItem = null;

                // Reload the hremployees list
                LoadhremployeeAsync();
            }
        }
    }
}



//public partial class HRDepartment : ContentPage
//{
//    public HRDepartment()
//    {
//        InitializeComponent();
//    }
//    private async void GraceEdit(object sender, EventArgs e)
//    {
//        Button button = (Button)sender;

//        string buttonText = button.Text;

//        var editEntry = new Entry { Placeholder = "Edit Information", Text = buttonText };

//        // Create a Save button to update the information.
//        var saveButton = new Button { Text = "Save" };
//        saveButton.Clicked += (s, args) =>
//        {
//            // Update the button text with the edited information.
//            string editedText = editEntry.Text;
//            button.Text = editedText;

//            //Adds a message after you press "Save"
//            DisplayAlert("Profile saved", "The profile has been saved", "OK");
//        };

//        var editPage = new ContentPage
//        {
//            Content = new StackLayout
//            {
//                Children = { editEntry, saveButton }
//            }
//        };


//        await Navigation.PushAsync(editPage);
//    }
//    private async void FrancisEdit(object sender, EventArgs e)
//    {
//        Button button = (Button)sender;


//        string buttonText = button.Text;


//        var editEntry = new Entry { Placeholder = "Edit Information", Text = buttonText };

//        // Create a Save button to update the information.
//        var saveButton = new Button { Text = "Save" };
//        saveButton.Clicked += (s, args) =>
//        {
//            // Update the button text with the edited information.
//            string editedText = editEntry.Text;
//            button.Text = editedText;

//            //Adds a message after you press "Save"
//            DisplayAlert("Profile saved", "The profile has been saved", "OK");
//        };

//        var editPage = new ContentPage
//        {
//            Content = new StackLayout
//            {
//                Children = { editEntry, saveButton }
//            }
//        };

//        await Navigation.PushAsync(editPage);
//    }

//    private async void TobyEdit(object sender, EventArgs e)
//    {
//        Button button = (Button)sender;


//        string buttonText = button.Text;


//        var editEntry = new Entry { Placeholder = "Edit Information", Text = buttonText };

//        // Create a Save button to update the information.
//        var saveButton = new Button { Text = "Save" };
//        saveButton.Clicked += (s, args) =>
//        {
//            // Update the button text with the edited information.
//            string editedText = editEntry.Text;
//            button.Text = editedText;


//            //Adds a message after you press "Save"
//            DisplayAlert("Profile saved", "The profile has been saved", "OK");


//        };

//        var editPage = new ContentPage
//        {
//            Content = new StackLayout
//            {
//                Children = { editEntry, saveButton }
//            }
//        };


//        await Navigation.PushAsync(editPage);
//    }

//    private async void AddProfile(object sender, EventArgs e)
//    {
//        // Display the alert message when the "Add" button is clicked
//        await DisplayAlert("Error", "No new employees in the database. Please consult management if there is an error.", "OK");
//    }
//}
