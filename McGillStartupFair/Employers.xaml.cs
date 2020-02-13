using System;
using System.Linq;
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
                Name = "Mixonset",
                Description = "Mixonset is building a music mixing app that solves the unresolved need that more than 150 million people have in creating mixtapes based on the music they love. Mixonset is your personal DJ that lets you create seamless mixes with just one tap.",
                URL = "https://www.mixonset.com",
                ImagePath = "McGillStartupFair.Assets.Images.Mixonset-Logo.png"
            });

            companies.Add(new Company
            {
                Name = "ShuttleControl",
                Description = "ShuttleControl is the shuttle app for car dealerships. It’s industry practice for car dealerships to offer a shuttle service when your car has to stay in the garage.The dealer promises to drop you off at home or work and pick you up when your car is ready.Today, almost all dealerships use pen and paper to manage this service, even when they complete up to 60 rides per day.This affects client satisfaction, costs dealerships time and money and leaves them without any tangible data regarding their service.ShuttleControl streamlines the process and makes it easy for dealerships to offer the best customer experience, save time and money and gain insightful data. ",
                URL = "https://www.shuttlecontrol.com",
                ImagePath = "McGillStartupFair.Assets.Images.amazon.png"
            });

            companies.Add(new Company
            {
                Name = "The Sweater Guys",
                Description = "The Sweater Guys was founded in a McGill University dorm in 2016, after founders Dexter and Dom were put in charge of ordering merchandise for their residence. They quickly realized the issues that plague the custom printing merchandise industry: overpriced items, slow turnaround times and awful customer service. The company was started to change all of that. By focusing on product, service, ethics and the environment, The Sweater Guys aims to change the clothing industry as a whole.",
                URL = "https://thesweaterguys.com",
                ImagePath = "McGillStartupFair.Assets.Images.amazon.png"
            });

            companies.Add(new Company
            {
                Name = "Yuma",
                Description = "Yuma is powering the lunches of the workforce.",
                URL = "https://www.itsyuma.com",
                ImagePath = "McGillStartupFair.Assets.Images.amazon.png"
            });

            companies.Add(new Company
            {
                Name = "Geek-it! Entertainment",
                Description = "We create modern fandom events across North America",
                URL = "http://geekitcon.com",
                ImagePath = "McGillStartupFair.Assets.Images.amazon.png"
            });

            companies.Add(new Company
            {
                Name = "Tote",
                Description = "Tote is a mobile app that provides its users with a personalized shopping experience that is easy, efficient and fun. Tote utilizes a tag-based search engine that is designed to allow users to express whatever is on their minds into their searches. By only showing products that fit their search criteria, Tote eliminates the overwhelming amount of unnecessary options that shoppers would normally see. Users of Tote browse by swiping, which not only requires minimal involvement from users, but also allows Tote to understand user preferences towards individual products. By running machine learning on the user preferences and the set of attributes each product has, Tote narrowcasts clothes to each user based on their individual tastes. Users get to browse clothes from hundreds of different retailers and make purchases without leaving the app. ",
                URL = "https://www.toteaway.co",
                ImagePath = "McGillStartupFair.Assets.Images.amazon.png"
            });

            companies.Add(new Company
            {
                Name = "Cookiestruct",
                Description = "With Cookiestruct, anyone can bake cookies with a loved one’s face or with a logo. We make custom 3D-printed cookie cutters that are food-safe, recyclable, and compostable. The customer uploads a photo of the object they want as a cookie cutter, the system sends it to our four dedicated artists. One of them will make it into a traced 2D file and is then sent through a code we have that turns it into a cookie cutter 3D model. Then depending on the size of the cookie cutter, the print takes anywhere from 1 hour to 3 hours. We recently launched in 2019, so if you’d like to support us or collaborate with us, please visit our website at cookiestruct.com or send us an email at help@cookiestruct.com.",
                URL = "https://cookiestruct.com",
                ImagePath = "McGillStartupFair.Assets.Images.Cookiestruct_logo.png"
            });

            companies.Add(new Company
            {
                Name = "McGill Engine Centre",
                Description = "The McGill Engine, the Faculty of Engineering Innovation and Entrepreneurship centre, focuses on stimulating and supporting technologically-based innovation and entrepreneurship at McGill in collaboration with the McGill Dobson Centre for Entrepreneurship and the Office of Innovation and Partnerships.",
                URL = "https://www.mcgill.ca/engine/about-us",
                ImagePath = ""
            });

            companies.Add(new Company
            {
                Name = "NEXT Canada",
                Description = "NEXT uncovers Canada's next generation of entrepreneurs and accelerates their trajectory with access to education, mentorship, venture funding and more.",
                URL = "https://www.nextcanada.com",
                ImagePath = ""
            });

            companies.Add(new Company
            {
                Name = "Tandem Launch",
                Description = "TandemLaunch works with driven entrepreneurs to turn research from the world’s best universities into exceptional consumer technology companies. As a startup foundry, we handpick talented individuals who join our Entrepreneur in Residence program without a team or an invention; less than two years later, they leave with a funded technology startup. We offer a proven path to build world-class deep technology companies in 12 to 18 months including significant executive-level interaction, guidance and hands-on support to each entrepreneur who works with us. Our portfolio ventures include: Mirametrix, LANDR, Algolux, SPORTLOGiQ, wrnchAI, IRYStec, Stratuscent, Airy:3D, Fluent.ai, Aerial.ai, BioMindR, ORA Graphene Audio, C2RO Cloud Robotics, Suometry, Contxtful, Wavelite, Soundskrit, Edgehog, Deeplite, Corowave, Sunia, Omniply, and Notos Technologies. ",
                URL = "http://tandemlaunch.com/",
                ImagePath = ""
            });

            companies.Add(new Company
            {
                Name = "Planned",
                Description = "Planned is a tech company that helps corporations ideate, plan and execute all of their events on one simple, centralized platform. The product we've created is oriented explicitly towards large companies and enterprise businesses.",
                URL = "https://planned.com/",
                ImagePath = ""
            });

            IEnumerable<Company> sortedList = companies.OrderBy(f => f.Name);

            companies = sortedList.ToList();

            BindingContext = this;

        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Company company = e.Item as Company;
            
            Navigation.PushAsync(new CompanyView(company));

        }
    }
}