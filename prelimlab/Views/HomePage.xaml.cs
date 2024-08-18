using prelimlab.Models;
using System.Collections.ObjectModel;

namespace prelimlab.Views;

public partial class HomePage : FlyoutPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		LoadCuties();
	}

	void LoadCuties()
	{
		var cuties = new ObservableCollection<CutieModel>(CutieModelRepository.GetCuties());
		HomePageImg.Source = cuties[0].Image.Source;
		HomePageImg.Aspect = cuties[0].Image.Aspect;
		lbltitle.Text = cuties[0].Title;
		lblUser.Text += $"{cuties[0].User}";
		lblDescription.Text = cuties[0].Description;
		

	}

}