using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TripLog.Models;

namespace TripLog
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();

            var items = new List<TripLogEntry> {

                        new TripLogEntry
                        {
                        Title = "Washington Monument",
                        Notes = "Amazing!",
                        Rating = 3,
                        Date = new DateTime(2017, 2, 5),
                        Latitude = 38.8895,
                        Longitude = -77.0352
                        },
                        new TripLogEntry
                        {
                        Title = "Statue of Liberty",
                        Notes = "Inspiring!",
                        Rating = 4,
                        Date = new DateTime(2017, 4, 13),
                        Latitude = 40.6892,
                        Longitude = -74.0444
                        },

                        new TripLogEntry
                        {
                        Title = "Golden Gate Bridge",
                        Notes = "Foggy, but beautiful.",
                        Rating = 5,
                        Date = new DateTime(2017, 4, 26),
                        Latitude = 37.8268,
                        Longitude = -122.4798
                        }
            };

            trips.ItemsSource = items;
        }

        public void NewClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TripLog.NewEntryPage());
        }

        public async void TripsItemTapped(object sender, ItemTappedEventArgs e)
        {
            var trip = (TripLogEntry)e.Item;
            await Navigation.PushAsync(new DetailPage(trip));
            trips.SelectedItem = null;
        }

        public async void NotesClicked(object sender, EventArgs e)
        {           
            await Navigation.PushAsync(new NotesPage());
        }

    }
}


