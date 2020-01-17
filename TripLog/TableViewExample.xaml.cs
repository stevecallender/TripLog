using System;
using System.Collections.Generic;
using TripLog.Data;
using TripLog.Models;

using Xamarin.Forms;

namespace TripLog
{
    public partial class TableViewExample : ContentPage
    {
        private List<Note> notes;

        public TableViewExample()
        {
            InitializeComponent();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            notes = await App.Database.GetNotesAsync();
            items.ItemsSource = notes;

        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            notes.Remove(note);
            
        }
    }
}
