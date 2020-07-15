using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace Apps.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapView : ContentPage
    {
        public MapView()
        {
            InitializeComponent();
        }
        public async void getlocation()
        {
            var request = new GeolocationRequest(GeolocationAccuracy.Medium);
            var location = await Geolocation.GetLocationAsync(request);
            if(location!=null)
            {
                Position p = new Position(location.Latitude, location.Longitude);
                MapSpan.FromCenterAndRadius(p, Distance.FromKilometers(.444));
            }
        }
        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //   // var location = await Geolocation.GetLocationAsync();
        //   // if(location!=null)
        //    Device.BeginInvokeOnMainThread(() =>
        //    {
        //        map.Pins.Add(new Pin()
        //        {
        //            Position = new Position(30.192935, 75.024409),
        //            Label = "Your Location",
        //            Icon = BitmapDescriptorFactory.DefaultMarker(Color.Red)
        //        });
        //        map.Pins.Add(new Pin()
        //        {
        //            Position = new Position(30.184348, 74.642953),
        //            Address = "Your Location",
        //            Label = "Your Location",
        //            Icon = BitmapDescriptorFactory.DefaultMarker(Color.Red)
        //        });
        //        map.MoveCamera(CameraUpdateFactory.NewCameraPosition(new CameraPosition(new Position(map.Pins[0].Position.Latitude, map.Pins[0].Position.Longitude), 9d, 0d, 0d)));
        //        map.UiSettings.RotateGesturesEnabled = false;
        //    });
        //}
    }
}