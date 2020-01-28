using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace McGillStartupFair
{
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
