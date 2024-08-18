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

		if (e.CurrentSelection.FirstOrDefault() is FlyOutItemPage item)
		{
			// Proceed with navigation
			Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetPage)) { BarTextColor = new Color(255, 249, 230) };
			flyout.clFlyout.SelectedItem = null; // Clear selection
			IsPresented = false; // Close the flyout
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
		LoadCuties();
	}

	void LoadCuties()
	{
		var cuties = new ObservableCollection<CutieModel>(CutieModelRepository.GetCuties());
		
		

	}

}