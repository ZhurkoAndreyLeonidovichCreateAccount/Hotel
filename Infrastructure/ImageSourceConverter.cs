using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Lab10.Infrastructure
{
    class ImageSourceConverter: IValueConverter
    {

        string imageDirectory = Directory.GetCurrentDirectory();

        public string ImageDirectory
        {
            get => Path.Combine(imageDirectory, "Images");

        }
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {

                return Path.Combine(ImageDirectory, (string)value);
            }
            catch
            {
                return Path.Combine(ImageDirectory, "2.jpg");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

