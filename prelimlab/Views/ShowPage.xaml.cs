using prelimlab.Models;

namespace prelimlab.Views;

public partial class ShowPage : ContentPage
{
	public ShowPage(CutieModel model, string additionalInformation)
	{
		InitializeComponent();
		showControl.Title = model.Title;
		showControl.ImgSource = model.Image.Source;
		showControl.User = model.User;
		showControl.Description = model.Description;
		showControl.AdditionalInformation = additionalInformation;
		showControl.ButtonText = "Go Back";

	}

	private async void showControl_OnShow(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}