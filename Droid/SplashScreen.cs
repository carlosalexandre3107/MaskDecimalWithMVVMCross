using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;

namespace MaskDecimal.Droid
{
    [Activity(
        Label = "Mask Decimal"
        , MainLauncher = true
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen
        : MvxSplashScreenActivity<MvxAndroidSetup<Core.App>, Core.App>
    {
        public SplashScreen()
            : base(Resource.Layout.splash_screen)
        {

        }
    }
}