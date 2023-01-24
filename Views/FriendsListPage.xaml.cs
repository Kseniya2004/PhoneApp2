namespace PhoneApp2.Views;
using PhoneApp2.ViewModels;

public partial class FriendsListPage : ContentPage
{
	public FriendsListPage()
	{
		InitializeComponent(); 
		BindingContext = new FriendsListViewModel() { Navigation = this.Navigation };
    }
}