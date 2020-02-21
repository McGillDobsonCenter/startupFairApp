using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace McGillStartupFair
{
    public partial class FloorPlan : ContentPage
    {
        public FloorPlan()
        {
            InitializeComponent();
            floorplan.Source = ImageSource.FromResource("McGillStartupFair.Assets.Images.floorplan.png");

        }
    }
}
