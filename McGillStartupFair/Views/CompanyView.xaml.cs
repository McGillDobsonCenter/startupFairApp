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

        public string CompanyURL { get; private set; }

        public CompanyView(Company company)
        {
            CompanyName = company.Name;

            CompanyDescription = company.Description;

            CompanyURL = company.URL;

            InitializeComponent();

            var assembly = typeof(CompanyView);

            compLogo.Source = ImageSource.FromResource(company.ImagePath, assembly);



            BindingContext = this;

        }
        void Link_Clicked(System.Object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri(CompanyURL));
        }
    }
}
