namespace prelimlab.Views.MyControls;

public partial class ShowControl : ContentView
{
	public event EventHandler<EventArgs> OnShow;
	public ImageSource ImgSource
	{
		get
		{
			return HomePageImg.Source;
		}
		set
		{
			HomePageImg.Source = value;
		}
	}

	public string Title
	{
		get
		{
			return lbltitle.Text;
		}
		set
		{
			lbltitle.Text = value;
		}
	}

	public string User
	{
		get
		{
			return lblUser.Text;
		}
		set
		{
			lblUser.Text += value;
		}
	}
	
	public string Description
	{
		get
		{
			return lblDescription.Text;
		}
		set
		{
			lblDescription.Text = value;
		}
	}

	public string AdditionalInformation
	{
		get
		{
			return lblQtOfTheDay.Text;
		}
		set
		{
			lblQtOfTheDay.Text = value;
		}
	}

	public string ButtonText
	{
		get
		{
			return btnOnShow.Text;
		}
		set
		{
			btnOnShow.Text = value;
		}
	}

	public ShowControl()
	{
		InitializeComponent();
	}


	private void btnOnShow_Clicked(object sender, EventArgs e)
	{
		OnShow?.Invoke(sender, e);
    }
}