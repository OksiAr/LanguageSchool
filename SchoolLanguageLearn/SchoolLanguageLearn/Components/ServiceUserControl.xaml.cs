using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace SchoolLanguageLearn.Components
{
    /// <summary>
    /// Логика взаимодействия для ServiceUserControl.xaml
    /// </summary>
    public partial class ServiceUserControl : UserControl
    {
        public ServiceUserControl(Image image, string title, decimal cost, string costTime, string discount, Visibility costVisibility)
        {
            InitializeComponent();
            //BitmapImage bitmapImage = new BitmapImage();
            //bitmapImage.StreamSource = new MemoryStream(image);
            //ServiceImg.Source =  bitmapImage as ImageSource;
            CosTb.Text = cost.ToString();
            TitleTb.Text = title;
            CostTimeTb.Text = costTime;
            DiscountTb.Text = discount;
            CosTb.Visibility = costVisibility;
        }
    }
}
