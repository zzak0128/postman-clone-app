using Avalonia.Controls;
using Avalonia.Interactivity;
using PostmanCloneLibrary;
using System;

namespace PostmanCloneAUI
{
    public partial class MainWindow : Window
    {
        private readonly IApiAccess api = new ApiAccess();

        public MainWindow()
        {
            InitializeComponent();
            //StatusText.Text = "Ready";
        }

        public async void ClickHandler(object sender, RoutedEventArgs args)
        {
            ResultsText.Text = "";

            if (api.IsValidUrl(ApiText.Text) == false)
            {
                StatusText.Text = "Invalid URL";
                return;
            }

            try
            {
                StatusText.Text = "Calling API...";

                ResultsText.Text = await api.CallApiAsync(ApiText.Text);

                StatusText.Text = "Ready";
            }
            catch (Exception ex)
            {
                StatusText.Text = "Error";
                ResultsText.Text = "Error: " + ex.Message;
            }
        }
    }
}