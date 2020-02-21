using System;
using System.Linq;
using System.Collections.Generic;
using McGillStartupFair.Models;
using McGillStartupFair.Views;
using System.Collections.Specialized;
using Xamarin.Forms;

namespace McGillStartupFair
{
    public partial class Employers : ContentPage
    {
        public List<Company> companies { get; private set; }

        public Employers()
        {

            InitializeComponent();
            companies = new List<Company>();
            InitList();

            IEnumerable<Company> sortedList = companies.OrderBy(f => f.Name);

            companies = sortedList.ToList();
            InitSB();
            BindingContext = this;

        }

        void InitSB()
        {
            sb.TextChanged += (s, e) => FilterItem(sb.Text);
            sb.SearchButtonPressed += (s, e) => FilterItem(sb.Text);

        }

        private void FilterItem(string filter)
        {
            EmployeeListView.BeginRefresh();
            if (string.IsNullOrWhiteSpace(filter))
            {
                EmployeeListView.ItemsSource = companies;
            }
            else
            {
                EmployeeListView.ItemsSource = companies.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
            }

            EmployeeListView.EndRefresh();
        }

        void OnItemTapped(Object sender, ItemTappedEventArgs e)
        {
            Company company = e.Item as Company;
            Navigation.PushAsync(new CompanyView(company));
        }

        void InitList()
        {
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
                ImagePath = "McGillStartupFair.Assets.Images.shuttleControl.png"
            });

            companies.Add(new Company
            {
                Name = "The Sweater Guys",
                Description = "The Sweater Guys was founded in a McGill University dorm in 2016, after founders Dexter and Dom were put in charge of ordering merchandise for their residence. They quickly realized the issues that plague the custom printing merchandise industry: overpriced items, slow turnaround times and awful customer service. The company was started to change all of that. By focusing on product, service, ethics and the environment, The Sweater Guys aims to change the clothing industry as a whole.",
                URL = "https://thesweaterguys.com",
                ImagePath = "McGillStartupFair.Assets.Images.sweaterGuys.png"
            });

            companies.Add(new Company
            {
                Name = "Yuma",
                Description = "Yuma is powering the lunches of the workforce.",
                URL = "https://www.itsyuma.com",
                ImagePath = "McGillStartupFair.Assets.Images.yuma.png"
            });

            companies.Add(new Company
            {
                Name = "Geek-it! Entertainment",
                Description = "We create modern fandom events across North America",
                URL = "http://geekitcon.com",
                ImagePath = "McGillStartupFair.Assets.Images.geekit.png"
            });

            companies.Add(new Company
            {
                Name = "Tote",
                Description = "Tote is a mobile app that provides its users with a personalized shopping experience that is easy, efficient and fun. Tote utilizes a tag-based search engine that is designed to allow users to express whatever is on their minds into their searches. By only showing products that fit their search criteria, Tote eliminates the overwhelming amount of unnecessary options that shoppers would normally see. Users of Tote browse by swiping, which not only requires minimal involvement from users, but also allows Tote to understand user preferences towards individual products. By running machine learning on the user preferences and the set of attributes each product has, Tote narrowcasts clothes to each user based on their individual tastes. Users get to browse clothes from hundreds of different retailers and make purchases without leaving the app. ",
                URL = "https://www.toteaway.co",
                ImagePath = "McGillStartupFair.Assets.Images.tote.png"
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
                ImagePath = "McGillStartupFair.Assets.Images.engine.png"
            });

            companies.Add(new Company
            {
                Name = "NEXT Canada",
                Description = "NEXT uncovers Canada's next generation of entrepreneurs and accelerates their trajectory with access to education, mentorship, venture funding and more.",
                URL = "https://www.nextcanada.com",
                ImagePath = "McGillStartupFair.Assets.Images.NEXT.png"
            });

            companies.Add(new Company
            {
                Name = "Tandem Launch",
                Description = "TandemLaunch works with driven entrepreneurs to turn research from the world’s best universities into exceptional consumer technology companies. As a startup foundry, we handpick talented individuals who join our Entrepreneur in Residence program without a team or an invention; less than two years later, they leave with a funded technology startup. We offer a proven path to build world-class deep technology companies in 12 to 18 months including significant executive-level interaction, guidance and hands-on support to each entrepreneur who works with us. Our portfolio ventures include: Mirametrix, LANDR, Algolux, SPORTLOGiQ, wrnchAI, IRYStec, Stratuscent, Airy:3D, Fluent.ai, Aerial.ai, BioMindR, ORA Graphene Audio, C2RO Cloud Robotics, Suometry, Contxtful, Wavelite, Soundskrit, Edgehog, Deeplite, Corowave, Sunia, Omniply, and Notos Technologies. ",
                URL = "http://tandemlaunch.com/",
                ImagePath = "McGillStartupFair.Assets.Images.tandem.png"
            });

            companies.Add(new Company
            {
                Name = "Planned",
                Description = "Planned is a tech company that helps corporations ideate, plan and execute all of their events on one simple, centralized platform. The product we've created is oriented explicitly towards large companies and enterprise businesses.",
                URL = "https://planned.com/",
                ImagePath = "McGillStartupFair.Assets.Images.planned.png"
            });

            companies.Add(new Company
            {
                Name = "Front Row Ventures",
                Description = "Front Row Ventures is the first Canadian student - run venture capital fund that invests solely in student - led startups. Most student entrepreneurs still lack access to capital.We're closing that gap by backing student founders with an early investment of $25,000, through a SAFE—the most founder-friendly terms that exist in Canada, and a portfolio of resources and world-class mentors. We believe that students are in a unique position to challenge the status quo.The university years are an entrepreneurial sweet spot and we want to help student founders launch unthinkable ventures that change the world. Powered by Real Ventures,FRV has successfully run a $600K Quebec - focused pilot fund over the past two years and is now raising a $10M fund to expand its operations to 7 new provinces and more than 30 university campuses across Canada.",
                URL = "https://frontrow.ventures",
                ImagePath = "McGillStartupFair.Assets.Images.FRVentures.png"
            }); ;

            companies.Add(new Company
            {
                Name = "Micropredictome",
                Description = "MicroPredictome was started with the intention of returning agency and clarity to those interacting with gastrointestinal diseases.Even the most prevalent conditions related to this space,such as IBS and IBD,are clouded by a level of uncertainty; resulting in extended periods between the inception of symptoms and the provision of precise care. By leveraging the power of machine learning, lifestyle data, and the microbial profile of stool MicroPredictome aims to provide accurate, cost-effective and non-invasive disease metrics for a greater understanding of gastrointestinal diseases; all from the comfort of one’s home.",
                URL = "https://micropredictome.com/",
                ImagePath = "McGillStartupFair.Assets.Images.micro.jpg"
            });

            companies.Add(new Company
            {
                Name = "MoveMate",
                Description = "MoveMate is a one-stop on-demand platform for all moving needs",
                URL = "https://movemate.ca/",
                ImagePath = "McGillStartupFair.Assets.Images.movemate.png"
            });

            companies.Add(new Company
            {
                Name = "Le Wagon Montréal",
                Description = "Le Wagon is a coding bootcamp that teaches students to develop web applications from scratch. Our cutting-edge curriculum and world-class teachers give students all the skills and tools needed to kick-start their tech career, land a job as web developers or product managers, or launch their own startup.",
                URL = "https://www.lewagon.com/montreal/",
                ImagePath = "McGillStartupFair.Assets.Images.lewagon.png"
            });

            companies.Add(new Company
            {
                Name = "Lighthouse Labs",
                Description = "Lighthouse Labs is the leading coding bootcamp in Canada with 6 locations spread out across the country. We aim to continuously find the best ways to train the next generation of full-stack developers and to transform the way tech education is delivered.",
                URL = "https://www.lighthouselabs.ca/",
                ImagePath = "McGillStartupFair.Assets.Images.lighthouse.png"
            });

            companies.Add(new Company
            {
                Name = "LFAnt Medical",
                Description = "LFAnt is developing a point-of-care device for the accurate and rapid detection of chlamydia and gonorrhea, with the same form factor as a traditional pregnancy test. ",
                URL = "https://www.lfantmedical.com",
                ImagePath = "McGillStartupFair.Assets.Images.lfant.png"

            });

            companies.Add(new Company
            {
                Name = "BoxKnight",
                Description = "Same-day delivery service for e-commerce retailers",
                URL = "https://boxknight.com",
                ImagePath = "McGillStartupFair.Assets.Images.boxnight.png"
            });

            companies.Add(new Company
            {
                Name = "Saccade Analytics",
                Description = "Saccade Analytics leverages eye-tracking in virtual reality to deliver better care for concussions and vestibular disorders. We enable healthcare professionals to make objective neurological assessments and provide targeted rehabilitation in just minutes.",
                URL = "https://saccadeanalytics.com/",
                ImagePath = "McGillStartupFair.Assets.Images.saccade.png"

            });

            companies.Add(new Company
            {
                Name = "GradeSlam/Paper",
                Description = "GradeSlam is the leader in personalized learning.Partnering with innovative schools and school districts, GradeSlam helps deliver true educational equity by offering virtual access to 24/7 tutors and essay reviewers. Founded in 2014, GradeSlam philosophically believes that all students should be given the tools and resources to reach their academic potential, independent of socio-economic status, geography, language or other barriers. Currently, GradeSlam is partnered with over 200 schools and 150,000 students.",
                URL = "https://gradeslam.org/",
                ImagePath = "McGillStartupFair.Assets.Images.gradeslam.png"
            });

            companies.Add(new Company
            {
                Name = "MyFoodprint",
                Description = "MyFoodprint is a carbon footprint calculator for meals to enable smart and sustainable decision making in and out of the kitchen. ",
                URL = "http://myfoodprint.io/",
                ImagePath = "McGillStartupFair.Assets.Images.foodprint.png"
            });

            companies.Add(new Company
            {
                Name = "Dialogue",
                Description = "Dialogue is one of Canada's fastest growing companies. Its important mission is to use technology to improve health and wellbeing by empowering employers to reduce barriers to quality care for employees and their families.  ",
                URL = "https://www.dialogue.co/en",
                ImagePath = "McGillStartupFair.Assets.Images.dialogue.png"
            });

            companies.Add(new Company
            {
                Name = "PLAKK",
                Description = "PLAKK harnesses the power of artificial intelligence and machine learning to provide a more accurate, accessible, and faster approach to improve how researchers and clinicians characterize atherosclerotic plaque features and instability. By improving how patients our diagnosed with atherosclerosis, we can improve clinical decision making and ultimately prevent heart attacks and strokes.",
                URL = "https://www.plakk-ai.com/",
                ImagePath = "McGillStartupFair.Assets.Images.plakk.jpg"

            });

            companies.Add(new Company
            {
                Name = "Scooble",
                Description = "Scooble is a managed carpooling solution for organizations. We enrich the everyday commutes of the employees.We help foster a more energized, engaged, and productive workforce. On our platform riders and drivers from the same organizations can simply match with each other and share the cost(not profit based) of the ride through seamless payment transaction.We also provide monthly usage reports, SOV reduction, CO2 emissions saved, and more.",
                URL = "",
                ImagePath = "McGillStartupFair.Assets.Images.scooble.png"
            });

            companies.Add(new Company
            {
                Name = "Mistplay",
                Description = "Mistplay is the first Loyalty Platform for mobile gamers. Players use Mistplay daily to play games, earn rewards and connect with friends. With already over 5 million members around the world in under 2-years, Mistplay is among the top 50 fastest growing technology startups in Canada.",
                URL = "https://www.mistplay.com/#/",
                ImagePath = "McGillStartupFair.Assets.Images.mistplay.png"

            });


            companies.Add(new Company
            {
                Name = "Exploriti",
                Description = "We have developed a student life application to improve the access to information for student's when getting involved in extracurricular activities on campus",
                URL = "https://www.exploriti.com/",
                ImagePath = "McGillStartupFair.Assets.Images.ex.png"

            });

            companies.Add(new Company
            {
                Name = "RailVision Analytics",
                Description = "RailVision Analytics specializes in advanced artificial intelligence for the passenger-rail industry. Our projects are focused on reducing fuel consumption and preventing locomotive failure.",
                URL = "http://www.railvision.ca",
                ImagePath = "McGillStartupFair.Assets.Images.rail.jpg"
            });

            companies.Add(new Company
            {
                Name = "nufuuds",
                Description = "nufuuds creates delicious, plant-based foods made with the world’s oldest and smallest superfood, algae.",
                URL = "https://nufuuds.com",
                ImagePath = "",

            });

            companies.Add(new Company
            {
                Name = "Hypnosand",
                Description = "Hypnosand is a luxury brand that combines art, design and technology by creating unique, customizable and high-quality tables.",
                URL = "http://hypnosand.com/",
                ImagePath = "",

            });

            companies.Add(new Company
            {
                Name = "Sonder",
                Description = "Short term rental company that was founded in MTL and has spaces worldwide. All of our spaces are professionally designed and curated so that our guests can experience the best of the cities that we operate in. ",
                URL = "https://www.sonder.com/",
                ImagePath = "",

            });

            companies.Add(new Company
            {
                Name = "Goalcast",
                Description = "Goalcast is a media company that’s hellbent on unleashing humanity’s full potential. We produce  short films, short documentaries and speeches. The stories we share impact millions. With a community of over 40+ Million followers, and monthly viewership of over 500 million, our content truly changes lives. ",
                URL = "",
                ImagePath = "",

            });

            companies.Add(new Company
            {
                Name = "PhysioBiometrics Inc.",
                Description = "Dedicated to the development of practical and accessible innovations for people with movement and posture vulnerabilities that can be marketed directly to those at risk and those who treat them",
                URL = "",
                ImagePath = "",

            });

            companies.Add(new Company
            {
                Name = "Compass Startup Legal Clinic",
                Description = "Compass Startup Legal Clinic offers free legal information to startups and entrepreneurs on business law issues.",
                URL = "http://compassclinic.org/",
                ImagePath = "",

            });

            companies.Add(new Company
            {
                Name = "Precare Inc.",
                Description = "An innovative platform that provides evidence-based information through animated medical and surgical guides. The guides are accessible on the web in 20 languages for free, thereby increasing information retention through simple audiovisuals and reducing dependency on printed media.",
                URL = "https://precare.ca/",
                ImagePath = "",

            });

            companies.Add(new Company
            {
                Name = "Off The Grid",
                Description = "Off The Grid specializes in a spinning bike combined with a web application that turns energy into electricity.This energy is then redistributed directly into the grid of the gym through a wall outlet. The process produces a credit on the monthly bill.",
                URL = "https://getoffthegrid.ca/",
                ImagePath = "",

            });

            companies.Add(new Company
            {
                Name = "Vent Over Tea",
                Description = "Vent Over Tea is a free active listening service that pairs those who need to vent with an empathetic listener in a local cafe. Our volunteer active listeners listen without judgment, give you their undivided attention, and ask reflective questions. Choose a time and cafe on our website, and a volunteer will meet you there!",
                URL = "https://ventovertea.com/en/",
                ImagePath = "",

            });

            companies.Add(new Company
            {
                Name = "AON3D",
                Description = "AON3D builds industrial 3D printers for high-performance materials. We serve customers like Blue Origin, Lockheed Martin, DuPont, and over 150 other leading engineering organizations.",
                URL = "https://www.aon3d.com/",
                ImagePath = "",

            });

            companies.Add(new Company
            {
                Name = "Blaise",
                Description = "On-demand bus software platform",
                URL = "https://www.blaisetransit.com/",
                ImagePath = "",
            });
        }

        
    }    
}
