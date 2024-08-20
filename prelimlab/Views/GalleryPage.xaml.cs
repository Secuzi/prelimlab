using prelimlab.Models;
using System.Collections.ObjectModel;

namespace prelimlab.Views;

public partial class GalleryPage : ContentPage
{
	public GalleryPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		var cuties = new ObservableCollection<CutieModel>(CutieModelRepository.GetCuties());
		clCutiesView.ItemsSource = cuties;

	}

	private void clCutiesView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (clCutiesView.SelectedItem != null)
		{
			var cutieModel = clCutiesView.SelectedItem as CutieModel;
			clCutiesView.SelectedItem = null;
			Navigation.PushAsync(new ShowPage(cutieModel, ""));
			
		}
	}
}