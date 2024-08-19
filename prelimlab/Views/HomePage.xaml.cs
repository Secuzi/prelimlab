using prelimlab.Models;
using System.Collections.ObjectModel;

namespace prelimlab.Views;

public partial class HomePage : FlyoutPage
{
	public HomePage()
	{
		InitializeComponent();
		flyout.clFlyout.SelectionChanged += ClFlyout_SelectionChanged;
	}

	private void ClFlyout_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{

		// Check if a valid selection is made
		if (e.CurrentSelection.FirstOrDefault() is FlyOutItemPage item)
		{
			try
			{
				// Create an instance of the target page
				var targetPage = (Page)Activator.CreateInstance(item.TargetPage);

				// Set the Detail property with a new NavigationPage
				Detail = new NavigationPage(targetPage);

				// Clear selection and close the flyout
				flyout.clFlyout.SelectedItem = null;
				IsPresented = false; // Close the flyout
			}
			catch (Exception ex)
			{
				// Handle any exceptions that occur during page creation
				Console.WriteLine($"Error creating page: {ex.Message}");
			}
		}
		else
		{
			// Handle the case where the selected item is not of the expected type
			Console.WriteLine("Selected item is not of type FlyOutItemPage.");
		}
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
	
	}

	

}