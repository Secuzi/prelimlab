using prelimlab.Models;
using System.Collections.ObjectModel;
using static Android.Graphics.ColorSpace;

namespace prelimlab.Views;

public partial class QtOfTheDayPage : ContentPage
{
	public QtOfTheDayPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		var cuties = new ObservableCollection<CutieModel>(CutieModelRepository.GetCuties());
		
		var random = new Random();
		int index = random.Next(cuties.Count);
		
		showControl.Title = cuties[index].Title;
		showControl.ImgSource = cuties[index].Image.Source;
		showControl.User = cuties[index].User;
		showControl.Description = cuties[index].Description;
		showControl.AdditionalInformation = "QT OF THE DAY";
		showControl.ButtonText = "See More";
	}

	private async void showControl_OnShow(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new GalleryPage());
	}
}