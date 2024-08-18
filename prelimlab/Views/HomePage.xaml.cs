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
		
		

	}

}