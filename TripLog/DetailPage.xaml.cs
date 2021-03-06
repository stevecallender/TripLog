﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
namespace TripLog
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(TripLog.Models.TripLogEntry entry)
        {
            InitializeComponent();

            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(entry.Latitude, entry.Longitude),
                                                             Distance.FromMiles(.5)));

            map.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Label = entry.Title,
                Position = new Position(entry.Latitude, entry.Longitude)
            });

            title.Text = entry.Title;
            date.Text = entry.Date.ToString("M");
            rating.Text = $"{entry.Rating} star rating";
            notes.Text = entry.Notes;

        }
    }
}
