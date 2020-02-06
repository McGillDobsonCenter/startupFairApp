using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McGillStartupFair
{
    public partial class info : ContentPage
    {
        public info()
        {
            InitializeComponent();
        }

        public async void map_Clicked(object sender, EventArgs e)
        {
            double latitud = 45.510906;
            double longitud = -73.575984;
            string placeName = "New Residence Hall";

            var supportsUri = await Launcher.CanOpenAsync("comgooglemaps://");

            if (supportsUri)
                await Launcher.OpenAsync($"comgooglemaps://?q={latitud},{longitud}({placeName})");
            
            else
                await  Map.OpenAsync(45.510906, -73.575984, new MapLaunchOptions { Name = "New Residence Hall" });

        }

        void Tips_Clicked(System.Object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.mcgill.ca/caps/files/caps/guide_careerfair.pdf"));
        }
    }
}
