using System;
using System.Collections.Generic;
using McGillStartupFair.Models;

using Xamarin.Forms;

namespace McGillStartupFair.Views
{
    public partial class CompanyView : ContentPage
    {
        public string CompanyName { get; private set; }

        public string CompanyDescription { get; private set; }

        public CompanyView(Company company)
        {
            CompanyName = company.Name;

            CompanyDescription = company.Description;

            InitializeComponent();

            var assembly = typeof(CompanyView);

            compLogo.Source = ImageSource.FromResource(company.ImagePath, assembly);



            BindingContext = this;

        }

        private void Favourites_Clicked(object sender, EventArgs args) { }
    }
}
