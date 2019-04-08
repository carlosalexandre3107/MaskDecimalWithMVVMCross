using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MaskDecimal.Core
{
    [Preserve(AllMembers = true, Conditional = true)]
    public class MaskDecimalViewModel
        : MvxViewModel
    {
        public readonly IMvxNavigationService NavigationService;

        public MaskDecimalViewModel
            (IMvxNavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        private decimal _valor;
        public decimal Valor
        {
            get => _valor;
            set
            {
                _valor = value;
                RaisePropertyChanged(nameof(Valor));
            }
        }

        public IMvxCommand LimparCommand
            => new MvxCommand(() => Valor = 0);
    }
}
