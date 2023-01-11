namespace MauiApp6;

public partial class MainPage : ContentPage
{
	int con = 0;
	NewContent1 n = new NewContent1();
	NewContent2 w = new NewContent2();
	NewContent3 s = new NewContent3();
	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		con++;
		if(con >= 3)
		{
			con = 0;
		}
		switch (con)
		{
			case 0:
                Pro.Children[0] = n;
                break;
			case 1:
				Pro.Children[0] = w;
				break;
			case 2:
				Pro.Children[0] = s;
				break;
		}		
	}
}

