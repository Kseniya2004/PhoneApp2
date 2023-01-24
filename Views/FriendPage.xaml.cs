namespace PhoneApp2.Views;
using PhoneApp2.ViewModels;

public partial class FriendPage : ContentPage
{
    public FriendViewModel ViewModel { get; private set; }
    public FriendPage(FriendViewModel vm)
    {
        InitializeComponent();
        ViewModel = vm;
        this.BindingContext = ViewModel;
    }
}