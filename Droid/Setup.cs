using Android.Widget;
using MaskDecimal.Core;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Logging;
using MvvmCross.Platforms.Android.Presenters;

namespace MaskDecimal.Droid
{
    public class Setup
        : MvxAppCompatSetup<App>
    {
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
            => new MvxAppCompatViewPresenter(AndroidViewAssemblies);

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories(registry);
            registry.RegisterCustomBindingFactory<EditText>("DecimalText", inputField => new DecimalEditTextTargetBinding(inputField));
        }

        public override MvxLogProviderType GetDefaultLogProviderType()
            => MvxLogProviderType.Console;
    }
}