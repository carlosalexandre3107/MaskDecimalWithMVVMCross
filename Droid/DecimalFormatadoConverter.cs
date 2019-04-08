using MvvmCross.Converters;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MaskDecimal.Droid
{
    public class DecimalFormatadoConverter
        : MvxValueConverter<decimal, string>
    {
        protected override string Convert(decimal value, Type targetType, object parameter, CultureInfo culture)
        {
            //Console.WriteLine($"[DEBUG] - CONVERT DE DECIMAL : VALOR INICIAL => {value}");

            value = value < 0 ? value * (-1) : value;

            var valor = value.ToString();
            var valorFormatado = ConversorGenerico(valor, culture);

            //Console.WriteLine($"[DEBUG] - CONVERT DE DECIMAL : VALOR FINAL => {valorFormatado}");
            return valorFormatado;
        }

        protected override decimal ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
        {
            //Console.WriteLine($"[DEBUG] - CONVERTBACK DE DECIMAL : VALOR INICIAL => {value}");

            var valorFormatado = ConversorGenerico(value, culture);
            var valorConvertido = decimal.Parse(valorFormatado);

            //Console.WriteLine($"[DEBUG] - CONVERTBACK DE DECIMAL : VALOR FINAL => {valorConvertido}");
            return valorConvertido;
        }

        private string ConversorGenerico(string valor, CultureInfo culture)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(valor))
                    return string.Empty;

                var valorLimpo = Regex.Replace(valor, "[^0-9a-zA-Z]+", string.Empty);
                var valorConvertido = double.Parse(valorLimpo);
                valorConvertido = valorConvertido / 100;
                var valorFormatado = string.Format(culture, "{0:C2}", valorConvertido);

                switch (culture.Name)
                {
                    case "pt-BR":
                        valorFormatado = valorFormatado.Remove(0, 3);
                        break;
                    case "en-US":
                        valorFormatado = valorFormatado.Remove(0, 1);
                        break;
                }

                return valorFormatado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }
}