using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;
using Intersoft.Crosslight.WinRT;
using Windows.UI.Xaml.Media;

namespace DrawerSamples.WinRT.Converters
{
    public sealed class ByteToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string img = value as string;

            if (img == null)
                return null;

            string fullPath = "ms-appx:///Assets/Images/" + img;
            ImageSource imageSource = new BitmapImage(new Uri(fullPath));

            return imageSource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
