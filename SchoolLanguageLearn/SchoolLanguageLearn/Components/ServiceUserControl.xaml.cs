﻿using System;
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
        Service service;
        public ServiceUserControl(Service _service)
        {
            InitializeComponent();
            service = _service;
            if (App.isAdmin == false)
            {
                EditBtn.Visibility = Visibility.Hidden;
                DeleteBtn.Visibility = Visibility.Hidden;
            }
            CosTb.Text = service.Cost.ToString("0");
            TitleTb.Text = service.Title;
            CostTimeTb.Text = service.CostTime;
            DiscountTb.Text = service.DiscountStr;
            CosTb.Visibility = service.CostVisibility;
            ServiceImg.Source = GetImageSource(service.MainImage);
            MainBorder.Background = service.DiscountBrush;
        }
        private BitmapImage GetImageSource(byte[] byteImage)
        {
            BitmapImage bitmapImage = new BitmapImage();
            try
            {
                MemoryStream byteStream = new MemoryStream(byteImage);  
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = byteStream;
                bitmapImage.EndInit();
            }
            catch
            {
                MessageBox.Show("Error");

            }
            return bitmapImage;  
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        { 
            if(service.ClientService != null)
            {
                MessageBox.Show("Удаление запрещено");
            }
            else
            {
                App.db.Service.Remove(service);
                App.db.SaveChanges();
            }
        }
    }
}
