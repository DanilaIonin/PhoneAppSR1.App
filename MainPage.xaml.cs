namespace PhoneAppSR1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
        this.BindingContext = new PhoneViewModel
        {       
            FIO = "Ионин Д.В.",
            Stuff = "Веб-дизайнер",
            Salary = 120000,
            Exp = 10,
            Factor= 2.35,
        };

    }

	
}

