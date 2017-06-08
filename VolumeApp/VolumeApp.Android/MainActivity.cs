using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using VolumeApp.Views;
using Xamarin.Forms;

namespace VolumeApp.Droid {
    [Activity(Label = "VolumeApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity {

        protected override void OnCreate(Bundle bundle) {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(bundle);
            Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        public override bool OnKeyUp(Keycode keyCode, KeyEvent e) {
            if (keyCode == Keycode.VolumeDown) { return true; }
            if (keyCode == Keycode.VolumeUp) { return true; }
            return base.OnKeyUp(keyCode, e);
        }
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e) {
            if (keyCode == Keycode.VolumeUp) {
                MainPage.mpvm.AddCommand.Execute();
                return true;
            }
            if (keyCode == Keycode.VolumeDown) {
                MainPage.mpvm.MinusCommand.Execute();
                return true;
            }
            return base.OnKeyDown(keyCode, e);
        }
    }
}

