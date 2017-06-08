using VolumeApp.ViewModels;
using Xamarin.Forms;


namespace VolumeApp.Views {
    public partial class MainPage : ContentPage {
        public static MainPageViewModel mpvm;

        public MainPage() {
            InitializeComponent();
            mpvm = (MainPageViewModel)BindingContext;
        }
    }
}