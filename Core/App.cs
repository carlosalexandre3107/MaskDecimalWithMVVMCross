using MvvmCross;
using MvvmCross.ViewModels;
using System;

namespace MaskDecimal.Core
{
    [Preserve(AllMembers = true, Conditional = true)]
    public class App
        : MvxApplication
    {
        public override void Initialize()
        {
            try
            {
                RegisterAppStart<MaskDecimalViewModel>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inicializar o app \n{ex.StackTrace}");
            }
        }
    }
}
