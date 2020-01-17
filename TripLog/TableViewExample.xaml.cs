using System;
using System.Collections.Generic;
using TripLog.Data;
using TripLog.Models;

using Xamarin.Forms;

namespace TripLog
{
    public partial class TableViewExample : ContentPage
    {
        public TableViewExample()
        {
            InitializeComponent();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            items.ItemsSource = await App.Database.GetNotesAsync();

        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            items.ItemsSource = await App.Database.GetNotesAsync();
            
        }
    }
}
