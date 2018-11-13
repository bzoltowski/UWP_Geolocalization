using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Devices.Geolocation;
namespace Mapa_WPS_BZ
{
    public partial class Koordynaty : PhoneApplicationPage
    {
        public Koordynaty()
        {
            InitializeComponent();
            UserLocation();
        }
        async void UserLocation()
        {
            Geolocator UserDes = new Geolocator();
            Geoposition UserPos = await UserDes.GetGeopositionAsync();
            double width = UserPos.Coordinate.Longitude;
            double heigth = UserPos.Coordinate.Latitude;
            tbGPS.Text = string.Format("dłg.: {0:F4} szer.: {1:F4}", width, heigth);

        }
    }
}