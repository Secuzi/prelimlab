using prelimlab.Models;
using prelimlab.Views;

namespace prelimlab;

public partial class FlyoutMenuPage : ContentPage
{
	public FlyoutMenuPage()
	{
		InitializeComponent();
		var items = new List<FlyOutItemPage>
			{
				new FlyOutItemPage
				{
					Title = "Home",
					IconSource = "Icons/home_icon.svg",
					TargetPage = typeof(QtOfTheDayPage)
                },
				new FlyOutItemPage
				{
					Title = "Gallery",
					IconSource = "Icons/gallery.svg",
					TargetPage = typeof(GalleryPage)
                }
			};

		clFlyout.ItemsSource = items;


	}

	private void clFlyout_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
    }
}