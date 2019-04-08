using Android.App;
using Android.OS;
using MaskDecimal.Core;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace MaskDecimal.Droid.View
{
    [MvxActivityPresentation]
    [Activity(Label = "Mask Decimal")]
    public class MaskDecimalActivity
        : MvxAppCompatActivity<MaskDecimalViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
        }
    }
}