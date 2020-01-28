using System;
using System.Collections.Generic;
using McGillStartupFair.Models;
using McGillStartupFair.Views;
using Xamarin.Forms;

namespace McGillStartupFair
{
    public partial class Employers : ContentPage
    {
        public IList<Company> companies { get; private set; }

        public Employers()
        {

            InitializeComponent();

            companies = new List<Company>();


            companies.Add(new Company
            {
                Name = "Google",
                Description = "Search Engine Startup",
                URL = "www.google.com",
                ImagePath = "McGillStartupFair.Assets.Images.amazon.png"
            });

            companies.Add(new Company
            {
                Name = "Amazon",
                Description = "Online Marketplace and Ruthless Regime",
                URL = "www.amazon.com",
                ImagePath = "McGillStartupFair.Assets.Images.amazon.png"
            });

            companies.Add(new Company
            {
                Name = "Netflix",
                Description = "Streaming Media",
                URL = "www.netflix.com",
                ImagePath = "McGillStartupFair.Assets.Images.amazon.png"
            });

            companies.Add(new Company
            {
                Name = "Oracle",
                Description = "tech comp",
                URL = "www.oracle.com",
                ImagePath = "McGillStartupFair.Assets.Images.amazon.png"
            });

            BindingContext = this;

        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Company company = e.Item as Company;
            
            Navigation.PushAsync(new CompanyView(company));

        }
    }
}